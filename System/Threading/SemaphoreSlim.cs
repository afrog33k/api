﻿using System.Diagnostics;
using System.Threading.Tasks;
using Android.Util;
using Java.Util.Concurrent;
using JetBrains.Annotations;

namespace System.Threading
{
    public class SemaphoreSlim : IDisposable
    {
        private readonly Semaphore _sem;
        private volatile bool _wasDisposed;
        private volatile ConcurrentLinkedQueue<AsyncWaiter> _asyncWaiters;
        //private static int idgen;
        private readonly int _id;
        
        public SemaphoreSlim(int initialCount)
        {
            _sem = new Semaphore(initialCount);
            //id = Interlocked.Increment(ref idgen);
        }

        public int CurrentCount
        {
            get { return _sem.AvailablePermits(); }
        }

        public Task WaitAsync(CancellationToken token)
        {
            return WaitAsync(-1, token);
        }

        public Task<bool> WaitAsync(TimeSpan duration, CancellationToken token)
        {
            return WaitAsync((int) duration.TotalMilliseconds, token);
        }

        public Task<bool> WaitAsync(Int32 duration, CancellationToken token)
        {
           VerboseLog("{0:000}|{1}|async wait requested", Thread.CurrentThread.Id, _id);

            CheckDisposed();
            token.ThrowIfCancellationRequested();

            if (_sem.TryAcquire())
            {
                VerboseLog("{0:000}|{1}|async wait immediate success", Thread.CurrentThread.Id,_id);
                return Task.FromResult(true);
            }
                

            if(duration == 0)
                return Task.FromResult(false);
            
            if (_asyncWaiters == null)
            {
                lock (this)
                {
                    if (_asyncWaiters == null)
                        _asyncWaiters = new ConcurrentLinkedQueue<AsyncWaiter>();
                }
            }

            AsyncWaiter waiter = new AsyncWaiter();
            TaskCompletionSource<bool> task = new TaskCompletionSource<bool>();
            
            waiter.Task = task;

            if (duration != -1)
            {
                waiter.CancelDelay = new CancellationTokenSource();
                waiter.Delay = Task.Delay(duration, waiter.CancelDelay.Token);
                waiter.Delay.ContinueWith(new ActionContinuation(() => TimeoutAsync(waiter)));
            }

            if (token != CancellationToken.None)
            {
                waiter.CancelRegistration = token.Register(() => CancelAsync(waiter));
            }
         
            _asyncWaiters.Add(waiter);

            VerboseLog("{0:000}|{1}|async wait enqued: {2:X}; {3}", Thread.CurrentThread.Id, _id, waiter.GetHashCode(), waiter.Task.Task.Id);

            if (_wasDisposed || token.IsCancellationRequested || waiter.Delay != null && waiter.Delay.IsCompleted)
            {
                // Mitigate the above race where a finishing condition occured
                // before where able to add our waiter to the waiters list.
                if (_asyncWaiters.Remove(waiter))
                {
                    CleanUpWaiter(waiter);
                }
            }

            return task.Task;
        }

        private void CancelAsync(AsyncWaiter waiter)
        {
            VerboseLog("{0:000}|{1}|async wait cancelled", Thread.CurrentThread.Id, _id);

            if (_asyncWaiters.Remove(waiter))
            {
                CleanUpWaiter(waiter);
            }
            waiter.Task.TrySetCanceled();
        }

        private void TimeoutAsync(AsyncWaiter waiter)
        {
            if (waiter.CancelDelay.IsCancellationRequested)
                return;
            VerboseLog("{0:000}|{1}|async wait timed out", Thread.CurrentThread.Id,_id);

            if (_asyncWaiters.Remove(waiter))
            {
                CleanUpWaiter(waiter);
            }

            waiter.Task.TrySetResult(false);
        }

        public Task WaitAsync()
        {
            return WaitAsync(-1, CancellationToken.None);
        }

        public void Wait()
        {
            Wait(-1, CancellationToken.None);
        }

        public void Wait(CancellationToken token)
        {
            Wait(-1, token);
        }

        public bool Wait(TimeSpan timeSpan, CancellationToken token)
        {
            return Wait((Int32)timeSpan.TotalMilliseconds, token);
        }

        public bool Wait(Int32 milliseconds)
        {
            return Wait(milliseconds, CancellationToken.None);
        }

        public bool Wait(Int32 milliseconds,  CancellationToken token)
        {
            VerboseLog("{0:000}|{1}|sync wait requested", Thread.CurrentThread.Id, _id);
            CheckDisposed();
            token.ThrowIfCancellationRequested();

            if (milliseconds == -1 && token == CancellationToken.None)
            {
                _sem.AcquireUninterruptibly();
                CheckDisposed();
                VerboseLog("{0:000}|{1}|sync wait complete.", Thread.CurrentThread.Id, _id);
                return true;
            }
            if (token == CancellationToken.None)
            {
                var ret = _sem.TryAcquire(milliseconds, TimeUnit.MILLISECONDS);
                CheckDisposed();
                VerboseLog("{0:000}|{1}|sync wait complete: {2}", Thread.CurrentThread.Id, _id, ret);
                return ret;
            }

            var thread = Thread.CurrentThread;
            
            try
            {
                using (token.Register(thread.Interrupt))
                {
                    var ret = _sem.TryAcquire(milliseconds, TimeUnit.MILLISECONDS);
                    CheckDisposed();
                    VerboseLog("{0:000}|{1}|sync wait complete: {2}", Thread.CurrentThread.Id, _id, ret);
                    return ret;
                }
            }
            catch (Java.Lang.InterruptedException ex)
            {
                VerboseLog("{0:000}|{1}|sync wait cancelled", Thread.CurrentThread.Id, _id);
                throw new OperationCanceledException("operation cancelled", ex, token);
            }
        }

        public void Release()
        {
            Release(1);
        }

        public void Release(int count)
        {
            VerboseLog("{0:000}|{1}|about to release {2}; available permits {3}", Thread.CurrentThread.Id, _id, count, _sem.AvailablePermits());
            if (count == 0) return;


            // Note: we are not being fair here. we always prefer async waiters.
            if (_asyncWaiters != null)
            {
                AsyncWaiter waiter;
                while (count > 0 && (waiter = _asyncWaiters.Poll()) != null)
                {
                    CleanUpWaiter(waiter);

                    if (waiter.Task.Task.IsCompleted)
                    {
                        VerboseLog("{0:000}|{1}|found completed async waiter", Thread.CurrentThread.Id, _id);
                        continue;
                    }

                    VerboseLog("{0:000}|{1}|releasing async waiter: {2:X}; {3}", Thread.CurrentThread.Id, _id, waiter.GetHashCode(), waiter.Task.Task.Id);
                    waiter.Task.SetResult(true);
                    count -= 1;
                    VerboseLog("{0:000}|{1}|async waiter released. remaining count: {2}; available permits: {3}", Thread.CurrentThread.Id, _id, count, _sem.AvailablePermits());
                }
            }

            if (count == 0) return;

            _sem.Release(count);
            VerboseLog("{0:000}|{1}|released semaphore(s). Available: {2}", Thread.CurrentThread.Id, _id, _sem.AvailablePermits());
        }

        public void Dispose()
        {
            if (_wasDisposed) return;

            VerboseLog("{0:000}|{1}|disposing semaphore. available: {2}", Thread.CurrentThread.Id, _id, _sem.AvailablePermits());

            _wasDisposed = true;
            _sem.Release(Int32.MaxValue);

            if (_asyncWaiters != null)
            {
                AsyncWaiter asyncWaiter;
                while ((asyncWaiter = _asyncWaiters.Poll()) != null)
                    CleanUpWaiter(asyncWaiter);
            }
        }

        /// <summary>
        /// Will set ObjectedDisposedException is we were disposed.
        /// </summary>
        private void CleanUpWaiter(AsyncWaiter waiter)
        {
            waiter.CancelRegistration.Dispose();

            if (waiter.Delay != null)
            {
                waiter.CancelDelay.Cancel();
                waiter.Delay.Dispose();
            }

            if (_wasDisposed)
            {
                VerboseLog("{0:000}|{1}|disposing async waiter: {2}", Thread.CurrentThread.Id, _id, waiter.Task.Task.Id);
                waiter.Task.TrySetException(new ObjectDisposedException(GetType().Name));
            }
        }

        private void CheckDisposed()
        {
            if (_wasDisposed)
            {
                VerboseLog("{0:000}|{1}|sync semaphore disposed.", Thread.CurrentThread.Id, _id);
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        private class AsyncWaiter
        {
            public TaskCompletionSource<bool> Task;
            public CancellationTokenRegistration CancelRegistration;
            public CancellationTokenSource CancelDelay;
            public Task Delay;
        }

        [Conditional("DEBUG")]
        [StringFormatMethod("format")]
        private static void VerboseLog(string format, params object[] args)
        {
            //Log.Verbose("dot42.threading", format, args);
        }
    }
}
