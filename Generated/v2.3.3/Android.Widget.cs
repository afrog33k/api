﻿#pragma warning disable 1717
namespace Android.Widget
{
		/// <summary>
		///  <para>Base class that can be used to implement virtualized lists of items. A list does not have a spatial definition here. For instance, subclases of this class can display the content of the list in a grid, in a carousel, as stack, etc.</para> <para>ref android.R.styleable::AbsListView_listSelector  ref android.R.styleable::AbsListView_drawSelectorOnTop  ref android.R.styleable::AbsListView_stackFromBottom  ref android.R.styleable::AbsListView_scrollingCache  ref android.R.styleable::AbsListView_textFilterEnabled  ref android.R.styleable::AbsListView_transcriptMode  ref android.R.styleable::AbsListView_cacheColorHint  ref android.R.styleable::AbsListView_fastScrollEnabled  ref android.R.styleable::AbsListView_smoothScrollbar  ref android.R.styleable::AbsListView_choiceMode </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AbsListView
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsListView", AccessFlags = 1057, Signature = "Landroid/widget/AdapterView<Landroid/widget/ListAdapter;>;Landroid/text/TextWatch" +
    "er;Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;Landroid/widget/Filter$" +
    "FilterListener;Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;")]
		public abstract partial class AbsListView : global::Android.Widget.AdapterView<global::Android.Widget.IListAdapter>, global::Android.Text.ITextWatcher, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, global::Android.Widget.Filter.IFilterListener, global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Disables the transcript mode.</para> <para> <para>setTranscriptMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TRANSCRIPT_MODE_DISABLED
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_DISABLED", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_DISABLED = 0;
				/// <summary>
				///  <para>The list will automatically scroll to the bottom when a data set change notification is received and only if the last item is already visible on screen.</para> <para> <para>setTranscriptMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TRANSCRIPT_MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_NORMAL", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_NORMAL = 1;
				/// <summary>
				///  <para>The list will automatically scroll to the bottom, no matter what items are currently visible.</para> <para> <para>setTranscriptMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// TRANSCRIPT_MODE_ALWAYS_SCROLL
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_ALWAYS_SCROLL", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_ALWAYS_SCROLL = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the listener that will receive notifications every time the list scrolls.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnScrollListener
				/// </java-name>
				[Dot42.DexImport("setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", AccessFlags = 1)]
				public virtual void SetOnScrollListener(global::Android.Widget.AbsListView.IOnScrollListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public override void GetFocusedRect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the initial value for the text filter.  <para>setTextFilterEnabled </para></para>        
				/// </summary>
				/// <java-name>
				/// setFilterText
				/// </java-name>
				[Dot42.DexImport("setFilterText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetFilterText(string filterText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses should NOT override this method but layoutChildren() instead. </para>        
				/// </summary>
				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses must override this method to layout their children. </para>        
				/// </summary>
				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal virtual void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Controls whether the selection highlight drawable should be drawn on top of the item or behind it.</para> <para>ref android.R.styleable::AbsListView_drawSelectorOnTop </para>        
				/// </summary>
				/// <java-name>
				/// setDrawSelectorOnTop
				/// </java-name>
				[Dot42.DexImport("setDrawSelectorOnTop", "(Z)V", AccessFlags = 1)]
				public virtual void SetDrawSelectorOnTop(bool onTop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a Drawable that should be used to highlight the currently selected item.</para> <para>ref android.R.styleable::AbsListView_listSelector </para>        
				/// </summary>
				/// <java-name>
				/// setSelector
				/// </java-name>
				[Dot42.DexImport("setSelector", "(I)V", AccessFlags = 1)]
				public virtual void SetSelector(int resID) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollIndicators
				/// </java-name>
				[Dot42.DexImport("setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetScrollIndicators(global::Android.Views.View up, global::Android.Views.View down) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 1)]
				public new virtual bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable dr) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool hasWindowFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool ShowContextMenuForChild(global::Android.Views.View originalView) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal override void DispatchSetPressed(bool pressed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Maps a point to a position in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position of the item which contains the specified point, or INVALID_POSITION if the point does not intersect an item. </para>
				/// </returns>
				/// <java-name>
				/// pointToPosition
				/// </java-name>
				[Dot42.DexImport("pointToPosition", "(II)I", AccessFlags = 1)]
				public virtual int PointToPosition(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Maps a point to a the rowId of the item which intersects that point.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The rowId of the item which contains the specified point, or INVALID_ROW_ID if the point does not intersect an item. </para>
				/// </returns>
				/// <java-name>
				/// pointToRowId
				/// </java-name>
				[Dot42.DexImport("pointToRowId", "(II)J", AccessFlags = 1)]
				public virtual long PointToRowId(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Callback method to be invoked when the touch mode changes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTouchModeChanged
				/// </java-name>
				[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnTouchModeChanged(bool isInTouchMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int scrollX, int scrollY, bool clampedX, bool clampedY) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public override void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Smoothly scroll to the specified adapter position. The view will scroll such that the indicated position is displayed. </para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(I)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPosition(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Smoothly scroll to the specified adapter position. The view will scroll such that the indicated position is displayed, but it will stop early if scrolling further would scroll boundPosition out of view. </para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(II)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPosition(int position, int boundPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Smoothly scroll by distance pixels over duration milliseconds. </para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 1)]
				public virtual void SmoothScrollBy(int distance, int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes all the views to be rebuilt and redrawn. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateViews
				/// </java-name>
				[Dot42.DexImport("invalidateViews", "()V", AccessFlags = 1)]
				public virtual void InvalidateViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleDataChanged
				/// </java-name>
				[Dot42.DexImport("handleDataChanged", "()V", AccessFlags = 4)]
				protected internal virtual void HandleDataChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal override void OnDisplayHint(int hint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return an InputConnection for editing of the filter text. </para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo outAttrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <summary>
				///  <para>For filtering we proxy an input connection to an internal text editor, and this allows the proxying to happen. </para>        
				/// </summary>
				/// <java-name>
				/// checkInputConnectionProxy
				/// </java-name>
				[Dot42.DexImport("checkInputConnectionProxy", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool CheckInputConnectionProxy(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Clear the text filter. </para>        
				/// </summary>
				/// <java-name>
				/// clearTextFilter
				/// </java-name>
				[Dot42.DexImport("clearTextFilter", "()V", AccessFlags = 1)]
				public virtual void ClearTextFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback method to be invoked when the global layout state or the visibility of views within the view tree changes </para>        
				/// </summary>
				/// <java-name>
				/// onGlobalLayout
				/// </java-name>
				[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1)]
				public virtual void OnGlobalLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For our text watcher that is associated with the text filter. Does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void BeforeTextChanged(global::Java.Lang.ICharSequence s, int start, int count, int after) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For our text watcher that is associated with the text filter. Performs the actual filtering as the text changes, and takes care of hiding and showing the popup displaying the currently entered filter text. </para>        
				/// </summary>
				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void OnTextChanged(global::Java.Lang.ICharSequence s, int start, int before, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>For our text watcher that is associated with the text filter. Does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 1)]
				public virtual void AfterTextChanged(global::Android.Text.IEditable s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the end of a filtering operation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onFilterComplete
				/// </java-name>
				[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1)]
				public virtual void OnFilterComplete(int count) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.AbsListView.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.AbsListView.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move all views (excluding headers and footers) held by this AbsListView into the supplied List. This includes views displayed on the screen as well as views stored in AbsListView's internal view recycler.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reclaimViews
				/// </java-name>
				[Dot42.DexImport("reclaimViews", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/view/View;>;)V")]
				public virtual void ReclaimViews(global::Java.Util.IList<global::Android.Views.View> views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the recycler listener to be notified whenever a View is set aside in the recycler for later reuse. This listener can be used to free resources associated to the View.</para> <para> <para>android.widget.AbsListView.RecycleBin </para> <para>android.widget.AbsListView.RecyclerListener </para></para>        
				/// </summary>
				/// <java-name>
				/// setRecyclerListener
				/// </java-name>
				[Dot42.DexImport("setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V", AccessFlags = 1)]
				public virtual void SetRecyclerListener(global::Android.Widget.AbsListView.IRecyclerListener listener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbsListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the fast scroller is enabled.</para> <para> <para>#setFastScrollEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if fast scroll is enabled, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isFastScrollEnabled
				/// </java-name>
				public virtual bool IsFastScrollEnabled
				{
						[Dot42.DexImport("isFastScrollEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFastScrollEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current state of the fast scroll feature.</para> <para> <para>setSmoothScrollbarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if smooth scrollbar is enabled is enabled, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isSmoothScrollbarEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollbarEnabled
				{
						[Dot42.DexImport("isSmoothScrollbarEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollbarEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether the children's drawing cache is used during a scroll. By default, the drawing cache is enabled but this will consume more memory.</para> <para> <para>setScrollingCacheEnabled(boolean) </para> <para>View::setDrawingCacheEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the scrolling cache is enabled, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isScrollingCacheEnabled
				/// </java-name>
				public virtual bool IsScrollingCacheEnabled
				{
						[Dot42.DexImport("isScrollingCacheEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setScrollingCacheEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether type filtering is enabled for this view</para> <para> <para>setTextFilterEnabled(boolean) </para> <para>Filterable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if type filtering is enabled, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isTextFilterEnabled
				/// </java-name>
				public virtual bool IsTextFilterEnabled
				{
						[Dot42.DexImport("isTextFilterEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setTextFilterEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether the content of this view is pinned to, or stacked from, the bottom edge.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the content is stacked from the bottom edge, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isStackFromBottom
				/// </java-name>
				public virtual bool IsStackFromBottom
				{
						[Dot42.DexImport("isStackFromBottom", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStackFromBottom", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the list's text filter, if available. </para>        
				/// </summary>
				/// <returns>
				///  <para>the list's text filter or null if filtering isn't enabled </para>
				/// </returns>
				/// <java-name>
				/// getTextFilter
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextFilter
				{
						[Dot42.DexImport("getTextFilter", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal override float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal override float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public override global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>List padding is the maximum of the normal view's padding and the padding of the selector.</para> <para> <para>android.view.View::getPaddingTop() </para> <para>getSelector()</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The top list padding. </para>
				/// </returns>
				/// <java-name>
				/// getListPaddingTop
				/// </java-name>
				public virtual int ListPaddingTop
				{
						[Dot42.DexImport("getListPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>List padding is the maximum of the normal view's padding and the padding of the selector.</para> <para> <para>android.view.View::getPaddingBottom() </para> <para>getSelector()</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The bottom list padding. </para>
				/// </returns>
				/// <java-name>
				/// getListPaddingBottom
				/// </java-name>
				public virtual int ListPaddingBottom
				{
						[Dot42.DexImport("getListPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>List padding is the maximum of the normal view's padding and the padding of the selector.</para> <para> <para>android.view.View::getPaddingLeft() </para> <para>getSelector()</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The left list padding. </para>
				/// </returns>
				/// <java-name>
				/// getListPaddingLeft
				/// </java-name>
				public virtual int ListPaddingLeft
				{
						[Dot42.DexImport("getListPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>List padding is the maximum of the normal view's padding and the padding of the selector.</para> <para> <para>android.view.View::getPaddingRight() </para> <para>getSelector()</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The right list padding. </para>
				/// </returns>
				/// <java-name>
				/// getListPaddingRight
				/// </java-name>
				public virtual int ListPaddingRight
				{
						[Dot42.DexImport("getListPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the selector android.graphics.drawable.Drawable that is used to draw the selection in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the drawable used to display the selector </para>
				/// </returns>
				/// <java-name>
				/// getSelector
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Selector
				{
						[Dot42.DexImport("getSelector", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setSelector", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal override global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <java-name>
				/// isInFilterMode
				/// </java-name>
				protected internal virtual bool IsInFilterMode
				{
						[Dot42.DexImport("isInFilterMode", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns if the ListView currently has a text filter. </para>        
				/// </summary>
				/// <java-name>
				/// hasTextFilter
				/// </java-name>
				public virtual bool HasTextFilter
				{
						[Dot42.DexImport("hasTextFilter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current transcript mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>TRANSCRIPT_MODE_DISABLED, TRANSCRIPT_MODE_NORMAL or TRANSCRIPT_MODE_ALWAYS_SCROLL </para>
				/// </returns>
				/// <java-name>
				/// getTranscriptMode
				/// </java-name>
				public virtual int TranscriptMode
				{
						[Dot42.DexImport("getTranscriptMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTranscriptMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSolidColor
				/// </java-name>
				public override int SolidColor
				{
						[Dot42.DexImport("getSolidColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>When set to a non-zero value, the cache color hint indicates that this list is always drawn on top of a solid, single-color, opaque background</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The cache color hint </para>
				/// </returns>
				/// <java-name>
				/// getCacheColorHint
				/// </java-name>
				public virtual int CacheColorHint
				{
						[Dot42.DexImport("getCacheColorHint", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCacheColorHint", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>A RecyclerListener is used to receive a notification whenever a View is placed inside the RecycleBin's scrap heap. This listener is used to free resources associated to Views placed in the RecycleBin.</para> <para> <para>android.widget.AbsListView.RecycleBin </para> <para>android.widget.AbsListView::setRecyclerListener(android.widget.AbsListView.RecyclerListener) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AbsListView$RecyclerListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$RecyclerListener", AccessFlags = 1545)]
				public partial interface IRecyclerListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Indicates that the specified View was moved into the recycler's scrap heap. The view is not displayed on screen any more and any expensive resource associated with the view should be discarded.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onMovedToScrapHeap
						/// </java-name>
						[Dot42.DexImport("onMovedToScrapHeap", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnMovedToScrapHeap(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>AbsListView extends LayoutParams to provide a place to hold the view type. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AbsListView$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the list or grid has been scrolled. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AbsListView$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$OnScrollListener", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IOnScrollListenerConstants
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The view is not scrolling. Note navigating the list using the trackball counts as being in the idle state since these transitions are not animated. </para>        
						/// </summary>
						/// <java-name>
						/// SCROLL_STATE_IDLE
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_IDLE", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_IDLE = 0;
						/// <summary>
						///  <para>The user is scrolling using touch, and their finger is still on the screen </para>        
						/// </summary>
						/// <java-name>
						/// SCROLL_STATE_TOUCH_SCROLL
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_TOUCH_SCROLL", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_TOUCH_SCROLL = 1;
						/// <summary>
						///  <para>The user had previously been scrolling using touch and had performed a fling. The animation is now coasting to a stop </para>        
						/// </summary>
						/// <java-name>
						/// SCROLL_STATE_FLING
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_FLING", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_FLING = 2;
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the list or grid has been scrolled. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AbsListView$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$OnScrollListener", AccessFlags = 1545)]
				public partial interface IOnScrollListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked while the list view or grid view is being scrolled. If the view is being scrolled, this method will be called before the next frame of the scroll is rendered. In particular, it will be called before any calls to Adapter#getView(int, View, ViewGroup).</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onScrollStateChanged
						/// </java-name>
						[Dot42.DexImport("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", AccessFlags = 1025)]
						void OnScrollStateChanged(global::Android.Widget.AbsListView view, int scrollState) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Callback method to be invoked when the list or grid has been scrolled. This will be called after the scroll has completed </para>        
						/// </summary>
						/// <java-name>
						/// onScroll
						/// </java-name>
						[Dot42.DexImport("onScroll", "(Landroid/widget/AbsListView;III)V", AccessFlags = 1025)]
						void OnScroll(global::Android.Widget.AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A layout that lets you specify exact locations (x/y coordinates) of its children. Absolute layouts are less flexible and harder to maintain than other types of layouts without absolute positioning.</para> <para> <b>XML attributes</b></para> <para>See ViewGroup Attributes, View Attributes</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.widget.FrameLayout, android.widget.RelativeLayout or a custom layout instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AbsoluteLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsoluteLayout", AccessFlags = 33)]
		public partial class AbsoluteLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#WRAP_CONTENT, a height of android.view.ViewGroup.LayoutParams#WRAP_CONTENT and with the coordinates (0, 0). </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbsoluteLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Per-child layout information associated with AbsoluteLayout. See Absolute Layout Attributes for a list of all child view attributes that this class supports. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AbsoluteLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsoluteLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The horizontal, or X, location of the child within the view group. </para>        
						/// </summary>
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "I", AccessFlags = 1)]
						public int X;
						/// <summary>
						///  <para>The vertical, or Y, location of the child within the view group. </para>        
						/// </summary>
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "I", AccessFlags = 1)]
						public int Y;
						[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string output) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/AbsSeekBar
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsSeekBar", AccessFlags = 1057)]
		public abstract partial class AbsSeekBar : global::Android.Widget.ProgressBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the thumb that will be drawn at the end of the progress meter within the SeekBar. </para> <para>If the thumb is a valid drawable (i.e. not null), half its width will be used as the new thumb offset ( <para>setThumbOffset(int)).</para></para>        
				/// </summary>
				/// <java-name>
				/// setThumb
				/// </java-name>
				[Dot42.DexImport("setThumb", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetThumb(global::Android.Graphics.Drawables.Drawable thumb) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 36)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbsSeekBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <para>setThumbOffset(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getThumbOffset
				/// </java-name>
				public virtual int ThumbOffset
				{
						[Dot42.DexImport("getThumbOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setThumbOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the amount of progress changed via the arrow keys. </para> <para>By default, this will be a value that is derived from the max progress.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The amount to increment or decrement when the user presses the arrow keys. This will be positive. </para>
				/// </returns>
				/// <java-name>
				/// getKeyProgressIncrement
				/// </java-name>
				public virtual int KeyProgressIncrement
				{
						[Dot42.DexImport("getKeyProgressIncrement", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setKeyProgressIncrement", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMax
				/// </java-name>
				public override int Max
				{
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

		}

		/// <summary>
		///  <para>An abstract base class for spinner widgets. SDK users will probably not need to use this class.</para> <para>ref android.R.styleable::AbsSpinner_entries </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AbsSpinner
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsSpinner", AccessFlags = 1057, Signature = "Landroid/widget/AdapterView<Landroid/widget/SpinnerAdapter;>;")]
		public abstract partial class AbsSpinner : global::Android.Widget.AdapterView<global::Android.Widget.ISpinnerAdapter>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>android.view.View::measure(int, int)</para>Figure out the dimensions of this Spinner. The width comes from the widthMeasureSpec as Spinnners can't have their width set to UNSPECIFIED. The height is based on the height of the selected item plus padding. </para>        
				/// </summary>
				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <summary>
				///  <para>Jump directly to a specific item in the adapter data. </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(IZ)V", AccessFlags = 1)]
				public virtual void SetSelection(int position, bool animate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to prevent spamming ourselves with layout requests as we place views</para> <para> <para>android.view.View::requestLayout() </para></para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Maps a point to a position in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position of the item which contains the specified point, or INVALID_POSITION if the point does not intersect an item. </para>
				/// </returns>
				/// <java-name>
				/// pointToPosition
				/// </java-name>
				[Dot42.DexImport("pointToPosition", "(II)I", AccessFlags = 1)]
				public virtual int PointToPosition(int x, int y) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AbsSpinner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public override global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.ISpinnerAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/SpinnerAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ISpinnerAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/SpinnerAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>An AdapterView is a view whose children are determined by an Adapter.</para> <para>See ListView, GridView, Spinner and Gallery for commonly used subclasses of AdapterView.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using AdapterView, read the  developer guide.</para> <para> </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AdapterView
		/// </java-name>
		[Dot42.DexImport("android/widget/AdapterView", AccessFlags = 1057, Signature = "<T::Landroid/widget/Adapter;>Landroid/view/ViewGroup;")]
		public abstract partial class AdapterView<T> : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The item view type returned by Adapter#getItemViewType(int) when the adapter does not want the item's view recycled. </para>        
				/// </summary>
				/// <java-name>
				/// ITEM_VIEW_TYPE_IGNORE
				/// </java-name>
				[Dot42.DexImport("ITEM_VIEW_TYPE_IGNORE", "I", AccessFlags = 25)]
				public const int ITEM_VIEW_TYPE_IGNORE = -1;
				/// <summary>
				///  <para>The item view type returned by Adapter#getItemViewType(int) when the item is a header or footer. </para>        
				/// </summary>
				/// <java-name>
				/// ITEM_VIEW_TYPE_HEADER_OR_FOOTER
				/// </java-name>
				[Dot42.DexImport("ITEM_VIEW_TYPE_HEADER_OR_FOOTER", "I", AccessFlags = 25)]
				public const int ITEM_VIEW_TYPE_HEADER_OR_FOOTER = -2;
				/// <summary>
				///  <para>Represents an invalid position. All valid positions are in the range 0 to 1 less than the number of items in the current adapter. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_POSITION
				/// </java-name>
				[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
				public const int INVALID_POSITION = -1;
				/// <summary>
				///  <para>Represents an empty or invalid row id </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_ROW_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_ROW_ID", "J", AccessFlags = 25)]
				public const long INVALID_ROW_ID = -9223372036854775808;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call the OnItemClickListener, if it is defined. Performs all normal actions associated with clicking: reporting accessibility event, playing a sound, etc.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if there was an assigned OnItemClickListener that was called, false otherwise is returned. </para>
				/// </returns>
				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public virtual bool PerformItemClick(global::Android.Views.View view, int position, long id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public override void RemoveViewAt(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is not supported and throws an UnsupportedOperationException when called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public override void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the position within the adapter's data set for the view, where view is a an adapter item or a descendant of an adapter item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the position within the adapter's data set of the view, or INVALID_POSITION if the view does not correspond to a list item (or it is not currently visible). </para>
				/// </returns>
				/// <java-name>
				/// getPositionForView
				/// </java-name>
				[Dot42.DexImport("getPositionForView", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int GetPositionForView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the currently selected item. To support accessibility subclasses that override this method must invoke the overriden super method first.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1025)]
				public abstract void SetSelection(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the data associated with the specified position in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The data associated with the specified position in the list </para>
				/// </returns>
				/// <java-name>
				/// getItemAtPosition
				/// </java-name>
				[Dot42.DexImport("getItemAtPosition", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetItemAtPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getItemIdAtPosition
				/// </java-name>
				[Dot42.DexImport("getItemIdAtPosition", "(I)J", AccessFlags = 1)]
				public virtual long GetItemIdAtPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public override void SetOnClickListener(global::Android.Views.View.IOnClickListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to prevent freezing of any views created by the adapter. </para>        
				/// </summary>
				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override to prevent thawing of any views created by the adapter. </para>        
				/// </summary>
				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AdapterView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The callback to be invoked with an item in this AdapterView has been clicked, or null id no callback has been set. </para>
				/// </returns>
				/// <java-name>
				/// getOnItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemClickListener); }
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The callback to be invoked with an item in this AdapterView has been clicked and held, or null id no callback as been set. </para>
				/// </returns>
				/// <java-name>
				/// getOnItemLongClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemLongClickListener OnItemLongClickListener
				{
						[Dot42.DexImport("getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemLongClickListener); }
						[Dot42.DexImport("setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemSelectedListener OnItemSelectedListener
				{
						[Dot42.DexImport("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemSelectedListener); }
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the adapter currently associated with this widget.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The adapter used to provide this view's content. </para>
				/// </returns>
				/// <java-name>
				/// getAdapter
				/// </java-name>
				public abstract T Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/Adapter;", AccessFlags = 1025, Signature = "()TT;")]
						get;
						[Dot42.DexImport("setAdapter", "(Landroid/widget/Adapter;)V", AccessFlags = 1025, Signature = "(TT;)V")]
						set;
				}

				/// <summary>
				///  <para>Return the position of the currently selected item within the adapter's data set</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int Position (starting at 0), or INVALID_POSITION if there is nothing selected. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id corresponding to the currently selected item, or INVALID_ROW_ID if nothing is selected. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view corresponding to the currently selected item, or null if nothing is selected </para>
				/// </returns>
				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public abstract global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The data corresponding to the currently selected item, or null if there is nothing selected. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedItem
				/// </java-name>
				public virtual object SelectedItem
				{
						[Dot42.DexImport("getSelectedItem", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of items owned by the Adapter associated with this AdapterView. (This is the number of data items, which may be larger than the number of visible views.) </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the position within the adapter's data set for the first item displayed on screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position within the adapter's data set </para>
				/// </returns>
				/// <java-name>
				/// getFirstVisiblePosition
				/// </java-name>
				public virtual int FirstVisiblePosition
				{
						[Dot42.DexImport("getFirstVisiblePosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the position within the adapter's data set for the last item displayed on screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position within the adapter's data set </para>
				/// </returns>
				/// <java-name>
				/// getLastVisiblePosition
				/// </java-name>
				public virtual int LastVisiblePosition
				{
						[Dot42.DexImport("getLastVisiblePosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>When the current adapter is empty, the AdapterView can display a special view call the empty view. The empty view is used to provide feedback to the user that no data is available in this AdapterView.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view to show if the adapter is empty. </para>
				/// </returns>
				/// <java-name>
				/// getEmptyView
				/// </java-name>
				public virtual global::Android.Views.View EmptyView
				{
						[Dot42.DexImport("getEmptyView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setEmptyView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal override bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// setFocusable
				/// </java-name>
				public override bool IsFocusable
				{
						[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setFocusableInTouchMode
				/// </java-name>
				public override bool IsFocusableInTouchMode
				{
						[Dot42.DexImport("setFocusableInTouchMode", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Extra menu information provided to the android.view.View.OnCreateContextMenuListener#onCreateContextMenu(ContextMenu, View, ContextMenuInfo) callback when a context menu is brought up for this AdapterView. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AdapterView$AdapterContextMenuInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$AdapterContextMenuInfo", AccessFlags = 9)]
				public partial class AdapterContextMenuInfo : global::Android.Views.IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The child view for which the context menu is being displayed. This will be one of the children of this AdapterView. </para>        
						/// </summary>
						/// <java-name>
						/// targetView
						/// </java-name>
						[Dot42.DexImport("targetView", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View TargetView;
						/// <summary>
						///  <para>The position in the adapter for which the context menu is being displayed. </para>        
						/// </summary>
						/// <java-name>
						/// position
						/// </java-name>
						[Dot42.DexImport("position", "I", AccessFlags = 1)]
						public int Position;
						/// <summary>
						///  <para>The row id of the item for which the context menu is being displayed. </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						[Dot42.DexImport("<init>", "(Landroid/view/View;IJ)V", AccessFlags = 1)]
						public AdapterContextMenuInfo(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal AdapterContextMenuInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an item in this view has been selected. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AdapterView$OnItemSelectedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemSelectedListener", AccessFlags = 1545)]
				public partial interface IOnItemSelectedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when an item in this view has been selected. This callback is invoked only when the newly selected position is different from the previously selected position or if there was no selected item.</para> <para>Impelmenters can call getItemAtPosition(position) if they need to access the data associated with the selected item.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onItemSelected
						/// </java-name>
						[Dot42.DexImport("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)V")]
						void OnItemSelected(global::Android.Widget.AdapterView<object> parent, global::Android.Views.View view, int position, long id) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Callback method to be invoked when the selection disappears from this view. The selection can disappear for instance when touch is activated or when the adapter becomes empty.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onNothingSelected
						/// </java-name>
						[Dot42.DexImport("onNothingSelected", "(Landroid/widget/AdapterView;)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;)V")]
						void OnNothingSelected(global::Android.Widget.AdapterView<object> parent) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an item in this view has been clicked and held. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AdapterView$OnItemLongClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemLongClickListener", AccessFlags = 1545)]
				public partial interface IOnItemLongClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when an item in this view has been clicked and held.</para> <para>Implementers can call getItemAtPosition(position) if they need to access the data associated with the selected item.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the callback consumed the long click, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// onItemLongClick
						/// </java-name>
						[Dot42.DexImport("onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)Z")]
						bool OnItemLongClick(global::Android.Widget.AdapterView<object> parent, global::Android.Views.View view, int position, long id) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an item in this AdapterView has been clicked. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AdapterView$OnItemClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemClickListener", AccessFlags = 1545)]
				public partial interface IOnItemClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when an item in this AdapterView has been clicked. </para> <para>Implementers can call getItemAtPosition(position) if they need to access the data associated with the selected item.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onItemClick
						/// </java-name>
						[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)V")]
						void OnItemClick(global::Android.Widget.AdapterView<object> parent, global::Android.Views.View view, int position, long id) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A helper class for adapters that implement the SectionIndexer interface. If the items in the adapter are sorted by simple alphabet-based sorting, then this class provides a way to do fast indexing of large lists using binary search. It caches the indices that have been determined through the binary search and also invalidates the cache if changes occur in the cursor. </para> <para>Your adapter is responsible for updating the cursor by calling setCursor if the cursor changes. getPositionForSection method does the binary search for the starting index of a given section (alphabet). </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AlphabetIndexer
		/// </java-name>
		[Dot42.DexImport("android/widget/AlphabetIndexer", AccessFlags = 33)]
		public partial class AlphabetIndexer : global::Android.Database.DataSetObserver, global::Android.Widget.ISectionIndexer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Cursor that is used by the adapter of the list view. </para>        
				/// </summary>
				/// <java-name>
				/// mDataCursor
				/// </java-name>
				[Dot42.DexImport("mDataCursor", "Landroid/database/Cursor;", AccessFlags = 4)]
				protected internal global::Android.Database.ICursor MDataCursor;
				/// <summary>
				///  <para>The index of the cursor column that this list is sorted on. </para>        
				/// </summary>
				/// <java-name>
				/// mColumnIndex
				/// </java-name>
				[Dot42.DexImport("mColumnIndex", "I", AccessFlags = 4)]
				protected internal int MColumnIndex;
				/// <summary>
				///  <para>The string of characters that make up the indexing sections. </para>        
				/// </summary>
				/// <java-name>
				/// mAlphabet
				/// </java-name>
				[Dot42.DexImport("mAlphabet", "Ljava/lang/CharSequence;", AccessFlags = 4)]
				protected internal global::Java.Lang.ICharSequence MAlphabet;
				/// <summary>
				///  <para>Constructs the indexer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;ILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public AlphabetIndexer(global::Android.Database.ICursor cursor, int sortedColumnIndex, global::Java.Lang.ICharSequence alphabet) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a new cursor as the data set and resets the cache of indices. </para>        
				/// </summary>
				/// <java-name>
				/// setCursor
				/// </java-name>
				[Dot42.DexImport("setCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Default implementation compares the first character of word with letter. </para>        
				/// </summary>
				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 4)]
				protected internal virtual int Compare(string word, string letter) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Performs a binary search or cache lookup to find the first row that matches a given section's starting letter. </para>        
				/// </summary>
				/// <returns>
				///  <para>the row index of the first occurrence, or the nearest next letter. For instance, if searching for "T" and no "T" is found, then the first row starting with "U" or any higher letter is returned. If there is no data following "T" at all, then the list size is returned. </para>
				/// </returns>
				/// <java-name>
				/// getPositionForSection
				/// </java-name>
				[Dot42.DexImport("getPositionForSection", "(I)I", AccessFlags = 1)]
				public virtual int GetPositionForSection(int sectionIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the section index for a given position in the list by querying the item and comparing it with all items in the section array. </para>        
				/// </summary>
				/// <java-name>
				/// getSectionForPosition
				/// </java-name>
				[Dot42.DexImport("getSectionForPosition", "(I)I", AccessFlags = 1)]
				public virtual int GetSectionForPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onChanged
				/// </java-name>
				[Dot42.DexImport("onChanged", "()V", AccessFlags = 1)]
				public override void OnChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInvalidated
				/// </java-name>
				[Dot42.DexImport("onInvalidated", "()V", AccessFlags = 1)]
				public override void OnInvalidated() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AlphabetIndexer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the section array constructed from the alphabet provided in the constructor. </para>        
				/// </summary>
				/// <returns>
				///  <para>the section array </para>
				/// </returns>
				/// <java-name>
				/// getSections
				/// </java-name>
				public virtual object[] Sections
				{
						[Dot42.DexImport("getSections", "()[Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object[]); }
				}

		}

		/// <summary>
		///  <para>This widget display an analogic clock with two hands for hours and minutes.</para> <para>ref android.R.styleable::AnalogClock_dial  ref android.R.styleable::AnalogClock_hand_hour  ref android.R.styleable::AnalogClock_hand_minute </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AnalogClock
		/// </java-name>
		[Dot42.DexImport("android/widget/AnalogClock", AccessFlags = 33)]
		public partial class AnalogClock : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AnalogClock() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A concrete BaseAdapter that is backed by an array of arbitrary objects. By default this class expects that the provided resource id references a single TextView. If you want to use a more complex layout, use the constructors that also takes a field id. That field id should reference a TextView in the larger layout resource.</para> <para>However the TextView is referenced, it will be filled with the toString() of each object in the array. You can add lists or arrays of custom objects. Override the toString() method of your objects to determine what text will be displayed for the item in the list.</para> <para>To use something other than TextViews for the array display, for instance, ImageViews, or to have some of data besides toString() results fill the views, override getView(int, View, ViewGroup) to return the type of view you want. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ArrayAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ArrayAdapter", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Landroid/widget/BaseAdapter;Landroid/widget/Filterable;")]
		public partial class ArrayAdapter<T> : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ArrayAdapter(global::Android.Content.Context context, int resource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public ArrayAdapter(global::Android.Content.Context context, int resource, int textViewResourceId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;I[TT;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int resource, T[] textViewResourceId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;II[TT;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int resource, int textViewResourceId, T[] objects) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILjava/util/List;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;ILjava/util/List<TT;>;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int resource, global::Java.Util.IList<T> textViewResourceId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;IILjava/util/List;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;IILjava/util/List<TT;>;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int resource, int textViewResourceId, global::Java.Util.IList<T> objects) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the specified object at the end of the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Add(T @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inserts the specified object at the specified index in the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TT;I)V")]
				public virtual void Insert(T @object, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the specified object from the array.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Remove(T @object) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all elements from the list. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sorts the content of this adapter using the specified comparator.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TT;>;)V")]
				public virtual void Sort(global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public override void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Control whether methods that change the list (add, insert, remove, clear) automatically call notifyDataSetChanged. If set to false, caller must manually call notifyDataSetChanged() to have the changes reflected in the attached view.</para> <para>The default is true, and calling notifyDataSetChanged() resets the flag to true.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNotifyOnChange
				/// </java-name>
				[Dot42.DexImport("setNotifyOnChange", "(Z)V", AccessFlags = 1)]
				public virtual void SetNotifyOnChange(bool notifyOnChange) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Get the data item associated with the specified position in the data set.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The data at the specified position.</para>
				/// </returns>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TT;")]
				public new virtual T GetItem(int position) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Returns the position of the specified item in the array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The position of the specified item. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetPosition(T item) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <para>Get the row id associated with the specified position in the list.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The id of the item at the specified position.</para>
				/// </returns>
				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int position) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para> <para>Get a View that displays the data at the specified position in the data set. You can either create a View manually or inflate it from an XML layout file. When the View is inflated, the parent View (GridView, ListView...) will apply default layout parameters unless you use android.view.LayoutInflater#inflate(int, android.view.ViewGroup, boolean) to specify a root view and to prevent attachment to the root.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>A View corresponding to the data at the specified position.</para>
				/// </returns>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Sets the layout resource to create the drop down views.</para> <para> <para>getDropDownView(int, android.view.View, android.view.ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int resource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Get a android.view.View that displays in the drop down popup the data at the specified position in the data set.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View corresponding to the data at the specified position.</para>
				/// </returns>
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Creates a new ArrayAdapter from external resources. The content of the array is obtained through android.content.res.Resources#getTextArray(int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An ArrayAdapter&lt;CharSequence&gt;. </para>
				/// </returns>
				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;", AccessFlags = 9, Signature = "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter<Ljava/lang/CharSequence" +
    ";>;")]
				public static global::Android.Widget.ArrayAdapter<global::Java.Lang.ICharSequence> CreateFromResource(global::Android.Content.Context context, int textArrayResId, int textViewResId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.ArrayAdapter<global::Java.Lang.ICharSequence>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ArrayAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the context associated with this array adapter. The context is used to create views from the resource passed to the constructor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Context associated with this adapter. </para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para> <para>How many items are in the data set represented by this Adapter.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>Count of items.</para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data</para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

		}

		/// <summary>
		///  <para>An editable text view that shows completion suggestions automatically while the user is typing. The list of suggestions is displayed in a drop down menu from which the user can choose an item to replace the content of the edit box with.</para> <para>The drop down can be dismissed at any time by pressing the back key or, if no item is selected in the drop down, by pressing the enter/dpad center key.</para> <para>The list of suggestions is obtained from a data adapter and appears only after a given number of characters defined by the threshold.</para> <para>The following code snippet shows how to create a text view which suggests various countries names while the user is typing:</para> <para> <pre>
		/// public class CountriesActivity extends Activity {
		///     protected void onCreate(Bundle icicle) {
		///         super.onCreate(icicle);
		///         setContentView(R.layout.countries);</pre></para> <para> <pre>        ArrayAdapter&lt;String&gt; adapter = new ArrayAdapter&lt;String&gt;(this,
		///                 android.R.layout.simple_dropdown_item_1line, COUNTRIES);
		///         AutoCompleteTextView textView = (AutoCompleteTextView)
		///                 findViewById(R.id.countries_list);
		///         textView.setAdapter(adapter);
		///     }</pre></para> <para> <pre>    private static final String[] COUNTRIES = new String[] {
		///         "Belgium", "France", "Italy", "Germany", "Spain"
		///     };
		/// }
		/// </pre></para> <para>See the  guide.</para> <para>ref android.R.styleable::AutoCompleteTextView_completionHint  ref android.R.styleable::AutoCompleteTextView_completionThreshold  ref android.R.styleable::AutoCompleteTextView_completionHintView  ref android.R.styleable::AutoCompleteTextView_dropDownSelector  ref android.R.styleable::AutoCompleteTextView_dropDownAnchor  ref android.R.styleable::AutoCompleteTextView_dropDownWidth  ref android.R.styleable::AutoCompleteTextView_dropDownHeight  ref android.R.styleable::AutoCompleteTextView_dropDownVerticalOffset  ref android.R.styleable::AutoCompleteTextView_dropDownHorizontalOffset </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/AutoCompleteTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/AutoCompleteTextView", AccessFlags = 33)]
		public partial class AutoCompleteTextView : global::Android.Widget.EditText, global::Android.Widget.Filter.IFilterListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public override void SetOnClickListener(global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the optional hint text that is displayed at the bottom of the the matching list. This can be used as a cue to the user on how to best use the list, or to provide extra information.</para> <para> <para>getCompletionHint()</para>ref android.R.styleable::AutoCompleteTextView_completionHint </para>        
				/// </summary>
				/// <java-name>
				/// setCompletionHint
				/// </java-name>
				[Dot42.DexImport("setCompletionHint", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCompletionHint(global::Java.Lang.ICharSequence hint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the background of the auto-complete drop-down list.</para> <para>ref android.R.styleable::PopupWindow_popupBackground </para>        
				/// </summary>
				/// <java-name>
				/// setDropDownBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetDropDownBackgroundDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the background of the auto-complete drop-down list.</para> <para>ref android.R.styleable::PopupWindow_popupBackground </para>        
				/// </summary>
				/// <java-name>
				/// setDropDownBackgroundResource
				/// </java-name>
				[Dot42.DexImport("setDropDownBackgroundResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownBackgroundResource(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Changes the list of data used for auto completion. The provided list must be a filterable list adapter.</para> <para>The caller is still responsible for managing any resources used by the adapter. Notably, when the AutoCompleteTextView is closed or released, the adapter is not notified. A common case is the use of android.widget.CursorAdapter, which contains a android.database.Cursor that must be closed. This can be done automatically (see startManagingCursor()), or by manually closing the cursor when the AutoCompleteTextView is dismissed.</para> <para> <para>getAdapter() </para> <para>android.widget.Filterable </para> <para>android.widget.ListAdapter </para></para>        
				/// </summary>
				/// <java-name>
				/// setAdapter
				/// </java-name>
				[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1, Signature = "<T::Landroid/widget/ListAdapter;:Landroid/widget/Filterable;>(TT;)V")]
				public virtual void SetAdapter<T>(T adapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyPreIme(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key up event has occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the amount of text in the field meets or exceeds the getThreshold requirement. You can override this to impose a different standard for when filtering will be triggered. </para>        
				/// </summary>
				/// <java-name>
				/// enoughToFilter
				/// </java-name>
				[Dot42.DexImport("enoughToFilter", "()Z", AccessFlags = 1)]
				public virtual bool EnoughToFilter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Converts the selected item from the drop down list into a sequence of character that can be used in the edit box.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a sequence of characters representing the selected suggestion </para>
				/// </returns>
				/// <java-name>
				/// convertSelectionToString
				/// </java-name>
				[Dot42.DexImport("convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.ICharSequence ConvertSelectionToString(object selectedItem) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Clear the list selection. This may only be temporary, as user input will often bring it back. </para>        
				/// </summary>
				/// <java-name>
				/// clearListSelection
				/// </java-name>
				[Dot42.DexImport("clearListSelection", "()V", AccessFlags = 1)]
				public virtual void ClearListSelection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts filtering the content of the drop down list. The filtering pattern is the content of the edit box. Subclasses should override this method to filter with a different pattern, for instance a substring of  <code>text</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;I)V", AccessFlags = 4)]
				protected internal virtual void PerformFiltering(global::Java.Lang.ICharSequence text, int keyCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the text completion by converting the selected item from the drop down list into a string, replacing the text box's content with this string and finally dismissing the drop down menu.</para>        
				/// </summary>
				/// <java-name>
				/// performCompletion
				/// </java-name>
				[Dot42.DexImport("performCompletion", "()V", AccessFlags = 1)]
				public virtual void PerformCompletion() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCommitCompletion
				/// </java-name>
				[Dot42.DexImport("onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public override void OnCommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completion) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the text completion by replacing the current text by the selected item. Subclasses should override this method to avoid replacing the whole content of the edit box.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// replaceText
				/// </java-name>
				[Dot42.DexImport("replaceText", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal virtual void ReplaceText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Notifies the end of a filtering operation.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onFilterComplete
				/// </java-name>
				[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1)]
				public virtual void OnFilterComplete(int count) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool hasWindowFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal override void OnDisplayHint(int hint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the drop down if present on screen.</para>        
				/// </summary>
				/// <java-name>
				/// dismissDropDown
				/// </java-name>
				[Dot42.DexImport("dismissDropDown", "()V", AccessFlags = 1)]
				public virtual void DismissDropDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal override bool SetFrame(int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Displays the drop down on screen.</para>        
				/// </summary>
				/// <java-name>
				/// showDropDown
				/// </java-name>
				[Dot42.DexImport("showDropDown", "()V", AccessFlags = 1)]
				public virtual void ShowDropDown() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If a validator was set on this view and the current string is not valid, ask the validator to fix it.</para> <para> <para>getValidator() </para> <para>setValidator(android.widget.AutoCompleteTextView.Validator) </para></para>        
				/// </summary>
				/// <java-name>
				/// performValidation
				/// </java-name>
				[Dot42.DexImport("performValidation", "()V", AccessFlags = 1)]
				public virtual void PerformValidation() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AutoCompleteTextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the current width for the auto-complete drop down list. This can be a fixed width, or ViewGroup.LayoutParams#MATCH_PARENT to fill the screen, or ViewGroup.LayoutParams#WRAP_CONTENT to fit the width of its anchor view.</para> <para>ref android.R.styleable::AutoCompleteTextView_dropDownWidth </para>        
				/// </summary>
				/// <returns>
				///  <para>the width for the drop down list</para>
				/// </returns>
				/// <java-name>
				/// getDropDownWidth
				/// </java-name>
				public virtual int DropDownWidth
				{
						[Dot42.DexImport("getDropDownWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownWidth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current height for the auto-complete drop down list. This can be a fixed height, or ViewGroup.LayoutParams#MATCH_PARENT to fill the screen, or ViewGroup.LayoutParams#WRAP_CONTENT to fit the height of the drop down's content.</para> <para>ref android.R.styleable::AutoCompleteTextView_dropDownHeight </para>        
				/// </summary>
				/// <returns>
				///  <para>the height for the drop down list</para>
				/// </returns>
				/// <java-name>
				/// getDropDownHeight
				/// </java-name>
				public virtual int DropDownHeight
				{
						[Dot42.DexImport("getDropDownHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the id for the view that the auto-complete drop down list is anchored to.</para> <para>ref android.R.styleable::AutoCompleteTextView_dropDownAnchor </para>        
				/// </summary>
				/// <returns>
				///  <para>the view's id, or View#NO_ID if none specified</para>
				/// </returns>
				/// <java-name>
				/// getDropDownAnchor
				/// </java-name>
				public virtual int DropDownAnchor
				{
						[Dot42.DexImport("getDropDownAnchor", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownAnchor", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the background of the auto-complete drop-down list.</para> <para>ref android.R.styleable::PopupWindow_popupBackground </para>        
				/// </summary>
				/// <returns>
				///  <para>the background drawable</para>
				/// </returns>
				/// <java-name>
				/// getDropDownBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable DropDownBackground
				{
						[Dot42.DexImport("getDropDownBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>Gets the vertical offset used for the auto-complete drop-down list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the vertical offset </para>
				/// </returns>
				/// <java-name>
				/// getDropDownVerticalOffset
				/// </java-name>
				public virtual int DropDownVerticalOffset
				{
						[Dot42.DexImport("getDropDownVerticalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownVerticalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the horizontal offset used for the auto-complete drop-down list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the horizontal offset </para>
				/// </returns>
				/// <java-name>
				/// getDropDownHorizontalOffset
				/// </java-name>
				public virtual int DropDownHorizontalOffset
				{
						[Dot42.DexImport("getDropDownHorizontalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownHorizontalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the number of characters the user must type before the drop down list is shown.</para> <para> <para>setThreshold(int)</para>ref android.R.styleable::AutoCompleteTextView_completionThreshold </para>        
				/// </summary>
				/// <returns>
				///  <para>the minimum number of characters to type to show the drop down</para>
				/// </returns>
				/// <java-name>
				/// getThreshold
				/// </java-name>
				public virtual int Threshold
				{
						[Dot42.DexImport("getThreshold", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setThreshold", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the listener that is notified whenever the user clicks an item in the drop down list.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getOnItemClickListener() intead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the item click listener</para>
				/// </returns>
				/// <java-name>
				/// getItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemClickListener ItemClickListener
				{
						[Dot42.DexImport("getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemClickListener); }
				}

				/// <summary>
				///  <para>Returns the listener that is notified whenever the user selects an item in the drop down list.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getOnItemSelectedListener() intead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the item selected listener</para>
				/// </returns>
				/// <java-name>
				/// getItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemSelectedListener ItemSelectedListener
				{
						[Dot42.DexImport("getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener); }
				}

				/// <summary>
				///  <para>Returns the listener that is notified whenever the user clicks an item in the drop down list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the item click listener </para>
				/// </returns>
				/// <java-name>
				/// getOnItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemClickListener); }
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the listener that is notified whenever the user selects an item in the drop down list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the item selected listener </para>
				/// </returns>
				/// <java-name>
				/// getOnItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemSelectedListener OnItemSelectedListener
				{
						[Dot42.DexImport("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener); }
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns a filterable list adapter used for auto completion.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a data adapter used for auto completion </para>
				/// </returns>
				/// <java-name>
				/// getAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
				}

				/// <summary>
				///  <para>Indicates whether the popup menu is showing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the popup menu is showing, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPopupShowing
				/// </java-name>
				public virtual bool IsPopupShowing
				{
						[Dot42.DexImport("isPopupShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Get the position of the dropdown view selection, if there is one. Returns ListView.INVALID_POSITION if there is no dropdown or if there is no selection.</para> <para> <para>ListView::getSelectedItemPosition() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the position of the current selection, if there is one, or ListView.INVALID_POSITION if not.</para>
				/// </returns>
				/// <java-name>
				/// getListSelection
				/// </java-name>
				public virtual int ListSelection
				{
						[Dot42.DexImport("getListSelection", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setListSelection", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Identifies whether the view is currently performing a text completion, so subclasses can decide whether to respond to text changed events. </para>        
				/// </summary>
				/// <java-name>
				/// isPerformingCompletion
				/// </java-name>
				public virtual bool IsPerformingCompletion
				{
						[Dot42.DexImport("isPerformingCompletion", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the Validator set with setValidator, or  <code>null</code> if it was not set.</para> <para> <para>setValidator(android.widget.AutoCompleteTextView.Validator) </para> <para>performValidation() </para></para>        
				/// </summary>
				/// <java-name>
				/// getValidator
				/// </java-name>
				public virtual global::Android.Widget.AutoCompleteTextView.IValidator Validator
				{
						[Dot42.DexImport("getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AutoCompleteTextView.IValidator); }
						[Dot42.DexImport("setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the Filter obtained from Filterable#getFilter, or  <code>null</code> if setAdapter was not called with a Filterable. </para>        
				/// </summary>
				/// <java-name>
				/// getFilter
				/// </java-name>
				protected internal virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 4)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <summary>
				///  <para>This interface is used to make sure that the text entered in this TextView complies to a certain format. Since there is no foolproof way to prevent the user from leaving this View with an incorrect value in it, all we can do is try to fix it ourselves when this happens. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/AutoCompleteTextView$Validator
				/// </java-name>
				[Dot42.DexImport("android/widget/AutoCompleteTextView$Validator", AccessFlags = 1545)]
				public partial interface IValidator
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Validates the specified text.</para> <para> <para>fixText(CharSequence) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>true If the text currently in the text editor is valid.</para>
						/// </returns>
						/// <java-name>
						/// isValid
						/// </java-name>
						[Dot42.DexImport("isValid", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1025)]
						bool IsValid(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Corrects the specified text to make it valid.</para> <para> <para>isValid(CharSequence) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>A string based on invalidText such as invoking isValid() on it returns true.</para>
						/// </returns>
						/// <java-name>
						/// fixText
						/// </java-name>
						[Dot42.DexImport("fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence FixText(global::Java.Lang.ICharSequence invalidText) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Common base class of common implementation for an Adapter that can be used in both ListView (by implementing the specialized ListAdapter interface} and Spinner (by implementing the specialized SpinnerAdapter interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/BaseAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/BaseAdapter", AccessFlags = 1057)]
		public abstract partial class BaseAdapter : global::Android.Widget.IListAdapter, global::Android.Widget.ISpinnerAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the data used by this adapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this adapter via registerDataSetObserver.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the attached observers that the underlying data has been changed and any View reflecting the data set should refresh itself. </para>        
				/// </summary>
				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the attached observers that the underlying data is no longer valid or available. Once invoked this adapter is no longer valid and should not report further data set changes. </para>        
				/// </summary>
				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether all the items in this adapter are enabled. If the value returned by this method changes over time, there is no guarantee it will take effect. If true, it means all items are selectable and clickable (there is no separator.)</para> <para> <para>isEnabled(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if all items are enabled, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the item at the specified position is not a separator. (A separator is a non-selectable, non-clickable item).</para> <para>The result is unspecified if position is invalid. An ArrayIndexOutOfBoundsException should be thrown in that case for fast failure.</para> <para> <para>areAllItemsEnabled() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the item is not a separator</para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1)]
				public virtual bool IsEnabled(int position) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get a android.view.View that displays in the drop down popup the data at the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetDropDownView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Get the type of View that will be created by getView for the specified item.</para> <para> <para>IGNORE_ITEM_VIEW_TYPE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of View. Two views should share the same type if one can be converted to the other in getView. Note: Integers must be in the range 0 to getViewTypeCount - 1. IGNORE_ITEM_VIEW_TYPE can also be returned. </para>
				/// </returns>
				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1)]
				public virtual int GetItemViewType(int position) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/Adapter", "getItem", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetItem(int position) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/Adapter", "getItemId", "(I)J", AccessFlags = 1025)]
				public virtual long GetItemId(int position) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/Adapter", "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Indicates whether the item ids are stable across changes to the underlying data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the same id always refers to the same object. </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public virtual bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the number of types of Views that will be created by getView. Each type represents a set of views that can be converted in getView. If the adapter always returns the same type of View for all items, this method should return 1. </para> <para>This method will only be called when when the adapter is set on the the AdapterView. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of types of Views that will be created by this adapter </para>
				/// </returns>
				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				public virtual int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this adapter doesn't contain any data. This is used to determine whether the empty view should be displayed. A typical implementation will return getCount() == 0 but since getCount() includes the headers and footers, specialized adapters might want a different behavior. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				public virtual int Count
				{
						[Dot42.DexImport("android/widget/Adapter", "getCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Base class for a ExpandableListAdapter used to provide data and Views from some data to an expandable list view. </para> <para>Adapters inheriting this class should verify that the base implementations of getCombinedChildId(long, long) and getCombinedGroupId(long) are correct in generating unique IDs from the group/children IDs. </para> <para> <para>SimpleExpandableListAdapter </para> <para>SimpleCursorTreeAdapter </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/BaseExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/BaseExpandableListAdapter", AccessFlags = 1057)]
		public abstract partial class BaseExpandableListAdapter : global::Android.Widget.IExpandableListAdapter, global::Android.Widget.IHeterogeneousExpandableList
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseExpandableListAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Adapter::registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Adapter::unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>DataSetObservable::notifyInvalidated() </para></para>        
				/// </summary>
				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>DataSetObservable::notifyChanged() </para></para>        
				/// </summary>
				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>ListAdapter::areAllItemsEnabled() </para></para>        
				/// </summary>
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a group is collapsed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupCollapsed(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a group is expanded.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGroupExpanded
				/// </java-name>
				[Dot42.DexImport("onGroupExpanded", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupExpanded(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Override this method if you foresee a clash in IDs based on this scheme: </para> <para>Base implementation returns a long:  bit 0: Whether this ID points to a child (unset) or group (set), so for this method this bit will be 1.  bit 1-31: Lower 31 bits of the groupId  bit 32-63: Lower 32 bits of the childId. </para> <para> <para>Gets an ID for a child that is unique across any item (either group or child) that is in this list. Expandable lists require each item (group or child) to have a unique ID among all children and groups in the list. This method is responsible for returning that unique ID given a child's ID and its group's ID. Furthermore, if hasStableIds() is true, the returned ID must be stable as well.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The unique (and possibly stable) ID of the child across all groups and children in this list.</para>
				/// </returns>
				/// <java-name>
				/// getCombinedChildId
				/// </java-name>
				[Dot42.DexImport("getCombinedChildId", "(JJ)J", AccessFlags = 1)]
				public virtual long GetCombinedChildId(long groupId, long childId) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Override this method if you foresee a clash in IDs based on this scheme: </para> <para>Base implementation returns a long:  bit 0: Whether this ID points to a child (unset) or group (set), so for this method this bit will be 0.  bit 1-31: Lower 31 bits of the groupId  bit 32-63: Lower 32 bits of the childId. </para> <para> <para>Gets an ID for a group that is unique across any item (either group or child) that is in this list. Expandable lists require each item (group or child) to have a unique ID among all children and groups in the list. This method is responsible for returning that unique ID given a group's ID. Furthermore, if hasStableIds() is true, the returned ID must be stable as well.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The unique (and possibly stable) ID of the group across all groups and children in this list.</para>
				/// </returns>
				/// <java-name>
				/// getCombinedGroupId
				/// </java-name>
				[Dot42.DexImport("getCombinedGroupId", "(J)J", AccessFlags = 1)]
				public virtual long GetCombinedGroupId(long groupId) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para> <para>Get the type of child View that will be created by android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) for the specified child item.</para> <para> <para>android.widget.Adapter::IGNORE_ITEM_VIEW_TYPE </para> <para>getChildTypeCount()</para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of child View. Two child views should share the same type if one can be converted to the other in android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) Note: Integers must be in the range 0 to getChildTypeCount - 1. android.widget.Adapter#IGNORE_ITEM_VIEW_TYPE can also be returned. </para> <para>0 for any group or child position, since only one child type count is declared. </para>
				/// </returns>
				/// <java-name>
				/// getChildType
				/// </java-name>
				[Dot42.DexImport("getChildType", "(II)I", AccessFlags = 1)]
				public virtual int GetChildType(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para> <para>Get the type of group View that will be created by android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . for the specified group item.</para> <para> <para>android.widget.Adapter::IGNORE_ITEM_VIEW_TYPE </para> <para>getGroupTypeCount()</para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of group View. Two group views should share the same type if one can be converted to the other in android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . Note: Integers must be in the range 0 to getGroupTypeCount - 1. android.widget.Adapter#IGNORE_ITEM_VIEW_TYPE can also be returned. </para> <para>0 for any groupPosition, since only one group type count is declared. </para>
				/// </returns>
				/// <java-name>
				/// getGroupType
				/// </java-name>
				[Dot42.DexImport("getGroupType", "(I)I", AccessFlags = 1)]
				public virtual int GetGroupType(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildrenCount", "(I)I", AccessFlags = 1025)]
				public virtual int GetChildrenCount(int groupPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetGroup(int groupPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChild", "(II)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetChild(int groupPosition, int childPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupId", "(I)J", AccessFlags = 1025)]
				public virtual long GetGroupId(int groupPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildId", "(II)J", AccessFlags = 1025)]
				public virtual long GetChildId(int groupPosition, int childPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetGroupView(int groupPosition, bool isExpanded, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetChildView(int groupPosition, int childPosition, bool isLastChild, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "isChildSelectable", "(II)Z", AccessFlags = 1025)]
				public virtual bool IsChildSelectable(int groupPosition, int childPosition) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para> <para>ListAdapter::isEmpty()</para></para> </para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para> <para>Returns the number of types of child Views that will be created by android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) . Each type represents a set of views that can be converted in android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) , for any group. If the adapter always returns the same type of View for all child items, this method should return 1. </para> <para>This method will only be called when the adapter is set on the AdapterView.</para> <para> <para>getGroupTypeCount() </para> <para>getChildType(int, int)</para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The total number of types of child Views that will be created by this adapter. </para> <para>1 as a default value in BaseExpandableListAdapter. </para>
				/// </returns>
				/// <java-name>
				/// getChildTypeCount
				/// </java-name>
				public virtual int ChildTypeCount
				{
						[Dot42.DexImport("getChildTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <para>Returns the number of types of group Views that will be created by android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . Each type represents a set of views that can be converted in android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . If the adapter always returns the same type of View for all group items, this method should return 1. </para> <para>This method will only be called when the adapter is set on the AdapterView.</para> <para> <para>getChildTypeCount() </para> <para>getGroupType(int)</para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of types of group Views that will be created by this adapter. </para> <para>1 as a default value in BaseExpandableListAdapter. </para>
				/// </returns>
				/// <java-name>
				/// getGroupTypeCount
				/// </java-name>
				public virtual int GroupTypeCount
				{
						[Dot42.DexImport("getGroupTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				public virtual int GroupCount
				{
						[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public virtual bool HasStableIds
				{
						[Dot42.DexImport("android/widget/ExpandableListAdapter", "hasStableIds", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Represents a push-button widget. Push-buttons can be pressed, or clicked, by the user to perform an action.</para> <para>A typical use of a push-button in an activity would be the following: </para> <para> <pre>
		/// public class MyActivity extends Activity {
		///     protected void onCreate(Bundle icicle) {
		///         super.onCreate(icicle);</pre></para> <para> <pre>        setContentView(R.layout.content_layout_id);</pre></para> <para> <pre>        final Button button = (Button) findViewById(R.id.button_id);
		///         button.setOnClickListener(new View.OnClickListener() {
		///             public void onClick(View v) {
		///                 // Perform action on click
		///             }
		///         });
		///     }
		/// }</pre></para> <para>However, instead of applying an OnClickListener to the button in your activity, you can assign a method to your button in the XML layout, using the android:onClick attribute. For example:</para> <para> <pre>
		/// &lt;Button
		///     android:layout_height="wrap_content"
		///     android:layout_width="wrap_content"
		///     android:text="@string/self_destruct"
		///     android:onClick="selfDestruct" /&gt;</pre></para> <para>Now, when a user clicks the button, the Android system calls the activity's <c>selfDestruct(View) </c> method. In order for this to work, the method must be public and accept a android.view.View as its only parameter. For example:</para> <para> <pre>
		/// public void selfDestruct(View view) {
		///     // Kabloey
		/// }</pre></para> <para>The android.view.View passed into the method is a reference to the widget that was clicked.</para> <para> <h3>Button style</h3></para> <para>Every Button is styled using the system's default button background, which is often different from one device to another and from one version of the platform to another. If you're not satisfied with the default button style and want to customize it to match the design of your application, then you can replace the button's background image with a . A state list drawable is a drawable resource defined in XML that changes its image based on the current state of the button. Once you've defined a state list drawable in XML, you can apply it to your Button with the android:background attribute. For more information and an example, see .</para> <para>See the  guide.</para> <para> <b>XML attributes</b></para> <para>See Button Attributes, TextView Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Button
		/// </java-name>
		[Dot42.DexImport("android/widget/Button", AccessFlags = 33)]
		public partial class Button : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Button() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A checkbox is a specific type of two-states button that can be either checked or unchecked. A example usage of a checkbox inside your activity would be the following: </para> <para> <pre>
		/// public class MyActivity extends Activity {
		///     protected void onCreate(Bundle icicle) {
		///         super.onCreate(icicle);</pre></para> <para> <pre>        setContentView(R.layout.content_layout_id);</pre></para> <para> <pre>        final CheckBox checkBox = (CheckBox) findViewById(R.id.checkbox_id);
		///         if (checkBox.isChecked()) {
		///             checkBox.setChecked(false);
		///         }
		///     }
		/// }
		/// </pre></para> <para>See the  guide.</para> <para> <b>XML attributes</b></para> <para>See CompoundButton Attributes, Button Attributes, TextView Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/CheckBox
		/// </java-name>
		[Dot42.DexImport("android/widget/CheckBox", AccessFlags = 33)]
		public partial class CheckBox : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CheckBox() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>An extension to TextView that supports the android.widget.Checkable interface. This is useful when used in a ListView where the it's setChoiceMode has been set to something other than CHOICE_MODE_NONE.</para> <para>ref android.R.styleable::CheckedTextView_checked  ref android.R.styleable::CheckedTextView_checkMark </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/CheckedTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/CheckedTextView", AccessFlags = 33)]
		public partial class CheckedTextView : global::Android.Widget.TextView, global::Android.Widget.ICheckable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the checked state of the view to the inverse of its current state </para>        
				/// </summary>
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the checkmark to a given Drawable, identified by its resourece id. This will be drawn when isChecked() is true.</para> <para> <para>setCheckMarkDrawable(Drawable) </para> <para>getCheckMarkDrawable()</para>ref android.R.styleable::CheckedTextView_checkMark </para>        
				/// </summary>
				/// <java-name>
				/// setCheckMarkDrawable
				/// </java-name>
				[Dot42.DexImport("setCheckMarkDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetCheckMarkDrawable(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the checkmark to a given Drawable, identified by its resourece id. This will be drawn when isChecked() is true.</para> <para> <para>setCheckMarkDrawable(Drawable) </para> <para>getCheckMarkDrawable()</para>ref android.R.styleable::CheckedTextView_checkMark </para>        
				/// </summary>
				/// <java-name>
				/// setCheckMarkDrawable
				/// </java-name>
				[Dot42.DexImport("setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCheckMarkDrawable(global::Android.Graphics.Drawables.Drawable resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public override void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CheckedTextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current checked state of the view </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				public virtual bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Class that implements a simple timer. </para> <para>You can give it a start time in the SystemClock#elapsedRealtime timebase, and it counts up from that, or if you don't give it a base time, it will use the time at which you call start. By default it will display the current timer value in the form "MM:SS" or "H:MM:SS", or you can use setFormat to format the timer value into an arbitrary string.</para> <para>ref android.R.styleable::Chronometer_format </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Chronometer
		/// </java-name>
		[Dot42.DexImport("android/widget/Chronometer", AccessFlags = 33)]
		public partial class Chronometer : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Initialize this Chronometer object. Sets the base to the current time. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize with standard view layout information. Sets the base to the current time. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize with standard view layout information and style. Sets the base to the current time. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start counting up. This does not affect the base as set from setBase, just the view display.</para> <para>Chronometer works by regularly scheduling messages to the handler, even when the Widget is not visible. To make sure resource leaks do not occur, the user should make sure that each start() call has a reciprocal call to stop. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop counting up. This does not affect the base as set from setBase, just the view display.</para> <para>This stops the messages to the handler, effectively releasing resources that would be held as the chronometer is running, via start. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Chronometer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the base time as set through setBase. </para>        
				/// </summary>
				/// <java-name>
				/// getBase
				/// </java-name>
				public virtual long Base
				{
						[Dot42.DexImport("getBase", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setBase", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current format string as set through setFormat. </para>        
				/// </summary>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public virtual string Format
				{
						[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setFormat", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The listener (may be null) that is listening for chronometer change events. </para>
				/// </returns>
				/// <java-name>
				/// getOnChronometerTickListener
				/// </java-name>
				public virtual global::Android.Widget.Chronometer.IOnChronometerTickListener OnChronometerTickListener
				{
						[Dot42.DexImport("getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Chronometer.IOnChronometerTickListener); }
						[Dot42.DexImport("setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>A callback that notifies when the chronometer has incremented on its own. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/Chronometer$OnChronometerTickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/Chronometer$OnChronometerTickListener", AccessFlags = 1545)]
				public partial interface IOnChronometerTickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notification that the chronometer has changed. </para>        
						/// </summary>
						/// <java-name>
						/// onChronometerTick
						/// </java-name>
						[Dot42.DexImport("onChronometerTick", "(Landroid/widget/Chronometer;)V", AccessFlags = 1025)]
						void OnChronometerTick(global::Android.Widget.Chronometer chronometer) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A button with two states, checked and unchecked. When the button is pressed or clicked, the state changes automatically. </para> <para> <b>XML attributes</b></para> <para>See CompoundButton Attributes, Button Attributes, TextView Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/CompoundButton
		/// </java-name>
		[Dot42.DexImport("android/widget/CompoundButton", AccessFlags = 1057)]
		public abstract partial class CompoundButton : global::Android.Widget.Button, global::Android.Widget.ICheckable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the checked state of the view to the inverse of its current state </para>        
				/// </summary>
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public override bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the checked state of this button changes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnCheckedChangeListener(global::Android.Widget.CompoundButton.IOnCheckedChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the background to a given Drawable, identified by its resource id.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setButtonDrawable
				/// </java-name>
				[Dot42.DexImport("setButtonDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetButtonDrawable(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the background to a given Drawable, identified by its resource id.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setButtonDrawable
				/// </java-name>
				[Dot42.DexImport("setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetButtonDrawable(global::Android.Graphics.Drawables.Drawable resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CompoundButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current checked state of the view </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				public virtual bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the checked state of a compound button changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/CompoundButton$OnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/CompoundButton$OnCheckedChangeListener", AccessFlags = 1545)]
				public partial interface IOnCheckedChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the checked state of a compound button has changed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCheckedChanged
						/// </java-name>
						[Dot42.DexImport("onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", AccessFlags = 1025)]
						void OnCheckedChanged(global::Android.Widget.CompoundButton buttonView, bool isChecked) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Adapter that exposes data from a Cursor to a ListView widget. </para> <para>The Cursor must include a column named "_id" or this class will not work. Additionally, using android.database.MergeCursor with this class will not work if the merged Cursors have overlapping values in their "_id" columns. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/CursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/CursorAdapter", AccessFlags = 1057)]
		public abstract partial class CursorAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor that always enables auto-requery.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This option is discouraged, as it results in Cursor queries being performed on the application's UI thread and thus can cause poor responsiveness or even Application Not Responding errors. As an alternative, use android.app.LoaderManager with a android.content.CursorLoader.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CursorAdapter(global::Android.Content.Context context, global::Android.Database.ICursor c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Recommended constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1)]
				public CursorAdapter(global::Android.Content.Context context, global::Android.Database.ICursor c, bool flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Android.Content.Context context, global::Android.Database.ICursor c, bool flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>android.widget.ListAdapter::getItem(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetItem(int position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para> <para>android.widget.ListAdapter::getItemId(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int position) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para> <para>android.widget.ListAdapter::getView(int, View, ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Get a android.view.View that displays in the drop down popup the data at the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Makes a new view to hold the data pointed to by cursor. </para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created view. </para>
				/// </returns>
				/// <java-name>
				/// newView
				/// </java-name>
				[Dot42.DexImport("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1025)]
				public abstract global::Android.Views.View NewView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Makes a new drop down view to hold the data pointed to by cursor. </para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created view. </para>
				/// </returns>
				/// <java-name>
				/// newDropDownView
				/// </java-name>
				[Dot42.DexImport("newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewDropDownView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Bind an existing view to the data pointed to by cursor </para>        
				/// </summary>
				/// <java-name>
				/// bindView
				/// </java-name>
				[Dot42.DexImport("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1025)]
				public abstract void BindView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the underlying cursor to a new cursor. If there is an existing cursor it will be closed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeCursor
				/// </java-name>
				[Dot42.DexImport("changeCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void ChangeCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts the cursor into a CharSequence. Subclasses should override this method to convert their results. The default implementation returns an empty String for null values or the default String representation of the value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a CharSequence representing the value </para>
				/// </returns>
				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Runs a query with the specified constraint. This query is requested by the filter attached to this adapter.</para> <para>The query is provided by a android.widget.FilterQueryProvider. If no provider is specified, the current cursor is not filtered and returned.</para> <para>After this method returns the resulting cursor is passed to changeCursor(Cursor) and the previous cursor is closed.</para> <para>This method is always executed on a background thread, not on the application's main thread (or UI thread.)</para> <para>Contract: when constraint is null or empty, the original results, prior to any filtering, must be returned.</para> <para> <para>getFilter() </para> <para>getFilterQueryProvider() </para> <para>setFilterQueryProvider(android.widget.FilterQueryProvider) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Cursor representing the results of the new query</para>
				/// </returns>
				/// <java-name>
				/// runQueryOnBackgroundThread
				/// </java-name>
				[Dot42.DexImport("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RunQueryOnBackgroundThread(global::Java.Lang.ICharSequence constraint) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Called when the ContentObserver on the cursor receives a change notification. The default implementation provides the auto-requery logic, but may be overridden by sub classes.</para> <para> <para>ContentObserver::onChange(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 4)]
				protected internal virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the cursor. </para>        
				/// </summary>
				/// <returns>
				///  <para>the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor Cursor
				{
						[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

				/// <summary>
				///  <para> <para>android.widget.ListAdapter::getCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether the item ids are stable across changes to the underlying data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the same id always refers to the same object. </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <summary>
				///  <para>Returns the query filter provider used for filtering. When the provider is null, no filtering occurs.</para> <para> <para>setFilterQueryProvider(android.widget.FilterQueryProvider) </para> <para>runQueryOnBackgroundThread(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current filter query provider or null if it does not exist</para>
				/// </returns>
				/// <java-name>
				/// getFilterQueryProvider
				/// </java-name>
				public virtual global::Android.Widget.IFilterQueryProvider FilterQueryProvider
				{
						[Dot42.DexImport("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IFilterQueryProvider); }
						[Dot42.DexImport("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>An adapter that exposes data from a series of Cursors to an ExpandableListView widget. The top-level Cursor (that is given in the constructor) exposes the groups, while subsequent Cursors returned from getChildrenCursor(Cursor) expose children within a particular group. The Cursors must include a column named "_id" or this class will not work. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/CursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/CursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class CursorTreeAdapter : global::Android.Widget.BaseExpandableListAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor. The adapter will call Cursor#requery() on the cursor whenever it changes so that the most recent data is always displayed.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V", AccessFlags = 1)]
				public CursorTreeAdapter(global::Android.Database.ICursor cursor, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V", AccessFlags = 1)]
				public CursorTreeAdapter(global::Android.Database.ICursor cursor, global::Android.Content.Context context, bool autoRequery) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the Cursor for the children at the given group. Subclasses must implement this method to return the children data for a particular group. </para> <para>If you want to asynchronously query a provider to prevent blocking the UI, it is possible to return null and at a later time call setChildrenCursor(int, Cursor). </para> <para>It is your responsibility to manage this Cursor through the Activity lifecycle. It is a good idea to use Activity#managedQuery which will handle this for you. In some situations, the adapter will deactivate the Cursor on its own, but this will not always be the case, so please ensure the Cursor is properly managed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The cursor for the children of a particular group, or null. </para>
				/// </returns>
				/// <java-name>
				/// getChildrenCursor
				/// </java-name>
				[Dot42.DexImport("getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", AccessFlags = 1028)]
				protected internal abstract global::Android.Database.ICursor GetChildrenCursor(global::Android.Database.ICursor groupCursor) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the group Cursor.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupCursor
				/// </java-name>
				[Dot42.DexImport("setGroupCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetGroupCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the children Cursor for a particular group. If there is an existing cursor it will be closed. </para> <para>This is useful when asynchronously querying to prevent blocking the UI.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChildrenCursor
				/// </java-name>
				[Dot42.DexImport("setChildrenCursor", "(ILandroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetChildrenCursor(int groupPosition, global::Android.Database.ICursor childrenCursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the data associated with the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data of the child </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Landroid/database/Cursor;", AccessFlags = 1)]
				public new virtual global::Android.Database.ICursor GetChild(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Gets the ID for the given child within the given group. This ID must be unique across all children within the group. The combined ID (see getCombinedChildId(long, long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the child </para>
				/// </returns>
				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1)]
				public override long GetChildId(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Gets the number of children in a specified group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the children count in the specified group </para>
				/// </returns>
				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1)]
				public override int GetChildrenCount(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the data associated with the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data child for the specified group </para>
				/// </returns>
				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Landroid/database/Cursor;", AccessFlags = 1)]
				public new virtual global::Android.Database.ICursor GetGroup(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para>Gets the ID for the group at the given position. This group ID must be unique across groups. The combined ID (see getCombinedGroupId(long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the group </para>
				/// </returns>
				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1)]
				public override long GetGroupId(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Gets a View that displays the given group. This View is only for the groupthe Views for the group's children will be fetched using getChildView(int, int, boolean, View, ViewGroup).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the group at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetGroupView(int groupPosition, bool isExpanded, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Makes a new group view to hold the group data pointed to by cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly created view. </para>
				/// </returns>
				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1028)]
				protected internal abstract global::Android.Views.View NewGroupView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isExpanded, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Bind an existing view to the group data pointed to by cursor.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindGroupView
				/// </java-name>
				[Dot42.DexImport("bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1028)]
				protected internal abstract void BindGroupView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isExpanded) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a View that displays the data for the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the child at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetChildView(int groupPosition, int childPosition, bool isLastChild, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Makes a new child view to hold the data pointed to by cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the newly created view. </para>
				/// </returns>
				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1028)]
				protected internal abstract global::Android.Views.View NewChildView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isLastChild, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Bind an existing view to the child data pointed to by cursor</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bindChildView
				/// </java-name>
				[Dot42.DexImport("bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1028)]
				protected internal abstract void BindChildView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isLastChild) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Whether the child at the specified position is selectable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the child is selectable. </para>
				/// </returns>
				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1)]
				public override bool IsChildSelectable(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public override void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies a data set change, but with the option of not releasing any cached cursors.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged(bool releaseCursors) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public override void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a group is collapsed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1)]
				public override void OnGroupCollapsed(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>CursorAdapter::convertToString(Cursor) </para></para>        
				/// </summary>
				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para> <para>CursorAdapter::runQueryOnBackgroundThread(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// runQueryOnBackgroundThread
				/// </java-name>
				[Dot42.DexImport("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RunQueryOnBackgroundThread(global::Java.Lang.ICharSequence constraint) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				///  <para> <para>CursorAdapter::changeCursor(Cursor) </para></para>        
				/// </summary>
				/// <java-name>
				/// changeCursor
				/// </java-name>
				[Dot42.DexImport("changeCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void ChangeCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the number of groups.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of groups </para>
				/// </returns>
				/// <java-name>
				/// getGroupCount
				/// </java-name>
				public override int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether the child and group IDs are stable across changes to the underlying data.</para> <para> <para>Adapter::hasStableIds() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether or not the same ID always refers to the same object </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <summary>
				///  <para> <para>CursorAdapter::getFilterQueryProvider() </para></para>        
				/// </summary>
				/// <java-name>
				/// getFilterQueryProvider
				/// </java-name>
				public virtual global::Android.Widget.IFilterQueryProvider FilterQueryProvider
				{
						[Dot42.DexImport("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IFilterQueryProvider); }
						[Dot42.DexImport("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <para>CursorAdapter::getCursor() </para></para>        
				/// </summary>
				/// <java-name>
				/// getCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor Cursor
				{
						[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

		}

		/// <summary>
		///  <para>This class is a widget for selecting a date. The date can be selected by a year, month, and day spinners or a CalendarView. The set of spinners and the calendar view are automatically synchronized. The client can customize whether only the spinners, or only the calendar view, or both to be displayed. Also the minimal and maximal date from which dates to be selected can be customized. </para> <para>See the  guide. </para> <para>For a dialog using this view, see android.app.DatePickerDialog. </para> <para>ref android.R.styleable::DatePicker_startYear  ref android.R.styleable::DatePicker_endYear  ref android.R.styleable::DatePicker_maxDate  ref android.R.styleable::DatePicker_minDate  ref android.R.styleable::DatePicker_spinnersShown  ref android.R.styleable::DatePicker_calendarViewShown </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/DatePicker
		/// </java-name>
		[Dot42.DexImport("android/widget/DatePicker", AccessFlags = 33)]
		public partial class DatePicker : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the current date.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(III)V", AccessFlags = 1)]
				public virtual void UpdateDate(int year, int month, int dayOfMonth) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the state. If the provided values designate an inconsistent date the values are normalized before updating the spinners.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V", AccessFlags = 1)]
				public virtual void Init(int year, int monthOfYear, int dayOfMonth, global::Android.Widget.DatePicker.IOnDateChangedListener onDateChangedListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DatePicker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The selected year. </para>
				/// </returns>
				/// <java-name>
				/// getYear
				/// </java-name>
				public virtual int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The selected month. </para>
				/// </returns>
				/// <java-name>
				/// getMonth
				/// </java-name>
				public virtual int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The selected day of month. </para>
				/// </returns>
				/// <java-name>
				/// getDayOfMonth
				/// </java-name>
				public virtual int DayOfMonth
				{
						[Dot42.DexImport("getDayOfMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The callback used to indicate the user changes the date. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/DatePicker$OnDateChangedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/DatePicker$OnDateChangedListener", AccessFlags = 1545)]
				public partial interface IOnDateChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called upon a date change.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDateChanged
						/// </java-name>
						[Dot42.DexImport("onDateChanged", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1025)]
						void OnDateChanged(global::Android.Widget.DatePicker view, int year, int monthOfYear, int dayOfMonth) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/DialerFilter
		/// </java-name>
		[Dot42.DexImport("android/widget/DialerFilter", AccessFlags = 33)]
		public partial class DialerFilter : global::Android.Widget.RelativeLayout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This mode has both lines </para>        
				/// </summary>
				/// <java-name>
				/// DIGITS_AND_LETTERS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS = 1;
				/// <summary>
				///  <para>This mode is when after starting in DIGITS_AND_LETTERS mode the filter has removed all possibility of the digits matching, leaving only the letters line </para>        
				/// </summary>
				/// <java-name>
				/// DIGITS_AND_LETTERS_NO_DIGITS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS_NO_DIGITS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS_NO_DIGITS = 2;
				/// <summary>
				///  <para>This mode is when after starting in DIGITS_AND_LETTERS mode the filter has removed all possibility of the letters matching, leaving only the digits line </para>        
				/// </summary>
				/// <java-name>
				/// DIGITS_AND_LETTERS_NO_LETTERS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS_NO_LETTERS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS_NO_LETTERS = 3;
				/// <summary>
				///  <para>This mode has only the digits line </para>        
				/// </summary>
				/// <java-name>
				/// DIGITS_ONLY
				/// </java-name>
				[Dot42.DexImport("DIGITS_ONLY", "I", AccessFlags = 25)]
				public const int DIGITS_ONLY = 4;
				/// <summary>
				///  <para>This mode has only the letters line </para>        
				/// </summary>
				/// <java-name>
				/// LETTERS_ONLY
				/// </java-name>
				[Dot42.DexImport("LETTERS_ONLY", "I", AccessFlags = 25)]
				public const int LETTERS_ONLY = 5;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DialerFilter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DialerFilter(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Only show the icon view when focused, if there is one. </para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key up event has occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Append(string text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears both the digits and the filter text. </para>        
				/// </summary>
				/// <java-name>
				/// clearText
				/// </java-name>
				[Dot42.DexImport("clearText", "()V", AccessFlags = 1)]
				public virtual void ClearText() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLettersWatcher
				/// </java-name>
				[Dot42.DexImport("setLettersWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetLettersWatcher(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDigitsWatcher
				/// </java-name>
				[Dot42.DexImport("setDigitsWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetDigitsWatcher(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterWatcher
				/// </java-name>
				[Dot42.DexImport("setFilterWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetFilterWatcher(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeFilterWatcher
				/// </java-name>
				[Dot42.DexImport("removeFilterWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void RemoveFilterWatcher(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called right after the mode changes to give subclasses the option to restyle, etc. </para>        
				/// </summary>
				/// <java-name>
				/// onModeChange
				/// </java-name>
				[Dot42.DexImport("onModeChange", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnModeChange(int oldMode, int newMode) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DialerFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isQwertyKeyboard
				/// </java-name>
				public virtual bool IsQwertyKeyboard
				{
						[Dot42.DexImport("isQwertyKeyboard", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				public virtual int Mode
				{
						[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLetters
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Letters
				{
						[Dot42.DexImport("getLetters", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getDigits
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Digits
				{
						[Dot42.DexImport("getDigits", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getFilterText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence FilterText
				{
						[Dot42.DexImport("getFilterText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

		}

		/// <summary>
		///  <para>Like AnalogClock, but digital. Shows seconds.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>It is recommended you use TextClock instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/DigitalClock
		/// </java-name>
		[Dot42.DexImport("android/widget/DigitalClock", AccessFlags = 33)]
		public partial class DigitalClock : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DigitalClock(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DigitalClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal DigitalClock() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>EditText is a thin veneer over TextView that configures itself to be editable.</para> <para>See the  guide.</para> <para> <b>XML attributes</b> </para> <para>See EditText Attributes, TextView Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/EditText
		/// </java-name>
		[Dot42.DexImport("android/widget/EditText", AccessFlags = 33)]
		public partial class EditText : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Landroid/text/Editable;", AccessFlags = 1)]
				public new virtual global::Android.Text.IEditable GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 1)]
				public override void SetText(global::Java.Lang.ICharSequence text, global::Android.Widget.TextView.BufferType type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for Selection#setSelection(Spannable, int, int). </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)V", AccessFlags = 1)]
				public virtual void SetSelection(int start, int stop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for Selection#setSelection(Spannable, int). </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for Selection#selectAll. </para>        
				/// </summary>
				/// <java-name>
				/// selectAll
				/// </java-name>
				[Dot42.DexImport("selectAll", "()V", AccessFlags = 1)]
				public virtual void SelectAll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience for Selection#extendSelection. </para>        
				/// </summary>
				/// <java-name>
				/// extendSelection
				/// </java-name>
				[Dot42.DexImport("extendSelection", "(I)V", AccessFlags = 1)]
				public virtual void ExtendSelection(int index) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal EditText() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultEditable
				/// </java-name>
				protected internal override bool DefaultEditable
				{
						[Dot42.DexImport("getDefaultEditable", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDefaultMovementMethod
				/// </java-name>
				protected internal override global::Android.Text.Method.IMovementMethod DefaultMovementMethod
				{
						[Dot42.DexImport("getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 4)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
				}

				/// <java-name>
				/// setEllipsize
				/// </java-name>
				public override global::Android.Text.TextUtils.TruncateAt Ellipsize
				{
						[Dot42.DexImport("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A view that shows items in a vertically scrolling two-level list. This differs from the ListView by allowing two levels: groups which can individually be expanded to show its children. The items come from the ExpandableListAdapter associated with this view. </para> <para>Expandable lists are able to show an indicator beside each item to display the item's current state (the states are usually one of expanded group, collapsed group, child, or last child). Use setChildIndicator(Drawable) or setGroupIndicator(Drawable) (or the corresponding XML attributes) to set these indicators (see the docs for each method to see additional state that each Drawable can have). The default style for an ExpandableListView provides indicators which will be shown next to Views given to the ExpandableListView. The layouts android.R.layout.simple_expandable_list_item_1 and android.R.layout.simple_expandable_list_item_2 (which should be used with SimpleCursorTreeAdapter) contain the preferred position information for indicators. </para> <para>The context menu information set by an ExpandableListView will be a ExpandableListContextMenuInfo object with ExpandableListContextMenuInfo#packedPosition being a packed position that can be used with getPackedPositionType(long) and the other similar methods. </para> <para> <b> <b>Note:</b></b> You cannot use the value  <code>wrap_content</code> for the  <code>android:layout_height</code> attribute of a ExpandableListView in XML if the parent's size is also not strictly specified (for example, if the parent were ScrollView you could not specify wrap_content since it also can be any length. However, you can use wrap_content if the ExpandableListView parent has a specific size, such as 100 pixels.</para> <para>ref android.R.styleable::ExpandableListView_groupIndicator  ref android.R.styleable::ExpandableListView_indicatorLeft  ref android.R.styleable::ExpandableListView_indicatorRight  ref android.R.styleable::ExpandableListView_childIndicator  ref android.R.styleable::ExpandableListView_childIndicatorLeft  ref android.R.styleable::ExpandableListView_childIndicatorRight  ref android.R.styleable::ExpandableListView_childDivider  ref android.R.styleable::ExpandableListView_indicatorStart  ref android.R.styleable::ExpandableListView_indicatorEnd  ref android.R.styleable::ExpandableListView_childIndicatorStart  ref android.R.styleable::ExpandableListView_childIndicatorEnd </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ExpandableListView
		/// </java-name>
		[Dot42.DexImport("android/widget/ExpandableListView", AccessFlags = 33)]
		public partial class ExpandableListView : global::Android.Widget.ListView
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The packed position represents a group. </para>        
				/// </summary>
				/// <java-name>
				/// PACKED_POSITION_TYPE_GROUP
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_GROUP", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_GROUP = 0;
				/// <summary>
				///  <para>The packed position represents a child. </para>        
				/// </summary>
				/// <java-name>
				/// PACKED_POSITION_TYPE_CHILD
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_CHILD", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_CHILD = 1;
				/// <summary>
				///  <para>The packed position represents a neither/null/no preference. </para>        
				/// </summary>
				/// <java-name>
				/// PACKED_POSITION_TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_NULL", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_NULL = 2;
				/// <summary>
				///  <para>The value for a packed position that represents neither/null/no preference. This value is not otherwise possible since a group type (first bit 0) should not have a child position filled. </para>        
				/// </summary>
				/// <java-name>
				/// PACKED_POSITION_VALUE_NULL
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_VALUE_NULL", "J", AccessFlags = 25)]
				public const long PACKED_POSITION_VALUE_NULL = 4294967295;
				/// <summary>
				///  <para>Denotes when a child indicator should inherit this bound from the generic indicator bounds </para>        
				/// </summary>
				/// <java-name>
				/// CHILD_INDICATOR_INHERIT
				/// </java-name>
				[Dot42.DexImport("CHILD_INDICATOR_INHERIT", "I", AccessFlags = 25)]
				public const int CHILD_INDICATOR_INHERIT = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable that will be drawn adjacent to every child in the list. This will be drawn using the same height as the normal divider (setDivider(Drawable)) or if it does not have an intrinsic height, the height set by setDividerHeight(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChildDivider
				/// </java-name>
				[Dot42.DexImport("setChildDivider", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetChildDivider(global::Android.Graphics.Drawables.Drawable childDivider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This overloaded method should not be used, instead use setAdapter(ExpandableListAdapter). </para>        
				/// </summary>
				/// <java-name>
				/// setAdapter
				/// </java-name>
				[Dot42.DexImport("setAdapter", "(Landroid/widget/ExpandableListAdapter;)V", AccessFlags = 1)]
				public virtual void SetAdapter(global::Android.Widget.IExpandableListAdapter adapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public override bool PerformItemClick(global::Android.Views.View v, int position, long id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Expand a group in the grouped list view</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the group was expanded, false otherwise (if the group was already expanded, this will return false) </para>
				/// </returns>
				/// <java-name>
				/// expandGroup
				/// </java-name>
				[Dot42.DexImport("expandGroup", "(I)Z", AccessFlags = 1)]
				public virtual bool ExpandGroup(int groupPos) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Collapse a group in the grouped list view</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the group was collapsed, false otherwise (if the group was already collapsed, this will return false) </para>
				/// </returns>
				/// <java-name>
				/// collapseGroup
				/// </java-name>
				[Dot42.DexImport("collapseGroup", "(I)Z", AccessFlags = 1)]
				public virtual bool CollapseGroup(int groupPos) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOnGroupCollapseListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupCollapseListener(global::Android.Widget.ExpandableListView.IOnGroupCollapseListener onGroupCollapseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnGroupExpandListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupExpandListener(global::Android.Widget.ExpandableListView.IOnGroupExpandListener onGroupExpandListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnGroupClickListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupClickListener(global::Android.Widget.ExpandableListView.IOnGroupClickListener onGroupClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnChildClickListener
				/// </java-name>
				[Dot42.DexImport("setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnChildClickListener(global::Android.Widget.ExpandableListView.IOnChildClickListener onChildClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Converts a flat list position (the raw position of an item (child or group) in the list) to a group and/or child position (represented in a packed position). This is useful in situations where the caller needs to use the underlying ListView's methods. Use ExpandableListView#getPackedPositionType , ExpandableListView#getPackedPositionChild, ExpandableListView#getPackedPositionGroup to unpack.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The group and/or child position for the given flat list position in packed position representation. PACKED_POSITION_VALUE_NULL if the position corresponds to a header or a footer item. </para>
				/// </returns>
				/// <java-name>
				/// getExpandableListPosition
				/// </java-name>
				[Dot42.DexImport("getExpandableListPosition", "(I)J", AccessFlags = 1)]
				public virtual long GetExpandableListPosition(int flatListPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Converts a group and/or child position to a flat list position. This is useful in situations where the caller needs to use the underlying ListView's methods.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The flat list position for the given child or group. </para>
				/// </returns>
				/// <java-name>
				/// getFlatListPosition
				/// </java-name>
				[Dot42.DexImport("getFlatListPosition", "(J)I", AccessFlags = 1)]
				public virtual int GetFlatListPosition(long packedPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the selection to the specified group. </para>        
				/// </summary>
				/// <java-name>
				/// setSelectedGroup
				/// </java-name>
				[Dot42.DexImport("setSelectedGroup", "(I)V", AccessFlags = 1)]
				public virtual void SetSelectedGroup(int groupPosition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the selection to the specified child. If the child is in a collapsed group, the group will only be expanded and child subsequently selected if shouldExpandGroup is set to true, otherwise the method will return false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the selection was successfully set on the child. </para>
				/// </returns>
				/// <java-name>
				/// setSelectedChild
				/// </java-name>
				[Dot42.DexImport("setSelectedChild", "(IIZ)Z", AccessFlags = 1)]
				public virtual bool SetSelectedChild(int groupPosition, int childPosition, bool shouldExpandGroup) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Whether the given group is currently expanded.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the group is currently expanded. </para>
				/// </returns>
				/// <java-name>
				/// isGroupExpanded
				/// </java-name>
				[Dot42.DexImport("isGroupExpanded", "(I)Z", AccessFlags = 1)]
				public virtual bool IsGroupExpanded(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the type of a packed position. See getPackedPositionForChild(int, int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The type of the position contained within the packed position, either PACKED_POSITION_TYPE_CHILD, PACKED_POSITION_TYPE_GROUP, or PACKED_POSITION_TYPE_NULL. </para>
				/// </returns>
				/// <java-name>
				/// getPackedPositionType
				/// </java-name>
				[Dot42.DexImport("getPackedPositionType", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionType(long packedPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the group position from a packed position. See getPackedPositionForChild(int, int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The group position portion of the packed position. If this does not contain a group, returns -1. </para>
				/// </returns>
				/// <java-name>
				/// getPackedPositionGroup
				/// </java-name>
				[Dot42.DexImport("getPackedPositionGroup", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionGroup(long packedPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the child position from a packed position that is of PACKED_POSITION_TYPE_CHILD type (use getPackedPositionType(long)). To get the group that this child belongs to, use getPackedPositionGroup(long). See getPackedPositionForChild(int, int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The child position portion of the packed position. If this does not contain a child, returns -1. </para>
				/// </returns>
				/// <java-name>
				/// getPackedPositionChild
				/// </java-name>
				[Dot42.DexImport("getPackedPositionChild", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionChild(long packedPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the packed position representation of a child's position. </para> <para>In general, a packed position should be used in situations where the position given to/returned from an ExpandableListAdapter or ExpandableListView method can either be a child or group. The two positions are packed into a single long which can be unpacked using getPackedPositionChild(long), getPackedPositionGroup(long), and getPackedPositionType(long).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The packed position representation of the child (and parent group). </para>
				/// </returns>
				/// <java-name>
				/// getPackedPositionForChild
				/// </java-name>
				[Dot42.DexImport("getPackedPositionForChild", "(II)J", AccessFlags = 9)]
				public static long GetPackedPositionForChild(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the packed position representation of a group's position. See getPackedPositionForChild(int, int).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The packed position representation of the group. </para>
				/// </returns>
				/// <java-name>
				/// getPackedPositionForGroup
				/// </java-name>
				[Dot42.DexImport("getPackedPositionForGroup", "(I)J", AccessFlags = 9)]
				public static long GetPackedPositionForGroup(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Sets the indicator to be drawn next to a child.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChildIndicator
				/// </java-name>
				[Dot42.DexImport("setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetChildIndicator(global::Android.Graphics.Drawables.Drawable childIndicator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawing bounds for the child indicator. For either, you can specify CHILD_INDICATOR_INHERIT to use inherit from the general indicator's bounds.</para> <para> <para>setIndicatorBounds(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setChildIndicatorBounds
				/// </java-name>
				[Dot42.DexImport("setChildIndicatorBounds", "(II)V", AccessFlags = 1)]
				public virtual void SetChildIndicatorBounds(int left, int right) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the indicator to be drawn next to a group.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupIndicator
				/// </java-name>
				[Dot42.DexImport("setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetGroupIndicator(global::Android.Graphics.Drawables.Drawable groupIndicator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawing bounds for the indicators (at minimum, the group indicator is affected by this; the child indicator is affected by this if the child indicator bounds are set to inherit).</para> <para> <para>setChildIndicatorBounds(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setIndicatorBounds
				/// </java-name>
				[Dot42.DexImport("setIndicatorBounds", "(II)V", AccessFlags = 1)]
				public virtual void SetIndicatorBounds(int left, int right) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ExpandableListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>This method should not be used, use getExpandableListAdapter(). </para>        
				/// </summary>
				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the adapter that provides data to this view. </para>        
				/// </summary>
				/// <returns>
				///  <para>The adapter that provides data to this view. </para>
				/// </returns>
				/// <java-name>
				/// getExpandableListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IExpandableListAdapter ExpandableListAdapter
				{
						[Dot42.DexImport("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IExpandableListAdapter); }
				}

				/// <summary>
				///  <para>Gets the position of the currently selected group or child (along with its type). Can return PACKED_POSITION_VALUE_NULL if no selection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A packed position containing the currently selected group or child's position and type. PACKED_POSITION_VALUE_NULL if no selection or if selection is on a header or a footer item. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedPosition
				/// </java-name>
				public virtual long SelectedPosition
				{
						[Dot42.DexImport("getSelectedPosition", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Gets the ID of the currently selected group or child. Can return -1 if no selection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ID of the currently selected group or child. -1 if no selection. </para>
				/// </returns>
				/// <java-name>
				/// getSelectedId
				/// </java-name>
				public virtual long SelectedId
				{
						[Dot42.DexImport("getSelectedId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an item has been clicked and the caller prefers to receive a ListView-style position instead of a group and/or child position. In most cases, the caller should use setOnGroupClickListener and/or setOnChildClickListener. </para>        
				/// </summary>
				/// <java-name>
				/// setOnItemClickListener
				/// </java-name>
				public override global::Android.Widget.AdapterView<global::Android.Widget.IListAdapter>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Extra menu information specific to an ExpandableListView provided to the android.view.View.OnCreateContextMenuListener#onCreateContextMenu(ContextMenu, View, ContextMenuInfo) callback when a context menu is brought up for this AdapterView. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ExpandableListView$ExpandableListContextMenuInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$ExpandableListContextMenuInfo", AccessFlags = 9)]
				public partial class ExpandableListContextMenuInfo : global::Android.Views.IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The view for which the context menu is being displayed. This will be one of the children Views of this ExpandableListView. </para>        
						/// </summary>
						/// <java-name>
						/// targetView
						/// </java-name>
						[Dot42.DexImport("targetView", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View TargetView;
						/// <summary>
						///  <para>The packed position in the list represented by the adapter for which the context menu is being displayed. Use the methods ExpandableListView#getPackedPositionType, ExpandableListView#getPackedPositionChild, and ExpandableListView#getPackedPositionGroup to unpack this. </para>        
						/// </summary>
						/// <java-name>
						/// packedPosition
						/// </java-name>
						[Dot42.DexImport("packedPosition", "J", AccessFlags = 1)]
						public long PackedPosition;
						/// <summary>
						///  <para>The ID of the item (group or child) for which the context menu is being displayed. </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						[Dot42.DexImport("<init>", "(Landroid/view/View;JJ)V", AccessFlags = 1)]
						public ExpandableListContextMenuInfo(global::Android.Views.View view, long int64, long int641) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal ExpandableListContextMenuInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a child in this expandable list has been clicked. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ExpandableListView$OnChildClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnChildClickListener", AccessFlags = 1545)]
				public partial interface IOnChildClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when a child in this expandable list has been clicked.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the click was handled </para>
						/// </returns>
						/// <java-name>
						/// onChildClick
						/// </java-name>
						[Dot42.DexImport("onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", AccessFlags = 1025)]
						bool OnChildClick(global::Android.Widget.ExpandableListView parent, global::Android.Views.View v, int groupPosition, int childPosition, long id) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a group in this expandable list has been clicked. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupClickListener", AccessFlags = 1545)]
				public partial interface IOnGroupClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when a group in this expandable list has been clicked.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the click was handled </para>
						/// </returns>
						/// <java-name>
						/// onGroupClick
						/// </java-name>
						[Dot42.DexImport("onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z", AccessFlags = 1025)]
						bool OnGroupClick(global::Android.Widget.ExpandableListView parent, global::Android.Views.View v, int groupPosition, long id) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Used for being notified when a group is expanded </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupExpandListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupExpandListener", AccessFlags = 1545)]
				public partial interface IOnGroupExpandListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when a group in this expandable list has been expanded.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onGroupExpand
						/// </java-name>
						[Dot42.DexImport("onGroupExpand", "(I)V", AccessFlags = 1025)]
						void OnGroupExpand(int groupPosition) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Used for being notified when a group is collapsed </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupCollapseListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupCollapseListener", AccessFlags = 1545)]
				public partial interface IOnGroupCollapseListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when a group in this expandable list has been collapsed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onGroupCollapse
						/// </java-name>
						[Dot42.DexImport("onGroupCollapse", "(I)V", AccessFlags = 1025)]
						void OnGroupCollapse(int groupPosition) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A filter constrains data with a filtering pattern.</para> <para>Filters are usually created by android.widget.Filterable classes.</para> <para>Filtering operations performed by calling filter(CharSequence) or filter(CharSequence, android.widget.Filter.FilterListener) are performed asynchronously. When these methods are called, a filtering request is posted in a request queue and processed later. Any call to one of these methods will cancel any previous non-executed filtering request.</para> <para> <para>android.widget.Filterable </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Filter
		/// </java-name>
		[Dot42.DexImport("android/widget/Filter", AccessFlags = 1057)]
		public abstract partial class Filter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new asynchronous filter.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Filter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts an asynchronous filtering operation. Calling this method cancels all previous non-executed filtering requests and posts a new filtering request that will be executed later.</para> <para> <para>#filter(CharSequence, android.widget.Filter.FilterListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void JavaFilter(global::Java.Lang.ICharSequence constraint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts an asynchronous filtering operation. Calling this method cancels all previous non-executed filtering requests and posts a new filtering request that will be executed later.</para> <para>Upon completion, the listener is notified.</para> <para> <para>#filter(CharSequence) </para> <para>#performFiltering(CharSequence) </para> <para>#publishResults(CharSequence, android.widget.Filter.FilterResults) </para></para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V", AccessFlags = 17)]
				public void JavaFilter(global::Java.Lang.ICharSequence constraint, global::Android.Widget.Filter.IFilterListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoked in a worker thread to filter the data according to the constraint. Subclasses must implement this method to perform the filtering operation. Results computed by the filtering operation must be returned as a android.widget.Filter.FilterResults that will then be published in the UI thread through android.widget.Filter.FilterResults).</para> <para> <b>Contract:</b> When the constraint is null, the original data must be restored.</para> <para> <para>#filter(CharSequence, android.widget.Filter.FilterListener) </para> <para>#publishResults(CharSequence, android.widget.Filter.FilterResults) </para> <para>android.widget.Filter.FilterResults </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the results of the filtering operation</para>
				/// </returns>
				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;", AccessFlags = 1028)]
				protected internal abstract global::Android.Widget.Filter.FilterResults PerformFiltering(global::Java.Lang.ICharSequence constraint) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Invoked in the UI thread to publish the filtering results in the user interface. Subclasses must implement this method to display the results computed in performFiltering.</para> <para> <para>#filter(CharSequence, android.widget.Filter.FilterListener) </para> <para>#performFiltering(CharSequence) </para> <para>android.widget.Filter.FilterResults </para></para>        
				/// </summary>
				/// <java-name>
				/// publishResults
				/// </java-name>
				[Dot42.DexImport("publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V", AccessFlags = 1028)]
				protected internal abstract void PublishResults(global::Java.Lang.ICharSequence constraint, global::Android.Widget.Filter.FilterResults results) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Converts a value from the filtered set into a CharSequence. Subclasses should override this method to convert their results. The default implementation returns an empty String for null values or the default String representation of the value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a CharSequence representing the value </para>
				/// </returns>
				/// <java-name>
				/// convertResultToString
				/// </java-name>
				[Dot42.DexImport("convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence ConvertResultToString(object resultValue) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Listener used to receive a notification upon completion of a filtering operation.</para>    
				/// </summary>
				/// <java-name>
				/// android/widget/Filter$FilterListener
				/// </java-name>
				[Dot42.DexImport("android/widget/Filter$FilterListener", AccessFlags = 1545)]
				public partial interface IFilterListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notifies the end of a filtering operation.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onFilterComplete
						/// </java-name>
						[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1025)]
						void OnFilterComplete(int count) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Holds the results of a filtering operation. The results are the values computed by the filtering operation and the number of these values.</para>    
				/// </summary>
				/// <java-name>
				/// android/widget/Filter$FilterResults
				/// </java-name>
				[Dot42.DexImport("android/widget/Filter$FilterResults", AccessFlags = 12)]
				public partial class FilterResults
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Contains all the values computed by the filtering operation.</para>        
						/// </summary>
						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Values;
						/// <summary>
						///  <para>Contains the number of values computed by the filtering operation.</para>        
						/// </summary>
						/// <java-name>
						/// count
						/// </java-name>
						[Dot42.DexImport("count", "I", AccessFlags = 1)]
						public int Count;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public FilterResults() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>FrameLayout is designed to block out an area on the screen to display a single item. Generally, FrameLayout should be used to hold a single child view, because it can be difficult to organize child views in a way that's scalable to different screen sizes without the children overlapping each other. You can, however, add multiple children to a FrameLayout and control their position within the FrameLayout by assigning gravity to each child, using the  attribute. </para> <para>Child views are drawn in a stack, with the most recently added child on top. The size of the FrameLayout is the size of its largest child (plus padding), visible or not (if the FrameLayout's parent permits). Views that are android.view.View#GONE are used for sizing only if setConsiderGoneChildrenWhenMeasuring() is set to true.</para> <para>ref android.R.styleable::FrameLayout_foreground  ref android.R.styleable::FrameLayout_foregroundGravity  ref android.R.styleable::FrameLayout_measureAllChildren </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/FrameLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/FrameLayout", AccessFlags = 33)]
		public partial class FrameLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describes how the foreground is positioned. Defaults to START and TOP.</para> <para> <para>getForegroundGravity()</para>ref android.R.styleable::FrameLayout_foregroundGravity </para>        
				/// </summary>
				/// <java-name>
				/// setForegroundGravity
				/// </java-name>
				[Dot42.DexImport("setForegroundGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetForegroundGravity(int foregroundGravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#MATCH_PARENT, and a height of android.view.ViewGroup.LayoutParams#MATCH_PARENT. </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.FrameLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gatherTransparentRegion
				/// </java-name>
				[Dot42.DexImport("gatherTransparentRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public override bool GatherTransparentRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets whether to consider all children, or just those in the VISIBLE or INVISIBLE state, when measuring. Defaults to false.</para> <para>ref android.R.styleable::FrameLayout_measureAllChildren </para>        
				/// </summary>
				/// <java-name>
				/// setMeasureAllChildren
				/// </java-name>
				[Dot42.DexImport("setMeasureAllChildren", "(Z)V", AccessFlags = 1)]
				public virtual void SetMeasureAllChildren(bool measureAll) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.FrameLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal FrameLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the drawable used as the foreground of this FrameLayout. The foreground drawable, if non-null, is always drawn on top of the children.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Drawable or null if no foreground was set. </para>
				/// </returns>
				/// <java-name>
				/// getForeground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Foreground
				{
						[Dot42.DexImport("getForeground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setForeground", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Determines whether all children, or just those in the VISIBLE or INVISIBLE state, are considered when measuring.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is deprecated in favor of getMeasureAllChildren(), which was renamed for consistency with setMeasureAllChildren(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether all children are considered when measuring.</para>
				/// </returns>
				/// <java-name>
				/// getConsiderGoneChildrenWhenMeasuring
				/// </java-name>
				public virtual bool ConsiderGoneChildrenWhenMeasuring
				{
						[Dot42.DexImport("getConsiderGoneChildrenWhenMeasuring", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Per-child layout information for layouts that support margins. See FrameLayout Layout Attributes for a list of all child view attributes that this class supports.</para> <para>ref android.R.styleable::FrameLayout_Layout_layout_gravity </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/FrameLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/FrameLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The gravity to apply with the View to which these layout parameters are associated.</para> <para> <para>android.view.Gravity</para>ref android.R.styleable::FrameLayout_Layout_layout_gravity </para>        
						/// </summary>
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
						public int Gravity;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A view that shows items in a center-locked, horizontally scrolling list. </para> <para>The default values for the Gallery assume you will be using android.R.styleable#Theme_galleryItemBackground as the background for each View given to the Gallery from the Adapter. If you are not doing this, you may need to adjust some Gallery properties, such as the spacing. </para> <para>Views given to the Gallery should use Gallery.LayoutParams as their layout parameters type.</para> <para>ref android.R.styleable::Gallery_animationDuration  ref android.R.styleable::Gallery_spacing  ref android.R.styleable::Gallery_gravity</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This widget is no longer supported. Other horizontally scrolling widgets include HorizontalScrollView and android.support.v4.view.ViewPager from the support library. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Gallery
		/// </java-name>
		[Dot42.DexImport("android/widget/Gallery", AccessFlags = 33)]
		public partial class Gallery : global::Android.Widget.AbsSpinner, global::Android.Views.GestureDetector.IOnGestureListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Whether or not to callback on any getOnItemSelectedListener() while the items are being flinged. If false, only the final selected item will cause the callback. If true, all items between the first and the final will cause callbacks.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCallbackDuringFling
				/// </java-name>
				[Dot42.DexImport("setCallbackDuringFling", "(Z)V", AccessFlags = 1)]
				public virtual void SetCallbackDuringFling(bool shouldCallback) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets how long the transition animation should run when a child view changes position. Only relevant if animation is turned on.</para> <para>ref android.R.styleable::Gallery_animationDuration </para>        
				/// </summary>
				/// <java-name>
				/// setAnimationDuration
				/// </java-name>
				[Dot42.DexImport("setAnimationDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetAnimationDuration(int animationDurationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the spacing between items in a Gallery</para> <para>ref android.R.styleable::Gallery_spacing </para>        
				/// </summary>
				/// <java-name>
				/// setSpacing
				/// </java-name>
				[Dot42.DexImport("setSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetSpacing(int spacing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the alpha of items that are not selected in the Gallery.</para> <para>ref android.R.styleable::Gallery_unselectedAlpha </para>        
				/// </summary>
				/// <java-name>
				/// setUnselectedAlpha
				/// </java-name>
				[Dot42.DexImport("setUnselectedAlpha", "(F)V", AccessFlags = 1)]
				public virtual void SetUnselectedAlpha(float unselectedAlpha) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildStaticTransformation
				/// </java-name>
				[Dot42.DexImport("getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", AccessFlags = 4)]
				protected internal override bool GetChildStaticTransformation(global::Android.Views.View child, global::Android.Views.Animations.Transformation t) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeHorizontalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Notified when a tap occurs with the up MotionEvent that triggered it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the event is consumed, else false </para>
				/// </returns>
				/// <java-name>
				/// onSingleTapUp
				/// </java-name>
				[Dot42.DexImport("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnSingleTapUp(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Notified of a fling event when it occurs with the initial on down MotionEvent and the matching up MotionEvent. The calculated velocity is supplied along the x and y axis in pixels per second.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the event is consumed, else false </para>
				/// </returns>
				/// <java-name>
				/// onFling
				/// </java-name>
				[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
				public virtual bool OnFling(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float velocityX, float velocityY) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Notified when a scroll occurs with the initial on down MotionEvent and the current move MotionEvent. The distance in x and y is also supplied for convenience.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the event is consumed, else false </para>
				/// </returns>
				/// <java-name>
				/// onScroll
				/// </java-name>
				[Dot42.DexImport("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
				public virtual bool OnScroll(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float distanceX, float distanceY) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Notified when a tap occurs with the down MotionEvent that triggered it. This will be triggered immediately for every down event. All other events should be preceded by this.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDown
				/// </java-name>
				[Dot42.DexImport("onDown", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnDown(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Notified when a long press occurs with the initial on down MotionEvent that trigged it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onLongPress
				/// </java-name>
				[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void OnLongPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The user has performed a down MotionEvent and not performed a move or up yet. This event is commonly used to provide visual feedback to the user to let them know that their action has been recognized i.e. highlight an element.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onShowPress
				/// </java-name>
				[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void OnShowPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 1)]
				public override void DispatchSetSelected(bool selected) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal override void DispatchSetPressed(bool pressed) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool ShowContextMenuForChild(global::Android.Views.View originalView) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showContextMenu
				/// </java-name>
				[Dot42.DexImport("showContextMenu", "()Z", AccessFlags = 1)]
				public override bool ShowContextMenu() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Handles left, right, and clicking  <para>android.view.View::onKeyDown </para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Describes how the child views are aligned. </para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal override int GetChildDrawingOrder(int childCount, int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Gallery() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal override global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <summary>
				///  <para>Gallery extends LayoutParams to provide a place to hold current Transformation information along with previous position/transformation info. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/Gallery$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/Gallery$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A view that shows items in two-dimensional scrolling grid. The items in the grid come from the ListAdapter associated with this view.</para> <para>See the  guide.</para> <para>ref android.R.styleable::GridView_horizontalSpacing  ref android.R.styleable::GridView_verticalSpacing  ref android.R.styleable::GridView_stretchMode  ref android.R.styleable::GridView_columnWidth  ref android.R.styleable::GridView_numColumns  ref android.R.styleable::GridView_gravity </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/GridView
		/// </java-name>
		[Dot42.DexImport("android/widget/GridView", AccessFlags = 33)]
		public partial class GridView : global::Android.Widget.AbsListView
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Disables stretching.</para> <para> <para>setStretchMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// NO_STRETCH
				/// </java-name>
				[Dot42.DexImport("NO_STRETCH", "I", AccessFlags = 25)]
				public const int NO_STRETCH = 0;
				/// <summary>
				///  <para>Stretches the spacing between columns.</para> <para> <para>setStretchMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// STRETCH_SPACING
				/// </java-name>
				[Dot42.DexImport("STRETCH_SPACING", "I", AccessFlags = 25)]
				public const int STRETCH_SPACING = 1;
				/// <summary>
				///  <para>Stretches columns.</para> <para> <para>setStretchMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// STRETCH_COLUMN_WIDTH
				/// </java-name>
				[Dot42.DexImport("STRETCH_COLUMN_WIDTH", "I", AccessFlags = 25)]
				public const int STRETCH_COLUMN_WIDTH = 2;
				/// <summary>
				///  <para>Stretches the spacing between columns. The spacing is uniform.</para> <para> <para>setStretchMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// STRETCH_SPACING_UNIFORM
				/// </java-name>
				[Dot42.DexImport("STRETCH_SPACING_UNIFORM", "I", AccessFlags = 25)]
				public const int STRETCH_SPACING_UNIFORM = 3;
				/// <summary>
				///  <para>Creates as many columns as can fit on screen.</para> <para> <para>setNumColumns(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// AUTO_FIT
				/// </java-name>
				[Dot42.DexImport("AUTO_FIT", "I", AccessFlags = 25)]
				public const int AUTO_FIT = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachLayoutAnimationParameters
				/// </java-name>
				[Dot42.DexImport("attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", AccessFlags = 4)]
				protected internal override void AttachLayoutAnimationParameters(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams @params, int index, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal override void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the currently selected item</para> <para>If in touch mode, the item will not be selected but it will still be positioned appropriately. </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int keyCode, int repeatCount, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the gravity for this grid. Gravity describes how the child views are horizontally aligned. Defaults to Gravity.LEFT</para> <para>ref android.R.styleable::GridView_gravity </para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the amount of horizontal (x) spacing to place between each item in the grid.</para> <para>ref android.R.styleable::GridView_horizontalSpacing </para>        
				/// </summary>
				/// <java-name>
				/// setHorizontalSpacing
				/// </java-name>
				[Dot42.DexImport("setHorizontalSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalSpacing(int horizontalSpacing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the amount of vertical (y) spacing to place between each item in the grid.</para> <para> <para>getVerticalSpacing()</para>ref android.R.styleable::GridView_verticalSpacing </para>        
				/// </summary>
				/// <java-name>
				/// setVerticalSpacing
				/// </java-name>
				[Dot42.DexImport("setVerticalSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalSpacing(int verticalSpacing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the width of columns in the grid.</para> <para>ref android.R.styleable::GridView_columnWidth </para>        
				/// </summary>
				/// <java-name>
				/// setColumnWidth
				/// </java-name>
				[Dot42.DexImport("setColumnWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetColumnWidth(int columnWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the number of columns in the grid</para> <para>ref android.R.styleable::GridView_numColumns </para>        
				/// </summary>
				/// <java-name>
				/// setNumColumns
				/// </java-name>
				[Dot42.DexImport("setNumColumns", "(I)V", AccessFlags = 1)]
				public virtual void SetNumColumns(int numColumns) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal GridView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStretchMode
				/// </java-name>
				public virtual int StretchMode
				{
						[Dot42.DexImport("getStretchMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStretchMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>ListAdapter used when a ListView has header views. This ListAdapter wraps another one and also keeps track of the header views and their associated data objects. </para> <para>This is intended as a base class; you will probably not need to use this class directly in your own code. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/HeaderViewListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/HeaderViewListAdapter", AccessFlags = 33)]
		public partial class HeaderViewListAdapter : global::Android.Widget.IWrapperListAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/widget/ListView$FixedViewInfo;>;Ljava/util/ArrayLi" +
    "st<Landroid/widget/ListView$FixedViewInfo;>;Landroid/widget/ListAdapter;)V")]
				public HeaderViewListAdapter(global::Java.Util.ArrayList<global::Android.Widget.ListView.FixedViewInfo> headerViewInfos, global::Java.Util.ArrayList<global::Android.Widget.ListView.FixedViewInfo> footerViewInfos, global::Android.Widget.IListAdapter adapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveHeader(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeFooter
				/// </java-name>
				[Dot42.DexImport("removeFooter", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveFooter(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether all the items in this adapter are enabled. If the value returned by this method changes over time, there is no guarantee it will take effect. If true, it means all items are selectable and clickable (there is no separator.)</para> <para> <para>isEnabled(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if all items are enabled, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the item at the specified position is not a separator. (A separator is a non-selectable, non-clickable item).</para> <para>The result is unspecified if position is invalid. An ArrayIndexOutOfBoundsException should be thrown in that case for fast failure.</para> <para> <para>areAllItemsEnabled() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the item is not a separator</para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1)]
				public virtual bool IsEnabled(int position) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get the data item associated with the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetItem(int position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Get the row id associated with the specified position in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id of the item at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public virtual long GetItemId(int position) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Get a View that displays the data at the specified position in the data set. You can either create a View manually or inflate it from an XML layout file. When the View is inflated, the parent View (GridView, ListView...) will apply default layout parameters unless you use android.view.LayoutInflater#inflate(int, android.view.ViewGroup, boolean) to specify a root view and to prevent attachment to the root.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Get the type of View that will be created by getView for the specified item.</para> <para> <para>IGNORE_ITEM_VIEW_TYPE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of View. Two views should share the same type if one can be converted to the other in getView. Note: Integers must be in the range 0 to getViewTypeCount - 1. IGNORE_ITEM_VIEW_TYPE can also be returned. </para>
				/// </returns>
				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1)]
				public virtual int GetItemViewType(int position) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the data used by this adapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this adapter via registerDataSetObserver.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HeaderViewListAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHeadersCount
				/// </java-name>
				public virtual int HeadersCount
				{
						[Dot42.DexImport("getHeadersCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFootersCount
				/// </java-name>
				public virtual int FootersCount
				{
						[Dot42.DexImport("getFootersCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this adapter doesn't contain any data. This is used to determine whether the empty view should be displayed. A typical implementation will return getCount() == 0 but since getCount() includes the headers and footers, specialized adapters might want a different behavior. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>How many items are in the data set represented by this Adapter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Count of items. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether the item ids are stable across changes to the underlying data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the same id always refers to the same object. </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public virtual bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the number of types of Views that will be created by getView. Each type represents a set of views that can be converted in getView. If the adapter always returns the same type of View for all items, this method should return 1. </para> <para>This method will only be called when when the adapter is set on the the AdapterView. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of types of Views that will be created by this adapter </para>
				/// </returns>
				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				public virtual int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <summary>
				///  <para>Returns the adapter wrapped by this list adapter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The android.widget.ListAdapter wrapped by this adapter. </para>
				/// </returns>
				/// <java-name>
				/// getWrappedAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter WrappedAdapter
				{
						[Dot42.DexImport("getWrappedAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
				}

		}

		/// <summary>
		///  <para>Layout container for a view hierarchy that can be scrolled by the user, allowing it to be larger than the physical display. A HorizontalScrollView is a FrameLayout, meaning you should place one child in it containing the entire contents to scroll; this child may itself be a layout manager with a complex hierarchy of objects. A child that is often used is a LinearLayout in a horizontal orientation, presenting a horizontal array of top-level items that the user can scroll through.</para> <para>The TextView class also takes care of its own scrolling, so does not require a HorizontalScrollView, but using the two together is possible to achieve the effect of a text view within a larger container.</para> <para>HorizontalScrollView only supports horizontal scrolling. For vertical scrolling, use either ScrollView or ListView.</para> <para>ref android.R.styleable::HorizontalScrollView_fillViewport </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/HorizontalScrollView
		/// </java-name>
		[Dot42.DexImport("android/widget/HorizontalScrollView", AccessFlags = 33)]
		public partial class HorizontalScrollView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>You can call this function yourself to have the scroll view perform scrolling from a key event, just as if the event had been dispatched to it by the view hierarchy.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if the event was handled, else false. </para>
				/// </returns>
				/// <java-name>
				/// executeKeyEvent
				/// </java-name>
				[Dot42.DexImport("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ExecuteKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int scrollX, int scrollY, bool clampedX, bool clampedY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Handles scrolling in response to a "page up/down" shortcut press. This method will scroll the view by one page left or right and give the focus to the leftmost/rightmost component in the new visible area. If no component is a good candidate for focus, this scrollview reclaims the focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the key event is consumed by this method, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// pageScroll
				/// </java-name>
				[Dot42.DexImport("pageScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool PageScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Handles scrolling in response to a "home/end" shortcut press. This method will scroll the view to the left or right and give the focus to the leftmost/rightmost component in the new visible area. If no component is a good candidate for focus, this scrollview reclaims the focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the key event is consumed by this method, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// fullScroll
				/// </java-name>
				[Dot42.DexImport("fullScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool FullScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Handle scrolling in response to a left or right arrow click.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if we consumed the event, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// arrowScroll
				/// </java-name>
				[Dot42.DexImport("arrowScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool ArrowScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Like View#scrollBy, but scroll smoothly instead of immediately.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 17)]
				public void SmoothScrollBy(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like scrollTo, but scroll smoothly instead of immediately.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollTo
				/// </java-name>
				[Dot42.DexImport("smoothScrollTo", "(II)V", AccessFlags = 17)]
				public void SmoothScrollTo(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The scroll range of a scroll view is the overall width of all of its children.</para>        
				/// </summary>
				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal override void MeasureChild(global::Android.Views.View child, int parentWidthMeasureSpec, int parentHeightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal override void MeasureChildWithMargins(global::Android.Views.View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compute the amount to scroll in the X direction in order to get a rectangle completely on the screen (or, if taller than the screen, at least the first screen size chunk of it).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The scroll delta. </para>
				/// </returns>
				/// <java-name>
				/// computeScrollDeltaToGetChildRectOnScreen
				/// </java-name>
				[Dot42.DexImport("computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I", AccessFlags = 4)]
				protected internal virtual int ComputeScrollDeltaToGetChildRectOnScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Called when a child of this parent wants focus</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public override void RequestChildFocus(global::Android.Views.View child, global::Android.Views.View focused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>When looking for focus in children of a scroll view, need to be a little more careful not to give focus to something that is scrolled off screen.</para> <para>This is more expensive than the default android.view.ViewGroup implementation, otherwise this behavior might have been made the default. </para>        
				/// </summary>
				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool OnRequestFocusInDescendants(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a child of this group wants a particular rectangle to be positioned onto the screen. ViewGroups overriding this can trust that:  <ul> <li> <para>child will be a direct child of this group </para></li> <li> <para>rectangle will be in the child's coordinates </para></li></ul></para> <para>ViewGroups overriding this should uphold the contract:</para> <para> <ul> <li> <para>nothing will change if the rectangle is already visible </para></li> <li> <para>the view port will be scrolled only just enough to make the rectangle visible  <ul> <li></li></ul>child The direct child making the request. </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the group scrolled to handle the operation </para>
				/// </returns>
				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View child, global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when something has changed which has invalidated the layout of a child of this view parent. This will schedule a layout pass of the view tree. </para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fling the scroll view</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(I)V", AccessFlags = 1)]
				public virtual void Fling(int velocityX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This version also clamps the scrolling to the bounds of our child. </para>        
				/// </summary>
				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public override void ScrollTo(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal HorizontalScrollView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal override float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal override float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum amount this scroll view will scroll in response to an arrow event. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether this HorizontalScrollView's content is stretched to fill the viewport.</para> <para>ref android.R.styleable::HorizontalScrollView_fillViewport </para>        
				/// </summary>
				/// <returns>
				///  <para>True if the content fills the viewport, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isFillViewport
				/// </java-name>
				public virtual bool IsFillViewport
				{
						[Dot42.DexImport("isFillViewport", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillViewport", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether arrow scrolling will animate its transition. </para>
				/// </returns>
				/// <java-name>
				/// isSmoothScrollingEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollingEnabled
				{
						[Dot42.DexImport("isSmoothScrollingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>An Adapter object acts as a bridge between an AdapterView and the underlying data for that view. The Adapter provides access to the data items. The Adapter is also responsible for making a android.view.View for each item in the data set.</para> <para> <para>android.widget.ArrayAdapter </para> <para>android.widget.CursorAdapter </para> <para>android.widget.SimpleCursorAdapter </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Adapter
		/// </java-name>
		[Dot42.DexImport("android/widget/Adapter", AccessFlags = 1537)]
		public partial interface IAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Register an observer that is called when changes happen to the data used by this adapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this adapter via registerDataSetObserver.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the data item associated with the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetItem(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the row id associated with the specified position in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id of the item at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1025)]
				long GetItemId(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get a View that displays the data at the specified position in the data set. You can either create a View manually or inflate it from an XML layout file. When the View is inflated, the parent View (GridView, ListView...) will apply default layout parameters unless you use android.view.LayoutInflater#inflate(int, android.view.ViewGroup, boolean) to specify a root view and to prevent attachment to the root.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the type of View that will be created by getView for the specified item.</para> <para> <para>IGNORE_ITEM_VIEW_TYPE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of View. Two views should share the same type if one can be converted to the other in getView. Note: Integers must be in the range 0 to getViewTypeCount - 1. IGNORE_ITEM_VIEW_TYPE can also be returned. </para>
				/// </returns>
				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1025)]
				int GetItemViewType(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>How many items are in the data set represented by this Adapter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Count of items. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Indicates whether the item ids are stable across changes to the underlying data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the same id always refers to the same object. </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the number of types of Views that will be created by getView. Each type represents a set of views that can be converted in getView. If the adapter always returns the same type of View for all items, this method should return 1. </para> <para>This method will only be called when when the adapter is set on the the AdapterView. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of types of Views that will be created by this adapter </para>
				/// </returns>
				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this adapter doesn't contain any data. This is used to determine whether the empty view should be displayed. A typical implementation will return getCount() == 0 but since getCount() includes the headers and footers, specialized adapters might want a different behavior. </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An Adapter object acts as a bridge between an AdapterView and the underlying data for that view. The Adapter provides access to the data items. The Adapter is also responsible for making a android.view.View for each item in the data set.</para> <para> <para>android.widget.ArrayAdapter </para> <para>android.widget.CursorAdapter </para> <para>android.widget.SimpleCursorAdapter </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Adapter
		/// </java-name>
		[Dot42.DexImport("android/widget/Adapter", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IAdapterConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>An item view type that causes the AdapterView to ignore the item view. For example, this can be used if the client does not want a particular view to be given for conversion in getView(int, View, ViewGroup).</para> <para> <para>getItemViewType(int) </para> <para>getViewTypeCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// IGNORE_ITEM_VIEW_TYPE
				/// </java-name>
				[Dot42.DexImport("IGNORE_ITEM_VIEW_TYPE", "I", AccessFlags = 25)]
				public const int IGNORE_ITEM_VIEW_TYPE = -1;
				/// <java-name>
				/// NO_SELECTION
				/// </java-name>
				[Dot42.DexImport("NO_SELECTION", "I", AccessFlags = 25)]
				public const int NO_SELECTION = -2147483648;
		}

		/// <summary>
		///  <para>Defines an extension for views that make them checkable. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Checkable
		/// </java-name>
		[Dot42.DexImport("android/widget/Checkable", AccessFlags = 1537)]
		public partial interface ICheckable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Change the checked state of the view to the inverse of its current state </para>        
				/// </summary>
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1025)]
				void Toggle() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current checked state of the view </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>An adapter that links a ExpandableListView with the underlying data. The implementation of this interface will provide access to the data of the children (categorized by groups), and also instantiate Views for children and groups. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ExpandableListAdapter", AccessFlags = 1537)]
		public partial interface IExpandableListAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <para>Adapter::registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <para>Adapter::unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of children in a specified group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the children count in the specified group </para>
				/// </returns>
				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1025)]
				int GetChildrenCount(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the data associated with the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data child for the specified group </para>
				/// </returns>
				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetGroup(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the data associated with the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data of the child </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetChild(int groupPosition, int childPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the ID for the group at the given position. This group ID must be unique across groups. The combined ID (see getCombinedGroupId(long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the group </para>
				/// </returns>
				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1025)]
				long GetGroupId(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the ID for the given child within the given group. This ID must be unique across all children within the group. The combined ID (see getCombinedChildId(long, long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the child </para>
				/// </returns>
				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1025)]
				long GetChildId(int groupPosition, int childPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a View that displays the given group. This View is only for the groupthe Views for the group's children will be fetched using getChildView(int, int, boolean, View, ViewGroup).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the group at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetGroupView(int groupPosition, bool isExpanded, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets a View that displays the data for the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the child at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetChildView(int groupPosition, int childPosition, bool isLastChild, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Whether the child at the specified position is selectable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the child is selectable. </para>
				/// </returns>
				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1025)]
				bool IsChildSelectable(int groupPosition, int childPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <para>ListAdapter::areAllItemsEnabled() </para></para>        
				/// </summary>
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1025)]
				bool AreAllItemsEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a group is expanded.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGroupExpanded
				/// </java-name>
				[Dot42.DexImport("onGroupExpanded", "(I)V", AccessFlags = 1025)]
				void OnGroupExpanded(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a group is collapsed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1025)]
				void OnGroupCollapsed(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets an ID for a child that is unique across any item (either group or child) that is in this list. Expandable lists require each item (group or child) to have a unique ID among all children and groups in the list. This method is responsible for returning that unique ID given a child's ID and its group's ID. Furthermore, if hasStableIds() is true, the returned ID must be stable as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The unique (and possibly stable) ID of the child across all groups and children in this list. </para>
				/// </returns>
				/// <java-name>
				/// getCombinedChildId
				/// </java-name>
				[Dot42.DexImport("getCombinedChildId", "(JJ)J", AccessFlags = 1025)]
				long GetCombinedChildId(long groupId, long childId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets an ID for a group that is unique across any item (either group or child) that is in this list. Expandable lists require each item (group or child) to have a unique ID among all children and groups in the list. This method is responsible for returning that unique ID given a group's ID. Furthermore, if hasStableIds() is true, the returned ID must be stable as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The unique (and possibly stable) ID of the group across all groups and children in this list. </para>
				/// </returns>
				/// <java-name>
				/// getCombinedGroupId
				/// </java-name>
				[Dot42.DexImport("getCombinedGroupId", "(J)J", AccessFlags = 1025)]
				long GetCombinedGroupId(long groupId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the number of groups.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of groups </para>
				/// </returns>
				/// <java-name>
				/// getGroupCount
				/// </java-name>
				int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Indicates whether the child and group IDs are stable across changes to the underlying data.</para> <para> <para>Adapter::hasStableIds() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether or not the same ID always refers to the same object </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <para>ListAdapter::isEmpty() </para></para>        
				/// </summary>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Defines a filterable behavior. A filterable class can have its data constrained by a filter. Filterable classes are usually android.widget.Adapter implementations.</para> <para> <para>android.widget.Filter </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Filterable
		/// </java-name>
		[Dot42.DexImport("android/widget/Filterable", AccessFlags = 1537)]
		public partial interface IFilterable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This class can be used by external clients of CursorAdapter and CursorTreeAdapter to define how the content of the adapter should be filtered.</para> <para> <para>runQuery(CharSequence) </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/FilterQueryProvider
		/// </java-name>
		[Dot42.DexImport("android/widget/FilterQueryProvider", AccessFlags = 1537)]
		public partial interface IFilterQueryProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Runs a query with the specified constraint. This query is requested by the filter attached to this adapter.</para> <para>Contract: when constraint is null or empty, the original results, prior to any filtering, must be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Cursor representing the results of the new query </para>
				/// </returns>
				/// <java-name>
				/// runQuery
				/// </java-name>
				[Dot42.DexImport("runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1025)]
				global::Android.Database.ICursor RunQuery(global::Java.Lang.ICharSequence constraint) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Additional methods that when implemented make an ExpandableListAdapter take advantage of the Adapter view type mechanism. </para> <para>An ExpandableListAdapter declares it has one view type for its group items and one view type for its child items. Although adapted for most ExpandableListViews, these values should be tuned for heterogeneous ExpandableListViews. </para> <para>Lists that contain different types of group and/or child item views, should use an adapter that implements this interface. This way, the recycled views that will be provided to android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) and android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) will be of the appropriate group or child type, resulting in a more efficient reuse of the previously created views. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/HeterogeneousExpandableList
		/// </java-name>
		[Dot42.DexImport("android/widget/HeterogeneousExpandableList", AccessFlags = 1537)]
		public partial interface IHeterogeneousExpandableList
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Get the type of group View that will be created by android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . for the specified group item.</para> <para> <para>android.widget.Adapter::IGNORE_ITEM_VIEW_TYPE </para> <para>getGroupTypeCount() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of group View. Two group views should share the same type if one can be converted to the other in android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . Note: Integers must be in the range 0 to getGroupTypeCount - 1. android.widget.Adapter#IGNORE_ITEM_VIEW_TYPE can also be returned. </para>
				/// </returns>
				/// <java-name>
				/// getGroupType
				/// </java-name>
				[Dot42.DexImport("getGroupType", "(I)I", AccessFlags = 1025)]
				int GetGroupType(int groupPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the type of child View that will be created by android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) for the specified child item.</para> <para> <para>android.widget.Adapter::IGNORE_ITEM_VIEW_TYPE </para> <para>getChildTypeCount() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An integer representing the type of child View. Two child views should share the same type if one can be converted to the other in android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) Note: Integers must be in the range 0 to getChildTypeCount - 1. android.widget.Adapter#IGNORE_ITEM_VIEW_TYPE can also be returned. </para>
				/// </returns>
				/// <java-name>
				/// getChildType
				/// </java-name>
				[Dot42.DexImport("getChildType", "(II)I", AccessFlags = 1025)]
				int GetChildType(int groupPosition, int childPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of types of group Views that will be created by android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . Each type represents a set of views that can be converted in android.widget.ExpandableListAdapter#getGroupView(int, boolean, View, ViewGroup) . If the adapter always returns the same type of View for all group items, this method should return 1. </para> <para>This method will only be called when the adapter is set on the AdapterView.</para> <para> <para>getChildTypeCount() </para> <para>getGroupType(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of types of group Views that will be created by this adapter. </para>
				/// </returns>
				/// <java-name>
				/// getGroupTypeCount
				/// </java-name>
				int GroupTypeCount
				{
						[Dot42.DexImport("getGroupTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the number of types of child Views that will be created by android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) . Each type represents a set of views that can be converted in android.widget.ExpandableListAdapter#getChildView(int, int, boolean, View, ViewGroup) , for any group. If the adapter always returns the same type of View for all child items, this method should return 1. </para> <para>This method will only be called when the adapter is set on the AdapterView.</para> <para> <para>getGroupTypeCount() </para> <para>getChildType(int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The total number of types of child Views that will be created by this adapter. </para>
				/// </returns>
				/// <java-name>
				/// getChildTypeCount
				/// </java-name>
				int ChildTypeCount
				{
						[Dot42.DexImport("getChildTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Extended Adapter that is the bridge between a ListView and the data that backs the list. Frequently that data comes from a Cursor, but that is not required. The ListView can display any data provided that it is wrapped in a ListAdapter. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ListAdapter", AccessFlags = 1537)]
		public partial interface IListAdapter : global::Android.Widget.IAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates whether all the items in this adapter are enabled. If the value returned by this method changes over time, there is no guarantee it will take effect. If true, it means all items are selectable and clickable (there is no separator.)</para> <para> <para>isEnabled(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if all items are enabled, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1025)]
				bool AreAllItemsEnabled() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if the item at the specified position is not a separator. (A separator is a non-selectable, non-clickable item).</para> <para>The result is unspecified if position is invalid. An ArrayIndexOutOfBoundsException should be thrown in that case for fast failure.</para> <para> <para>areAllItemsEnabled() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the item is not a separator</para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1025)]
				bool IsEnabled(int position) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Displays a button with an image (instead of text) that can be pressed or clicked by the user. By default, an ImageButton looks like a regular android.widget.Button, with the standard button background that changes color during different button states. The image on the surface of the button is defined either by the <c>android:src </c> attribute in the  <c>&lt;ImageButton&gt; </c> XML element or by the setImageResource(int) method.</para> <para>To remove the standard button background image, define your own background image or set the background color to be transparent.</para> <para>To indicate the different button states (focused, selected, etc.), you can define a different image for each state. E.g., a blue image by default, an orange one for when focused, and a yellow one for when pressed. An easy way to do this is with an XML drawable "selector." For example:</para> <para> <pre>
		/// &lt;?xml version="1.0" encoding="utf-8"?&gt;
		/// &lt;selector xmlns:android="http://schemas.android.com/apk/res/android"&gt;
		///     &lt;item android:state_pressed="true"
		///           android:drawable="@drawable/button_pressed" /&gt; &lt;!-- pressed --&gt;
		///     &lt;item android:state_focused="true"
		///           android:drawable="@drawable/button_focused" /&gt; &lt;!-- focused --&gt;
		///     &lt;item android:drawable="@drawable/button_normal" /&gt; &lt;!-- default --&gt;
		/// &lt;/selector&gt;</pre></para> <para>Save the XML file in your project <c>res/drawable/ </c> folder and then reference it as a drawable for the source of your ImageButton (in the  <c>android:src </c> attribute). Android will automatically change the image based on the state of the button and the corresponding images defined in the XML.</para> <para>The order of the <c>&lt;item&gt; </c> elements is important because they are evaluated in order. This is why the "normal" button image comes last, because it will only be applied after <c>android:state_pressed </c> and <c>android:state_focused </c> have both evaluated false.</para> <para>See the  guide.</para> <para> <b>XML attributes</b></para> <para>See Button Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ImageButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageButton", AccessFlags = 33)]
		public partial class ImageButton : global::Android.Widget.ImageView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnSetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ImageButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/ImageSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageSwitcher", AccessFlags = 33)]
		public partial class ImageSwitcher : global::Android.Widget.ViewSwitcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageResource
				/// </java-name>
				[Dot42.DexImport("setImageResource", "(I)V", AccessFlags = 1)]
				public virtual void SetImageResource(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageURI
				/// </java-name>
				[Dot42.DexImport("setImageURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageDrawable
				/// </java-name>
				[Dot42.DexImport("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetImageDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ImageSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Displays an arbitrary image, such as an icon. The ImageView class can load images from various sources (such as resources or content providers), takes care of computing its measurement from the image so that it can be used in any layout manager, and provides various display options such as scaling and tinting.</para> <para>ref android.R.styleable::ImageView_adjustViewBounds  ref android.R.styleable::ImageView_src  ref android.R.styleable::ImageView_maxWidth  ref android.R.styleable::ImageView_maxHeight  ref android.R.styleable::ImageView_tint  ref android.R.styleable::ImageView_scaleType  ref android.R.styleable::ImageView_cropToPadding </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ImageView
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageView", AccessFlags = 33)]
		public partial class ImageView : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable dr) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnSetAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set this to true if you want the ImageView to adjust its bounds to preserve the aspect ratio of its drawable.</para> <para> <b>Note:</b> If the application targets API level 17 or lower, adjustViewBounds will allow the drawable to shrink the view bounds, but not grow to fill available measured space in all cases. This is for compatibility with legacy MeasureSpec and RelativeLayout behavior.</para> <para> <para>getAdjustViewBounds()</para>ref android.R.styleable::ImageView_adjustViewBounds </para>        
				/// </summary>
				/// <java-name>
				/// setAdjustViewBounds
				/// </java-name>
				[Dot42.DexImport("setAdjustViewBounds", "(Z)V", AccessFlags = 1)]
				public virtual void SetAdjustViewBounds(bool adjustViewBounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>An optional argument to supply a maximum width for this view. Only valid if setAdjustViewBounds(boolean) has been set to true. To set an image to be a maximum of 100 x 100 while preserving the original aspect ratio, do the following: 1) set adjustViewBounds to true 2) set maxWidth and maxHeight to 100 3) set the height and width layout params to WRAP_CONTENT.</para> <para>Note that this view could be still smaller than 100 x 100 using this approach if the original image is small. To set an image to a fixed size, specify that size in the layout params and then use setScaleType(android.widget.ImageView.ScaleType) to determine how to fit the image within the bounds. </para> <para> <para>getMaxWidth()</para>ref android.R.styleable::ImageView_maxWidth </para>        
				/// </summary>
				/// <java-name>
				/// setMaxWidth
				/// </java-name>
				[Dot42.DexImport("setMaxWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxWidth(int maxWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>An optional argument to supply a maximum height for this view. Only valid if setAdjustViewBounds(boolean) has been set to true. To set an image to be a maximum of 100 x 100 while preserving the original aspect ratio, do the following: 1) set adjustViewBounds to true 2) set maxWidth and maxHeight to 100 3) set the height and width layout params to WRAP_CONTENT.</para> <para>Note that this view could be still smaller than 100 x 100 using this approach if the original image is small. To set an image to a fixed size, specify that size in the layout params and then use setScaleType(android.widget.ImageView.ScaleType) to determine how to fit the image within the bounds. </para> <para> <para>getMaxHeight()</para>ref android.R.styleable::ImageView_maxHeight </para>        
				/// </summary>
				/// <java-name>
				/// setMaxHeight
				/// </java-name>
				[Dot42.DexImport("setMaxHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxHeight(int maxHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a drawable as the content of this ImageView.</para> <para>This does Bitmap reading and decoding on the UI thread, which can cause a latency hiccup. If that's a concern, consider using setImageDrawable(android.graphics.drawable.Drawable) or setImageBitmap(android.graphics.Bitmap) and android.graphics.BitmapFactory instead.</para> <para>ref android.R.styleable::ImageView_src </para>        
				/// </summary>
				/// <java-name>
				/// setImageResource
				/// </java-name>
				[Dot42.DexImport("setImageResource", "(I)V", AccessFlags = 1)]
				public virtual void SetImageResource(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the content of this ImageView to the specified Uri.</para> <para>This does Bitmap reading and decoding on the UI thread, which can cause a latency hiccup. If that's a concern, consider using setImageDrawable(android.graphics.drawable.Drawable) or setImageBitmap(android.graphics.Bitmap) and android.graphics.BitmapFactory instead.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageURI
				/// </java-name>
				[Dot42.DexImport("setImageURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a drawable as the content of this ImageView.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageDrawable
				/// </java-name>
				[Dot42.DexImport("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetImageDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a Bitmap as the content of this ImageView.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageBitmap
				/// </java-name>
				[Dot42.DexImport("setImageBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetImageBitmap(global::Android.Graphics.Bitmap bm) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageState
				/// </java-name>
				[Dot42.DexImport("setImageState", "([IZ)V", AccessFlags = 1)]
				public virtual void SetImageState(int[] state, bool merge) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the image level, when it is constructed from a android.graphics.drawable.LevelListDrawable.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageLevel
				/// </java-name>
				[Dot42.DexImport("setImageLevel", "(I)V", AccessFlags = 1)]
				public virtual void SetImageLevel(int level) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Controls how the image should be resized or moved to match the size of this ImageView.</para> <para>ref android.R.styleable::ImageView_scaleType </para>        
				/// </summary>
				/// <java-name>
				/// setScaleType
				/// </java-name>
				[Dot42.DexImport("setScaleType", "(Landroid/widget/ImageView$ScaleType;)V", AccessFlags = 1)]
				public virtual void SetScaleType(global::Android.Widget.ImageView.ScaleType scaleType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the current scale type in use by this ImageView.</para> <para> <para>ImageView.ScaleType</para>ref android.R.styleable::ImageView_scaleType </para>        
				/// </summary>
				/// <java-name>
				/// getScaleType
				/// </java-name>
				[Dot42.DexImport("getScaleType", "()Landroid/widget/ImageView$ScaleType;", AccessFlags = 1)]
				public virtual global::Android.Widget.ImageView.ScaleType GetScaleType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.ImageView.ScaleType);
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 1)]
				public new virtual int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal virtual bool SetFrame(int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a tinting option for the image.</para> <para>ref android.R.styleable::ImageView_tint </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 17)]
				public void SetColorFilter(int color, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a tinting option for the image. Assumes PorterDuff.Mode#SRC_ATOP blending mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(I)V", AccessFlags = 17)]
				public void SetColorFilter(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearColorFilter
				/// </java-name>
				[Dot42.DexImport("clearColorFilter", "()V", AccessFlags = 17)]
				public void ClearColorFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a tinting option for the image. Assumes PorterDuff.Mode#SRC_ATOP blending mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public virtual void SetColorFilter(global::Android.Graphics.ColorFilter color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the alpha value that should be applied to the image.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use setImageAlpha(int) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public virtual void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ImageView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the view's drawable, or null if no drawable has been assigned. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>Return the view's optional matrix. This is applied to the view's drawable when it is drawn. If there is not matrix, this method will return an identity matrix. Do not change this matrix in place but make a copy. If you want a different matrix applied to the drawable, be sure to call setImageMatrix(). </para>        
				/// </summary>
				/// <java-name>
				/// getImageMatrix
				/// </java-name>
				public virtual global::Android.Graphics.Matrix ImageMatrix
				{
						[Dot42.DexImport("getImageMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Matrix); }
						[Dot42.DexImport("setImageMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the offset of the widget's text baseline from the widget's top boundary. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset of the baseline within the widget's bounds or -1 if baseline alignment is not supported. </para>
				/// </returns>
				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				public override bool IsSelected
				{
						[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/ImageView$ScaleType
				/// </java-name>
				[Dot42.DexImport("android/widget/ImageView$ScaleType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/widget/ImageView$ScaleType;>;")]
				public sealed class ScaleType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CENTER
						/// </java-name>
						[Dot42.DexImport("CENTER", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER;
						/// <java-name>
						/// CENTER_CROP
						/// </java-name>
						[Dot42.DexImport("CENTER_CROP", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER_CROP;
						/// <java-name>
						/// CENTER_INSIDE
						/// </java-name>
						[Dot42.DexImport("CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER_INSIDE;
						/// <java-name>
						/// FIT_CENTER
						/// </java-name>
						[Dot42.DexImport("FIT_CENTER", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_CENTER;
						/// <java-name>
						/// FIT_END
						/// </java-name>
						[Dot42.DexImport("FIT_END", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_END;
						/// <java-name>
						/// FIT_START
						/// </java-name>
						[Dot42.DexImport("FIT_START", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_START;
						/// <java-name>
						/// FIT_XY
						/// </java-name>
						[Dot42.DexImport("FIT_XY", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_XY;
						/// <java-name>
						/// MATRIX
						/// </java-name>
						[Dot42.DexImport("MATRIX", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType MATRIX;
						private ScaleType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/widget/ImageView$ScaleType;", AccessFlags = 9)]
						public static ScaleType[] Values() /* MethodBuilder.Create */ 
						{
								return default(ScaleType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;", AccessFlags = 9)]
						public static ScaleType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(ScaleType);
						}

				}

		}

		/// <summary>
		///  <para>Interface that may implemented on Adapters to enable fast scrolling between sections of an AbsListView. </para> <para>A section is a group of list items that have something in common. For example, they may begin with the same letter or they may be songs from the same artist. </para> <para>ExpandableListAdapters that consider groups and sections as synonymous should account for collapsed groups and return an appropriate section/position.</para> <para> <para>AbsListView::setFastScrollEnabled(boolean) </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SectionIndexer
		/// </java-name>
		[Dot42.DexImport("android/widget/SectionIndexer", AccessFlags = 1537)]
		public partial interface ISectionIndexer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Given the index of a section within the array of section objects, returns the starting position of that section within the adapter. </para> <para>If the section's starting position is outside of the adapter bounds, the position must be clipped to fall within the size of the adapter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the starting position of that section within the adapter, constrained to fall within the adapter bounds </para>
				/// </returns>
				/// <java-name>
				/// getPositionForSection
				/// </java-name>
				[Dot42.DexImport("getPositionForSection", "(I)I", AccessFlags = 1025)]
				int GetPositionForSection(int sectionIndex) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Given a position within the adapter, returns the index of the corresponding section within the array of section objects. </para> <para>If the section index is outside of the section array bounds, the index must be clipped to fall within the size of the section array. </para> <para>For example, consider an indexer where the section at array index 0 starts at adapter position 100. Calling this method with position 10, which is before the first section, must return index 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the corresponding section within the array of section objects, constrained to fall within the array bounds </para>
				/// </returns>
				/// <java-name>
				/// getSectionForPosition
				/// </java-name>
				[Dot42.DexImport("getSectionForPosition", "(I)I", AccessFlags = 1025)]
				int GetSectionForPosition(int position) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an array of objects representing sections of the list. The returned array and its contents should be non-null. </para> <para>The list view will call toString() on the objects to get the preview text to display while scrolling. For example, an adapter may return an array of Strings representing letters of the alphabet. Or, it may return an array of objects whose toString() methods return their section titles.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the array of section objects </para>
				/// </returns>
				/// <java-name>
				/// getSections
				/// </java-name>
				object[] Sections
				{
						[Dot42.DexImport("getSections", "()[Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Extended Adapter that is the bridge between a android.widget.Spinner and its data. A spinner adapter allows to define two different views: one that shows the data in the spinner itself and one that shows the data in the drop down list when the spinner is pressed.</para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SpinnerAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SpinnerAdapter", AccessFlags = 1537)]
		public partial interface ISpinnerAdapter : global::Android.Widget.IAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Get a android.view.View that displays in the drop down popup the data at the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetDropDownView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>List adapter that wraps another list adapter. The wrapped adapter can be retrieved by calling getWrappedAdapter().</para> <para> <para>ListView </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/WrapperListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/WrapperListAdapter", AccessFlags = 1537)]
		public partial interface IWrapperListAdapter : global::Android.Widget.IListAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the adapter wrapped by this list adapter.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The android.widget.ListAdapter wrapped by this adapter. </para>
				/// </returns>
				/// <java-name>
				/// getWrappedAdapter
				/// </java-name>
				global::Android.Widget.IListAdapter WrappedAdapter
				{
						[Dot42.DexImport("getWrappedAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>A Layout that arranges its children in a single column or a single row. The direction of the row can be set by calling setOrientation(). You can also specify gravity, which specifies the alignment of all the child elements by calling setGravity() or specify that specific children grow to fill up any remaining space in the layout by setting the  <b>weight</b> member of LinearLayout.LayoutParams. The default orientation is horizontal.</para> <para>See the  guide.</para> <para>Also see android.widget.LinearLayout.LayoutParams for layout attributes </para> <para>ref android.R.styleable::LinearLayout_baselineAligned  ref android.R.styleable::LinearLayout_baselineAlignedChildIndex  ref android.R.styleable::LinearLayout_gravity  ref android.R.styleable::LinearLayout_measureWithLargestChild  ref android.R.styleable::LinearLayout_orientation  ref android.R.styleable::LinearLayout_weightSum </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/LinearLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/LinearLayout", AccessFlags = 33)]
		public partial class LinearLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL", "I", AccessFlags = 25)]
				public const int HORIZONTAL = 0;
				/// <java-name>
				/// VERTICAL
				/// </java-name>
				[Dot42.DexImport("VERTICAL", "I", AccessFlags = 25)]
				public const int VERTICAL = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public LinearLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LinearLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describes how the child views are positioned. Defaults to GRAVITY_TOP. If this layout has a VERTICAL orientation, this controls where all the child views are placed if there is extra vertical space. If this layout has a HORIZONTAL orientation, this controls the alignment of the children.</para> <para>ref android.R.styleable::LinearLayout_gravity </para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalGravity
				/// </java-name>
				[Dot42.DexImport("setHorizontalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalGravity(int horizontalGravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalGravity
				/// </java-name>
				[Dot42.DexImport("setVerticalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalGravity(int verticalGravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#MATCH_PARENT and a height of android.view.ViewGroup.LayoutParams#WRAP_CONTENT when the layout's orientation is VERTICAL. When the orientation is HORIZONTAL, the width is set to LayoutParams#WRAP_CONTENT and the height to LayoutParams#WRAP_CONTENT. </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal LinearLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether widgets contained within this layout are aligned on their baseline or not.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when widgets are baseline-aligned, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isBaselineAligned
				/// </java-name>
				public virtual bool IsBaselineAligned
				{
						[Dot42.DexImport("isBaselineAligned", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBaselineAligned", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The index of the child that will be used if this layout is part of a larger layout that is baseline aligned, or -1 if none has been set. </para>
				/// </returns>
				/// <java-name>
				/// getBaselineAlignedChildIndex
				/// </java-name>
				public virtual int BaselineAlignedChildIndex
				{
						[Dot42.DexImport("getBaselineAlignedChildIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBaselineAlignedChildIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the desired weights sum.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A number greater than 0.0f if the weight sum is defined, or a number lower than or equals to 0.0f if not weight sum is to be used. </para>
				/// </returns>
				/// <java-name>
				/// getWeightSum
				/// </java-name>
				public virtual float WeightSum
				{
						[Dot42.DexImport("getWeightSum", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setWeightSum", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current orientation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>either HORIZONTAL or VERTICAL </para>
				/// </returns>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				public virtual int Orientation
				{
						[Dot42.DexImport("getOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOrientation", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Per-child layout information associated with ViewLinearLayout.</para> <para>ref android.R.styleable::LinearLayout_Layout_layout_weight  ref android.R.styleable::LinearLayout_Layout_layout_gravity </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/LinearLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/LinearLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Indicates how much of the extra space in the LinearLayout will be allocated to the view associated with these LayoutParams. Specify 0 if the view should not be stretched. Otherwise the extra pixels will be pro-rated among all views whose weight is greater than 0. </para>        
						/// </summary>
						/// <java-name>
						/// weight
						/// </java-name>
						[Dot42.DexImport("weight", "F", AccessFlags = 1)]
						public float Weight;
						/// <summary>
						///  <para>Gravity for the view associated with these LayoutParams.</para> <para> <para>android.view.Gravity </para></para>        
						/// </summary>
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
						public int Gravity;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string output) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A view that shows items in a vertically scrolling list. The items come from the ListAdapter associated with this view.</para> <para>See the  guide.</para> <para>ref android.R.styleable::ListView_entries  ref android.R.styleable::ListView_divider  ref android.R.styleable::ListView_dividerHeight  ref android.R.styleable::ListView_headerDividersEnabled  ref android.R.styleable::ListView_footerDividersEnabled </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ListView
		/// </java-name>
		[Dot42.DexImport("android/widget/ListView", AccessFlags = 33)]
		public partial class ListView : global::Android.Widget.AbsListView
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHOICE_MODE_NONE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_NONE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_NONE = 0;
				/// <java-name>
				/// CHOICE_MODE_SINGLE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_SINGLE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_SINGLE = 1;
				/// <java-name>
				/// CHOICE_MODE_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_MULTIPLE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_MULTIPLE = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a fixed view to appear at the top of the list. If this method is called more than once, the views will appear in the order they were added. Views added using this call can take focus if they want. </para> <para>Note: When first introduced, this method could only be called before setting the adapter with setAdapter(ListAdapter). Starting with android.os.Build.VERSION_CODES#KITKAT, this method may be called at any time. If the ListView's adapter does not extend HeaderViewListAdapter, it will be wrapped with a supporting instance of WrapperListAdapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addHeaderView
				/// </java-name>
				[Dot42.DexImport("addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public virtual void AddHeaderView(global::Android.Views.View v, object data, bool isSelectable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a fixed view to appear at the top of the list. If addHeaderView is called more than once, the views will appear in the order they were added. Views added using this call can take focus if they want. </para> <para>Note: When first introduced, this method could only be called before setting the adapter with setAdapter(ListAdapter). Starting with android.os.Build.VERSION_CODES#KITKAT, this method may be called at any time. If the ListView's adapter does not extend HeaderViewListAdapter, it will be wrapped with a supporting instance of WrapperListAdapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addHeaderView
				/// </java-name>
				[Dot42.DexImport("addHeaderView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddHeaderView(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a previously-added header view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view was removed, false if the view was not a header view </para>
				/// </returns>
				/// <java-name>
				/// removeHeaderView
				/// </java-name>
				[Dot42.DexImport("removeHeaderView", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveHeaderView(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Add a fixed view to appear at the bottom of the list. If addFooterView is called more than once, the views will appear in the order they were added. Views added using this call can take focus if they want. </para> <para>Note: When first introduced, this method could only be called before setting the adapter with setAdapter(ListAdapter). Starting with android.os.Build.VERSION_CODES#KITKAT, this method may be called at any time. If the ListView's adapter does not extend HeaderViewListAdapter, it will be wrapped with a supporting instance of WrapperListAdapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFooterView
				/// </java-name>
				[Dot42.DexImport("addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public virtual void AddFooterView(global::Android.Views.View v, object data, bool isSelectable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a fixed view to appear at the bottom of the list. If addFooterView is called more than once, the views will appear in the order they were added. Views added using this call can take focus if they want. </para> <para>Note: When first introduced, this method could only be called before setting the adapter with setAdapter(ListAdapter). Starting with android.os.Build.VERSION_CODES#KITKAT, this method may be called at any time. If the ListView's adapter does not extend HeaderViewListAdapter, it will be wrapped with a supporting instance of WrapperListAdapter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFooterView
				/// </java-name>
				[Dot42.DexImport("addFooterView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddFooterView(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a previously-added footer view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view was removed, false if the view was not a footer view </para>
				/// </returns>
				/// <java-name>
				/// removeFooterView
				/// </java-name>
				[Dot42.DexImport("removeFooterView", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveFooterView(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View child, global::Android.Graphics.Rect rect, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal override void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the currently selected item. If in touch mode, the item will not be selected but it will still be positioned appropriately. If the specified selection position is less than 0, then the item at position 0 will be selected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the selected item and positions the selection y pixels from the top edge of the ListView. (If in touch mode, the item will not be selected but it will still be positioned appropriately.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSelectionFromTop
				/// </java-name>
				[Dot42.DexImport("setSelectionFromTop", "(II)V", AccessFlags = 1)]
				public virtual void SetSelectionFromTop(int position, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>setSelectionAfterHeaderView set the selection to be the first list item after the header views. </para>        
				/// </summary>
				/// <java-name>
				/// setSelectionAfterHeaderView
				/// </java-name>
				[Dot42.DexImport("setSelectionAfterHeaderView", "()V", AccessFlags = 1)]
				public virtual void SetSelectionAfterHeaderView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int keyCode, int repeatCount, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables or disables the drawing of the divider for header views.</para> <para> <para>setFooterDividersEnabled(boolean) </para> <para>areHeaderDividersEnabled() </para> <para>addHeaderView(android.view.View) </para></para>        
				/// </summary>
				/// <java-name>
				/// setHeaderDividersEnabled
				/// </java-name>
				[Dot42.DexImport("setHeaderDividersEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetHeaderDividersEnabled(bool headerDividersEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables or disables the drawing of the divider for footer views.</para> <para> <para>setHeaderDividersEnabled(boolean) </para> <para>areFooterDividersEnabled() </para> <para>addFooterView(android.view.View) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFooterDividersEnabled
				/// </java-name>
				[Dot42.DexImport("setFooterDividersEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetFooterDividersEnabled(bool footerDividersEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewTraversal
				/// </java-name>
				[Dot42.DexImport("findViewTraversal", "(I)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View FindViewTraversal(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// findViewWithTagTraversal
				/// </java-name>
				[Dot42.DexImport("findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View FindViewWithTagTraversal(object tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public override bool PerformItemClick(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setItemChecked
				/// </java-name>
				[Dot42.DexImport("setItemChecked", "(IZ)V", AccessFlags = 1)]
				public virtual void SetItemChecked(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isItemChecked
				/// </java-name>
				[Dot42.DexImport("isItemChecked", "(I)Z", AccessFlags = 1)]
				public virtual bool IsItemChecked(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearChoices
				/// </java-name>
				[Dot42.DexImport("clearChoices", "()V", AccessFlags = 1)]
				public virtual void ClearChoices() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum amount a list view will scroll in response to an arrow event. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHeaderViewsCount
				/// </java-name>
				public virtual int HeaderViewsCount
				{
						[Dot42.DexImport("getHeaderViewsCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFooterViewsCount
				/// </java-name>
				public virtual int FooterViewsCount
				{
						[Dot42.DexImport("getFooterViewsCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the adapter currently in use in this ListView. The returned adapter might not be the same adapter passed to setAdapter(ListAdapter) but might be a WrapperListAdapter.</para> <para> <para>setAdapter(ListAdapter) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The adapter currently used to display data in this ListView.</para>
				/// </returns>
				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal override bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the views created by the ListAdapter can contain focusable items. </para>
				/// </returns>
				/// <java-name>
				/// getItemsCanFocus
				/// </java-name>
				public virtual bool ItemsCanFocus
				{
						[Dot42.DexImport("getItemsCanFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setItemsCanFocus", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the drawable that will be drawn between each item in the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current drawable drawn between list elements </para>
				/// </returns>
				/// <java-name>
				/// getDivider
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Divider
				{
						[Dot42.DexImport("getDivider", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setDivider", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the height of the divider that will be drawn between each item in the list. </para>
				/// </returns>
				/// <java-name>
				/// getDividerHeight
				/// </java-name>
				public virtual int DividerHeight
				{
						[Dot42.DexImport("getDividerHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDividerHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The drawable that will be drawn above all other list content </para>
				/// </returns>
				/// <java-name>
				/// getOverscrollHeader
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable OverscrollHeader
				{
						[Dot42.DexImport("getOverscrollHeader", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setOverscrollHeader", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The drawable that will be drawn below all other list content </para>
				/// </returns>
				/// <java-name>
				/// getOverscrollFooter
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable OverscrollFooter
				{
						[Dot42.DexImport("getOverscrollFooter", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setOverscrollFooter", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getChoiceMode
				/// </java-name>
				public virtual int ChoiceMode
				{
						[Dot42.DexImport("getChoiceMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setChoiceMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCheckedItemPosition
				/// </java-name>
				public virtual int CheckedItemPosition
				{
						[Dot42.DexImport("getCheckedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCheckedItemPositions
				/// </java-name>
				public virtual global::Android.Util.SparseBooleanArray CheckedItemPositions
				{
						[Dot42.DexImport("getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;", AccessFlags = 1)]
						get{ return default(global::Android.Util.SparseBooleanArray); }
				}

				/// <summary>
				///  <para>Returns the set of checked items ids. The result is only valid if the choice mode has not been set to CHOICE_MODE_NONE.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getCheckedItemIds() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>A new array which contains the id of each checked item in the list.</para>
				/// </returns>
				/// <java-name>
				/// getCheckItemIds
				/// </java-name>
				public virtual long[] CheckItemIds
				{
						[Dot42.DexImport("getCheckItemIds", "()[J", AccessFlags = 1)]
						get{ return default(long[]); }
				}

				/// <java-name>
				/// getCheckedItemIds
				/// </java-name>
				public virtual long[] CheckedItemIds
				{
						[Dot42.DexImport("getCheckedItemIds", "()[J", AccessFlags = 1)]
						get{ return default(long[]); }
				}

				/// <java-name>
				/// setCacheColorHint
				/// </java-name>
				public override int CacheColorHint
				{
						[Dot42.DexImport("setCacheColorHint", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>A class that represents a fixed view in a list, for example a header at the top or a footer at the bottom. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ListView$FixedViewInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/ListView$FixedViewInfo", AccessFlags = 1)]
				public partial class FixedViewInfo
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The view to add to the list </para>        
						/// </summary>
						/// <java-name>
						/// view
						/// </java-name>
						[Dot42.DexImport("view", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View View;
						/// <summary>
						///  <para>The data backing the view. This is returned from ListAdapter#getItem(int). </para>        
						/// </summary>
						/// <java-name>
						/// data
						/// </java-name>
						[Dot42.DexImport("data", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Data;
						/// <summary>
						///  <para> <code>true</code> if the fixed view should be selectable in the list </para>        
						/// </summary>
						/// <java-name>
						/// isSelectable
						/// </java-name>
						[Dot42.DexImport("isSelectable", "Z", AccessFlags = 1)]
						public bool IsSelectable;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/widget/ListView;", AccessFlags = 4112)]
						internal readonly global::Android.Widget.ListView This_0;
						[Dot42.DexImport("<init>", "(Landroid/widget/ListView;)V", AccessFlags = 1)]
						public FixedViewInfo(global::Android.Widget.ListView listView) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal FixedViewInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A view containing controls for a MediaPlayer. Typically contains the buttons like "Play/Pause", "Rewind", "Fast Forward" and a progress slider. It takes care of synchronizing the controls with the state of the MediaPlayer. </para> <para>The way to use this class is to instantiate it programatically. The MediaController will create a default set of controls and put them in a window floating above your application. Specifically, the controls will float above the view specified with setAnchorView(). The window will disappear if left idle for three seconds and reappear when the user touches the anchor view. </para> <para>Functions like show() and hide() have no effect when MediaController is created in an xml layout.</para> <para>MediaController will hide and show the buttons according to these rules:  <ul> <li> <para>The "previous" and "next" buttons are hidden until setPrevNextListeners() has been called </para></li> <li> <para>The "previous" and "next" buttons are visible but disabled if setPrevNextListeners() was called with null listeners </para></li> <li> <para>The "rewind" and "fastforward" buttons are shown unless requested otherwise by using the MediaController(Context, boolean) constructor with the boolean set to false </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/MediaController
		/// </java-name>
		[Dot42.DexImport("android/widget/MediaController", AccessFlags = 33)]
		public partial class MediaController : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Z)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context, bool attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 1)]
				public new virtual void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMediaPlayer
				/// </java-name>
				[Dot42.DexImport("setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V", AccessFlags = 1)]
				public virtual void SetMediaPlayer(global::Android.Widget.MediaController.IMediaPlayerControl player) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the view that acts as the anchor for the control view. This can for example be a VideoView, or your Activity's main view. When VideoView calls this method, it will use the VideoView's parent as the anchor. </para>        
				/// </summary>
				/// <java-name>
				/// setAnchorView
				/// </java-name>
				[Dot42.DexImport("setAnchorView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetAnchorView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Show the controller on screen. It will go away automatically after 3 seconds of inactivity. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Show the controller on screen. It will go away automatically after 'timeout' milliseconds of inactivity. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(I)V", AccessFlags = 1)]
				public virtual void Show(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove the controller from the screen. </para>        
				/// </summary>
				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPrevNextListeners
				/// </java-name>
				[Dot42.DexImport("setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetPrevNextListeners(global::Android.Views.View.IOnClickListener next, global::Android.Views.View.IOnClickListener prev) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal MediaController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/MediaController$MediaPlayerControl
				/// </java-name>
				[Dot42.DexImport("android/widget/MediaController$MediaPlayerControl", AccessFlags = 1545)]
				public partial interface IMediaPlayerControl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// start
						/// </java-name>
						[Dot42.DexImport("start", "()V", AccessFlags = 1025)]
						void Start() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// pause
						/// </java-name>
						[Dot42.DexImport("pause", "()V", AccessFlags = 1025)]
						void Pause() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// seekTo
						/// </java-name>
						[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 1025)]
						void SeekTo(int pos) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getDuration
						/// </java-name>
						int Duration
						{
								[Dot42.DexImport("getDuration", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getCurrentPosition
						/// </java-name>
						int CurrentPosition
						{
								[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// isPlaying
						/// </java-name>
						bool IsPlaying
						{
								[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getBufferPercentage
						/// </java-name>
						int BufferPercentage
						{
								[Dot42.DexImport("getBufferPercentage", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canPause
						/// </java-name>
						bool CanPause
						{
								[Dot42.DexImport("canPause", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canSeekBackward
						/// </java-name>
						bool CanSeekBackward
						{
								[Dot42.DexImport("canSeekBackward", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canSeekForward
						/// </java-name>
						bool CanSeekForward
						{
								[Dot42.DexImport("canSeekForward", "()Z", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <summary>
		///  <para>An editable text view, extending AutoCompleteTextView, that can show completion suggestions for the substring of the text where the user is typing instead of necessarily for the entire thing. </para> <para>You must provide a Tokenizer to distinguish the various substrings.</para> <para>The following code snippet shows how to create a text view which suggests various countries names while the user is typing:</para> <para> <pre>
		/// public class CountriesActivity extends Activity {
		///     protected void onCreate(Bundle savedInstanceState) {
		///         super.onCreate(savedInstanceState);
		///         setContentView(R.layout.autocomplete_7);</pre></para> <para> <pre>        ArrayAdapter&lt;String&gt; adapter = new ArrayAdapter&lt;String&gt;(this,
		///                 android.R.layout.simple_dropdown_item_1line, COUNTRIES);
		///         MultiAutoCompleteTextView textView = (MultiAutoCompleteTextView) findViewById(R.id.edit);
		///         textView.setAdapter(adapter);
		///         textView.setTokenizer(new MultiAutoCompleteTextView.CommaTokenizer());
		///     }</pre></para> <para> <pre>    private static final String[] COUNTRIES = new String[] {
		///         "Belgium", "France", "Italy", "Germany", "Spain"
		///     };
		/// }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/MultiAutoCompleteTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/MultiAutoCompleteTextView", AccessFlags = 33)]
		public partial class MultiAutoCompleteTextView : global::Android.Widget.AutoCompleteTextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the Tokenizer that will be used to determine the relevant range of the text where the user is typing. </para>        
				/// </summary>
				/// <java-name>
				/// setTokenizer
				/// </java-name>
				[Dot42.DexImport("setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V", AccessFlags = 1)]
				public virtual void SetTokenizer(global::Android.Widget.MultiAutoCompleteTextView.ITokenizer t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Instead of filtering on the entire contents of the edit box, this subclass method filters on the range from Tokenizer#findTokenStart to getSelectionEnd if the length of that range meets or exceeds getThreshold. </para>        
				/// </summary>
				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;I)V", AccessFlags = 4)]
				protected internal override void PerformFiltering(global::Java.Lang.ICharSequence text, int keyCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Instead of filtering whenever the total length of the text exceeds the threshhold, this subclass filters only when the length of the range from Tokenizer#findTokenStart to getSelectionEnd meets or exceeds getThreshold. </para>        
				/// </summary>
				/// <java-name>
				/// enoughToFilter
				/// </java-name>
				[Dot42.DexImport("enoughToFilter", "()Z", AccessFlags = 1)]
				public override bool EnoughToFilter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Instead of validating the entire text, this subclass method validates each token of the text individually. Empty tokens are removed. </para>        
				/// </summary>
				/// <java-name>
				/// performValidation
				/// </java-name>
				[Dot42.DexImport("performValidation", "()V", AccessFlags = 1)]
				public override void PerformValidation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Starts filtering the content of the drop down list. The filtering pattern is the specified range of text from the edit box. Subclasses may override this method to filter with a different pattern, for instance a smaller substring of  <code>text</code>.</para>        
				/// </summary>
				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;III)V", AccessFlags = 4)]
				protected internal virtual void PerformFiltering(global::Java.Lang.ICharSequence text, int start, int end, int keyCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the text completion by replacing the range from Tokenizer#findTokenStart to getSelectionEnd by the the result of passing  <code>text</code> through Tokenizer#terminateToken. In addition, the replaced region will be marked as an AutoText substition so that if the user immediately presses DEL, the completion will be undone. Subclasses may override this method to do some different insertion of the content into the edit box.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// replaceText
				/// </java-name>
				[Dot42.DexImport("replaceText", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal override void ReplaceText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal MultiAutoCompleteTextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>This simple Tokenizer can be used for lists where the items are separated by a comma and one or more spaces. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/MultiAutoCompleteTextView$CommaTokenizer
				/// </java-name>
				[Dot42.DexImport("android/widget/MultiAutoCompleteTextView$CommaTokenizer", AccessFlags = 9)]
				public partial class CommaTokenizer : global::Android.Widget.MultiAutoCompleteTextView.ITokenizer
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CommaTokenizer() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Returns the start of the token that ends at offset  <code>cursor</code> within  <code>text</code>. </para>        
						/// </summary>
						/// <java-name>
						/// findTokenStart
						/// </java-name>
						[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
						public virtual int FindTokenStart(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Returns the end of the token (minus trailing punctuation) that begins at offset  <code>cursor</code> within  <code>text</code>. </para>        
						/// </summary>
						/// <java-name>
						/// findTokenEnd
						/// </java-name>
						[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
						public virtual int FindTokenEnd(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Returns  <code>text</code>, modified, if necessary, to ensure that it ends with a token terminator (for example a space or comma). </para>        
						/// </summary>
						/// <java-name>
						/// terminateToken
						/// </java-name>
						[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public virtual global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <java-name>
				/// android/widget/MultiAutoCompleteTextView$Tokenizer
				/// </java-name>
				[Dot42.DexImport("android/widget/MultiAutoCompleteTextView$Tokenizer", AccessFlags = 1545)]
				public partial interface ITokenizer
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Returns the start of the token that ends at offset  <code>cursor</code> within  <code>text</code>. </para>        
						/// </summary>
						/// <java-name>
						/// findTokenStart
						/// </java-name>
						[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1025)]
						int FindTokenStart(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Returns the end of the token (minus trailing punctuation) that begins at offset  <code>cursor</code> within  <code>text</code>. </para>        
						/// </summary>
						/// <java-name>
						/// findTokenEnd
						/// </java-name>
						[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1025)]
						int FindTokenEnd(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Returns  <code>text</code>, modified, if necessary, to ensure that it ends with a token terminator (for example a space or comma). </para>        
						/// </summary>
						/// <java-name>
						/// terminateToken
						/// </java-name>
						[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>This class encapsulates scrolling with the ability to overshoot the bounds of a scrolling operation. This class is a drop-in replacement for android.widget.Scroller in most cases. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/OverScroller
		/// </java-name>
		[Dot42.DexImport("android/widget/OverScroller", AccessFlags = 33)]
		public partial class OverScroller
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an OverScroller with a viscous fluid scroll interpolator and flywheel. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an OverScroller with flywheel enabled. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an OverScroller with flywheel enabled. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;FF)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator, float bounceCoefficientX, float bounceCoefficientY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force the finished field to a particular value. Contrary to abortAnimation(), forcing the animation to finished does NOT cause the scroller to move to the final x and y position.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forceFinished
				/// </java-name>
				[Dot42.DexImport("forceFinished", "(Z)V", AccessFlags = 17)]
				public void ForceFinished(bool finished) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this when you want to know the new location. If it returns true, the animation is not yet finished. </para>        
				/// </summary>
				/// <java-name>
				/// computeScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeScrollOffset", "()Z", AccessFlags = 1)]
				public virtual bool ComputeScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Start scrolling by providing a starting point and the distance to travel. The scroll will use the default value of 250 milliseconds for the duration.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int startX, int startY, int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start scrolling by providing a starting point and the distance to travel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int startX, int startY, int dx, int dy, int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this when you want to 'spring back' into a valid coordinate range.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a springback was initiated, false if startX and startY were already within the valid range. </para>
				/// </returns>
				/// <java-name>
				/// springBack
				/// </java-name>
				[Dot42.DexImport("springBack", "(IIIIII)Z", AccessFlags = 1)]
				public virtual bool SpringBack(int startX, int startY, int minX, int maxX, int minY, int maxY) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int startX, int startY, int velocityX, int velocityY, int minX, int maxX, int minY, int maxY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start scrolling based on a fling gesture. The distance traveled will depend on the initial velocity of the fling.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int startX, int startY, int velocityX, int velocityY, int minX, int maxX, int minY, int maxY, int overX, int overY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notify the scroller that we've reached a horizontal boundary. Normally the information to handle this will already be known when the animation is started, such as in a call to one of the fling functions. However there are cases where this cannot be known in advance. This function will transition the current motion and animate from startX to finalX as appropriate.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyHorizontalEdgeReached
				/// </java-name>
				[Dot42.DexImport("notifyHorizontalEdgeReached", "(III)V", AccessFlags = 1)]
				public virtual void NotifyHorizontalEdgeReached(int startX, int finalX, int overX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notify the scroller that we've reached a vertical boundary. Normally the information to handle this will already be known when the animation is started, such as in a call to one of the fling functions. However there are cases where this cannot be known in advance. This function will animate a parabolic motion from startY to finalY.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyVerticalEdgeReached
				/// </java-name>
				[Dot42.DexImport("notifyVerticalEdgeReached", "(III)V", AccessFlags = 1)]
				public virtual void NotifyVerticalEdgeReached(int startY, int finalY, int overY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops the animation. Contrary to forceFinished(boolean), aborting the animating causes the scroller to move to the final x and y positions.</para> <para> <para>forceFinished(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// abortAnimation
				/// </java-name>
				[Dot42.DexImport("abortAnimation", "()V", AccessFlags = 1)]
				public virtual void AbortAnimation() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal OverScroller() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the scroller has finished scrolling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the scroller has finished scrolling, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFinished
				/// </java-name>
				public bool IsFinished
				{
						[Dot42.DexImport("isFinished", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current X offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getCurrX
				/// </java-name>
				public int CurrX
				{
						[Dot42.DexImport("getCurrX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current Y offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getCurrY
				/// </java-name>
				public int CurrY
				{
						[Dot42.DexImport("getCurrY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the start X offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The start X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getStartX
				/// </java-name>
				public int StartX
				{
						[Dot42.DexImport("getStartX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the start Y offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The start Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getStartY
				/// </java-name>
				public int StartY
				{
						[Dot42.DexImport("getStartY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns where the scroll will end. Valid only for "fling" scrolls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The final X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getFinalX
				/// </java-name>
				public int FinalX
				{
						[Dot42.DexImport("getFinalX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns where the scroll will end. Valid only for "fling" scrolls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The final Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getFinalY
				/// </java-name>
				public int FinalY
				{
						[Dot42.DexImport("getFinalY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns whether the current Scroller is currently returning to a valid position. Valid bounds were provided by the fling(int, int, int, int, int, int, int, int, int, int) method.</para> <para>One should check this value before calling startScroll(int, int, int, int) as the interpolation currently in progress to restore a valid position will then be stopped. The caller has to take into account the fact that the started scroll will start from an overscrolled position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true when the current position is overscrolled and in the process of interpolating back to a valid value. </para>
				/// </returns>
				/// <java-name>
				/// isOverScrolled
				/// </java-name>
				public virtual bool IsOverScrolled
				{
						[Dot42.DexImport("isOverScrolled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A popup window that can be used to display an arbitrary view. The popup window is a floating container that appears on top of the current activity.</para> <para> <para>android.widget.AutoCompleteTextView </para> <para>android.widget.Spinner </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/PopupWindow
		/// </java-name>
		[Dot42.DexImport("android/widget/PopupWindow", AccessFlags = 33)]
		public partial class PopupWindow
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Mode for setInputMethodMode(int): the requirements for the input method should be based on the focusability of the popup. That is if it is focusable than it needs to work with the input method, else it doesn't. </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_FROM_FOCUSABLE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_FROM_FOCUSABLE", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_FROM_FOCUSABLE = 0;
				/// <summary>
				///  <para>Mode for setInputMethodMode(int): this popup always needs to work with an input method, regardless of whether it is focusable. This means that it will always be displayed so that the user can also operate the input method while it is shown. </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NEEDED = 1;
				/// <summary>
				///  <para>Mode for setInputMethodMode(int): this popup never needs to work with an input method, regardless of whether it is focusable. This means that it will always be displayed to use as much space on the screen as needed, regardless of whether this covers the input method. </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_NOT_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NOT_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NOT_NEEDED = 2;
				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does not provide any background. This should be handled by the content view.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PopupWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/View;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PopupWindow(int context, int attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new empty, non focusable popup window of dimension (0,0).</para> <para>The popup does provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View context, int attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new, empty, non focusable popup window of dimension (0,0).</para> <para>The popup does not provide a background.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/View;IIZ)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View context, int attrs, int defStyleAttr, bool defStyleRes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the background drawable for this popup window. The background can be set to null.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable background) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the flag on popup to ignore cheek press eventt; by default this flag is set to false which means the pop wont ignore cheek press dispatch events.</para> <para>If the popup is showing, calling this method will take effect only the next time the popup is shown or through a manual call to one of the update() methods.</para> <para> <para>update() </para></para>        
				/// </summary>
				/// <java-name>
				/// setIgnoreCheekPress
				/// </java-name>
				[Dot42.DexImport("setIgnoreCheekPress", "()V", AccessFlags = 1)]
				public virtual void SetIgnoreCheekPress() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a callback for all touch events being dispatched to the popup window. </para>        
				/// </summary>
				/// <java-name>
				/// setTouchInterceptor
				/// </java-name>
				[Dot42.DexImport("setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V", AccessFlags = 1)]
				public virtual void SetTouchInterceptor(global::Android.Views.View.IOnTouchListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the width and height measure specs that are given to the window manager by the popup. By default these are 0, meaning that the current width or height is requested as an explicit size from the window manager. You can supply ViewGroup.LayoutParams#WRAP_CONTENT or ViewGroup.LayoutParams#MATCH_PARENT to have that measure spec supplied instead, replacing the absolute width and height that has been set in the popup.</para> <para>If the popup is showing, calling this method will take effect only the next time the popup is shown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWindowLayoutMode
				/// </java-name>
				[Dot42.DexImport("setWindowLayoutMode", "(II)V", AccessFlags = 1)]
				public virtual void SetWindowLayoutMode(int widthSpec, int heightSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Display the content view in a popup window at the specified location. If the popup window cannot fit on screen, it will be clipped. See android.view.WindowManager.LayoutParams for more information on how gravity and the x and y parameters are related. Specifying a gravity of android.view.Gravity#NO_GRAVITY is similar to specifying  <code>Gravity.LEFT | Gravity.TOP</code>. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// showAtLocation
				/// </java-name>
				[Dot42.DexImport("showAtLocation", "(Landroid/view/View;III)V", AccessFlags = 1)]
				public virtual void ShowAtLocation(global::Android.Views.View parent, int gravity, int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Display the content view in a popup window anchored to the bottom-left corner of the anchor view. If there is not enough room on screen to show the popup in its entirety, this method tries to find a parent scroll view to scroll. If no parent scroll view can be scrolled, the bottom-left corner of the popup is pinned at the top left corner of the anchor view.</para> <para> <para>dismiss() </para></para>        
				/// </summary>
				/// <java-name>
				/// showAsDropDown
				/// </java-name>
				[Dot42.DexImport("showAsDropDown", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ShowAsDropDown(global::Android.Views.View anchor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Display the content view in a popup window anchored to the bottom-left corner of the anchor view offset by the specified x and y coordinates. If there is not enough room on screen to show the popup in its entirety, this method tries to find a parent scroll view to scroll. If no parent scroll view can be scrolled, the bottom-left corner of the popup is pinned at the top left corner of the anchor view.</para> <para>If the view later scrolls to move  <code>anchor</code> to a different location, the popup will be moved correspondingly.</para> <para> <para>dismiss() </para></para>        
				/// </summary>
				/// <java-name>
				/// showAsDropDown
				/// </java-name>
				[Dot42.DexImport("showAsDropDown", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void ShowAsDropDown(global::Android.Views.View anchor, int xoff, int yoff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the maximum height that is available for the popup to be completely shown. It is recommended that this height be the maximum for the popup's height, otherwise it is possible that the popup will be clipped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum available height for the popup to be completely shown. </para>
				/// </returns>
				/// <java-name>
				/// getMaxAvailableHeight
				/// </java-name>
				[Dot42.DexImport("getMaxAvailableHeight", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int GetMaxAvailableHeight(global::Android.Views.View anchor) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the maximum height that is available for the popup to be completely shown. It is recommended that this height be the maximum for the popup's height, otherwise it is possible that the popup will be clipped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum available height for the popup to be completely shown. </para>
				/// </returns>
				/// <java-name>
				/// getMaxAvailableHeight
				/// </java-name>
				[Dot42.DexImport("getMaxAvailableHeight", "(Landroid/view/View;I)I", AccessFlags = 1)]
				public virtual int GetMaxAvailableHeight(global::Android.Views.View anchor, int yOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Dispose of the popup window. This method can be invoked only after showAsDropDown(android.view.View) has been executed. Failing that, calling this method will have no effect.</para> <para> <para>showAsDropDown(android.view.View) </para></para>        
				/// </summary>
				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener to be called when the window is dismissed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Widget.PopupWindow.IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the state of the popup window, if it is currently being displayed, from the currently set state. This include: setClippingEnabled(boolean), setFocusable(boolean), setIgnoreCheekPress(), setInputMethodMode(int), setTouchable(boolean), and setAnimationStyle(int). </para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "()V", AccessFlags = 1)]
				public virtual void Update() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the dimension of the popup window. Calling this function also updates the window with the current popup state as described for update().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(II)V", AccessFlags = 1)]
				public virtual void Update(int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the position and the dimension of the popup window. Width and height can be set to -1 to update location only. Calling this function also updates the window with the current popup state as described for update().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(IIII)V", AccessFlags = 1)]
				public virtual void Update(int x, int y, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the position and the dimension of the popup window. Width and height can be set to -1 to update location only. Calling this function also updates the window with the current popup state as described for update().</para> <para>If the view later scrolls to move  <code>anchor</code> to a different location, the popup will be moved correspondingly.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void Update(int anchor, int xoff, int yoff, int width, bool height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the position and the dimension of the popup window. Calling this function also updates the window with the current popup state as described for update().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void Update(global::Android.Views.View anchor, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the position and the dimension of the popup window. Width and height can be set to -1 to update location only. Calling this function also updates the window with the current popup state as described for update().</para> <para>If the view later scrolls to move  <code>anchor</code> to a different location, the popup will be moved correspondingly.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public virtual void Update(global::Android.Views.View anchor, int xoff, int yoff, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the drawable used as the popup window's background.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the background drawable or null </para>
				/// </returns>
				/// <java-name>
				/// getBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Background
				{
						[Dot42.DexImport("getBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>Return the animation style to use the popup appears and disappears</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the animation style to use the popup appears and disappears </para>
				/// </returns>
				/// <java-name>
				/// getAnimationStyle
				/// </java-name>
				public virtual int AnimationStyle
				{
						[Dot42.DexImport("getAnimationStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAnimationStyle", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the view used as the content of the popup window.</para> <para> <para>setContentView(android.view.View) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View representing the popup's content</para>
				/// </returns>
				/// <java-name>
				/// getContentView
				/// </java-name>
				public virtual global::Android.Views.View ContentView
				{
						[Dot42.DexImport("getContentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicate whether the popup window can grab the focus.</para> <para> <para>setFocusable(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the popup is focusable, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isFocusable
				/// </java-name>
				public virtual bool IsFocusable
				{
						[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the current value in setInputMethodMode(int).</para> <para> <para>setInputMethodMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getInputMethodMode
				/// </java-name>
				public virtual int InputMethodMode
				{
						[Dot42.DexImport("getInputMethodMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInputMethodMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current value in setSoftInputMode(int).</para> <para> <para>setSoftInputMode(int) </para> <para>android.view.WindowManager.LayoutParams::softInputMode </para></para>        
				/// </summary>
				/// <java-name>
				/// getSoftInputMode
				/// </java-name>
				public virtual int SoftInputMode
				{
						[Dot42.DexImport("getSoftInputMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSoftInputMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether the popup window receives touch events.</para> <para> <para>setTouchable(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the popup is touchable, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isTouchable
				/// </java-name>
				public virtual bool IsTouchable
				{
						[Dot42.DexImport("isTouchable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setTouchable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether the popup window will be informed of touch events outside of its window.</para> <para> <para>setOutsideTouchable(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the popup is outside touchable, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isOutsideTouchable
				/// </java-name>
				public virtual bool IsOutsideTouchable
				{
						[Dot42.DexImport("isOutsideTouchable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setOutsideTouchable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether clipping of the popup window is enabled.</para> <para> <para>setClippingEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the clipping is enabled, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isClippingEnabled
				/// </java-name>
				public virtual bool IsClippingEnabled
				{
						[Dot42.DexImport("isClippingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setClippingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return this popup's height MeasureSpec</para> <para> <para>setHeight(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the height MeasureSpec of the popup</para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return this popup's width MeasureSpec</para> <para> <para>setWidth(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the width MeasureSpec of the popup</para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setWidth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicate whether this popup window is showing on screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the popup is showing, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the popup is showing above (the y coordinate of the popup's bottom is less than the y coordinate of the anchor) or below the anchor view (the y coordinate of the popup is greater than y coordinate of the anchor's bottom).</para> <para>The value returned by this method is meaningful only after showAsDropDown(android.view.View) or showAsDropDown(android.view.View, int, int) was invoked.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this popup is showing above the anchor view, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAboveAnchor
				/// </java-name>
				public virtual bool IsAboveAnchor
				{
						[Dot42.DexImport("isAboveAnchor", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Listener that is called when this popup window is dismissed. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/PopupWindow$OnDismissListener
				/// </java-name>
				[Dot42.DexImport("android/widget/PopupWindow$OnDismissListener", AccessFlags = 1545)]
				public partial interface IOnDismissListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when this popup window is dismissed. </para>        
						/// </summary>
						/// <java-name>
						/// onDismiss
						/// </java-name>
						[Dot42.DexImport("onDismiss", "()V", AccessFlags = 1025)]
						void OnDismiss() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Visual indicator of progress in some operation. Displays a bar to the user representing how far the operation has progressed; the application can change the amount of progress (modifying the length of the bar) as it moves forward. There is also a secondary progress displayable on a progress bar which is useful for displaying intermediate progress, such as the buffer level during a streaming playback progress bar. </para> <para>A progress bar can also be made indeterminate. In indeterminate mode, the progress bar shows a cyclic animation without an indication of progress. This mode is used by applications when the length of the task is unknown. The indeterminate progress bar can be either a spinning wheel or a horizontal bar. </para> <para>The following code example shows how a progress bar can be used from a worker thread to update the user interface to notify the user of progress: </para> <para> <pre>
		/// public class MyActivity extends Activity {
		///     private static final int PROGRESS = 0x1;</pre></para> <para> <pre>    private ProgressBar mProgress;
		///     private int mProgressStatus = 0;</pre></para> <para> <pre>    private Handler mHandler = new Handler();</pre></para> <para> <pre>    protected void onCreate(Bundle icicle) {
		///         super.onCreate(icicle);</pre></para> <para> <pre>        setContentView(R.layout.progressbar_activity);</pre></para> <para> <pre>        mProgress = (ProgressBar) findViewById(R.id.progress_bar);</pre></para> <para> <pre>        // Start lengthy operation in a background thread
		///         new Thread(new Runnable() {
		///             public void run() {
		///                 while (mProgressStatus &lt; 100) {
		///                     mProgressStatus = doWork();</pre></para> <para> <pre>                    // Update the progress bar
		///                     mHandler.post(new Runnable() {
		///                         public void run() {
		///                             mProgress.setProgress(mProgressStatus);
		///                         }
		///                     });
		///                 }
		///             }
		///         }).start();
		///     }
		/// }</pre></para> <para>To add a progress bar to a layout file, you can use the <c>&amp;lt;ProgressBar&amp;gt; </c> element. By default, the progress bar is a spinning wheel (an indeterminate indicator). To change to a horizontal progress bar, apply the Widget.ProgressBar.Horizontal style, like so:</para> <para> <pre>
		/// &lt;ProgressBar
		///     style="@android:style/Widget.ProgressBar.Horizontal"
		///     ... /&gt;</pre></para> <para>If you will use the progress bar to show real progress, you must use the horizontal bar. You can then increment the progress with incrementProgressBy() or setProgress(). By default, the progress bar is full when it reaches 100. If necessary, you can adjust the maximum value (the value for a full bar) using the android:max attribute. Other attributes available are listed below.</para> <para>Another common style to apply to the progress bar is Widget.ProgressBar.Small, which shows a smaller version of the spinning wheeluseful when waiting for content to load. For example, you can insert this kind of progress bar into your default layout for a view that will be populated by some content fetched from the Internetthe spinning wheel appears immediately and when your application receives the content, it replaces the progress bar with the loaded content. For example:</para> <para> <pre>
		/// &lt;LinearLayout
		///     android:orientation="horizontal"
		///     ... &gt;
		///     &lt;ProgressBar
		///         android:layout_width="wrap_content"
		///         android:layout_height="wrap_content"
		///         style="@android:style/Widget.ProgressBar.Small"
		///         android:layout_marginRight="5dp" /&gt;
		///     &lt;TextView
		///         android:layout_width="wrap_content"
		///         android:layout_height="wrap_content"
		///         android:text="@string/loading" /&gt;
		/// &lt;/LinearLayout&gt;</pre></para> <para>Other progress bar styles provided by the system include:</para> <para> <ul> <li> <para>Widget.ProgressBar.Horizontal </para></li> <li> <para>Widget.ProgressBar.Small </para></li> <li> <para>Widget.ProgressBar.Large </para></li> <li> <para>Widget.ProgressBar.Inverse </para></li> <li> <para>Widget.ProgressBar.Small.Inverse </para></li> <li> <para>Widget.ProgressBar.Large.Inverse </para></li></ul></para> <para>The "inverse" styles provide an inverse color scheme for the spinner, which may be necessary if your application uses a light colored theme (a white background).</para> <para> <b>XML attributes</b> </para> <para>See ProgressBar Attributes, View Attributes </para> <para>ref android.R.styleable::ProgressBar_animationResolution  ref android.R.styleable::ProgressBar_indeterminate  ref android.R.styleable::ProgressBar_indeterminateBehavior  ref android.R.styleable::ProgressBar_indeterminateDrawable  ref android.R.styleable::ProgressBar_indeterminateDuration  ref android.R.styleable::ProgressBar_indeterminateOnly  ref android.R.styleable::ProgressBar_interpolator  ref android.R.styleable::ProgressBar_max  ref android.R.styleable::ProgressBar_maxHeight  ref android.R.styleable::ProgressBar_maxWidth  ref android.R.styleable::ProgressBar_minHeight  ref android.R.styleable::ProgressBar_minWidth  ref android.R.styleable::ProgressBar_mirrorForRtl  ref android.R.styleable::ProgressBar_progress  ref android.R.styleable::ProgressBar_progressDrawable  ref android.R.styleable::ProgressBar_secondaryProgress </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ProgressBar
		/// </java-name>
		[Dot42.DexImport("android/widget/ProgressBar", AccessFlags = 33)]
		public partial class ProgressBar : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new progress bar with range 0...100 and initial progress of 0. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "()V", AccessFlags = 1)]
				public override void PostInvalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Increase the progress bar's progress by the specified amount.</para> <para> <para>setProgress(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// incrementProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementProgressBy", "(I)V", AccessFlags = 49)]
				public void IncrementProgressBy(int diff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Increase the progress bar's secondary progress by the specified amount.</para> <para> <para>setSecondaryProgress(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// incrementSecondaryProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementSecondaryProgressBy", "(I)V", AccessFlags = 49)]
				public void IncrementSecondaryProgressBy(int diff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the acceleration curve for the indeterminate animation. The interpolator is loaded as a resource from the specified context.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int resID) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.Views.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 36)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ProgressBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicate whether this progress bar is in indeterminate mode.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the progress bar is in indeterminate mode </para>
				/// </returns>
				/// <java-name>
				/// isIndeterminate
				/// </java-name>
				public virtual bool IsIndeterminate
				{
						[Dot42.DexImport("isIndeterminate", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
						[Dot42.DexImport("setIndeterminate", "(Z)V", AccessFlags = 33)]
						set{ }
				}

				/// <summary>
				///  <para>Get the drawable used to draw the progress bar in indeterminate mode.</para> <para> <para>setIndeterminateDrawable(android.graphics.drawable.Drawable) </para> <para>setIndeterminate(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.graphics.drawable.Drawable instance</para>
				/// </returns>
				/// <java-name>
				/// getIndeterminateDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable IndeterminateDrawable
				{
						[Dot42.DexImport("getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the drawable used to draw the progress bar in progress mode.</para> <para> <para>setProgressDrawable(android.graphics.drawable.Drawable) </para> <para>setIndeterminate(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.graphics.drawable.Drawable instance</para>
				/// </returns>
				/// <java-name>
				/// getProgressDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable ProgressDrawable
				{
						[Dot42.DexImport("getProgressDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the progress bar's current level of progress. Return 0 when the progress bar is in indeterminate mode.</para> <para> <para>setIndeterminate(boolean) </para> <para>isIndeterminate() </para> <para>setProgress(int) </para> <para>setMax(int) </para> <para>getMax() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current progress, between 0 and getMax()</para>
				/// </returns>
				/// <java-name>
				/// getProgress
				/// </java-name>
				public virtual int Progress
				{
						[Dot42.DexImport("getProgress", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setProgress", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <summary>
				///  <para>Get the progress bar's current level of secondary progress. Return 0 when the progress bar is in indeterminate mode.</para> <para> <para>setIndeterminate(boolean) </para> <para>isIndeterminate() </para> <para>setSecondaryProgress(int) </para> <para>setMax(int) </para> <para>getMax() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current secondary progress, between 0 and getMax()</para>
				/// </returns>
				/// <java-name>
				/// getSecondaryProgress
				/// </java-name>
				public virtual int SecondaryProgress
				{
						[Dot42.DexImport("getSecondaryProgress", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setSecondaryProgress", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <summary>
				///  <para>Return the upper limit of this progress bar's range.</para> <para> <para>setMax(int) </para> <para>getProgress() </para> <para>getSecondaryProgress() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a positive integer</para>
				/// </returns>
				/// <java-name>
				/// getMax
				/// </java-name>
				public virtual int Max
				{
						[Dot42.DexImport("getMax", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the acceleration curve type for the indeterminate animation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Interpolator associated to this animation </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Views.Animations.IInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.IInterpolator); }
						[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setVisibility
				/// </java-name>
				public override int Visibility
				{
						[Dot42.DexImport("setVisibility", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Widget used to show an image with the standard QuickContact badge and on-click behavior. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/QuickContactBadge
		/// </java-name>
		[Dot42.DexImport("android/widget/QuickContactBadge", AccessFlags = 33)]
		public partial class QuickContactBadge : global::Android.Widget.ImageView, global::Android.Views.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mExcludeMimes
				/// </java-name>
				[Dot42.DexImport("mExcludeMimes", "[Ljava/lang/String;", AccessFlags = 4)]
				protected internal string[] MExcludeMimes;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This call has no effect anymore, as there is only one QuickContact mode </para>        
				/// </summary>
				/// <java-name>
				/// setMode
				/// </java-name>
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
				public virtual void SetMode(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign the contact uri that this QuickContactBadge should be associated with. Note that this is only used for displaying the QuickContact window and won't bind the contact's photo for you. Call setImageDrawable(Drawable) to set the photo.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assignContactUri
				/// </java-name>
				[Dot42.DexImport("assignContactUri", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void AssignContactUri(global::Android.Net.Uri contactUri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign a contact based on an email address. This should only be used when the contact's URI is not available, as an extra query will have to be performed to lookup the URI based on the email.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assignContactFromEmail
				/// </java-name>
				[Dot42.DexImport("assignContactFromEmail", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void AssignContactFromEmail(string emailAddress, bool lazyLookup) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign a contact based on a phone number. This should only be used when the contact's URI is not available, as an extra query will have to be performed to lookup the URI based on the phone number.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// assignContactFromPhone
				/// </java-name>
				[Dot42.DexImport("assignContactFromPhone", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void AssignContactFromPhone(string phoneNumber, bool lazyLookup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a list of specific MIME-types to exclude and not display. For example, this can be used to hide the Contacts#CONTENT_ITEM_TYPE profile icon. </para>        
				/// </summary>
				/// <java-name>
				/// setExcludeMimes
				/// </java-name>
				[Dot42.DexImport("setExcludeMimes", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetExcludeMimes(string[] excludeMimes) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal QuickContactBadge() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A radio button is a two-states button that can be either checked or unchecked. When the radio button is unchecked, the user can press or click it to check it. However, contrary to a android.widget.CheckBox, a radio button cannot be unchecked by the user once checked. </para> <para>Radio buttons are normally used together in a android.widget.RadioGroup. When several radio buttons live inside a radio group, checking one radio button unchecks all the others.</para> <para>See the  guide.</para> <para> <b>XML attributes</b></para> <para>See CompoundButton Attributes, Button Attributes, TextView Attributes, View Attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/RadioButton
		/// </java-name>
		[Dot42.DexImport("android/widget/RadioButton", AccessFlags = 33)]
		public partial class RadioButton : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Change the checked state of the view to the inverse of its current state</para> </para> <para>If the radio button is already checked, this method will not toggle the radio button. </para>        
				/// </summary>
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public override void Toggle() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RadioButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This class is used to create a multiple-exclusion scope for a set of radio buttons. Checking one radio button that belongs to a radio group unchecks any previously checked radio button within the same group.</para> <para>Intially, all of the radio buttons are unchecked. While it is not possible to uncheck a particular radio button, the radio group can be cleared to remove the checked state.</para> <para>The selection is identified by the unique id of the radio button as defined in the XML layout file.</para> <para> <b>XML Attributes</b></para> <para>See RadioGroup Attributes, LinearLayout Attributes, ViewGroup Attributes, View Attributes</para> <para>Also see LinearLayout.LayoutParams for layout attributes.</para> <para> <para>RadioButton </para></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/RadioGroup
		/// </java-name>
		[Dot42.DexImport("android/widget/RadioGroup", AccessFlags = 33)]
		public partial class RadioGroup : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RadioGroup(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RadioGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the selection to the radio button whose identifier is passed in parameter. Using -1 as the selection identifier clears the selection; such an operation is equivalent to invoking clearCheck().</para> <para> <para>getCheckedRadioButtonId() </para> <para>clearCheck() </para></para>        
				/// </summary>
				/// <java-name>
				/// check
				/// </java-name>
				[Dot42.DexImport("check", "(I)V", AccessFlags = 1)]
				public virtual void Check(int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clears the selection. When the selection is cleared, no radio button in this group is selected and getCheckedRadioButtonId() returns null.</para> <para> <para>check(int) </para> <para>getCheckedRadioButtonId() </para></para>        
				/// </summary>
				/// <java-name>
				/// clearCheck
				/// </java-name>
				[Dot42.DexImport("clearCheck", "()V", AccessFlags = 1)]
				public virtual void ClearCheck() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the checked radio button changes in this group.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnCheckedChangeListener(global::Android.Widget.RadioGroup.IOnCheckedChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.RadioGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RadioGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RadioGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the identifier of the selected radio button in this group. Upon empty selection, the returned value is -1.</para> <para> <para>check(int) </para> <para>clearCheck()</para>ref android.R.styleable::RadioGroup_checkedButton </para>        
				/// </summary>
				/// <returns>
				///  <para>the unique id of the selected radio button in this group</para>
				/// </returns>
				/// <java-name>
				/// getCheckedRadioButtonId
				/// </java-name>
				public virtual int CheckedRadioButtonId
				{
						[Dot42.DexImport("getCheckedRadioButtonId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the checked radio button changed in this group.</para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RadioGroup$OnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/RadioGroup$OnCheckedChangeListener", AccessFlags = 1545)]
				public partial interface IOnCheckedChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the checked radio button has changed. When the selection is cleared, checkedId is -1.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCheckedChanged
						/// </java-name>
						[Dot42.DexImport("onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", AccessFlags = 1025)]
						void OnCheckedChanged(global::Android.Widget.RadioGroup group, int checkedId) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>This set of layout parameters defaults the width and the height of the children to WRAP_CONTENT when they are not specified in the XML file. Otherwise, this class ussed the value read from the XML file.</para> <para>See LinearLayout Attributes for a list of all child view attributes that this class supports.</para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RadioGroup$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/RadioGroup$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Fixes the child's width to android.view.ViewGroup.LayoutParams#WRAP_CONTENT and the child's height to android.view.ViewGroup.LayoutParams#WRAP_CONTENT when not specified in the XML file.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray a, int widthAttr, int heightAttr) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A RatingBar is an extension of SeekBar and ProgressBar that shows a rating in stars. The user can touch/drag or use arrow keys to set the rating when using the default size RatingBar. The smaller RatingBar style ( android.R.attr#ratingBarStyleSmall) and the larger indicator-only style (android.R.attr#ratingBarStyleIndicator) do not support user interaction and should only be used as indicators. </para> <para>When using a RatingBar that supports user interaction, placing widgets to the left or right of the RatingBar is discouraged. </para> <para>The number of stars set (via setNumStars(int) or in an XML layout) will be shown when the layout width is set to wrap content (if another layout width is set, the results may be unpredictable). </para> <para>The secondary progress should not be modified by the client as it is used internally as the background for a fractionally filled star.</para> <para>ref android.R.styleable::RatingBar_numStars  ref android.R.styleable::RatingBar_rating  ref android.R.styleable::RatingBar_stepSize  ref android.R.styleable::RatingBar_isIndicator </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/RatingBar
		/// </java-name>
		[Dot42.DexImport("android/widget/RatingBar", AccessFlags = 33)]
		public partial class RatingBar : global::Android.Widget.AbsSeekBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Whether this rating bar should only be an indicator (thus non-changeable by the user).</para> <para>ref android.R.styleable::RatingBar_isIndicator </para>        
				/// </summary>
				/// <java-name>
				/// setIsIndicator
				/// </java-name>
				[Dot42.DexImport("setIsIndicator", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsIndicator(bool isIndicator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RatingBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The listener (may be null) that is listening for rating change events. </para>
				/// </returns>
				/// <java-name>
				/// getOnRatingBarChangeListener
				/// </java-name>
				public virtual global::Android.Widget.RatingBar.IOnRatingBarChangeListener OnRatingBarChangeListener
				{
						[Dot42.DexImport("getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.RatingBar.IOnRatingBarChangeListener); }
						[Dot42.DexImport("setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>ref android.R.styleable::RatingBar_isIndicator </para>        
				/// </summary>
				/// <returns>
				///  <para>Whether this rating bar is only an indicator.</para>
				/// </returns>
				/// <java-name>
				/// isIndicator
				/// </java-name>
				public virtual bool IsIndicator
				{
						[Dot42.DexImport("isIndicator", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the number of stars shown. </para>        
				/// </summary>
				/// <returns>
				///  <para>The number of stars shown. </para>
				/// </returns>
				/// <java-name>
				/// getNumStars
				/// </java-name>
				public virtual int NumStars
				{
						[Dot42.DexImport("getNumStars", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNumStars", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the current rating (number of stars filled).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current rating. </para>
				/// </returns>
				/// <java-name>
				/// getRating
				/// </java-name>
				public virtual float Rating
				{
						[Dot42.DexImport("getRating", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRating", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the step size of this rating bar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The step size. </para>
				/// </returns>
				/// <java-name>
				/// getStepSize
				/// </java-name>
				public virtual float StepSize
				{
						[Dot42.DexImport("getStepSize", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setStepSize", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMax
				/// </java-name>
				public override int Max
				{
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <summary>
				///  <para>A callback that notifies clients when the rating has been changed. This includes changes that were initiated by the user through a touch gesture or arrow key/trackball as well as changes that were initiated programmatically. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RatingBar$OnRatingBarChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/RatingBar$OnRatingBarChangeListener", AccessFlags = 1545)]
				public partial interface IOnRatingBarChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notification that the rating has changed. Clients can use the fromUser parameter to distinguish user-initiated changes from those that occurred programmatically. This will not be called continuously while the user is dragging, only when the user finalizes a rating by lifting the touch.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onRatingChanged
						/// </java-name>
						[Dot42.DexImport("onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", AccessFlags = 1025)]
						void OnRatingChanged(global::Android.Widget.RatingBar ratingBar, float rating, bool fromUser) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A Layout where the positions of the children can be described in relation to each other or to the parent.</para> <para>Note that you cannot have a circular dependency between the size of the RelativeLayout and the position of its children. For example, you cannot have a RelativeLayout whose height is set to WRAP_CONTENT and a child set to ALIGN_PARENT_BOTTOM. </para> <para> <b>Note:</b> In platform version 17 and lower, RelativeLayout was affected by a measurement bug that could cause child views to be measured with incorrect MeasureSpec values. (See MeasureSpec.makeMeasureSpec for more details.) This was triggered when a RelativeLayout container was placed in a scrolling container, such as a ScrollView or HorizontalScrollView. If a custom view not equipped to properly measure with the MeasureSpec mode UNSPECIFIED was placed in a RelativeLayout, this would silently work anyway as RelativeLayout would pass a very large AT_MOST MeasureSpec instead.</para> <para>This behavior has been preserved for apps that set  <code>android:targetSdkVersion="17"</code> or older in their manifest's  <code>uses-sdk</code> tag for compatibility. Apps targeting SDK version 18 or newer will receive the correct behavior</para> <para>See the  guide.</para> <para>Also see RelativeLayout.LayoutParams for layout attributes </para> <para>ref android.R.styleable::RelativeLayout_gravity  ref android.R.styleable::RelativeLayout_ignoreGravity </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/RelativeLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/RelativeLayout", AccessFlags = 33)]
		public partial class RelativeLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRUE
				/// </java-name>
				[Dot42.DexImport("TRUE", "I", AccessFlags = 25)]
				public const int TRUE = -1;
				/// <summary>
				///  <para>Rule that aligns a child's right edge with another child's left edge. </para>        
				/// </summary>
				/// <java-name>
				/// LEFT_OF
				/// </java-name>
				[Dot42.DexImport("LEFT_OF", "I", AccessFlags = 25)]
				public const int LEFT_OF = 0;
				/// <summary>
				///  <para>Rule that aligns a child's left edge with another child's right edge. </para>        
				/// </summary>
				/// <java-name>
				/// RIGHT_OF
				/// </java-name>
				[Dot42.DexImport("RIGHT_OF", "I", AccessFlags = 25)]
				public const int RIGHT_OF = 1;
				/// <summary>
				///  <para>Rule that aligns a child's bottom edge with another child's top edge. </para>        
				/// </summary>
				/// <java-name>
				/// ABOVE
				/// </java-name>
				[Dot42.DexImport("ABOVE", "I", AccessFlags = 25)]
				public const int ABOVE = 2;
				/// <summary>
				///  <para>Rule that aligns a child's top edge with another child's bottom edge. </para>        
				/// </summary>
				/// <java-name>
				/// BELOW
				/// </java-name>
				[Dot42.DexImport("BELOW", "I", AccessFlags = 25)]
				public const int BELOW = 3;
				/// <summary>
				///  <para>Rule that aligns a child's baseline with another child's baseline. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_BASELINE
				/// </java-name>
				[Dot42.DexImport("ALIGN_BASELINE", "I", AccessFlags = 25)]
				public const int ALIGN_BASELINE = 4;
				/// <summary>
				///  <para>Rule that aligns a child's left edge with another child's left edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_LEFT
				/// </java-name>
				[Dot42.DexImport("ALIGN_LEFT", "I", AccessFlags = 25)]
				public const int ALIGN_LEFT = 5;
				/// <summary>
				///  <para>Rule that aligns a child's top edge with another child's top edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_TOP
				/// </java-name>
				[Dot42.DexImport("ALIGN_TOP", "I", AccessFlags = 25)]
				public const int ALIGN_TOP = 6;
				/// <summary>
				///  <para>Rule that aligns a child's right edge with another child's right edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_RIGHT
				/// </java-name>
				[Dot42.DexImport("ALIGN_RIGHT", "I", AccessFlags = 25)]
				public const int ALIGN_RIGHT = 7;
				/// <summary>
				///  <para>Rule that aligns a child's bottom edge with another child's bottom edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_BOTTOM = 8;
				/// <summary>
				///  <para>Rule that aligns the child's left edge with its RelativeLayout parent's left edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_PARENT_LEFT
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_LEFT", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_LEFT = 9;
				/// <summary>
				///  <para>Rule that aligns the child's top edge with its RelativeLayout parent's top edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_PARENT_TOP
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_TOP", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_TOP = 10;
				/// <summary>
				///  <para>Rule that aligns the child's right edge with its RelativeLayout parent's right edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_PARENT_RIGHT
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_RIGHT", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_RIGHT = 11;
				/// <summary>
				///  <para>Rule that aligns the child's bottom edge with its RelativeLayout parent's bottom edge. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_PARENT_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_BOTTOM = 12;
				/// <summary>
				///  <para>Rule that centers the child with respect to the bounds of its RelativeLayout parent. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER_IN_PARENT
				/// </java-name>
				[Dot42.DexImport("CENTER_IN_PARENT", "I", AccessFlags = 25)]
				public const int CENTER_IN_PARENT = 13;
				/// <summary>
				///  <para>Rule that centers the child horizontally with respect to the bounds of its RelativeLayout parent. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CENTER_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CENTER_HORIZONTAL = 14;
				/// <summary>
				///  <para>Rule that centers the child vertically with respect to the bounds of its RelativeLayout parent. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CENTER_VERTICAL", "I", AccessFlags = 25)]
				public const int CENTER_VERTICAL = 15;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Defines which View is ignored when the gravity is applied. This setting has no effect if the gravity is  <code>Gravity.START | Gravity.TOP</code>.</para> <para> <para>setGravity(int)</para>ref android.R.styleable::RelativeLayout_ignoreGravity </para>        
				/// </summary>
				/// <java-name>
				/// setIgnoreGravity
				/// </java-name>
				[Dot42.DexImport("setIgnoreGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetIgnoreGravity(int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describes how the child views are positioned. Defaults to  <code>Gravity.START | Gravity.TOP</code>.</para> <para>Note that since RelativeLayout considers the positioning of each child relative to one another to be significant, setting gravity will affect the positioning of all children as a single unit within the parent. This happens after children have been relatively positioned.</para> <para> <para>setHorizontalGravity(int) </para> <para>setVerticalGravity(int)</para>ref android.R.styleable::RelativeLayout_gravity </para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalGravity
				/// </java-name>
				[Dot42.DexImport("setHorizontalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalGravity(int horizontalGravity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalGravity
				/// </java-name>
				[Dot42.DexImport("setVerticalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalGravity(int verticalGravity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when something has changed which has invalidated the layout of a child of this view parent. This will schedule a layout pass of the view tree. </para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.RelativeLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RelativeLayout.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#WRAP_CONTENT, a height of android.view.ViewGroup.LayoutParams#WRAP_CONTENT and no spanning. </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RelativeLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Per-child layout information associated with RelativeLayout.</para> <para>ref android.R.styleable::RelativeLayout_Layout_layout_alignWithParentIfMissing  ref android.R.styleable::RelativeLayout_Layout_layout_toLeftOf  ref android.R.styleable::RelativeLayout_Layout_layout_toRightOf  ref android.R.styleable::RelativeLayout_Layout_layout_above  ref android.R.styleable::RelativeLayout_Layout_layout_below  ref android.R.styleable::RelativeLayout_Layout_layout_alignBaseline  ref android.R.styleable::RelativeLayout_Layout_layout_alignLeft  ref android.R.styleable::RelativeLayout_Layout_layout_alignTop  ref android.R.styleable::RelativeLayout_Layout_layout_alignRight  ref android.R.styleable::RelativeLayout_Layout_layout_alignBottom  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentLeft  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentTop  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentRight  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentBottom  ref android.R.styleable::RelativeLayout_Layout_layout_centerInParent  ref android.R.styleable::RelativeLayout_Layout_layout_centerHorizontal  ref android.R.styleable::RelativeLayout_Layout_layout_centerVertical  ref android.R.styleable::RelativeLayout_Layout_layout_toStartOf  ref android.R.styleable::RelativeLayout_Layout_layout_toEndOf  ref android.R.styleable::RelativeLayout_Layout_layout_alignStart  ref android.R.styleable::RelativeLayout_Layout_layout_alignEnd  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentStart  ref android.R.styleable::RelativeLayout_Layout_layout_alignParentEnd </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RelativeLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/RelativeLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>When true, uses the parent as the anchor if the anchor doesn't exist or if the anchor's visibility is GONE. </para>        
						/// </summary>
						/// <java-name>
						/// alignWithParent
						/// </java-name>
						[Dot42.DexImport("alignWithParent", "Z", AccessFlags = 1)]
						public bool AlignWithParent;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string output) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Adds a layout rule to be interpreted by the RelativeLayout. This method should only be used for constraints that don't refer to another sibling (e.g., CENTER_IN_PARENT) or take a boolean value (RelativeLayout#TRUE for true or 0 for false). To specify a verb that takes a subject, use addRule(int, int) instead.</para> <para> <para>addRule(int, int) </para></para>        
						/// </summary>
						/// <java-name>
						/// addRule
						/// </java-name>
						[Dot42.DexImport("addRule", "(I)V", AccessFlags = 1)]
						public virtual void AddRule(int verb) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Adds a layout rule to be interpreted by the RelativeLayout. Use this for verbs that take a target, such as a sibling (ALIGN_RIGHT) or a boolean value (VISIBLE).</para> <para> <para>addRule(int) </para></para>        
						/// </summary>
						/// <java-name>
						/// addRule
						/// </java-name>
						[Dot42.DexImport("addRule", "(II)V", AccessFlags = 1)]
						public virtual void AddRule(int verb, int anchor) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Retrieves a complete list of all supported rules, where the index is the rule verb, and the element value is the value specified, or "false" if it was never set. There will be no resolution of relative rules done.</para> <para> <para>addRule(int, int) </para></para>        
						/// </summary>
						/// <returns>
						///  <para>the supported rules </para>
						/// </returns>
						/// <java-name>
						/// getRules
						/// </java-name>
						public virtual int[] Rules
						{
								[Dot42.DexImport("getRules", "()[I", AccessFlags = 1)]
								get{ return default(int[]); }
						}

				}

		}

		/// <summary>
		///  <para>A class that describes a view hierarchy that can be displayed in another process. The hierarchy is inflated from a layout resource file, and this class provides some basic operations for modifying the content of the inflated hierarchy. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/RemoteViews
		/// </java-name>
		[Dot42.DexImport("android/widget/RemoteViews", AccessFlags = 33)]
		public partial class RemoteViews : global::Android.OS.IParcelable, global::Android.Views.LayoutInflater.IFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Parcelable.Creator that instantiates RemoteViews objects </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Widget.RemoteViews> CREATOR;
				/// <summary>
				///  <para>Create a new RemoteViews object that will inflate as the specified landspace or portrait RemoteViews, depending on the current configuration.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public RemoteViews(string landscape, int portrait) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads a RemoteViews object from a parcel.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public RemoteViews(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public virtual global::Android.Widget.RemoteViews Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RemoteViews);
				}

				/// <summary>
				///  <para>Equivalent to calling ViewGroup#addView(View) after inflating the given RemoteViews. This allows users to build "nested" RemoteViews. In cases where consumers of RemoteViews may recycle layouts, use removeAllViews(int) to clear any existing children.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void AddView(int viewId, global::Android.Widget.RemoteViews nestedView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling ViewGroup#removeAllViews().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAllViews(int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling View.setVisibility</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewVisibility
				/// </java-name>
				[Dot42.DexImport("setViewVisibility", "(II)V", AccessFlags = 1)]
				public virtual void SetViewVisibility(int viewId, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling TextView.setText</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTextViewText
				/// </java-name>
				[Dot42.DexImport("setTextViewText", "(ILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTextViewText(int viewId, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling ImageView.setImageResource</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageViewResource
				/// </java-name>
				[Dot42.DexImport("setImageViewResource", "(II)V", AccessFlags = 1)]
				public virtual void SetImageViewResource(int viewId, int srcId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling ImageView.setImageURI</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageViewUri
				/// </java-name>
				[Dot42.DexImport("setImageViewUri", "(ILandroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageViewUri(int viewId, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling ImageView.setImageBitmap</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setImageViewBitmap
				/// </java-name>
				[Dot42.DexImport("setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetImageViewBitmap(int viewId, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling Chronometer.setBase, Chronometer.setFormat, and Chronometer.start() or Chronometer.stop().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChronometer
				/// </java-name>
				[Dot42.DexImport("setChronometer", "(IJLjava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetChronometer(int viewId, long @base, string format, bool started) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling ProgressBar.setMax, ProgressBar.setProgress, and ProgressBar.setIndeterminate</para> <para>If indeterminate is true, then the values for max and progress are ignored.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setProgressBar
				/// </java-name>
				[Dot42.DexImport("setProgressBar", "(IIIZ)V", AccessFlags = 1)]
				public virtual void SetProgressBar(int viewId, int max, int progress, bool indeterminate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling android.view.View#setOnClickListener(android.view.View.OnClickListener) to launch the provided PendingIntent.</para> <para>When setting the on-click action of items within collections (eg. ListView, StackView etc.), this method will not work. Instead, use in conjunction with RemoteViews#setOnClickFillInIntent(int, Intent).  viewId The id of the view that will trigger the  PendingIntent when clicked </para>        
				/// </summary>
				/// <java-name>
				/// setOnClickPendingIntent
				/// </java-name>
				[Dot42.DexImport("setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetOnClickPendingIntent(int viewId, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to calling android.widget.TextView#setTextColor(int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(II)V", AccessFlags = 1)]
				public virtual void SetTextColor(int viewId, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one boolean on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(ILjava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetBoolean(int viewId, string methodName, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one byte on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(ILjava/lang/String;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetByte(int viewId, string methodName, sbyte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one byte on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(ILjava/lang/String;B)V", AccessFlags = 1)]
				public virtual void SetByte(int viewId, string methodName, byte value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one short on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(ILjava/lang/String;S)V", AccessFlags = 1)]
				public virtual void SetShort(int viewId, string methodName, short value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one int on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(ILjava/lang/String;I)V", AccessFlags = 1)]
				public virtual void SetInt(int viewId, string methodName, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one long on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(ILjava/lang/String;J)V", AccessFlags = 1)]
				public virtual void SetLong(int viewId, string methodName, long value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one float on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(ILjava/lang/String;F)V", AccessFlags = 1)]
				public virtual void SetFloat(int viewId, string methodName, float value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one double on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(ILjava/lang/String;D)V", AccessFlags = 1)]
				public virtual void SetDouble(int viewId, string methodName, double value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one char on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(ILjava/lang/String;C)V", AccessFlags = 1)]
				public virtual void SetChar(int viewId, string methodName, char value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one String on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetString(int viewId, string methodName, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one CharSequence on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCharSequence
				/// </java-name>
				[Dot42.DexImport("setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCharSequence(int viewId, string methodName, global::Java.Lang.ICharSequence value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one Uri on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setUri
				/// </java-name>
				[Dot42.DexImport("setUri", "(ILjava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetUri(int viewId, string methodName, global::Android.Net.Uri value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one Bitmap on a view in the layout for this RemoteViews.  </para> <para>The bitmap will be flattened into the parcel if this object is sent across processes, so it may end up using a lot of memory, and may be fairly slow.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(int viewId, string methodName, global::Android.Graphics.Bitmap value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call a method taking one Bundle on a view in the layout for this RemoteViews.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBundle
				/// </java-name>
				[Dot42.DexImport("setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetBundle(int viewId, string methodName, global::Android.OS.Bundle value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inflates the view hierarchy represented by this object and applies all of the actions.</para> <para> <b>Caller beware: this may throw</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The inflated view hierarchy </para>
				/// </returns>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Apply(global::Android.Content.Context context, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Applies all of the actions to the provided view.</para> <para> <b>Caller beware: this may throw</b></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// reapply
				/// </java-name>
				[Dot42.DexImport("reapply", "(Landroid/content/Context;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void Reapply(global::Android.Content.Context context, global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hook to allow clients of the LayoutInflater to restrict the set of Views that are allowed to be inflated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this class is allowed to be inflated, or false otherwise </para>
				/// </returns>
				/// <java-name>
				/// onLoadClass
				/// </java-name>
				[Dot42.DexImport("onLoadClass", "(Ljava/lang/Class;)Z", AccessFlags = 1)]
				public virtual bool OnLoadClass(global::System.Type clazz) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal RemoteViews() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				public virtual string Package
				{
						[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Reutrns the layout id of the root layout associated with this RemoteViews. In the case that the RemoteViews has both a landscape and portrait root, this will return the layout id associated with the portrait layout.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the layout id. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutId
				/// </java-name>
				public virtual int LayoutId
				{
						[Dot42.DexImport("getLayoutId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Exception to send when something goes wrong executing an action </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RemoteViews$ActionException
				/// </java-name>
				[Dot42.DexImport("android/widget/RemoteViews$ActionException", AccessFlags = 9)]
				public partial class ActionException : global::System.SystemException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
						public ActionException(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public ActionException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal ActionException() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>This annotation indicates that a subclass of View is alllowed to be used with the RemoteViews mechanism. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/RemoteViews$RemoteView
				/// </java-name>
				[Dot42.DexImport("android/widget/RemoteViews$RemoteView", AccessFlags = 9737)]
				public partial interface IRemoteView : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <summary>
		///  <para>An easy adapter that creates views defined in an XML file. You can specify the XML file that defines the appearance of the views. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ResourceCursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ResourceCursorAdapter", AccessFlags = 1057)]
		public abstract partial class ResourceCursorAdapter : global::Android.Widget.CursorAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor the enables auto-requery.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This option is discouraged, as it results in Cursor queries being performed on the application's UI thread and thus can cause poor responsiveness or even Application Not Responding errors. As an alternative, use android.app.LoaderManager with a android.content.CursorLoader.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V", AccessFlags = 1)]
				public ResourceCursorAdapter(global::Android.Content.Context context, int layout, global::Android.Database.ICursor c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Standard constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V", AccessFlags = 1)]
				public ResourceCursorAdapter(global::Android.Content.Context context, int layout, global::Android.Database.ICursor c, bool flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inflates view(s) from the specified XML file.</para> <para> <para>android.widget.CursorAdapter::newView(android.content.Context, android.database.Cursor, ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// newView
				/// </java-name>
				[Dot42.DexImport("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View NewView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newDropDownView
				/// </java-name>
				[Dot42.DexImport("newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View NewDropDownView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Sets the layout resource of the item views.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewResource
				/// </java-name>
				[Dot42.DexImport("setViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetViewResource(int layout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the layout resource of the drop down views.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int dropDownLayout) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ResourceCursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A fairly simple ExpandableListAdapter that creates views defined in an XML file. You can specify the XML file that defines the appearance of the views. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ResourceCursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ResourceCursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class ResourceCursorTreeAdapter : global::Android.Widget.CursorTreeAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;IIII)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int collapsedGroupLayout, int expandedGroupLayout, int childLayout, int lastChildLayout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;III)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int collapsedGroupLayout, int expandedGroupLayout, int childLayout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int groupLayout, int childLayout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1)]
				protected internal override global::Android.Views.View NewChildView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isLastChild, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1)]
				protected internal override global::Android.Views.View NewGroupView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isExpanded, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ResourceCursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This class encapsulates scrolling. You can use scrollers (Scroller or OverScroller) to collect the data you need to produce a scrolling animationfor example, in response to a fling gesture. Scrollers track scroll offsets for you over time, but they don't automatically apply those positions to your view. It's your responsibility to get and apply new coordinates at a rate that will make the scrolling animation look smooth.</para> <para>Here is a simple example:</para> <para> <pre> private Scroller mScroller = new Scroller(context);
		/// ...
		/// public void zoomIn() {
		///     // Revert any animation currently in progress
		///     mScroller.forceFinished(true);
		///     // Start scrolling by providing a starting point and
		///     // the distance to travel
		///     mScroller.startScroll(0, 0, 100, 0);
		///     // Invalidate to request a redraw
		///     invalidate();
		/// }</pre></para> <para>To track the changing positions of the x/y coordinates, use computeScrollOffset. The method returns a boolean to indicate whether the scroller is finished. If it isn't, it means that a fling or programmatic pan operation is still in progress. You can use this method to find the current offsets of the x and y coordinates, for example:</para> <para> <pre>if (mScroller.computeScrollOffset()) {
		///     // Get current x and y positions
		///     int currX = mScroller.getCurrX();
		///     int currY = mScroller.getCurrY();
		///    ...
		/// }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Scroller
		/// </java-name>
		[Dot42.DexImport("android/widget/Scroller", AccessFlags = 33)]
		public partial class Scroller
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a Scroller with the default duration and interpolator. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Scroller(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a Scroller with the specified interpolator. If the interpolator is null, the default (viscous) interpolator will be used. "Flywheel" behavior will be in effect for apps targeting Honeycomb or newer. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public Scroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Force the finished field to a particular value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// forceFinished
				/// </java-name>
				[Dot42.DexImport("forceFinished", "(Z)V", AccessFlags = 17)]
				public void ForceFinished(bool finished) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this when you want to know the new location. If it returns true, the animation is not yet finished. </para>        
				/// </summary>
				/// <java-name>
				/// computeScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeScrollOffset", "()Z", AccessFlags = 1)]
				public virtual bool ComputeScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Start scrolling by providing a starting point and the distance to travel. The scroll will use the default value of 250 milliseconds for the duration.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int startX, int startY, int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start scrolling by providing a starting point, the distance to travel, and the duration of the scroll.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int startX, int startY, int dx, int dy, int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start scrolling based on a fling gesture. The distance travelled will depend on the initial velocity of the fling.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int startX, int startY, int velocityX, int velocityY, int minX, int maxX, int minY, int maxY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stops the animation. Contrary to forceFinished(boolean), aborting the animating cause the scroller to move to the final x and y position</para> <para> <para>forceFinished(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// abortAnimation
				/// </java-name>
				[Dot42.DexImport("abortAnimation", "()V", AccessFlags = 1)]
				public virtual void AbortAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Extend the scroll animation. This allows a running animation to scroll further and longer, when used with setFinalX(int) or setFinalY(int).</para> <para> <para>setFinalX(int) </para> <para>setFinalY(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// extendDuration
				/// </java-name>
				[Dot42.DexImport("extendDuration", "(I)V", AccessFlags = 1)]
				public virtual void ExtendDuration(int extend) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the time elapsed since the beginning of the scrolling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The elapsed time in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// timePassed
				/// </java-name>
				[Dot42.DexImport("timePassed", "()I", AccessFlags = 1)]
				public virtual int TimePassed() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Scroller() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the scroller has finished scrolling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the scroller has finished scrolling, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFinished
				/// </java-name>
				public bool IsFinished
				{
						[Dot42.DexImport("isFinished", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns how long the scroll event will take, in milliseconds.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The duration of the scroll in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current X offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getCurrX
				/// </java-name>
				public int CurrX
				{
						[Dot42.DexImport("getCurrX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current Y offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The new Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getCurrY
				/// </java-name>
				public int CurrY
				{
						[Dot42.DexImport("getCurrY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the start X offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The start X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getStartX
				/// </java-name>
				public int StartX
				{
						[Dot42.DexImport("getStartX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the start Y offset in the scroll.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The start Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getStartY
				/// </java-name>
				public int StartY
				{
						[Dot42.DexImport("getStartY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns where the scroll will end. Valid only for "fling" scrolls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The final X offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getFinalX
				/// </java-name>
				public virtual int FinalX
				{
						[Dot42.DexImport("getFinalX", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setFinalX", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns where the scroll will end. Valid only for "fling" scrolls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The final Y offset as an absolute distance from the origin. </para>
				/// </returns>
				/// <java-name>
				/// getFinalY
				/// </java-name>
				public virtual int FinalY
				{
						[Dot42.DexImport("getFinalY", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setFinalY", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Layout container for a view hierarchy that can be scrolled by the user, allowing it to be larger than the physical display. A ScrollView is a FrameLayout, meaning you should place one child in it containing the entire contents to scroll; this child may itself be a layout manager with a complex hierarchy of objects. A child that is often used is a LinearLayout in a vertical orientation, presenting a vertical array of top-level items that the user can scroll through. </para> <para>You should never use a ScrollView with a ListView, because ListView takes care of its own vertical scrolling. Most importantly, doing this defeats all of the important optimizations in ListView for dealing with large lists, since it effectively forces the ListView to display its entire list of items to fill up the infinite container supplied by ScrollView. </para> <para>The TextView class also takes care of its own scrolling, so does not require a ScrollView, but using the two together is possible to achieve the effect of a text view within a larger container.</para> <para>ScrollView only supports vertical scrolling. For horizontal scrolling, use HorizontalScrollView.</para> <para>ref android.R.styleable::ScrollView_fillViewport </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ScrollView
		/// </java-name>
		[Dot42.DexImport("android/widget/ScrollView", AccessFlags = 33)]
		public partial class ScrollView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>You can call this function yourself to have the scroll view perform scrolling from a key event, just as if the event had been dispatched to it by the view hierarchy.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if the event was handled, else false. </para>
				/// </returns>
				/// <java-name>
				/// executeKeyEvent
				/// </java-name>
				[Dot42.DexImport("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ExecuteKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int scrollX, int scrollY, bool clampedX, bool clampedY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Handles scrolling in response to a "page up/down" shortcut press. This method will scroll the view by one page up or down and give the focus to the topmost/bottommost component in the new visible area. If no component is a good candidate for focus, this scrollview reclaims the focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the key event is consumed by this method, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// pageScroll
				/// </java-name>
				[Dot42.DexImport("pageScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool PageScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Handles scrolling in response to a "home/end" shortcut press. This method will scroll the view to the top or bottom and give the focus to the topmost/bottommost component in the new visible area. If no component is a good candidate for focus, this scrollview reclaims the focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the key event is consumed by this method, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// fullScroll
				/// </java-name>
				[Dot42.DexImport("fullScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool FullScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Handle scrolling in response to an up or down arrow click.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if we consumed the event, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// arrowScroll
				/// </java-name>
				[Dot42.DexImport("arrowScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool ArrowScroll(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Like View#scrollBy, but scroll smoothly instead of immediately.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 17)]
				public void SmoothScrollBy(int dx, int dy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like scrollTo, but scroll smoothly instead of immediately.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// smoothScrollTo
				/// </java-name>
				[Dot42.DexImport("smoothScrollTo", "(II)V", AccessFlags = 17)]
				public void SmoothScrollTo(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The scroll range of a scroll view is the overall height of all of its children.</para>        
				/// </summary>
				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal override void MeasureChild(global::Android.Views.View child, int parentWidthMeasureSpec, int parentHeightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal override void MeasureChildWithMargins(global::Android.Views.View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compute the amount to scroll in the Y direction in order to get a rectangle completely on the screen (or, if taller than the screen, at least the first screen size chunk of it).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The scroll delta. </para>
				/// </returns>
				/// <java-name>
				/// computeScrollDeltaToGetChildRectOnScreen
				/// </java-name>
				[Dot42.DexImport("computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I", AccessFlags = 4)]
				protected internal virtual int ComputeScrollDeltaToGetChildRectOnScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Called when a child of this parent wants focus</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public override void RequestChildFocus(global::Android.Views.View child, global::Android.Views.View focused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>When looking for focus in children of a scroll view, need to be a little more careful not to give focus to something that is scrolled off screen.</para> <para>This is more expensive than the default android.view.ViewGroup implementation, otherwise this behavior might have been made the default. </para>        
				/// </summary>
				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool OnRequestFocusInDescendants(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a child of this group wants a particular rectangle to be positioned onto the screen. ViewGroups overriding this can trust that:  <ul> <li> <para>child will be a direct child of this group </para></li> <li> <para>rectangle will be in the child's coordinates </para></li></ul></para> <para>ViewGroups overriding this should uphold the contract:</para> <para> <ul> <li> <para>nothing will change if the rectangle is already visible </para></li> <li> <para>the view port will be scrolled only just enough to make the rectangle visible  <ul> <li></li></ul>child The direct child making the request. </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the group scrolled to handle the operation </para>
				/// </returns>
				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View child, global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when something has changed which has invalidated the layout of a child of this view parent. This will schedule a layout pass of the view tree. </para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fling the scroll view</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(I)V", AccessFlags = 1)]
				public virtual void Fling(int velocityY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This version also clamps the scrolling to the bounds of our child. </para>        
				/// </summary>
				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public override void ScrollTo(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ScrollView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal override float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal override float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum amount this scroll view will scroll in response to an arrow event. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether this ScrollView's content is stretched to fill the viewport.</para> <para>ref android.R.styleable::ScrollView_fillViewport </para>        
				/// </summary>
				/// <returns>
				///  <para>True if the content fills the viewport, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isFillViewport
				/// </java-name>
				public virtual bool IsFillViewport
				{
						[Dot42.DexImport("isFillViewport", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillViewport", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether arrow scrolling will animate its transition. </para>
				/// </returns>
				/// <java-name>
				/// isSmoothScrollingEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollingEnabled
				{
						[Dot42.DexImport("isSmoothScrollingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A SeekBar is an extension of ProgressBar that adds a draggable thumb. The user can touch the thumb and drag left or right to set the current progress level or use the arrow keys. Placing focusable widgets to the left or right of a SeekBar is discouraged. </para> <para>Clients of the SeekBar can attach a SeekBar.OnSeekBarChangeListener to be notified of the user's actions.</para> <para>ref android.R.styleable::SeekBar_thumb </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SeekBar
		/// </java-name>
		[Dot42.DexImport("android/widget/SeekBar", AccessFlags = 33)]
		public partial class SeekBar : global::Android.Widget.AbsSeekBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a listener to receive notifications of changes to the SeekBar's progress level. Also provides notifications of when the user starts and stops a touch gesture within the SeekBar.</para> <para> <para>SeekBar.OnSeekBarChangeListener </para></para>        
				/// </summary>
				/// <java-name>
				/// setOnSeekBarChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnSeekBarChangeListener(global::Android.Widget.SeekBar.IOnSeekBarChangeListener l) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SeekBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>A callback that notifies clients when the progress level has been changed. This includes changes that were initiated by the user through a touch gesture or arrow key/trackball as well as changes that were initiated programmatically. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SeekBar$OnSeekBarChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SeekBar$OnSeekBarChangeListener", AccessFlags = 1545)]
				public partial interface IOnSeekBarChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notification that the progress level has changed. Clients can use the fromUser parameter to distinguish user-initiated changes from those that occurred programmatically.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onProgressChanged
						/// </java-name>
						[Dot42.DexImport("onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", AccessFlags = 1025)]
						void OnProgressChanged(global::Android.Widget.SeekBar seekBar, int progress, bool fromUser) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification that the user has started a touch gesture. Clients may want to use this to disable advancing the seekbar. </para>        
						/// </summary>
						/// <java-name>
						/// onStartTrackingTouch
						/// </java-name>
						[Dot42.DexImport("onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", AccessFlags = 1025)]
						void OnStartTrackingTouch(global::Android.Widget.SeekBar seekBar) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification that the user has finished a touch gesture. Clients may want to use this to re-enable advancing the seekbar. </para>        
						/// </summary>
						/// <java-name>
						/// onStopTrackingTouch
						/// </java-name>
						[Dot42.DexImport("onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", AccessFlags = 1025)]
						void OnStopTrackingTouch(global::Android.Widget.SeekBar seekBar) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An easy adapter to map static data to views defined in an XML file. You can specify the data backing the list as an ArrayList of Maps. Each entry in the ArrayList corresponds to one row in the list. The Maps contain the data for each row. You also specify an XML file that defines the views used to display the row, and a mapping from keys in the Map to specific views.</para> <para>Binding data to views occurs in two phases. First, if a android.widget.SimpleAdapter.ViewBinder is available, ViewBinder#setViewValue(android.view.View, Object, String) is invoked. If the returned value is true, binding has occurred. If the returned value is false, the following views are then tried in order:  <ul> <li> <para>A view that implements Checkable (e.g. CheckBox). The expected bind value is a boolean. </para></li> <li> <para>TextView. The expected bind value is a string and setViewText(TextView, String) is invoked. </para></li> <li> <para>ImageView. The expected bind value is a resource id or a string and setViewImage(ImageView, int) or setViewImage(ImageView, String) is invoked. </para></li></ul>If no appropriate binding can be found, an IllegalStateException is thrown. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SimpleAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleAdapter", AccessFlags = 33)]
		public partial class SimpleAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "I[Ljava/lang/String;[I)V")]
				public SimpleAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> data, int resource, string[] from, int[] to) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>android.widget.Adapter::getItem(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetItem(int position) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para> <para>android.widget.Adapter::getItemId(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int position) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para> <para>android.widget.Adapter::getView(int, View, ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Sets the layout resource to create the drop down views.</para> <para> <para>getDropDownView(int, android.view.View, android.view.ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int resource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a android.view.View that displays in the drop down popup the data at the specified position in the data set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a android.view.View corresponding to the data at the specified position. </para>
				/// </returns>
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Called by bindView() to set the image for an ImageView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to an ImageView.</para> <para>This method is called instead of setViewImage(ImageView, String) if the supplied data is an int or Integer.</para> <para> <para>setViewImage(ImageView, String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;I)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView v, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the image for an ImageView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to an ImageView.</para> <para>This method is called instead of setViewImage(ImageView, String) if the supplied data is an int or Integer.</para> <para> <para>setViewImage(ImageView, String) </para></para>        
				/// </summary>
				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView v, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the text for a TextView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to a TextView.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView v, string text) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SimpleAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <para>android.widget.Adapter::getCount() </para></para>        
				/// </summary>
				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the ViewBinder used to bind data to views.</para> <para> <para>setViewBinder(android.widget.SimpleAdapter.ViewBinder) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ViewBinder or null if the binder does not exist</para>
				/// </returns>
				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns a filter that can be used to constrain data with a filtering pattern.</para> <para>This method is usually implemented by android.widget.Adapter classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a filter used to constrain data </para>
				/// </returns>
				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <summary>
				///  <para>This class can be used by external clients of SimpleAdapter to bind values to views.</para> <para>You should use this class to bind values to views that are not directly supported by SimpleAdapter or to change the way binding occurs for views supported by SimpleAdapter.</para> <para> <para>SimpleAdapter::setViewImage(ImageView, int) </para> <para>SimpleAdapter::setViewImage(ImageView, String) </para> <para>SimpleAdapter::setViewText(TextView, String) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SimpleAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Binds the specified data to the specified view.</para> <para>When binding is handled by this ViewBinder, this method must return true. If this method returns false, SimpleAdapter will attempts to handle the binding on its own.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the data was bound to the view, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, object data, string textRepresentation) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An easy adapter to map columns from a cursor to TextViews or ImageViews defined in an XML file. You can specify which columns you want, which views you want to display the columns, and the XML file that defines the appearance of these views.</para> <para>Binding occurs in two phases. First, if a android.widget.SimpleCursorAdapter.ViewBinder is available, ViewBinder#setViewValue(android.view.View, android.database.Cursor, int) is invoked. If the returned value is true, binding has occured. If the returned value is false and the view to bind is a TextView, setViewText(TextView, String) is invoked. If the returned value is false and the view to bind is an ImageView, setViewImage(ImageView, String) is invoked. If no appropriate binding can be found, an IllegalStateException is thrown.</para> <para>If this adapter is used with filtering, for instance in an android.widget.AutoCompleteTextView, you can use the android.widget.SimpleCursorAdapter.CursorToStringConverter and the android.widget.FilterQueryProvider interfaces to get control over the filtering process. You can refer to convertToString(android.database.Cursor) and runQueryOnBackgroundThread(CharSequence) for more information. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SimpleCursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleCursorAdapter", AccessFlags = 33)]
		public partial class SimpleCursorAdapter : global::Android.Widget.ResourceCursorAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor the enables auto-requery.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This option is discouraged, as it results in Cursor queries being performed on the application's UI thread and thus can cause poor responsiveness or even Application Not Responding errors. As an alternative, use android.app.LoaderManager with a android.content.CursorLoader. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorAdapter(global::Android.Content.Context context, int layout, global::Android.Database.ICursor c, string[] from, int[] to) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Binds all of the field names passed into the "to" parameter of the constructor with their corresponding cursor columns as specified in the "from" parameter.</para> <para>Binding occurs in two phases. First, if a android.widget.SimpleCursorAdapter.ViewBinder is available, ViewBinder#setViewValue(android.view.View, android.database.Cursor, int) is invoked. If the returned value is true, binding has occured. If the returned value is false and the view to bind is a TextView, setViewText(TextView, String) is invoked. If the returned value is false and the view to bind is an ImageView, setViewImage(ImageView, String) is invoked. If no appropriate binding can be found, an IllegalStateException is thrown.</para> <para> <para>android.widget.CursorAdapter::bindView(android.view.View, android.content.Context, android.database.Cursor) </para> <para>getViewBinder() </para> <para>setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder) </para> <para>setViewImage(ImageView, String) </para> <para>setViewText(TextView, String) </para></para>        
				/// </summary>
				/// <java-name>
				/// bindView
				/// </java-name>
				[Dot42.DexImport("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1)]
				public override void BindView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the image for an ImageView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to an ImageView.</para> <para>By default, the value will be treated as an image resource. If the value cannot be used as an image resource, the value is used as an image Uri.</para> <para>Intended to be overridden by Adapters that need to filter strings retrieved from the database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView v, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the text for a TextView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to a TextView.</para> <para>Intended to be overridden by Adapters that need to filter strings retrieved from the database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView v, string text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a CharSequence representation of the specified Cursor as defined by the current CursorToStringConverter. If no CursorToStringConverter has been set, the String conversion column is used instead. If the conversion column is -1, the returned String is empty if the cursor is null or Cursor.toString().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a non-null CharSequence representing the cursor </para>
				/// </returns>
				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// changeCursor
				/// </java-name>
				[Dot42.DexImport("changeCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public override void ChangeCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the cursor and change the column-to-view mappings at the same time.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeCursorAndColumns
				/// </java-name>
				[Dot42.DexImport("changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V", AccessFlags = 1)]
				public virtual void ChangeCursorAndColumns(global::Android.Database.ICursor c, string[] from, int[] to) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SimpleCursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the ViewBinder used to bind data to views.</para> <para> <para>bindView(android.view.View, android.content.Context, android.database.Cursor) </para> <para>setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ViewBinder or null if the binder does not exist</para>
				/// </returns>
				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the index of the column used to get a String representation of the Cursor.</para> <para> <para>android.widget.CursorAdapter::convertToString(android.database.Cursor) </para> <para>setStringConversionColumn(int) </para> <para>setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter) </para> <para>getCursorToStringConverter() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a valid index in the current Cursor or -1</para>
				/// </returns>
				/// <java-name>
				/// getStringConversionColumn
				/// </java-name>
				public virtual int StringConversionColumn
				{
						[Dot42.DexImport("getStringConversionColumn", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStringConversionColumn", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the converter used to convert the filtering Cursor into a String.</para> <para> <para>setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter) </para> <para>getStringConversionColumn() </para> <para>setStringConversionColumn(int) </para> <para>android.widget.CursorAdapter::convertToString(android.database.Cursor) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>null if the converter does not exist or an instance of android.widget.SimpleCursorAdapter.CursorToStringConverter</para>
				/// </returns>
				/// <java-name>
				/// getCursorToStringConverter
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorAdapter.ICursorToStringConverter CursorToStringConverter
				{
						[Dot42.DexImport("getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorAdapter.ICursorToStringConverter); }
						[Dot42.DexImport("setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>This class can be used by external clients of SimpleCursorAdapter to define how the Cursor should be converted to a String.</para> <para> <para>android.widget.CursorAdapter::convertToString(android.database.Cursor) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SimpleCursorAdapter$CursorToStringConverter
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorAdapter$CursorToStringConverter", AccessFlags = 1545)]
				public partial interface ICursorToStringConverter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Returns a CharSequence representing the specified Cursor.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a non-null CharSequence representing the cursor </para>
						/// </returns>
						/// <java-name>
						/// convertToString
						/// </java-name>
						[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>This class can be used by external clients of SimpleCursorAdapter to bind values fom the Cursor to views.</para> <para>You should use this class to bind values from the Cursor to views that are not directly supported by SimpleCursorAdapter or to change the way binding occurs for views supported by SimpleCursorAdapter.</para> <para> <para>SimpleCursorAdapter::bindView(android.view.View, android.content.Context, android.database.Cursor) </para> <para>SimpleCursorAdapter::setViewImage(ImageView, String) </para> <para>SimpleCursorAdapter::setViewText(TextView, String) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SimpleCursorAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Binds the Cursor column defined by the specified index to the specified view.</para> <para>When binding is handled by this ViewBinder, this method must return true. If this method returns false, SimpleCursorAdapter will attempts to handle the binding on its own.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the data was bound to the view, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, global::Android.Database.ICursor cursor, int columnIndex) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An easy adapter to map columns from a cursor to TextViews or ImageViews defined in an XML file. You can specify which columns you want, which views you want to display the columns, and the XML file that defines the appearance of these views. Separate XML files for child and groups are possible.</para> <para>Binding occurs in two phases. First, if a android.widget.SimpleCursorTreeAdapter.ViewBinder is available, ViewBinder#setViewValue(android.view.View, android.database.Cursor, int) is invoked. If the returned value is true, binding has occurred. If the returned value is false and the view to bind is a TextView, setViewText(TextView, String) is invoked. If the returned value is false and the view to bind is an ImageView, setViewImage(ImageView, String) is invoked. If no appropriate binding can be found, an IllegalStateException is thrown. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SimpleCursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleCursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class SimpleCursorTreeAdapter : global::Android.Widget.ResourceCursorTreeAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljav" +
    "a/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int collapsedGroupLayout, int expandedGroupLayout, string[] groupFrom, int[] groupTo, int childLayout, int lastChildLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava" +
    "/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int collapsedGroupLayout, int expandedGroupLayout, string[] groupFrom, int[] groupTo, int childLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/" +
    "lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int groupLayout, string[] groupFrom, int[] groupTo, int childLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindChildView
				/// </java-name>
				[Dot42.DexImport("bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal override void BindChildView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isLastChild) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindGroupView
				/// </java-name>
				[Dot42.DexImport("bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal override void BindGroupView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool isExpanded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the image for an ImageView. By default, the value will be treated as a Uri. Intended to be overridden by Adapters that need to filter strings retrieved from the database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SetViewImage(global::Android.Widget.ImageView v, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by bindView() to set the text for a TextView but only if there is no existing ViewBinder or if the existing ViewBinder cannot handle binding to a TextView.</para> <para>Intended to be overridden by Adapters that need to filter strings retrieved from the database.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView v, string text) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SimpleCursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the ViewBinder used to bind data to views.</para> <para> <para>setViewBinder(android.widget.SimpleCursorTreeAdapter.ViewBinder) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ViewBinder or null if the binder does not exist</para>
				/// </returns>
				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorTreeAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorTreeAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>This class can be used by external clients of SimpleCursorTreeAdapter to bind values from the Cursor to views.</para> <para>You should use this class to bind values from the Cursor to views that are not directly supported by SimpleCursorTreeAdapter or to change the way binding occurs for views supported by SimpleCursorTreeAdapter.</para> <para> <para>SimpleCursorTreeAdapter::setViewImage(ImageView, String) </para> <para>SimpleCursorTreeAdapter::setViewText(TextView, String) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SimpleCursorTreeAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorTreeAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Binds the Cursor column defined by the specified index to the specified view.</para> <para>When binding is handled by this ViewBinder, this method must return true. If this method returns false, SimpleCursorTreeAdapter will attempts to handle the binding on its own.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the data was bound to the view, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, global::Android.Database.ICursor cursor, int columnIndex) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>An easy adapter to map static data to group and child views defined in an XML file. You can separately specify the data backing the group as a List of Maps. Each entry in the ArrayList corresponds to one group in the expandable list. The Maps contain the data for each row. You also specify an XML file that defines the views used to display a group, and a mapping from keys in the Map to specific views. This process is similar for a child, except it is one-level deeper so the data backing is specified as a List&lt;List&lt;Map&gt;&gt;, where the first List corresponds to the group of the child, the second List corresponds to the position of the child within the group, and finally the Map holds the data for that particular child. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SimpleExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleExpandableListAdapter", AccessFlags = 33)]
		public partial class SimpleExpandableListAdapter : global::Android.Widget.BaseExpandableListAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I" +
    "[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "I[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/lan" +
    "g/String;*>;>;>;I[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> groupData, int groupLayout, string[] groupFrom, int[] groupTo, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> childData, int childLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;" +
    "I[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "II[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/la" +
    "ng/String;*>;>;>;I[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> groupData, int expandedGroupLayout, int collapsedGroupLayout, string[] groupFrom, int[] groupTo, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> childData, int childLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;" +
    "II[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "II[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/la" +
    "ng/String;*>;>;>;II[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> groupData, int expandedGroupLayout, int collapsedGroupLayout, string[] groupFrom, int[] groupTo, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> childData, int childLayout, int lastChildLayout, string[] childFrom, int[] childTo) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the data associated with the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data of the child </para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetChild(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Gets the ID for the given child within the given group. This ID must be unique across all children within the group. The combined ID (see getCombinedChildId(long, long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the child </para>
				/// </returns>
				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1)]
				public override long GetChildId(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Gets a View that displays the data for the given child within the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the child at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetChildView(int groupPosition, int childPosition, bool isLastChild, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Instantiates a new View for a child. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new child View </para>
				/// </returns>
				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewChildView(bool isLastChild, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Gets the number of children in a specified group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the children count in the specified group </para>
				/// </returns>
				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1)]
				public override int GetChildrenCount(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the data associated with the given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the data child for the specified group </para>
				/// </returns>
				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetGroup(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Gets the ID for the group at the given position. This group ID must be unique across groups. The combined ID (see getCombinedGroupId(long)) must be unique across ALL items (groups and all children).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID associated with the group </para>
				/// </returns>
				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1)]
				public override long GetGroupId(int groupPosition) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Gets a View that displays the given group. This View is only for the groupthe Views for the group's children will be fetched using getChildView(int, int, boolean, View, ViewGroup).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the View corresponding to the group at the specified position </para>
				/// </returns>
				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetGroupView(int groupPosition, bool isExpanded, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Instantiates a new View for a group. </para>        
				/// </summary>
				/// <returns>
				///  <para>A new group View </para>
				/// </returns>
				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewGroupView(bool isExpanded, global::Android.Views.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Whether the child at the specified position is selectable.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the child is selectable. </para>
				/// </returns>
				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1)]
				public override bool IsChildSelectable(int groupPosition, int childPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SimpleExpandableListAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the number of groups.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of groups </para>
				/// </returns>
				/// <java-name>
				/// getGroupCount
				/// </java-name>
				public override int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether the child and group IDs are stable across changes to the underlying data.</para> <para> <para>Adapter::hasStableIds() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether or not the same ID always refers to the same object </para>
				/// </returns>
				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>SlidingDrawer hides content out of the screen and allows the user to drag a handle to bring the content on screen. SlidingDrawer can be used vertically or horizontally.</para> <para>A special widget composed of two children views: the handle, that the users drags, and the content, attached to the handle and dragged with it.</para> <para>SlidingDrawer should be used as an overlay inside layouts. This means SlidingDrawer should only be used inside of a FrameLayout or a RelativeLayout for instance. The size of the SlidingDrawer defines how much space the content will occupy once slid out so SlidingDrawer should usually use match_parent for both its dimensions.</para> <para>Inside an XML layout, SlidingDrawer must define the id of the handle and of the content:</para> <para> <pre>
		/// &lt;SlidingDrawer
		///     android:id="@+id/drawer"
		///     android:layout_width="match_parent"
		///     android:layout_height="match_parent"</pre></para> <para> <pre>    android:handle="@+id/handle"
		///     android:content="@+id/content"&gt;</pre></para> <para> <pre>    &lt;ImageView
		///         android:id="@id/handle"
		///         android:layout_width="88dip"
		///         android:layout_height="44dip" /&gt;</pre></para> <para> <pre>    &lt;GridView
		///         android:id="@id/content"
		///         android:layout_width="match_parent"
		///         android:layout_height="match_parent" /&gt;</pre></para> <para> <pre>&lt;/SlidingDrawer&gt;
		/// </pre></para> <para>ref android.R.styleable::SlidingDrawer_content  ref android.R.styleable::SlidingDrawer_handle  ref android.R.styleable::SlidingDrawer_topOffset  ref android.R.styleable::SlidingDrawer_bottomOffset  ref android.R.styleable::SlidingDrawer_orientation  ref android.R.styleable::SlidingDrawer_allowSingleTap  ref android.R.styleable::SlidingDrawer_animateOnClick</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This class is not supported anymore. It is recommended you base your own implementation on the source code for the Android Open Source Project if you must use it in your application. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/SlidingDrawer
		/// </java-name>
		[Dot42.DexImport("android/widget/SlidingDrawer", AccessFlags = 33)]
		public partial class SlidingDrawer : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORIENTATION_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_HORIZONTAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_HORIZONTAL = 0;
				/// <java-name>
				/// ORIENTATION_VERTICAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_VERTICAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_VERTICAL = 1;
				/// <summary>
				///  <para>Creates a new SlidingDrawer from a specified set of attributes defined in XML.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SlidingDrawer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SlidingDrawer from a specified set of attributes defined in XML.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SlidingDrawer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Toggles the drawer open and close. Takes effect immediately.</para> <para> <para>open() </para> <para>close() </para> <para>animateClose() </para> <para>animateOpen() </para> <para>animateToggle() </para></para>        
				/// </summary>
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Toggles the drawer open and close with an animation.</para> <para> <para>open() </para> <para>close() </para> <para>animateClose() </para> <para>animateOpen() </para> <para>toggle() </para></para>        
				/// </summary>
				/// <java-name>
				/// animateToggle
				/// </java-name>
				[Dot42.DexImport("animateToggle", "()V", AccessFlags = 1)]
				public virtual void AnimateToggle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Opens the drawer immediately.</para> <para> <para>toggle() </para> <para>close() </para> <para>animateOpen() </para></para>        
				/// </summary>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()V", AccessFlags = 1)]
				public virtual void Open() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the drawer immediately.</para> <para> <para>toggle() </para> <para>open() </para> <para>animateClose() </para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the drawer with an animation.</para> <para> <para>close() </para> <para>open() </para> <para>animateOpen() </para> <para>animateToggle() </para> <para>toggle() </para></para>        
				/// </summary>
				/// <java-name>
				/// animateClose
				/// </java-name>
				[Dot42.DexImport("animateClose", "()V", AccessFlags = 1)]
				public virtual void AnimateClose() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Opens the drawer with an animation.</para> <para> <para>close() </para> <para>open() </para> <para>animateClose() </para> <para>animateToggle() </para> <para>toggle() </para></para>        
				/// </summary>
				/// <java-name>
				/// animateOpen
				/// </java-name>
				[Dot42.DexImport("animateOpen", "()V", AccessFlags = 1)]
				public virtual void AnimateOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener that receives a notification when the drawer becomes open.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDrawerOpenListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerOpenListener(global::Android.Widget.SlidingDrawer.IOnDrawerOpenListener onDrawerOpenListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener that receives a notification when the drawer becomes close.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDrawerCloseListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerCloseListener(global::Android.Widget.SlidingDrawer.IOnDrawerCloseListener onDrawerCloseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener that receives a notification when the drawer starts or ends a scroll. A fling is considered as a scroll. A fling will also trigger a drawer opened or drawer closed event.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDrawerScrollListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerScrollListener(global::Android.Widget.SlidingDrawer.IOnDrawerScrollListener onDrawerScrollListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unlocks the SlidingDrawer so that touch events are processed.</para> <para> <para>lock() </para></para>        
				/// </summary>
				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
				public virtual void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Locks the SlidingDrawer so that touch events are ignores.</para> <para> <para>unlock() </para></para>        
				/// </summary>
				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
				public virtual void Lock() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SlidingDrawer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the handle of the drawer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The View reprenseting the handle of the drawer, identified by the "handle" id in XML. </para>
				/// </returns>
				/// <java-name>
				/// getHandle
				/// </java-name>
				public virtual global::Android.Views.View Handle
				{
						[Dot42.DexImport("getHandle", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Returns the content of the drawer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The View reprenseting the content of the drawer, identified by the "content" id in XML. </para>
				/// </returns>
				/// <java-name>
				/// getContent
				/// </java-name>
				public virtual global::Android.Views.View Content
				{
						[Dot42.DexImport("getContent", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Indicates whether the drawer is currently fully opened.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the drawer is opened, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isOpened
				/// </java-name>
				public virtual bool IsOpened
				{
						[Dot42.DexImport("isOpened", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the drawer is scrolling or flinging.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the drawer is scroller or flinging, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isMoving
				/// </java-name>
				public virtual bool IsMoving
				{
						[Dot42.DexImport("isMoving", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Callback invoked when the drawer is scrolled. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerScrollListener", AccessFlags = 1545)]
				public partial interface IOnDrawerScrollListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Invoked when the user starts dragging/flinging the drawer's handle. </para>        
						/// </summary>
						/// <java-name>
						/// onScrollStarted
						/// </java-name>
						[Dot42.DexImport("onScrollStarted", "()V", AccessFlags = 1025)]
						void OnScrollStarted() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Invoked when the user stops dragging/flinging the drawer's handle. </para>        
						/// </summary>
						/// <java-name>
						/// onScrollEnded
						/// </java-name>
						[Dot42.DexImport("onScrollEnded", "()V", AccessFlags = 1025)]
						void OnScrollEnded() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Callback invoked when the drawer is closed. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerCloseListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerCloseListener", AccessFlags = 1545)]
				public partial interface IOnDrawerCloseListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Invoked when the drawer becomes fully closed. </para>        
						/// </summary>
						/// <java-name>
						/// onDrawerClosed
						/// </java-name>
						[Dot42.DexImport("onDrawerClosed", "()V", AccessFlags = 1025)]
						void OnDrawerClosed() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Callback invoked when the drawer is opened. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerOpenListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerOpenListener", AccessFlags = 1545)]
				public partial interface IOnDrawerOpenListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Invoked when the drawer becomes fully open. </para>        
						/// </summary>
						/// <java-name>
						/// onDrawerOpened
						/// </java-name>
						[Dot42.DexImport("onDrawerOpened", "()V", AccessFlags = 1025)]
						void OnDrawerOpened() /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A view that displays one child at a time and lets the user pick among them. The items in the Spinner come from the Adapter associated with this view.</para> <para>See the  guide.</para> <para>ref android.R.styleable::Spinner_dropDownHorizontalOffset  ref android.R.styleable::Spinner_dropDownSelector  ref android.R.styleable::Spinner_dropDownVerticalOffset  ref android.R.styleable::Spinner_dropDownWidth  ref android.R.styleable::Spinner_gravity  ref android.R.styleable::Spinner_popupBackground  ref android.R.styleable::Spinner_prompt  ref android.R.styleable::Spinner_spinnerMode </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Spinner
		/// </java-name>
		[Dot42.DexImport("android/widget/Spinner", AccessFlags = 33)]
		public partial class Spinner : global::Android.Widget.AbsSpinner, global::Android.Content.IDialogInterface_IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Construct a new spinner with the given context's theme.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a new spinner with the given context's theme and the supplied mode of displaying choices.  <code>mode</code> may be one of MODE_DIALOG or MODE_DROPDOWN.</para> <para> <para>MODE_DIALOG </para> <para>MODE_DROPDOWN </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct a new spinner with the given context's theme, the supplied attribute set, and default style.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>android.view.View::onLayout(boolean,int,int,int,int)</para>Creates and positions all views </para>        
				/// </summary>
				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public override bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This method will be invoked when a button in the dialog is clicked.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialog, int which) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the prompt to display when the dialog is shown. </para>        
				/// </summary>
				/// <java-name>
				/// setPromptId
				/// </java-name>
				[Dot42.DexImport("setPromptId", "(I)V", AccessFlags = 1)]
				public virtual void SetPromptId(int promptId) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Spinner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The prompt to display when the dialog is shown </para>
				/// </returns>
				/// <java-name>
				/// getPrompt
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Prompt
				{
						[Dot42.DexImport("getPrompt", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setPrompt", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>A spinner does not support item click events. Calling this method will raise an exception.</para> <para>Instead use AdapterView#setOnItemSelectedListener.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnItemClickListener
				/// </java-name>
				public override global::Android.Widget.AdapterView<global::Android.Widget.ISpinnerAdapter>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Container for a tabbed window view. This object holds two children: a set of tab labels that the user clicks to select a specific tab, and a FrameLayout object that displays the contents of that page. The individual elements are typically controlled using this container object, rather than setting values on the child elements themselves. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TabHost
		/// </java-name>
		[Dot42.DexImport("android/widget/TabHost", AccessFlags = 33)]
		public partial class TabHost : global::Android.Widget.FrameLayout, global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TabHost(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TabHost(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a new TabSpec associated with this tab host. </para>        
				/// </summary>
				/// <java-name>
				/// newTabSpec
				/// </java-name>
				[Dot42.DexImport("newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
				public virtual global::Android.Widget.TabHost.TabSpec NewTabSpec(string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TabHost.TabSpec);
				}

				/// <summary>
				///  <para>Call setup() before adding tabs if loading TabHost using findViewById().  <b> <b>However</b>: You do not need to call setup() after getTabHost() in TabActivity. Example:</b></para> <para> <b>  <pre>mTabHost = (TabHost)findViewById(R.id.tabhost);
				/// mTabHost.setup();
				/// mTabHost.addTab(TAB_TAG_1, "Hello, world!", "Tab 1");
				/// </pre></b></para>        
				/// </summary>
				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "()V", AccessFlags = 1)]
				public virtual void Setup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If you are using TabSpec#setContent(android.content.Intent), this must be called since the activityGroup is needed to launch the local activity.</para> <para>This is done for you if you extend android.app.TabActivity. </para>        
				/// </summary>
				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "(Landroid/app/LocalActivityManager;)V", AccessFlags = 1)]
				public virtual void Setup(global::Android.App.LocalActivityManager activityGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Callback method to be invoked when the touch mode changes.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onTouchModeChanged
				/// </java-name>
				[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnTouchModeChanged(bool isInTouchMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a tab. </para>        
				/// </summary>
				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/widget/TabHost$TabSpec;)V", AccessFlags = 1)]
				public virtual void AddTab(global::Android.Widget.TabHost.TabSpec tabSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes all tabs from the tab widget associated with this tab host. </para>        
				/// </summary>
				/// <java-name>
				/// clearAllTabs
				/// </java-name>
				[Dot42.DexImport("clearAllTabs", "()V", AccessFlags = 1)]
				public virtual void ClearAllTabs() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCurrentTabByTag
				/// </java-name>
				[Dot42.DexImport("setCurrentTabByTag", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCurrentTabByTag(string tag) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void DispatchWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the selected state of any of the items in this list changes </para>        
				/// </summary>
				/// <java-name>
				/// setOnTabChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnTabChangedListener(global::Android.Widget.TabHost.IOnTabChangeListener l) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TabHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTabWidget
				/// </java-name>
				public virtual global::Android.Widget.TabWidget TabWidget
				{
						[Dot42.DexImport("getTabWidget", "()Landroid/widget/TabWidget;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabWidget); }
				}

				/// <java-name>
				/// getCurrentTab
				/// </java-name>
				public virtual int CurrentTab
				{
						[Dot42.DexImport("getCurrentTab", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCurrentTab", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentTabTag
				/// </java-name>
				public virtual string CurrentTabTag
				{
						[Dot42.DexImport("getCurrentTabTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCurrentTabView
				/// </java-name>
				public virtual global::Android.Views.View CurrentTabView
				{
						[Dot42.DexImport("getCurrentTabView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getCurrentView
				/// </java-name>
				public virtual global::Android.Views.View CurrentView
				{
						[Dot42.DexImport("getCurrentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Get the FrameLayout which holds tab content </para>        
				/// </summary>
				/// <java-name>
				/// getTabContentView
				/// </java-name>
				public virtual global::Android.Widget.FrameLayout TabContentView
				{
						[Dot42.DexImport("getTabContentView", "()Landroid/widget/FrameLayout;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.FrameLayout); }
				}

				/// <summary>
				///  <para>A tab has a tab indicator, content, and a tag that is used to keep track of it. This builder helps choose among these options.</para> <para>For the tab indicator, your choices are: 1) set a label 2) set a label and an icon</para> <para>For the tab content, your choices are: 1) the id of a View 2) a TabContentFactory that creates the View content. 3) an Intent that launches an android.app.Activity. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TabHost$TabSpec
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$TabSpec", AccessFlags = 1)]
				public partial class TabSpec
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/widget/TabHost;", AccessFlags = 4112)]
						internal readonly global::Android.Widget.TabHost This_0;
						[Dot42.DexImport("<init>", "(Landroid/widget/TabHost;)V", AccessFlags = 0)]
						internal TabSpec(global::Android.Widget.TabHost tabHost) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Specify a view as the tab indicator. </para>        
						/// </summary>
						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Java.Lang.ICharSequence view) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <summary>
						///  <para>Specify a label and icon as the tab indicator. </para>        
						/// </summary>
						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/Tab" +
    "Host$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Java.Lang.ICharSequence label, global::Android.Graphics.Drawables.Drawable icon) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <summary>
						///  <para>Specify a view as the tab indicator. </para>        
						/// </summary>
						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <summary>
						///  <para>Specify the id of the view that should be used as the content of the tab. </para>        
						/// </summary>
						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(I)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(int viewId) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <summary>
						///  <para>Specify the id of the view that should be used as the content of the tab. </para>        
						/// </summary>
						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(global::Android.Widget.TabHost.ITabContentFactory viewId) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <summary>
						///  <para>Specify the id of the view that should be used as the content of the tab. </para>        
						/// </summary>
						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(global::Android.Content.Intent viewId) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal TabSpec() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						public virtual string Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

				}

				/// <summary>
				///  <para>Makes the content of a tab when it is selected. Use this if your tab content needs to be created on demand, i.e. you are not showing an existing view or starting an activity. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TabHost$TabContentFactory
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$TabContentFactory", AccessFlags = 1545)]
				public partial interface ITabContentFactory
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback to make the tab contents</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The view to display the contents of the selected tab. </para>
						/// </returns>
						/// <java-name>
						/// createTabContent
						/// </java-name>
						[Dot42.DexImport("createTabContent", "(Ljava/lang/String;)Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View CreateTabContent(string tag) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when tab changed </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TabHost$OnTabChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$OnTabChangeListener", AccessFlags = 1545)]
				public partial interface IOnTabChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTabChanged
						/// </java-name>
						[Dot42.DexImport("onTabChanged", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnTabChanged(string tabId) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A layout that arranges its children into rows and columns. A TableLayout consists of a number of android.widget.TableRow objects, each defining a row (actually, you can have other children, which will be explained below). TableLayout containers do not display border lines for their rows, columns, or cells. Each row has zero or more cells; each cell can hold one View object. The table has as many columns as the row with the most cells. A table can leave cells empty. Cells can span columns, as they can in HTML.</para> <para>The width of a column is defined by the row with the widest cell in that column. However, a TableLayout can specify certain columns as shrinkable or stretchable by calling setColumnShrinkable() or setColumnStretchable(). If marked as shrinkable, the column width can be shrunk to fit the table into its parent object. If marked as stretchable, it can expand in width to fit any extra space. The total width of the table is defined by its parent container. It is important to remember that a column can be both shrinkable and stretchable. In such a situation, the column will change its size to always use up the available space, but never more. Finally, you can hide a column by calling setColumnCollapsed().</para> <para>The children of a TableLayout cannot specify the  <code>layout_width</code> attribute. Width is always  <code>MATCH_PARENT</code>. However, the  <code>layout_height</code> attribute can be defined by a child; default value is android.widget.TableLayout.LayoutParams#WRAP_CONTENT. If the child is a android.widget.TableRow, then the height is always android.widget.TableLayout.LayoutParams#WRAP_CONTENT.</para> <para>Cells must be added to a row in increasing column order, both in code and XML. Column numbers are zero-based. If you don't specify a column number for a child cell, it will autoincrement to the next available column. If you skip a column number, it will be considered an empty cell in that row. See the TableLayout examples in ApiDemos for examples of creating tables in XML.</para> <para>Although the typical child of a TableLayout is a TableRow, you can actually use any View subclass as a direct child of TableLayout. The View will be displayed as a single row that spans all the table columns.</para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TableLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/TableLayout", AccessFlags = 33)]
		public partial class TableLayout : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new TableLayout for the given context.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TableLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new TableLayout for the given context and with the specified set attributes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TableLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Called when something has changed which has invalidated the layout of a child of this view parent. This will schedule a layout pass of the view tree.</para> </para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Collapses or restores a given column. When collapsed, a column does not appear on screen and the extra space is reclaimed by the other columns. A column is collapsed/restored only when it belongs to a android.widget.TableRow.</para> <para>Calling this method requests a layout operation.</para> <para>ref android.R.styleable::TableLayout_collapseColumns </para>        
				/// </summary>
				/// <java-name>
				/// setColumnCollapsed
				/// </java-name>
				[Dot42.DexImport("setColumnCollapsed", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnCollapsed(int columnIndex, bool isCollapsed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the collapsed state of the specified column.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the column is collapsed, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isColumnCollapsed
				/// </java-name>
				[Dot42.DexImport("isColumnCollapsed", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnCollapsed(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Makes the given column stretchable or not. When stretchable, a column takes up as much as available space as possible in its row.</para> <para>Calling this method requests a layout operation.</para> <para>ref android.R.styleable::TableLayout_stretchColumns </para>        
				/// </summary>
				/// <java-name>
				/// setColumnStretchable
				/// </java-name>
				[Dot42.DexImport("setColumnStretchable", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnStretchable(int columnIndex, bool isStretchable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the specified column is stretchable or not.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the column is stretchable, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isColumnStretchable
				/// </java-name>
				[Dot42.DexImport("isColumnStretchable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnStretchable(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Makes the given column shrinkable or not. When a row is too wide, the table can reclaim extra space from shrinkable columns.</para> <para>Calling this method requests a layout operation.</para> <para>ref android.R.styleable::TableLayout_shrinkColumns </para>        
				/// </summary>
				/// <java-name>
				/// setColumnShrinkable
				/// </java-name>
				[Dot42.DexImport("setColumnShrinkable", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnShrinkable(int columnIndex, bool isShrinkable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the specified column is shrinkable or not.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the column is shrinkable, false otherwise. Default is false. </para>
				/// </returns>
				/// <java-name>
				/// isColumnShrinkable
				/// </java-name>
				[Dot42.DexImport("isColumnShrinkable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnShrinkable(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.TableLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TableLayout.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#MATCH_PARENT, and a height of android.view.ViewGroup.LayoutParams#WRAP_CONTENT. </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TableLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether all columns are shrinkable or not.</para> <para>ref android.R.styleable::TableLayout_shrinkColumns </para>        
				/// </summary>
				/// <returns>
				///  <para>true if all columns are shrinkable, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isShrinkAllColumns
				/// </java-name>
				public virtual bool IsShrinkAllColumns
				{
						[Dot42.DexImport("isShrinkAllColumns", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShrinkAllColumns", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Indicates whether all columns are stretchable or not.</para> <para>ref android.R.styleable::TableLayout_stretchColumns </para>        
				/// </summary>
				/// <returns>
				///  <para>true if all columns are stretchable, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isStretchAllColumns
				/// </java-name>
				public virtual bool IsStretchAllColumns
				{
						[Dot42.DexImport("isStretchAllColumns", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStretchAllColumns", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>This set of layout parameters enforces the width of each child to be MATCH_PARENT and the height of each child to be WRAP_CONTENT, but only if the height is not specified.</para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TableLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/TableLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LayoutParams() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Fixes the row's width to android.view.ViewGroup.LayoutParams#MATCH_PARENT; the row's height is fixed to android.view.ViewGroup.LayoutParams#WRAP_CONTENT if no layout height is specified.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray a, int widthAttr, int heightAttr) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>A layout that arranges its children horizontally. A TableRow should always be used as a child of a android.widget.TableLayout. If a TableRow's parent is not a TableLayout, the TableRow will behave as an horizontal android.widget.LinearLayout.</para> <para>The children of a TableRow do not need to specify the  <code>layout_width</code> and  <code>layout_height</code> attributes in the XML file. TableRow always enforces those values to be respectively android.widget.TableLayout.LayoutParams#MATCH_PARENT and android.widget.TableLayout.LayoutParams#WRAP_CONTENT.</para> <para>Also see android.widget.TableRow.LayoutParams for layout attributes </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TableRow
		/// </java-name>
		[Dot42.DexImport("android/widget/TableRow", AccessFlags = 33)]
		public partial class TableRow : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new TableRow for the given context.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TableRow(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new TableRow for the given context and with the specified set attributes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TableRow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVirtualChildAt
				/// </java-name>
				[Dot42.DexImport("getVirtualChildAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetVirtualChildAt(int i) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.TableRow.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TableRow.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a set of layout parameters with a width of android.view.ViewGroup.LayoutParams#MATCH_PARENT, a height of android.view.ViewGroup.LayoutParams#WRAP_CONTENT and no spanning. </para>        
				/// </summary>
				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TableRow() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getVirtualChildCount
				/// </java-name>
				public virtual int VirtualChildCount
				{
						[Dot42.DexImport("getVirtualChildCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Set of layout parameters used in table rows.</para> <para> <para>android.widget.TableLayout.LayoutParams</para>ref android.R.styleable::TableRow_Cell_layout_column  ref android.R.styleable::TableRow_Cell_layout_span </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TableRow$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/TableRow$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The column index of the cell represented by the widget.</para>        
						/// </summary>
						/// <java-name>
						/// column
						/// </java-name>
						[Dot42.DexImport("column", "I", AccessFlags = 1)]
						public int Column;
						/// <summary>
						///  <para>The number of columns the widgets spans over.</para>        
						/// </summary>
						/// <java-name>
						/// span
						/// </java-name>
						[Dot42.DexImport("span", "I", AccessFlags = 1)]
						public int Span;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LayoutParams() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
						public LayoutParams(int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray a, int widthAttr, int heightAttr) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Displays a list of tab labels representing each page in the parent's tab collection. The container object for this widget is TabHost. When the user selects a tab, this object sends a message to the parent container, TabHost, to tell it to switch the displayed page. You typically won't use many methods directly on this object. The container TabHost is used to add labels, add the callback handler, and manage callbacks. You might call this object to iterate the list of tabs, or to tweak the layout of the tab list, but most methods should be called on the containing TabHost object.</para> <para>ref android.R.styleable::TabWidget_divider  ref android.R.styleable::TabWidget_tabStripEnabled  ref android.R.styleable::TabWidget_tabStripLeft  ref android.R.styleable::TabWidget_tabStripRight </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TabWidget
		/// </java-name>
		[Dot42.DexImport("android/widget/TabWidget", AccessFlags = 33)]
		public partial class TabWidget : global::Android.Widget.LinearLayout, global::Android.Views.View.IOnFocusChangeListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal override int GetChildDrawingOrder(int childCount, int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the tab indicator view at the given index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the tab indicator view at the given index </para>
				/// </returns>
				/// <java-name>
				/// getChildTabViewAt
				/// </java-name>
				[Dot42.DexImport("getChildTabViewAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetChildTabViewAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Sets the drawable to use as a divider between the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setDividerDrawable
				/// </java-name>
				[Dot42.DexImport("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetDividerDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable to use as a divider between the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setDividerDrawable
				/// </java-name>
				[Dot42.DexImport("setDividerDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetDividerDrawable(int drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable to use as the left part of the strip below the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setLeftStripDrawable
				/// </java-name>
				[Dot42.DexImport("setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetLeftStripDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable to use as the left part of the strip below the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setLeftStripDrawable
				/// </java-name>
				[Dot42.DexImport("setLeftStripDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetLeftStripDrawable(int drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable to use as the right part of the strip below the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setRightStripDrawable
				/// </java-name>
				[Dot42.DexImport("setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetRightStripDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the drawable to use as the right part of the strip below the tab indicators. </para>        
				/// </summary>
				/// <java-name>
				/// setRightStripDrawable
				/// </java-name>
				[Dot42.DexImport("setRightStripDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetRightStripDrawable(int drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called on the parent when a child's drawable state has changed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void ChildDrawableStateChanged(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public new virtual void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current tab. This method is used to bring a tab to the front of the Widget, and is used to post to the rest of the UI that a different tab has been brought to the foreground.</para> <para>Note, this is separate from the traditional "focus" that is employed from the view logic.</para> <para>For instance, if we have a list in a tabbed view, a user may be navigating up and down the list, moving the UI focus (orange highlighting) through the list items. The cursor movement does not effect the "selected" tab though, because what is being scrolled through is all on the same tab. The selected tab only changes when we navigate between tabs (moving from the list view to the next tabbed view, in this example).</para> <para>To move both the focus AND the selected tab at once, please use setCurrentTab. Normally, the view logic takes care of adjusting the focus, so unless you're circumventing the UI, you'll probably just focus your interest here.</para> <para> <para>focusCurrentTab </para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrentTab
				/// </java-name>
				[Dot42.DexImport("setCurrentTab", "(I)V", AccessFlags = 1)]
				public virtual void SetCurrentTab(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the current tab and focuses the UI on it. This method makes sure that the focused tab matches the selected tab, normally at setCurrentTab. Normally this would not be an issue if we go through the UI, since the UI is responsible for calling TabWidget.onFocusChanged(), but in the case where we are selecting the tab programmatically, we'll need to make sure focus keeps up.</para> <para> <para>setCurrentTab </para></para>        
				/// </summary>
				/// <java-name>
				/// focusCurrentTab
				/// </java-name>
				[Dot42.DexImport("focusCurrentTab", "(I)V", AccessFlags = 1)]
				public virtual void FocusCurrentTab(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Called when the focus state of a view has changed.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onFocusChange
				/// </java-name>
				[Dot42.DexImport("onFocusChange", "(Landroid/view/View;Z)V", AccessFlags = 1)]
				public virtual void OnFocusChange(global::Android.Views.View v, bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TabWidget() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of tab indicator views. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of tab indicator views. </para>
				/// </returns>
				/// <java-name>
				/// getTabCount
				/// </java-name>
				public virtual int TabCount
				{
						[Dot42.DexImport("getTabCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether the bottom strips on the tab indicators are drawn or not. </para>        
				/// </summary>
				/// <java-name>
				/// isStripEnabled
				/// </java-name>
				public virtual bool IsStripEnabled
				{
						[Dot42.DexImport("isStripEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStripEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Specialized android.widget.ViewSwitcher that contains only children of type android.widget.TextView.</para> <para>A TextSwitcher is useful to animate a label on screen. Whenever setText(CharSequence) is called, TextSwitcher animates the current text out and animates the new text in. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TextSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/TextSwitcher", AccessFlags = 33)]
		public partial class TextSwitcher : global::Android.Widget.ViewSwitcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new empty TextSwitcher.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TextSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new empty TextSwitcher for the given context and with the specified set attributes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TextSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text of the next view and switches to the next view. This can be used to animate the old text out and animate the next text in.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text of the text view that is currently showing. This does not perform the animations.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrentText
				/// </java-name>
				[Dot42.DexImport("setCurrentText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCurrentText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TextSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Displays text to the user and optionally allows them to edit it. A TextView is a complete text editor, however the basic class is configured to not allow editing; see EditText for a subclass that configures the text view for editing.</para> <para>To allow users to copy some or all of the TextView's value and paste it somewhere else, set the XML attribute android:textIsSelectable to "true" or call setTextIsSelectable(true). The <c>textIsSelectable </c> flag allows users to make selection gestures in the TextView, which in turn triggers the system's built-in copy/paste controls. </para> <para> <b>XML attributes</b> </para> <para>See TextView Attributes, View Attributes</para> <para>ref android.R.styleable::TextView_text  ref android.R.styleable::TextView_bufferType  ref android.R.styleable::TextView_hint  ref android.R.styleable::TextView_textColor  ref android.R.styleable::TextView_textColorHighlight  ref android.R.styleable::TextView_textColorHint  ref android.R.styleable::TextView_textAppearance  ref android.R.styleable::TextView_textColorLink  ref android.R.styleable::TextView_textSize  ref android.R.styleable::TextView_textScaleX  ref android.R.styleable::TextView_fontFamily  ref android.R.styleable::TextView_typeface  ref android.R.styleable::TextView_textStyle  ref android.R.styleable::TextView_cursorVisible  ref android.R.styleable::TextView_maxLines  ref android.R.styleable::TextView_maxHeight  ref android.R.styleable::TextView_lines  ref android.R.styleable::TextView_height  ref android.R.styleable::TextView_minLines  ref android.R.styleable::TextView_minHeight  ref android.R.styleable::TextView_maxEms  ref android.R.styleable::TextView_maxWidth  ref android.R.styleable::TextView_ems  ref android.R.styleable::TextView_width  ref android.R.styleable::TextView_minEms  ref android.R.styleable::TextView_minWidth  ref android.R.styleable::TextView_gravity  ref android.R.styleable::TextView_scrollHorizontally  ref android.R.styleable::TextView_password  ref android.R.styleable::TextView_singleLine  ref android.R.styleable::TextView_selectAllOnFocus  ref android.R.styleable::TextView_includeFontPadding  ref android.R.styleable::TextView_maxLength  ref android.R.styleable::TextView_shadowColor  ref android.R.styleable::TextView_shadowDx  ref android.R.styleable::TextView_shadowDy  ref android.R.styleable::TextView_shadowRadius  ref android.R.styleable::TextView_autoLink  ref android.R.styleable::TextView_linksClickable  ref android.R.styleable::TextView_numeric  ref android.R.styleable::TextView_digits  ref android.R.styleable::TextView_phoneNumber  ref android.R.styleable::TextView_inputMethod  ref android.R.styleable::TextView_capitalize  ref android.R.styleable::TextView_autoText  ref android.R.styleable::TextView_editable  ref android.R.styleable::TextView_freezesText  ref android.R.styleable::TextView_ellipsize  ref android.R.styleable::TextView_drawableTop  ref android.R.styleable::TextView_drawableBottom  ref android.R.styleable::TextView_drawableRight  ref android.R.styleable::TextView_drawableLeft  ref android.R.styleable::TextView_drawableStart  ref android.R.styleable::TextView_drawableEnd  ref android.R.styleable::TextView_drawablePadding  ref android.R.styleable::TextView_lineSpacingExtra  ref android.R.styleable::TextView_lineSpacingMultiplier  ref android.R.styleable::TextView_marqueeRepeatLimit  ref android.R.styleable::TextView_inputType  ref android.R.styleable::TextView_imeOptions  ref android.R.styleable::TextView_privateImeOptions  ref android.R.styleable::TextView_imeActionLabel  ref android.R.styleable::TextView_imeActionId  ref android.R.styleable::TextView_editorExtras </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TextView
		/// </java-name>
		[Dot42.DexImport("android/widget/TextView", AccessFlags = 33)]
		public partial class TextView : global::Android.Views.View, global::Android.Views.ViewTreeObserver.IOnPreDrawListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the typeface and style in which the text should be displayed, and turns on the fake bold and italic bits in the Paint if the Typeface that you provided does not have all the bits in the style that you specified.</para> <para>ref android.R.styleable::TextView_typeface  ref android.R.styleable::TextView_textStyle </para>        
				/// </summary>
				/// <java-name>
				/// setTypeface
				/// </java-name>
				[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;I)V", AccessFlags = 1)]
				public virtual void SetTypeface(global::Android.Graphics.Typeface tf, int style) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the length, in characters, of the text managed by this TextView </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the Drawables (if any) to appear to the left of, above, to the right of, and below the text. Use null if you do not want a Drawable there. The Drawables must already have had Drawable#setBounds called.</para> <para>ref android.R.styleable::TextView_drawableLeft  ref android.R.styleable::TextView_drawableTop  ref android.R.styleable::TextView_drawableRight  ref android.R.styleable::TextView_drawableBottom </para>        
				/// </summary>
				/// <java-name>
				/// setCompoundDrawables
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid" +
    "/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawables(global::Android.Graphics.Drawables.Drawable left, global::Android.Graphics.Drawables.Drawable top, global::Android.Graphics.Drawables.Drawable right, global::Android.Graphics.Drawables.Drawable bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the Drawables (if any) to appear to the left of, above, to the right of, and below the text. Use 0 if you do not want a Drawable there. The Drawables' bounds will be set to their intrinsic bounds.</para> <para>ref android.R.styleable::TextView_drawableLeft  ref android.R.styleable::TextView_drawableTop  ref android.R.styleable::TextView_drawableRight  ref android.R.styleable::TextView_drawableBottom </para>        
				/// </summary>
				/// <java-name>
				/// setCompoundDrawablesWithIntrinsicBounds
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawablesWithIntrinsicBounds", "(IIII)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawablesWithIntrinsicBounds(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the Drawables (if any) to appear to the left of, above, to the right of, and below the text. Use 0 if you do not want a Drawable there. The Drawables' bounds will be set to their intrinsic bounds.</para> <para>ref android.R.styleable::TextView_drawableLeft  ref android.R.styleable::TextView_drawableTop  ref android.R.styleable::TextView_drawableRight  ref android.R.styleable::TextView_drawableBottom </para>        
				/// </summary>
				/// <java-name>
				/// setCompoundDrawablesWithIntrinsicBounds
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid" +
    "/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawablesWithIntrinsicBounds(global::Android.Graphics.Drawables.Drawable left, global::Android.Graphics.Drawables.Drawable top, global::Android.Graphics.Drawables.Drawable right, global::Android.Graphics.Drawables.Drawable bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public override void SetPadding(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text color, size, style, hint color, and highlight color from the specified TextAppearance resource. </para>        
				/// </summary>
				/// <java-name>
				/// setTextAppearance
				/// </java-name>
				[Dot42.DexImport("setTextAppearance", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetTextAppearance(global::Android.Content.Context context, int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the default text size to a given unit and value. See TypedValue for the possible dimension units.</para> <para>ref android.R.styleable::TextView_textSize </para>        
				/// </summary>
				/// <java-name>
				/// setTextSize
				/// </java-name>
				[Dot42.DexImport("setTextSize", "(IF)V", AccessFlags = 1)]
				public virtual void SetTextSize(int unit, float size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text color for all the states (normal, selected, focused) to be this color.</para> <para> <para>setTextColor(ColorStateList) </para> <para>getTextColors()</para>ref android.R.styleable::TextView_textColor </para>        
				/// </summary>
				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(I)V", AccessFlags = 1)]
				public virtual void SetTextColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text color for all the states (normal, selected, focused) to be this color.</para> <para> <para>setTextColor(ColorStateList) </para> <para>getTextColors()</para>ref android.R.styleable::TextView_textColor </para>        
				/// </summary>
				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 1)]
				public virtual void SetTextColor(global::Android.Content.Res.ColorStateList color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the color used to display the selection highlight.</para> <para>ref android.R.styleable::TextView_textColorHighlight </para>        
				/// </summary>
				/// <java-name>
				/// setHighlightColor
				/// </java-name>
				[Dot42.DexImport("setHighlightColor", "(I)V", AccessFlags = 1)]
				public virtual void SetHighlightColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gives the text a shadow of the specified radius and color, the specified distance from its normal position.</para> <para>ref android.R.styleable::TextView_shadowColor  ref android.R.styleable::TextView_shadowDx  ref android.R.styleable::TextView_shadowDy  ref android.R.styleable::TextView_shadowRadius </para>        
				/// </summary>
				/// <java-name>
				/// setShadowLayer
				/// </java-name>
				[Dot42.DexImport("setShadowLayer", "(FFFI)V", AccessFlags = 1)]
				public virtual void SetShadowLayer(float radius, float dx, float dy, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the color of the hint text for all the states (disabled, focussed, selected...) of this TextView.</para> <para> <para>setHintTextColor(ColorStateList) </para> <para>getHintTextColors() </para> <para>setTextColor(int)</para>ref android.R.styleable::TextView_textColorHint </para>        
				/// </summary>
				/// <java-name>
				/// setHintTextColor
				/// </java-name>
				[Dot42.DexImport("setHintTextColor", "(I)V", AccessFlags = 17)]
				public void SetHintTextColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the color of the hint text for all the states (disabled, focussed, selected...) of this TextView.</para> <para> <para>setHintTextColor(ColorStateList) </para> <para>getHintTextColors() </para> <para>setTextColor(int)</para>ref android.R.styleable::TextView_textColorHint </para>        
				/// </summary>
				/// <java-name>
				/// setHintTextColor
				/// </java-name>
				[Dot42.DexImport("setHintTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 17)]
				public void SetHintTextColor(global::Android.Content.Res.ColorStateList color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the color of links in the text.</para> <para> <para>setLinkTextColor(ColorStateList) </para> <para>getLinkTextColors()</para>ref android.R.styleable::TextView_textColorLink </para>        
				/// </summary>
				/// <java-name>
				/// setLinkTextColor
				/// </java-name>
				[Dot42.DexImport("setLinkTextColor", "(I)V", AccessFlags = 17)]
				public void SetLinkTextColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the color of links in the text.</para> <para> <para>setLinkTextColor(ColorStateList) </para> <para>getLinkTextColors()</para>ref android.R.styleable::TextView_textColorLink </para>        
				/// </summary>
				/// <java-name>
				/// setLinkTextColor
				/// </java-name>
				[Dot42.DexImport("setLinkTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 17)]
				public void SetLinkTextColor(global::Android.Content.Res.ColorStateList color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether the text should be allowed to be wider than the View is. If false, it will be wrapped to the width of the View.</para> <para>ref android.R.styleable::TextView_scrollHorizontally </para>        
				/// </summary>
				/// <java-name>
				/// setHorizontallyScrolling
				/// </java-name>
				[Dot42.DexImport("setHorizontallyScrolling", "(Z)V", AccessFlags = 1)]
				public virtual void SetHorizontallyScrolling(bool whether) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at least this many lines tall.</para> <para>Setting this value overrides any other (minimum) height setting. A single line TextView will set this value to 1.</para> <para> <para>getMinLines()</para>ref android.R.styleable::TextView_minLines </para>        
				/// </summary>
				/// <java-name>
				/// setMinLines
				/// </java-name>
				[Dot42.DexImport("setMinLines", "(I)V", AccessFlags = 1)]
				public virtual void SetMinLines(int minlines) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at least this many pixels tall.</para> <para>Setting this value overrides any other (minimum) number of lines setting.</para> <para>ref android.R.styleable::TextView_minHeight </para>        
				/// </summary>
				/// <java-name>
				/// setMinHeight
				/// </java-name>
				[Dot42.DexImport("setMinHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMinHeight(int minHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at most this many lines tall.</para> <para>Setting this value overrides any other (maximum) height setting.</para> <para>ref android.R.styleable::TextView_maxLines </para>        
				/// </summary>
				/// <java-name>
				/// setMaxLines
				/// </java-name>
				[Dot42.DexImport("setMaxLines", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxLines(int maxlines) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at most this many pixels tall. This option is mutually exclusive with the setMaxLines(int) method.</para> <para>Setting this value overrides any other (maximum) number of lines setting.</para> <para>ref android.R.styleable::TextView_maxHeight </para>        
				/// </summary>
				/// <java-name>
				/// setMaxHeight
				/// </java-name>
				[Dot42.DexImport("setMaxHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxHeight(int maxHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView exactly this many lines tall.</para> <para>Note that setting this value overrides any other (minimum / maximum) number of lines or height setting. A single line TextView will set this value to 1.</para> <para>ref android.R.styleable::TextView_lines </para>        
				/// </summary>
				/// <java-name>
				/// setLines
				/// </java-name>
				[Dot42.DexImport("setLines", "(I)V", AccessFlags = 1)]
				public virtual void SetLines(int lines) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView exactly this many pixels tall. You could do the same thing by specifying this number in the LayoutParams.</para> <para>Note that setting this value overrides any other (minimum / maximum) number of lines or height setting.</para> <para>ref android.R.styleable::TextView_height </para>        
				/// </summary>
				/// <java-name>
				/// setHeight
				/// </java-name>
				[Dot42.DexImport("setHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetHeight(int pixels) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at least this many ems wide</para> <para>ref android.R.styleable::TextView_minEms </para>        
				/// </summary>
				/// <java-name>
				/// setMinEms
				/// </java-name>
				[Dot42.DexImport("setMinEms", "(I)V", AccessFlags = 1)]
				public virtual void SetMinEms(int minems) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at least this many pixels wide</para> <para>ref android.R.styleable::TextView_minWidth </para>        
				/// </summary>
				/// <java-name>
				/// setMinWidth
				/// </java-name>
				[Dot42.DexImport("setMinWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMinWidth(int minpixels) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at most this many ems wide</para> <para>ref android.R.styleable::TextView_maxEms </para>        
				/// </summary>
				/// <java-name>
				/// setMaxEms
				/// </java-name>
				[Dot42.DexImport("setMaxEms", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxEms(int maxems) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView at most this many pixels wide</para> <para>ref android.R.styleable::TextView_maxWidth </para>        
				/// </summary>
				/// <java-name>
				/// setMaxWidth
				/// </java-name>
				[Dot42.DexImport("setMaxWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxWidth(int maxpixels) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView exactly this many ems wide</para> <para> <para>setMaxEms(int) </para> <para>setMinEms(int) </para> <para>getMinEms() </para> <para>getMaxEms()</para>ref android.R.styleable::TextView_ems </para>        
				/// </summary>
				/// <java-name>
				/// setEms
				/// </java-name>
				[Dot42.DexImport("setEms", "(I)V", AccessFlags = 1)]
				public virtual void SetEms(int ems) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes the TextView exactly this many pixels wide. You could do the same thing by specifying this number in the LayoutParams.</para> <para> <para>setMaxWidth(int) </para> <para>setMinWidth(int) </para> <para>getMinWidth() </para> <para>getMaxWidth()</para>ref android.R.styleable::TextView_width </para>        
				/// </summary>
				/// <java-name>
				/// setWidth
				/// </java-name>
				[Dot42.DexImport("setWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetWidth(int pixels) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets line spacing for this TextView. Each line will have its height multiplied by  <code>mult</code> and have  <code>add</code> added to it.</para> <para>ref android.R.styleable::TextView_lineSpacingExtra  ref android.R.styleable::TextView_lineSpacingMultiplier </para>        
				/// </summary>
				/// <java-name>
				/// setLineSpacing
				/// </java-name>
				[Dot42.DexImport("setLineSpacing", "(FF)V", AccessFlags = 1)]
				public virtual void SetLineSpacing(float add, float mult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method: Append the specified text to the TextView's display buffer, upgrading it to BufferType.EDITABLE if it was not already editable. </para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void Append(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method: Append the specified text slice to the TextView's display buffer, upgrading it to BufferType.EDITABLE if it was not already editable. </para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)V", AccessFlags = 1)]
				public virtual void Append(global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the Factory used to create new Editables. </para>        
				/// </summary>
				/// <java-name>
				/// setEditableFactory
				/// </java-name>
				[Dot42.DexImport("setEditableFactory", "(Landroid/text/Editable$Factory;)V", AccessFlags = 17)]
				public void SetEditableFactory(global::Android.Text.IEditable_Factory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the Factory used to create new Spannables. </para>        
				/// </summary>
				/// <java-name>
				/// setSpannableFactory
				/// </java-name>
				[Dot42.DexImport("setSpannableFactory", "(Landroid/text/Spannable$Factory;)V", AccessFlags = 17)]
				public void SetSpannableFactory(global::Android.Text.ISpannable_Factory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like setText(CharSequence), except that the cursor position (if any) is retained in the new text.</para> <para> <para>setText(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTextKeepState
				/// </java-name>
				[Dot42.DexImport("setTextKeepState", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void SetTextKeepState(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the TextView to display the specified slice of the specified char array. You must promise that you will not change the contents of the array except for right before another call to setText(), since the TextView has no way to know that the text has changed and that it needs to invalidate and re-layout. </para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "([CII)V", AccessFlags = 17)]
				public void SetText(char[] text, int start, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Like setText(CharSequence, android.widget.TextView.BufferType), except that the cursor position (if any) is retained in the new text.</para> <para> <para>setText(CharSequence, android.widget.TextView.BufferType) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTextKeepState
				/// </java-name>
				[Dot42.DexImport("setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 17)]
				public void SetTextKeepState(global::Java.Lang.ICharSequence text, global::Android.Widget.TextView.BufferType type) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(I)V", AccessFlags = 17)]
				public void SetText(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(ILandroid/widget/TextView$BufferType;)V", AccessFlags = 17)]
				public void SetText(int int32, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the text to be displayed when the text of the TextView is empty, from a resource.</para> <para>ref android.R.styleable::TextView_hint </para>        
				/// </summary>
				/// <java-name>
				/// setHint
				/// </java-name>
				[Dot42.DexImport("setHint", "(I)V", AccessFlags = 17)]
				public void SetHint(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Directly change the content type integer of the text view, without modifying any other state.  <para>setInputType(int) </para> <para>android.text.InputType  ref android.R.styleable::TextView_inputType </para></para>        
				/// </summary>
				/// <java-name>
				/// setRawInputType
				/// </java-name>
				[Dot42.DexImport("setRawInputType", "(I)V", AccessFlags = 1)]
				public virtual void SetRawInputType(int type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the custom IME action associated with the text view, which will be reported to an IME with EditorInfo#actionLabel and EditorInfo#actionId when it has focus.  <para>getImeActionLabel </para> <para>getImeActionId </para> <para>android.view.inputmethod.EditorInfo  ref android.R.styleable::TextView_imeActionLabel  ref android.R.styleable::TextView_imeActionId </para></para>        
				/// </summary>
				/// <java-name>
				/// setImeActionLabel
				/// </java-name>
				[Dot42.DexImport("setImeActionLabel", "(Ljava/lang/CharSequence;I)V", AccessFlags = 1)]
				public virtual void SetImeActionLabel(global::Java.Lang.ICharSequence label, int actionId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a special listener to be called when an action is performed on the text view. This will be called when the enter key is pressed, or when an action supplied to the IME is selected by the user. Setting this means that the normal hard key event will not insert a newline into the text view, even if it is multi-line; holding down the ALT modifier will, however, allow the user to insert a newline character. </para>        
				/// </summary>
				/// <java-name>
				/// setOnEditorActionListener
				/// </java-name>
				[Dot42.DexImport("setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V", AccessFlags = 1)]
				public virtual void SetOnEditorActionListener(global::Android.Widget.TextView.IOnEditorActionListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when an attached input method calls InputConnection.performEditorAction() for this text view. The default implementation will call your action listener supplied to setOnEditorActionListener, or perform a standard operation for EditorInfo.IME_ACTION_NEXT, EditorInfo.IME_ACTION_PREVIOUS, or EditorInfo.IME_ACTION_DONE.</para> <para>For backwards compatibility, if no IME options have been set and the text view would not normally advance focus on enter, then the NEXT and DONE actions received here will be turned into an enter key down/up pair to go through the normal key handling.</para> <para> <para>setOnEditorActionListener </para></para>        
				/// </summary>
				/// <java-name>
				/// onEditorAction
				/// </java-name>
				[Dot42.DexImport("onEditorAction", "(I)V", AccessFlags = 1)]
				public virtual void OnEditorAction(int actionCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the extra input data of the text, which is the TextBoxAttribute.extras Bundle that will be filled in when creating an input connection. The given integer is the resource ID of an XML resource holding an &lt;input-extras&gt; XML tree.</para> <para> <para>getInputExtras(boolean) </para> <para>EditorInfo::extras  ref android.R.styleable::TextView_editorExtras </para></para>        
				/// </summary>
				/// <java-name>
				/// setInputExtras
				/// </java-name>
				[Dot42.DexImport("setInputExtras", "(I)V", AccessFlags = 1)]
				public virtual void SetInputExtras(int xmlResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the input extras currently associated with the text view, which can be viewed as well as modified.</para> <para> <para>setInputExtras(int) </para> <para>EditorInfo::extras  ref android.R.styleable::TextView_editorExtras </para></para>        
				/// </summary>
				/// <java-name>
				/// getInputExtras
				/// </java-name>
				[Dot42.DexImport("getInputExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetInputExtras(bool create) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Sets the right-hand compound drawable of the TextView to the specified icon and sets an error message that will be displayed in a popup when the TextView has focus. The icon and error message will be reset to null when any key events cause changes to the TextView's text. The drawable must already have had Drawable#setBounds set on it. If the  <code>error</code> is  <code>null</code>, the error message will be cleared (and you should provide a  <code>null</code> icon as well). </para>        
				/// </summary>
				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetError(global::Java.Lang.ICharSequence error, global::Android.Graphics.Drawables.Drawable icon) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal virtual bool SetFrame(int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Callback method to be invoked when the view tree is about to be drawn. At this point, all views in the tree have been measured and given a frame. Clients can use this to adjust their scroll bounds or even to request a new layout before drawing occurs.</para> <para> <para>android.view.View::onMeasure </para> <para>android.view.View::onLayout </para> <para>android.view.View::onDraw</para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>Return true to proceed with the current drawing pass, or false to cancel.</para>
				/// </returns>
				/// <java-name>
				/// onPreDraw
				/// </java-name>
				[Dot42.DexImport("onPreDraw", "()Z", AccessFlags = 1)]
				public virtual bool OnPreDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public override void GetFocusedRect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the baseline for the specified line (0...getLineCount() - 1) If bounds is not null, return the top, left, right, bottom extents of the specified line in it. If the internal Layout has not been built, return 0 and set bounds to (0, 0, 0, 0) </para>        
				/// </summary>
				/// <returns>
				///  <para>the Y-coordinate of the baseline </para>
				/// </returns>
				/// <java-name>
				/// getLineBounds
				/// </java-name>
				[Dot42.DexImport("getLineBounds", "(ILandroid/graphics/Rect;)I", AccessFlags = 1)]
				public virtual int GetLineBounds(int line, global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when multiple down/up pairs of the same key have occurred in a row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int keyCode, int count, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key up event has occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCheckIsTextEditor
				/// </java-name>
				[Dot42.DexImport("onCheckIsTextEditor", "()Z", AccessFlags = 1)]
				public override bool OnCheckIsTextEditor() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo outAttrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <summary>
				///  <para>If this TextView contains editable content, extract a portion of it based on the information in  <b>request</b> in to  <b>outText</b>. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the text was successfully extracted, else false. </para>
				/// </returns>
				/// <java-name>
				/// extractText
				/// </java-name>
				[Dot42.DexImport("extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/Extract" +
    "edText;)Z", AccessFlags = 1)]
				public virtual bool ExtractText(global::Android.Views.Inputmethod.ExtractedTextRequest request, global::Android.Views.Inputmethod.ExtractedText outText) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Apply to this text view the given extracted text, as previously returned by extractText(ExtractedTextRequest, ExtractedText). </para>        
				/// </summary>
				/// <java-name>
				/// setExtractedText
				/// </java-name>
				[Dot42.DexImport("setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public virtual void SetExtractedText(global::Android.Views.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the framework in response to a text completion from the current input method, provided by it calling InputConnection.commitCompletion(). The default implementation does nothing; text views that are supporting auto-completion should override this to do their desired behavior.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCommitCompletion
				/// </java-name>
				[Dot42.DexImport("onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public virtual void OnCommitCompletion(global::Android.Views.Inputmethod.CompletionInfo text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()V", AccessFlags = 1)]
				public virtual void BeginBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()V", AccessFlags = 1)]
				public virtual void EndBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the framework in response to a request to begin a batch of edit operations through a call to link beginBatchEdit(). </para>        
				/// </summary>
				/// <java-name>
				/// onBeginBatchEdit
				/// </java-name>
				[Dot42.DexImport("onBeginBatchEdit", "()V", AccessFlags = 1)]
				public virtual void OnBeginBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the framework in response to a request to end a batch of edit operations through a call to link endBatchEdit. </para>        
				/// </summary>
				/// <java-name>
				/// onEndBatchEdit
				/// </java-name>
				[Dot42.DexImport("onEndBatchEdit", "()V", AccessFlags = 1)]
				public virtual void OnEndBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the framework in response to a private command from the current method, provided by it calling InputConnection.performPrivateCommand().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true if you handled the command, else false. </para>
				/// </returns>
				/// <java-name>
				/// onPrivateIMECommand
				/// </java-name>
				[Dot42.DexImport("onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool OnPrivateIMECommand(string action, global::Android.OS.Bundle data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set whether the TextView includes extra top and bottom padding to make room for accents that go above the normal ascent and descent. The default is true.</para> <para> <para>getIncludeFontPadding()</para>ref android.R.styleable::TextView_includeFontPadding </para>        
				/// </summary>
				/// <java-name>
				/// setIncludeFontPadding
				/// </java-name>
				[Dot42.DexImport("setIncludeFontPadding", "(Z)V", AccessFlags = 1)]
				public virtual void SetIncludeFontPadding(bool includepad) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the point, specified by the offset, into the view if it is needed. This has to be called after layout. Returns true if anything changed. </para>        
				/// </summary>
				/// <java-name>
				/// bringPointIntoView
				/// </java-name>
				[Dot42.DexImport("bringPointIntoView", "(I)Z", AccessFlags = 1)]
				public virtual bool BringPointIntoView(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor, if needed, so that it is at an offset that is visible to the user. This will not move the cursor if it represents more than one character (a selection range). This will only work if the TextView contains spannable text; otherwise it will do nothing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the cursor was actually moved, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// moveCursorToVisibleOffset
				/// </java-name>
				[Dot42.DexImport("moveCursorToVisibleOffset", "()Z", AccessFlags = 1)]
				public virtual bool MoveCursorToVisibleOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(I)V", AccessFlags = 1)]
				public virtual void Debug(int depth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the properties of this field (lines, horizontally scrolling, transformation method) to be for a single-line input.</para> <para>ref android.R.styleable::TextView_singleLine </para>        
				/// </summary>
				/// <java-name>
				/// setSingleLine
				/// </java-name>
				[Dot42.DexImport("setSingleLine", "()V", AccessFlags = 1)]
				public virtual void SetSingleLine() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If true, sets the properties of this field (number of lines, horizontally scrolling, transformation method) to be for a single-line input; if false, restores these to the default conditions.</para> <para>Note that the default conditions are not necessarily those that were in effect prior this method, and you may want to reset these properties to your custom values.</para> <para>ref android.R.styleable::TextView_singleLine </para>        
				/// </summary>
				/// <java-name>
				/// setSingleLine
				/// </java-name>
				[Dot42.DexImport("setSingleLine", "(Z)V", AccessFlags = 1)]
				public virtual void SetSingleLine(bool singleLine) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets how many times to repeat the marquee animation. Only applied if the TextView has marquee enabled. Set to -1 to repeat indefinitely.</para> <para> <para>getMarqueeRepeatLimit()</para>ref android.R.styleable::TextView_marqueeRepeatLimit </para>        
				/// </summary>
				/// <java-name>
				/// setMarqueeRepeatLimit
				/// </java-name>
				[Dot42.DexImport("setMarqueeRepeatLimit", "(I)V", AccessFlags = 1)]
				public virtual void SetMarqueeRepeatLimit(int marqueeLimit) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the TextView so that when it takes focus, all the text is selected.</para> <para>ref android.R.styleable::TextView_selectAllOnFocus </para>        
				/// </summary>
				/// <java-name>
				/// setSelectAllOnFocus
				/// </java-name>
				[Dot42.DexImport("setSelectAllOnFocus", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelectAllOnFocus(bool selectAllOnFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set whether the cursor is visible. The default is true. Note that this property only makes sense for editable TextView.</para> <para> <para>isCursorVisible()</para>ref android.R.styleable::TextView_cursorVisible </para>        
				/// </summary>
				/// <java-name>
				/// setCursorVisible
				/// </java-name>
				[Dot42.DexImport("setCursorVisible", "(Z)V", AccessFlags = 1)]
				public virtual void SetCursorVisible(bool visible) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the text is changed, in case any subclasses would like to know.</para> <para>Within  <code>text</code>, the  <code>lengthAfter</code> characters beginning at  <code>start</code> have just replaced old text that had length  <code>lengthBefore</code>. It is an error to attempt to make changes to  <code>text</code> from this callback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 4)]
				protected internal virtual void OnTextChanged(global::Java.Lang.ICharSequence text, int start, int lengthBefore, int lengthAfter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the selection has changed, in case any subclasses would like to know.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onSelectionChanged", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnSelectionChanged(int selStart, int selEnd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a TextWatcher to the list of those whose methods are called whenever this TextView's text changes. </para> <para>In 1.0, the TextWatcher#afterTextChanged method was erroneously not called after setText calls. Now, doing setText if there are any text changed listeners forces the buffer type to Editable if it would not otherwise be and does call this method. </para>        
				/// </summary>
				/// <java-name>
				/// addTextChangedListener
				/// </java-name>
				[Dot42.DexImport("addTextChangedListener", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void AddTextChangedListener(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the specified TextWatcher from the list of those whose methods are called whenever this TextView's text changes. </para>        
				/// </summary>
				/// <java-name>
				/// removeTextChangedListener
				/// </java-name>
				[Dot42.DexImport("removeTextChangedListener", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void RemoveTextChangedListener(global::Android.Text.ITextWatcher watcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onStartTemporaryDetach", "()V", AccessFlags = 1)]
				public override void OnStartTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onFinishTemporaryDetach", "()V", AccessFlags = 1)]
				public override void OnFinishTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool hasWindowFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.Views.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Use BaseInputConnection.removeComposingSpans() to remove any IME composing state from this text view. </para>        
				/// </summary>
				/// <java-name>
				/// clearComposingText
				/// </java-name>
				[Dot42.DexImport("clearComposingText", "()V", AccessFlags = 1)]
				public virtual void ClearComposingText() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true, only while processing a touch gesture, if the initial touch down event caused focus to move to the text view and as a result its selection changed. Only valid while processing the touch gesture of interest, in an editable text view. </para>        
				/// </summary>
				/// <java-name>
				/// didTouchFocusSelect
				/// </java-name>
				[Dot42.DexImport("didTouchFocusSelect", "()Z", AccessFlags = 1)]
				public virtual bool DidTouchFocusSelect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancelLongPress
				/// </java-name>
				[Dot42.DexImport("cancelLongPress", "()V", AccessFlags = 1)]
				public override void CancelLongPress() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setScroller
				/// </java-name>
				[Dot42.DexImport("setScroller", "(Landroid/widget/Scroller;)V", AccessFlags = 1)]
				public virtual void SetScroller(global::Android.Widget.Scroller s) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the TextView_textColor attribute from the TypedArray, if set, or the TextAppearance_textColor from the TextView_textAppearance attribute, if TextView_textColor was not set directly. </para>        
				/// </summary>
				/// <java-name>
				/// getTextColors
				/// </java-name>
				[Dot42.DexImport("getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/C" +
    "olorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList GetTextColors(global::Android.Content.Context context, global::Android.Content.Res.TypedArray attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				///  <para>Returns the default color from the TextView_textColor attribute from the AttributeSet, if set, or the default color from the TextAppearance_textColor from the TextView_textAppearance attribute, if TextView_textColor was not set directly. </para>        
				/// </summary>
				/// <java-name>
				/// getTextColor
				/// </java-name>
				[Dot42.DexImport("getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I", AccessFlags = 9)]
				public static int GetTextColor(global::Android.Content.Context context, global::Android.Content.Res.TypedArray attrs, int def) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyShortcut(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 4)]
				protected internal override void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a context menu option for the text view is selected. Currently this will be one of android.R.id#selectAll, android.R.id#cut, android.R.id#copy or android.R.id#paste.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the context menu item action was performed. </para>
				/// </returns>
				/// <java-name>
				/// onTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public virtual bool OnTextContextMenuItem(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public override bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Subclasses override this to specify that they have a KeyListener by default even if not specifically called for in the XML options. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultEditable
				/// </java-name>
				protected internal virtual bool DefaultEditable
				{
						[Dot42.DexImport("getDefaultEditable", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Subclasses override this to specify a default movement method. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultMovementMethod
				/// </java-name>
				protected internal virtual global::Android.Text.Method.IMovementMethod DefaultMovementMethod
				{
						[Dot42.DexImport("getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 4)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
				}

				/// <summary>
				///  <para>Return the text the TextView is displaying. If setText() was called with an argument of BufferType.SPANNABLE or BufferType.EDITABLE, you can cast the return value from this method to Spannable or Editable, respectively.</para> <para>Note: The content of the return value should not be modified. If you want a modifiable one, you should make your own copy first.</para> <para>ref android.R.styleable::TextView_text </para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Return the text the TextView is displaying as an Editable object. If the text is not editable, null is returned.</para> <para> <para>getText </para></para>        
				/// </summary>
				/// <java-name>
				/// getEditableText
				/// </java-name>
				public virtual global::Android.Text.IEditable EditableText
				{
						[Dot42.DexImport("getEditableText", "()Landroid/text/Editable;", AccessFlags = 1)]
						get{ return default(global::Android.Text.IEditable); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the height of one standard line in pixels. Note that markup within the text can cause individual lines to be taller or shorter than this height, and the layout may contain additional first- or last-line padding. </para>
				/// </returns>
				/// <java-name>
				/// getLineHeight
				/// </java-name>
				public virtual int LineHeight
				{
						[Dot42.DexImport("getLineHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Layout that is currently being used to display the text. This can be null if the text or width has recently changes. </para>
				/// </returns>
				/// <java-name>
				/// getLayout
				/// </java-name>
				public global::Android.Text.Layout Layout
				{
						[Dot42.DexImport("getLayout", "()Landroid/text/Layout;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Layout); }
				}

				/// <summary>
				///  <para>ref android.R.styleable::TextView_numeric  ref android.R.styleable::TextView_digits  ref android.R.styleable::TextView_phoneNumber  ref android.R.styleable::TextView_inputMethod  ref android.R.styleable::TextView_capitalize  ref android.R.styleable::TextView_autoText </para>        
				/// </summary>
				/// <returns>
				///  <para>the current key listener for this TextView. This will frequently be null for non-EditText TextViews.</para>
				/// </returns>
				/// <java-name>
				/// getKeyListener
				/// </java-name>
				public virtual global::Android.Text.Method.IKeyListener KeyListener
				{
						[Dot42.DexImport("getKeyListener", "()Landroid/text/method/KeyListener;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.IKeyListener); }
						[Dot42.DexImport("setKeyListener", "(Landroid/text/method/KeyListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the movement method being used for this TextView. This will frequently be null for non-EditText TextViews. </para>
				/// </returns>
				/// <java-name>
				/// getMovementMethod
				/// </java-name>
				public global::Android.Text.Method.IMovementMethod MovementMethod
				{
						[Dot42.DexImport("getMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
						[Dot42.DexImport("setMovementMethod", "(Landroid/text/method/MovementMethod;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>ref android.R.styleable::TextView_password  ref android.R.styleable::TextView_singleLine </para>        
				/// </summary>
				/// <returns>
				///  <para>the current transformation method for this TextView. This will frequently be null except for single-line and password fields.</para>
				/// </returns>
				/// <java-name>
				/// getTransformationMethod
				/// </java-name>
				public global::Android.Text.Method.ITransformationMethod TransformationMethod
				{
						[Dot42.DexImport("getTransformationMethod", "()Landroid/text/method/TransformationMethod;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.ITransformationMethod); }
						[Dot42.DexImport("setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the top padding of the view, plus space for the top Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundPaddingTop
				/// </java-name>
				public virtual int CompoundPaddingTop
				{
						[Dot42.DexImport("getCompoundPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the bottom padding of the view, plus space for the bottom Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundPaddingBottom
				/// </java-name>
				public virtual int CompoundPaddingBottom
				{
						[Dot42.DexImport("getCompoundPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the left padding of the view, plus space for the left Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundPaddingLeft
				/// </java-name>
				public virtual int CompoundPaddingLeft
				{
						[Dot42.DexImport("getCompoundPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the right padding of the view, plus space for the right Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundPaddingRight
				/// </java-name>
				public virtual int CompoundPaddingRight
				{
						[Dot42.DexImport("getCompoundPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the extended top padding of the view, including both the top Drawable if any and any extra space to keep more than maxLines of text from showing. It is only valid to call this after measuring. </para>        
				/// </summary>
				/// <java-name>
				/// getExtendedPaddingTop
				/// </java-name>
				public virtual int ExtendedPaddingTop
				{
						[Dot42.DexImport("getExtendedPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the extended bottom padding of the view, including both the bottom Drawable if any and any extra space to keep more than maxLines of text from showing. It is only valid to call this after measuring. </para>        
				/// </summary>
				/// <java-name>
				/// getExtendedPaddingBottom
				/// </java-name>
				public virtual int ExtendedPaddingBottom
				{
						[Dot42.DexImport("getExtendedPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total left padding of the view, including the left Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalPaddingLeft
				/// </java-name>
				public virtual int TotalPaddingLeft
				{
						[Dot42.DexImport("getTotalPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total right padding of the view, including the right Drawable if any. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalPaddingRight
				/// </java-name>
				public virtual int TotalPaddingRight
				{
						[Dot42.DexImport("getTotalPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total top padding of the view, including the top Drawable if any, the extra space to keep more than maxLines from showing, and the vertical offset for gravity, if any. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalPaddingTop
				/// </java-name>
				public virtual int TotalPaddingTop
				{
						[Dot42.DexImport("getTotalPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the total bottom padding of the view, including the bottom Drawable if any, the extra space to keep more than maxLines from showing, and the vertical offset for gravity, if any. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalPaddingBottom
				/// </java-name>
				public virtual int TotalPaddingBottom
				{
						[Dot42.DexImport("getTotalPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns drawables for the left, top, right, and bottom borders.</para> <para>ref android.R.styleable::TextView_drawableLeft  ref android.R.styleable::TextView_drawableTop  ref android.R.styleable::TextView_drawableRight  ref android.R.styleable::TextView_drawableBottom </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundDrawables
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable[] CompoundDrawables
				{
						[Dot42.DexImport("getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable[]); }
				}

				/// <summary>
				///  <para>Returns the padding between the compound drawables and the text.</para> <para>ref android.R.styleable::TextView_drawablePadding </para>        
				/// </summary>
				/// <java-name>
				/// getCompoundDrawablePadding
				/// </java-name>
				public virtual int CompoundDrawablePadding
				{
						[Dot42.DexImport("getCompoundDrawablePadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCompoundDrawablePadding", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the autolink mask of the text. See Linkify.ALL and peers for possible values.</para> <para>ref android.R.styleable::TextView_autoLink </para>        
				/// </summary>
				/// <java-name>
				/// getAutoLinkMask
				/// </java-name>
				public int AutoLinkMask
				{
						[Dot42.DexImport("getAutoLinkMask", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setAutoLinkMask", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the size (in pixels) of the default text size in this TextView. </para>
				/// </returns>
				/// <java-name>
				/// getTextSize
				/// </java-name>
				public virtual float TextSize
				{
						[Dot42.DexImport("getTextSize", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTextSize", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the extent by which text is currently being stretched horizontally. This will usually be 1. </para>
				/// </returns>
				/// <java-name>
				/// getTextScaleX
				/// </java-name>
				public virtual float TextScaleX
				{
						[Dot42.DexImport("getTextScaleX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTextScaleX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <para>setTypeface(Typeface)</para>ref android.R.styleable::TextView_fontFamily  ref android.R.styleable::TextView_typeface  ref android.R.styleable::TextView_textStyle </para>        
				/// </summary>
				/// <returns>
				///  <para>the current typeface and style in which the text is being displayed.</para>
				/// </returns>
				/// <java-name>
				/// getTypeface
				/// </java-name>
				public virtual global::Android.Graphics.Typeface Typeface
				{
						[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Typeface); }
						[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the text colors for the different states (normal, selected, focused) of the TextView.</para> <para> <para>setTextColor(ColorStateList) </para> <para>setTextColor(int)</para>ref android.R.styleable::TextView_textColor </para>        
				/// </summary>
				/// <java-name>
				/// getTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList TextColors
				{
						[Dot42.DexImport("getTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <summary>
				///  <para>Return the current color selected for normal text.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current text color. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentTextColor
				/// </java-name>
				public int CurrentTextColor
				{
						[Dot42.DexImport("getCurrentTextColor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the base paint used for the text. Please use this only to consult the Paint's properties and not to change them. </para>
				/// </returns>
				/// <java-name>
				/// getPaint
				/// </java-name>
				public virtual global::Android.Text.TextPaint Paint
				{
						[Dot42.DexImport("getPaint", "()Landroid/text/TextPaint;", AccessFlags = 1)]
						get{ return default(global::Android.Text.TextPaint); }
				}

				/// <summary>
				///  <para>Returns whether the movement method will automatically be set to LinkMovementMethod if setAutoLinkMask has been set to nonzero and links are detected in setText. The default is true.</para> <para>ref android.R.styleable::TextView_linksClickable </para>        
				/// </summary>
				/// <java-name>
				/// getLinksClickable
				/// </java-name>
				public bool LinksClickable
				{
						[Dot42.DexImport("getLinksClickable", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setLinksClickable", "(Z)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the list of URLSpans attached to the text (by Linkify or otherwise) if any. You can call URLSpan#getURL on them to find where they link to or use Spanned#getSpanStart and Spanned#getSpanEnd to find the region of the text they are attached to. </para>        
				/// </summary>
				/// <java-name>
				/// getUrls
				/// </java-name>
				public virtual global::Android.Text.Style.URLSpan[] Urls
				{
						[Dot42.DexImport("getUrls", "()[Landroid/text/style/URLSpan;", AccessFlags = 1)]
						get{ return default(global::Android.Text.Style.URLSpan[]); }
				}

				/// <summary>
				///  <para> <para>setHintTextColor(ColorStateList) </para> <para>setHintTextColor(int) </para> <para>setTextColor(ColorStateList) </para> <para>setLinkTextColor(ColorStateList)</para>ref android.R.styleable::TextView_textColorHint </para>        
				/// </summary>
				/// <returns>
				///  <para>the color of the hint text, for the different states of this TextView.</para>
				/// </returns>
				/// <java-name>
				/// getHintTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList HintTextColors
				{
						[Dot42.DexImport("getHintTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <summary>
				///  <para>Return the current color selected to paint the hint text.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current hint text color. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentHintTextColor
				/// </java-name>
				public int CurrentHintTextColor
				{
						[Dot42.DexImport("getCurrentHintTextColor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <para>setLinkTextColor(ColorStateList) </para> <para>setLinkTextColor(int)</para>ref android.R.styleable::TextView_textColorLink </para>        
				/// </summary>
				/// <returns>
				///  <para>the list of colors used to paint the links in the text, for the different states of this TextView</para>
				/// </returns>
				/// <java-name>
				/// getLinkTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList LinkTextColors
				{
						[Dot42.DexImport("getLinkTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <summary>
				///  <para>Returns the horizontal and vertical alignment of this TextView.</para> <para> <para>android.view.Gravity  ref android.R.styleable::TextView_gravity </para></para>        
				/// </summary>
				/// <java-name>
				/// getGravity
				/// </java-name>
				public virtual int Gravity
				{
						[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <para>Paint::getFlags </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the flags on the Paint being used to display the text. </para>
				/// </returns>
				/// <java-name>
				/// getPaintFlags
				/// </java-name>
				public virtual int PaintFlags
				{
						[Dot42.DexImport("getPaintFlags", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPaintFlags", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return whether this text view is including its entire text contents in frozen icicles.</para> <para> <para>setFreezesText </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if text is included, false if it isn't.</para>
				/// </returns>
				/// <java-name>
				/// getFreezesText
				/// </java-name>
				public virtual bool FreezesText
				{
						[Dot42.DexImport("getFreezesText", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFreezesText", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the hint that is displayed when the text of the TextView is empty.</para> <para>ref android.R.styleable::TextView_hint </para>        
				/// </summary>
				/// <java-name>
				/// getHint
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Hint
				{
						[Dot42.DexImport("getHint", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setHint", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
						set{ }
				}

				/// <summary>
				///  <para>Get the type of the editable content.</para> <para> <para>setInputType(int) </para> <para>android.text.InputType </para></para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public virtual int InputType
				{
						[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInputType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the type of the IME editor.</para> <para> <para>setImeOptions(int) </para> <para>android.view.inputmethod.EditorInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// getImeOptions
				/// </java-name>
				public virtual int ImeOptions
				{
						[Dot42.DexImport("getImeOptions", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setImeOptions", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the IME action label previous set with setImeActionLabel.</para> <para> <para>setImeActionLabel </para> <para>android.view.inputmethod.EditorInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// getImeActionLabel
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence ImeActionLabel
				{
						[Dot42.DexImport("getImeActionLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <summary>
				///  <para>Get the IME action ID previous set with setImeActionLabel.</para> <para> <para>setImeActionLabel </para> <para>android.view.inputmethod.EditorInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// getImeActionId
				/// </java-name>
				public virtual int ImeActionId
				{
						[Dot42.DexImport("getImeActionId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the private type of the content.</para> <para> <para>setPrivateImeOptions(String) </para> <para>EditorInfo::privateImeOptions </para></para>        
				/// </summary>
				/// <java-name>
				/// getPrivateImeOptions
				/// </java-name>
				public virtual string PrivateImeOptions
				{
						[Dot42.DexImport("getPrivateImeOptions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPrivateImeOptions", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the error message that was set to be displayed with setError, or  <code>null</code> if no error was set or if it the error was cleared by the widget after user input. </para>        
				/// </summary>
				/// <java-name>
				/// getError
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Error
				{
						[Dot42.DexImport("getError", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setError", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current list of input filters.</para> <para>ref android.R.styleable::TextView_maxLength </para>        
				/// </summary>
				/// <java-name>
				/// getFilters
				/// </java-name>
				public virtual global::Android.Text.IInputFilter[] Filters
				{
						[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Text.IInputFilter[]); }
						[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isPaddingOffsetRequired
				/// </java-name>
				protected internal override bool IsPaddingOffsetRequired
				{
						[Dot42.DexImport("isPaddingOffsetRequired", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLeftPaddingOffset
				/// </java-name>
				protected internal override int LeftPaddingOffset
				{
						[Dot42.DexImport("getLeftPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPaddingOffset
				/// </java-name>
				protected internal override int TopPaddingOffset
				{
						[Dot42.DexImport("getTopPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPaddingOffset
				/// </java-name>
				protected internal override int BottomPaddingOffset
				{
						[Dot42.DexImport("getBottomPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRightPaddingOffset
				/// </java-name>
				protected internal override int RightPaddingOffset
				{
						[Dot42.DexImport("getRightPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the number of lines of text, or 0 if the internal Layout has not been built. </para>        
				/// </summary>
				/// <java-name>
				/// getLineCount
				/// </java-name>
				public virtual int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Convenience for Selection#getSelectionStart. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectionStart
				/// </java-name>
				public virtual int SelectionStart
				{
						[Dot42.DexImport("getSelectionStart", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Convenience for Selection#getSelectionEnd. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectionEnd
				/// </java-name>
				public virtual int SelectionEnd
				{
						[Dot42.DexImport("getSelectionEnd", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return true iff there is a selection inside this text view. </para>        
				/// </summary>
				/// <java-name>
				/// hasSelection
				/// </java-name>
				public virtual bool HasSelection
				{
						[Dot42.DexImport("hasSelection", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns where, if anywhere, words that are longer than the view is wide should be ellipsized. </para>        
				/// </summary>
				/// <java-name>
				/// getEllipsize
				/// </java-name>
				public virtual global::Android.Text.TextUtils.TruncateAt Ellipsize
				{
						[Dot42.DexImport("getEllipsize", "()Landroid/text/TextUtils$TruncateAt;", AccessFlags = 1)]
						get{ return default(global::Android.Text.TextUtils.TruncateAt); }
						[Dot42.DexImport("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal override float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal override float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns whether this text view is a current input method target. The default implementation just checks with InputMethodManager. </para>        
				/// </summary>
				/// <java-name>
				/// isInputMethodTarget
				/// </java-name>
				public virtual bool IsInputMethodTarget
				{
						[Dot42.DexImport("isInputMethodTarget", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				public override bool IsSelected
				{
						[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/TextView$BufferType
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$BufferType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/widget/TextView$BufferType;>;")]
				public sealed class BufferType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EDITABLE
						/// </java-name>
						[Dot42.DexImport("EDITABLE", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType EDITABLE;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType NORMAL;
						/// <java-name>
						/// SPANNABLE
						/// </java-name>
						[Dot42.DexImport("SPANNABLE", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType SPANNABLE;
						private BufferType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/widget/TextView$BufferType;", AccessFlags = 9)]
						public static BufferType[] Values() /* MethodBuilder.Create */ 
						{
								return default(BufferType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;", AccessFlags = 9)]
						public static BufferType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(BufferType);
						}

				}

				/// <summary>
				///  <para>User interface state that is stored by TextView for implementing View#onSaveInstanceState. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TextView$SavedState
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$SavedState", AccessFlags = 9)]
				public partial class SavedState : global::Android.Views.View.BaseSavedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<SavedState> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SavedState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public override void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when an action is performed on the editor. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TextView$OnEditorActionListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$OnEditorActionListener", AccessFlags = 1545)]
				public partial interface IOnEditorActionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when an action is being performed.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Return true if you have consumed the action, else false. </para>
						/// </returns>
						/// <java-name>
						/// onEditorAction
						/// </java-name>
						[Dot42.DexImport("onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnEditorAction(global::Android.Widget.TextView v, int actionId, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A view for selecting the time of day, in either 24 hour or AM/PM mode. The hour, each minute digit, and AM/PM (if applicable) can be conrolled by vertical spinners. The hour can be entered by keyboard input. Entering in two digit hours can be accomplished by hitting two digits within a timeout of about a second (e.g. '1' then '2' to select 12). The minutes can be entered by entering single digits. Under AM/PM mode, the user can hit 'a', 'A", 'p' or 'P' to pick. For a dialog using this view, see android.app.TimePickerDialog. </para> <para>See the  guide. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TimePicker
		/// </java-name>
		[Dot42.DexImport("android/widget/TimePicker", AccessFlags = 33)]
		public partial class TimePicker : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the callback that indicates the time has been adjusted by the user.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnTimeChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V", AccessFlags = 1)]
				public virtual void SetOnTimeChangedListener(global::Android.Widget.TimePicker.IOnTimeChangedListener onTimeChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set whether in 24 hour or AM/PM mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIs24HourView
				/// </java-name>
				[Dot42.DexImport("setIs24HourView", "(Ljava/lang/Boolean;)V", AccessFlags = 1)]
				public virtual void SetIs24HourView(bool? is24HourView) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TimePicker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current hour in the range (0-23). </para>
				/// </returns>
				/// <java-name>
				/// getCurrentHour
				/// </java-name>
				public virtual int? CurrentHour
				{
						[Dot42.DexImport("getCurrentHour", "()Ljava/lang/Integer;", AccessFlags = 1)]
						get{ return default(int?); }
						[Dot42.DexImport("setCurrentHour", "(Ljava/lang/Integer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this is in 24 hour view else false. </para>
				/// </returns>
				/// <java-name>
				/// is24HourView
				/// </java-name>
				public virtual bool Is24HourView
				{
						[Dot42.DexImport("is24HourView", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current minute. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentMinute
				/// </java-name>
				public virtual int? CurrentMinute
				{
						[Dot42.DexImport("getCurrentMinute", "()Ljava/lang/Integer;", AccessFlags = 1)]
						get{ return default(int?); }
						[Dot42.DexImport("setCurrentMinute", "(Ljava/lang/Integer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>The callback interface used to indicate the time has been adjusted. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/TimePicker$OnTimeChangedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TimePicker$OnTimeChangedListener", AccessFlags = 1545)]
				public partial interface IOnTimeChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <java-name>
						/// onTimeChanged
						/// </java-name>
						[Dot42.DexImport("onTimeChanged", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1025)]
						void OnTimeChanged(global::Android.Widget.TimePicker view, int hourOfDay, int minute) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A toast is a view containing a quick little message for the user. The toast class helps you create and show those. {}</para> <para>When the view is shown to the user, appears as a floating view over the application. It will never receive focus. The user will probably be in the middle of typing something else. The idea is to be as unobtrusive as possible, while still showing the user the information you want them to see. Two examples are the volume control, and the brief message saying that your settings have been saved. </para> <para>The easiest way to use this class is to call one of the static methods that constructs everything you need and returns a new Toast object.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about creating Toast notifications, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/Toast
		/// </java-name>
		[Dot42.DexImport("android/widget/Toast", AccessFlags = 33)]
		public partial class Toast
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Show the view or text notification for a short period of time. This time could be user-definable. This is the default.  <para>setDuration </para></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_SHORT
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORT", "I", AccessFlags = 25)]
				public const int LENGTH_SHORT = 0;
				/// <summary>
				///  <para>Show the view or text notification for a long period of time. This time could be user-definable.  <para>setDuration </para></para>        
				/// </summary>
				/// <java-name>
				/// LENGTH_LONG
				/// </java-name>
				[Dot42.DexImport("LENGTH_LONG", "I", AccessFlags = 25)]
				public const int LENGTH_LONG = 1;
				/// <summary>
				///  <para>Construct an empty Toast object. You must call setView before you can call show.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Toast(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Show the view for the specified duration. </para>        
				/// </summary>
				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Close the view if it's showing, or don't show it if it isn't showing yet. You do not normally have to call this. Normally view will disappear on its own after the appropriate duration. </para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the margins of the view.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMargin
				/// </java-name>
				[Dot42.DexImport("setMargin", "(FF)V", AccessFlags = 1)]
				public virtual void SetMargin(float horizontalMargin, float verticalMargin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the location at which the notification should appear on the screen.  <para>android.view.Gravity </para> <para>getGravity </para></para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(III)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity, int xOffset, int yOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make a standard toast that just contains a text view with the text from a resource.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// makeText
				/// </java-name>
				[Dot42.DexImport("makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;", AccessFlags = 9)]
				public static global::Android.Widget.Toast MakeText(global::Android.Content.Context context, global::Java.Lang.ICharSequence resId, int duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Toast);
				}

				/// <summary>
				///  <para>Make a standard toast that just contains a text view with the text from a resource.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// makeText
				/// </java-name>
				[Dot42.DexImport("makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;", AccessFlags = 9)]
				public static global::Android.Widget.Toast MakeText(global::Android.Content.Context context, int resId, int duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Toast);
				}

				/// <summary>
				///  <para>Update the text in a Toast that was previously created using one of the makeText() methods. </para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(I)V", AccessFlags = 1)]
				public virtual void SetText(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update the text in a Toast that was previously created using one of the makeText() methods. </para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Toast() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the view.  <para>setView </para></para>        
				/// </summary>
				/// <java-name>
				/// getView
				/// </java-name>
				public virtual global::Android.Views.View View
				{
						[Dot42.DexImport("getView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the duration.  <para>setDuration </para></para>        
				/// </summary>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDuration", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return the horizontal margin. </para>        
				/// </summary>
				/// <java-name>
				/// getHorizontalMargin
				/// </java-name>
				public virtual float HorizontalMargin
				{
						[Dot42.DexImport("getHorizontalMargin", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the vertical margin. </para>        
				/// </summary>
				/// <java-name>
				/// getVerticalMargin
				/// </java-name>
				public virtual float VerticalMargin
				{
						[Dot42.DexImport("getVerticalMargin", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Get the location at which the notification should appear on the screen.  <para>android.view.Gravity </para> <para>getGravity </para></para>        
				/// </summary>
				/// <java-name>
				/// getGravity
				/// </java-name>
				public virtual int Gravity
				{
						[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the X offset in pixels to apply to the gravity's location. </para>        
				/// </summary>
				/// <java-name>
				/// getXOffset
				/// </java-name>
				public virtual int XOffset
				{
						[Dot42.DexImport("getXOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the Y offset in pixels to apply to the gravity's location. </para>        
				/// </summary>
				/// <java-name>
				/// getYOffset
				/// </java-name>
				public virtual int YOffset
				{
						[Dot42.DexImport("getYOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Displays checked/unchecked states as a button with a "light" indicator and by default accompanied with the text "ON" or "OFF".</para> <para>See the  guide.</para> <para>ref android.R.styleable::ToggleButton_textOn  ref android.R.styleable::ToggleButton_textOff  ref android.R.styleable::ToggleButton_disabledAlpha </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ToggleButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ToggleButton", AccessFlags = 33)]
		public partial class ToggleButton : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable d) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ToggleButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the text for when the button is in the checked state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getTextOn
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOn
				{
						[Dot42.DexImport("getTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the text for when the button is not in the checked state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getTextOff
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOff
				{
						[Dot42.DexImport("getTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Change the checked state of the view</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChecked
				/// </java-name>
				public override bool IsChecked
				{
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>A view group with two children, intended for use in ListViews. This item has two TextViews elements (or subclasses) with the ID values text1 and text2. There is an optional third View element with the ID selectedIcon, which can be any View subclass (though it is typically a graphic View, such as ImageView) that can be displayed when a TwoLineListItem has focus. Android supplies a standard layout resource for TwoLineListView (which does not include a selected item icon), but you can design your own custom XML layout for this object.</para> <para>ref android.R.styleable::TwoLineListItem_mode</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This class can be implemented easily by apps using a RelativeLayout or a LinearLayout. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/widget/TwoLineListItem
		/// </java-name>
		[Dot42.DexImport("android/widget/TwoLineListItem", AccessFlags = 33)]
		public partial class TwoLineListItem : global::Android.Widget.RelativeLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal TwoLineListItem() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a handle to the item with ID text1. </para>        
				/// </summary>
				/// <returns>
				///  <para>A handle to the item with ID text1. </para>
				/// </returns>
				/// <java-name>
				/// getText1
				/// </java-name>
				public virtual global::Android.Widget.TextView Text1
				{
						[Dot42.DexImport("getText1", "()Landroid/widget/TextView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TextView); }
				}

				/// <summary>
				///  <para>Returns a handle to the item with ID text2. </para>        
				/// </summary>
				/// <returns>
				///  <para>A handle to the item with ID text2. </para>
				/// </returns>
				/// <java-name>
				/// getText2
				/// </java-name>
				public virtual global::Android.Widget.TextView Text2
				{
						[Dot42.DexImport("getText2", "()Landroid/widget/TextView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TextView); }
				}

		}

		/// <summary>
		///  <para>Displays a video file. The VideoView class can load images from various sources (such as resources or content providers), takes care of computing its measurement from the video so that it can be used in any layout manager, and provides various display options such as scaling and tinting.</para> <para> <b>Note: VideoView does not retain its full state when going into the background.</b> In particular, it does not restore the current play state, play position, selected tracks, or any subtitle tracks added via addSubtitleSource(). Applications should save and restore these on their own in android.app.Activity#onSaveInstanceState and android.app.Activity#onRestoreInstanceState.</para> <para>Also note that the audio session id (from getAudioSessionId) may change from its previously returned value when the VideoView is restored. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/VideoView
		/// </java-name>
		[Dot42.DexImport("android/widget/VideoView", AccessFlags = 33)]
		public partial class VideoView : global::Android.Views.SurfaceView, global::Android.Widget.MediaController.IMediaPlayerControl
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveAdjustedSize
				/// </java-name>
				[Dot42.DexImport("resolveAdjustedSize", "(II)I", AccessFlags = 1)]
				public virtual int ResolveAdjustedSize(int desiredSize, int measureSpec) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVideoPath
				/// </java-name>
				[Dot42.DexImport("setVideoPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetVideoPath(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoURI
				/// </java-name>
				[Dot42.DexImport("setVideoURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetVideoURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopPlayback
				/// </java-name>
				[Dot42.DexImport("stopPlayback", "()V", AccessFlags = 1)]
				public virtual void StopPlayback() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMediaController
				/// </java-name>
				[Dot42.DexImport("setMediaController", "(Landroid/widget/MediaController;)V", AccessFlags = 1)]
				public virtual void SetMediaController(global::Android.Widget.MediaController controller) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the media file is loaded and ready to go.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnPreparedListener
				/// </java-name>
				[Dot42.DexImport("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreparedListener(global::Android.Media.MediaPlayer.IOnPreparedListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the end of a media file has been reached during playback.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCompletionListener
				/// </java-name>
				[Dot42.DexImport("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", AccessFlags = 1)]
				public virtual void SetOnCompletionListener(global::Android.Media.MediaPlayer.IOnCompletionListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when an error occurs during playback or setup. If no listener is specified, or if the listener returned false, VideoView will inform the user of any errors.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaPlayer.IOnErrorListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// suspend
				/// </java-name>
				[Dot42.DexImport("suspend", "()V", AccessFlags = 1)]
				public virtual void Suspend() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// seekTo
				/// </java-name>
				[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 1)]
				public virtual void SeekTo(int msec) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal VideoView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrentPosition
				/// </java-name>
				public virtual int CurrentPosition
				{
						[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isPlaying
				/// </java-name>
				public virtual bool IsPlaying
				{
						[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getBufferPercentage
				/// </java-name>
				public virtual int BufferPercentage
				{
						[Dot42.DexImport("getBufferPercentage", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// canPause
				/// </java-name>
				public virtual bool CanPause
				{
						[Dot42.DexImport("canPause", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// canSeekBackward
				/// </java-name>
				public virtual bool CanSeekBackward
				{
						[Dot42.DexImport("canSeekBackward", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// canSeekForward
				/// </java-name>
				public virtual bool CanSeekForward
				{
						[Dot42.DexImport("canSeekForward", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Base class for a FrameLayout container that will perform animations when switching between its views.</para> <para>ref android.R.styleable::ViewAnimator_inAnimation  ref android.R.styleable::ViewAnimator_outAnimation  ref android.R.styleable::ViewAnimator_animateFirstView </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ViewAnimator
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewAnimator", AccessFlags = 33)]
		public partial class ViewAnimator : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewAnimator(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewAnimator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Manually shows the next child. </para>        
				/// </summary>
				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "()V", AccessFlags = 1)]
				public virtual void ShowNext() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Manually shows the previous child. </para>        
				/// </summary>
				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "()V", AccessFlags = 1)]
				public virtual void ShowPrevious() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public override void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public override void RemoveViewAt(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewInLayout", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveViewInLayout(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViews
				/// </java-name>
				[Dot42.DexImport("removeViews", "(II)V", AccessFlags = 1)]
				public override void RemoveViews(int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewsInLayout", "(II)V", AccessFlags = 1)]
				public override void RemoveViewsInLayout(int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies the animation used to animate a View that enters the screen.</para> <para> <para>getInAnimation() </para> <para>setInAnimation(android.view.animation.Animation) </para></para>        
				/// </summary>
				/// <java-name>
				/// setInAnimation
				/// </java-name>
				[Dot42.DexImport("setInAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInAnimation(global::Android.Content.Context context, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specifies the animation used to animate a View that exit the screen.</para> <para> <para>getOutAnimation() </para> <para>setOutAnimation(android.view.animation.Animation) </para></para>        
				/// </summary>
				/// <java-name>
				/// setOutAnimation
				/// </java-name>
				[Dot42.DexImport("setOutAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetOutAnimation(global::Android.Content.Context context, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether the current View should be animated the first time the ViewAnimator is displayed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAnimateFirstView
				/// </java-name>
				[Dot42.DexImport("setAnimateFirstView", "(Z)V", AccessFlags = 1)]
				public virtual void SetAnimateFirstView(bool animate) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ViewAnimator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the index of the currently displayed child view. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayedChild
				/// </java-name>
				public virtual int DisplayedChild
				{
						[Dot42.DexImport("getDisplayedChild", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDisplayedChild", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the View corresponding to the currently displayed child.</para> <para> <para>getDisplayedChild() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The View currently displayed.</para>
				/// </returns>
				/// <java-name>
				/// getCurrentView
				/// </java-name>
				public virtual global::Android.Views.View CurrentView
				{
						[Dot42.DexImport("getCurrentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Returns the current animation used to animate a View that enters the screen.</para> <para> <para>setInAnimation(android.view.animation.Animation) </para> <para>setInAnimation(android.content.Context, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Animation or null if none is set.</para>
				/// </returns>
				/// <java-name>
				/// getInAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation InAnimation
				{
						[Dot42.DexImport("getInAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setInAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the current animation used to animate a View that exits the screen.</para> <para> <para>setOutAnimation(android.view.animation.Animation) </para> <para>setOutAnimation(android.content.Context, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Animation or null if none is set.</para>
				/// </returns>
				/// <java-name>
				/// getOutAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation OutAnimation
				{
						[Dot42.DexImport("getOutAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setOutAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Simple ViewAnimator that will animate between two or more views that have been added to it. Only one child is shown at a time. If requested, can automatically flip between each child at a regular interval.</para> <para>ref android.R.styleable::ViewFlipper_flipInterval  ref android.R.styleable::ViewFlipper_autoStart </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ViewFlipper
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewFlipper", AccessFlags = 33)]
		public partial class ViewFlipper : global::Android.Widget.ViewAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewFlipper(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewFlipper(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>How long to wait before flipping to the next view</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFlipInterval
				/// </java-name>
				[Dot42.DexImport("setFlipInterval", "(I)V", AccessFlags = 1)]
				public virtual void SetFlipInterval(int milliseconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start a timer to cycle through child views </para>        
				/// </summary>
				/// <java-name>
				/// startFlipping
				/// </java-name>
				[Dot42.DexImport("startFlipping", "()V", AccessFlags = 1)]
				public virtual void StartFlipping() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>No more flips </para>        
				/// </summary>
				/// <java-name>
				/// stopFlipping
				/// </java-name>
				[Dot42.DexImport("stopFlipping", "()V", AccessFlags = 1)]
				public virtual void StopFlipping() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ViewFlipper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the child views are flipping. </para>        
				/// </summary>
				/// <java-name>
				/// isFlipping
				/// </java-name>
				public virtual bool IsFlipping
				{
						[Dot42.DexImport("isFlipping", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if this view automatically calls startFlipping() when it becomes attached to a window. </para>        
				/// </summary>
				/// <java-name>
				/// isAutoStart
				/// </java-name>
				public virtual bool IsAutoStart
				{
						[Dot42.DexImport("isAutoStart", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAutoStart", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>ViewAnimator that switches between two views, and has a factory from which these views are created. You can either use the factory to create the views, or add them yourself. A ViewSwitcher can only have two child views, of which only one is shown at a time. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ViewSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewSwitcher", AccessFlags = 33)]
		public partial class ViewSwitcher : global::Android.Widget.ViewAnimator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new empty ViewSwitcher.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new empty ViewSwitcher for the given context and with the specified set attributes.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the factory used to create the two views between which the ViewSwitcher will flip. Instead of using a factory, you can call addView(android.view.View, int, android.view.ViewGroup.LayoutParams) twice.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFactory
				/// </java-name>
				[Dot42.DexImport("setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V", AccessFlags = 1)]
				public virtual void SetFactory(global::Android.Widget.ViewSwitcher.IViewFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the ViewSwitcher to hide all of the existing views and to make it think that the first time animation has not yet played. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ViewSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the next view to be displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the view that will be displayed after the next views flip. </para>
				/// </returns>
				/// <java-name>
				/// getNextView
				/// </java-name>
				public virtual global::Android.Views.View NextView
				{
						[Dot42.DexImport("getNextView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Creates views in a ViewSwitcher. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ViewSwitcher$ViewFactory
				/// </java-name>
				[Dot42.DexImport("android/widget/ViewSwitcher$ViewFactory", AccessFlags = 1545)]
				public partial interface IViewFactory
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Creates a new android.view.View to be added in a android.widget.ViewSwitcher.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a android.view.View </para>
						/// </returns>
						/// <java-name>
						/// makeView
						/// </java-name>
						[Dot42.DexImport("makeView", "()Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View MakeView() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/ZoomButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomButton", AccessFlags = 33)]
		public partial class ZoomButton : global::Android.Widget.ImageButton, global::Android.Views.View.IOnLongClickListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long speed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when a view has been clicked and held.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the callback consumed the long click, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onLongClick
				/// </java-name>
				[Dot42.DexImport("onLongClick", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool OnLongClick(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when a key up event has occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchUnhandledMove
				/// </java-name>
				[Dot42.DexImport("dispatchUnhandledMove", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public override bool DispatchUnhandledMove(global::Android.Views.View focused, int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZoomButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>The ZoomButtonsController handles showing and hiding the zoom controls and positioning it relative to an owner view. It also gives the client access to the zoom controls container, allowing for additional accessory buttons to be shown in the zoom controls window. </para> <para>Typically, clients should call setVisible(true) on a touch down or move (no need to call setVisible(false) since it will time out on its own). Also, whenever the owner cannot be zoomed further, the client should update setZoomInEnabled(boolean) and setZoomOutEnabled(boolean). </para> <para>If you are using this with a custom View, please call setVisible(false) from View#onDetachedFromWindow and from View#onVisibilityChanged when  <code>visibility != View.VISIBLE</code>. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ZoomButtonsController
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomButtonsController", AccessFlags = 33)]
		public partial class ZoomButtonsController : global::Android.Views.View.IOnTouchListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor for the ZoomButtonsController.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/View;)V", AccessFlags = 1)]
				public ZoomButtonsController(global::Android.Views.View ownerView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Whether to enable the zoom in control.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setZoomInEnabled
				/// </java-name>
				[Dot42.DexImport("setZoomInEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetZoomInEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Whether to enable the zoom out control.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setZoomOutEnabled
				/// </java-name>
				[Dot42.DexImport("setZoomOutEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetZoomOutEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the delay between zoom callbacks as the user holds a zoom button.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long speed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the OnZoomListener listener that receives callbacks to zoom.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnZoomListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomListener(global::Android.Widget.ZoomButtonsController.IOnZoomListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets whether the zoom controls should be focusable. If the controls are focusable, then trackball and arrow key interactions are possible. Otherwise, only touch interactions are possible.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFocusable
				/// </java-name>
				[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocusable(bool focusable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The ZoomButtonsController implements the OnTouchListener, but this does not need to be shown in its public API. </para>        
				/// </summary>
				/// <java-name>
				/// onTouch
				/// </java-name>
				[Dot42.DexImport("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouch(global::Android.Views.View v, global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZoomButtonsController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Whether the zoom controls will be automatically dismissed after showing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the zoom controls will be auto dismissed after showing. </para>
				/// </returns>
				/// <java-name>
				/// isAutoDismissed
				/// </java-name>
				public virtual bool IsAutoDismissed
				{
						[Dot42.DexImport("isAutoDismissed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAutoDismissed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Whether the zoom controls are visible to the user.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the zoom controls are visible to the user. </para>
				/// </returns>
				/// <java-name>
				/// isVisible
				/// </java-name>
				public virtual bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setVisible", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the container that is the parent of the zoom controls. </para> <para>The client can add other views to this container to link them with the zoom controls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The container of the zoom controls. It will be a layout that respects the gravity of a child's layout parameters. </para>
				/// </returns>
				/// <java-name>
				/// getContainer
				/// </java-name>
				public virtual global::Android.Views.ViewGroup Container
				{
						[Dot42.DexImport("getContainer", "()Landroid/view/ViewGroup;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewGroup); }
				}

				/// <summary>
				///  <para>Gets the view for the zoom controls.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The zoom controls view. </para>
				/// </returns>
				/// <java-name>
				/// getZoomControls
				/// </java-name>
				public virtual global::Android.Views.View ZoomControls
				{
						[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Interface that will be called when the user performs an interaction that triggers some action, for example zooming. </para>    
				/// </summary>
				/// <java-name>
				/// android/widget/ZoomButtonsController$OnZoomListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ZoomButtonsController$OnZoomListener", AccessFlags = 1545)]
				public partial interface IOnZoomListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the zoom controls' visibility changes.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onVisibilityChanged", "(Z)V", AccessFlags = 1025)]
						void OnVisibilityChanged(bool visible) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when the owner view needs to be zoomed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onZoom
						/// </java-name>
						[Dot42.DexImport("onZoom", "(Z)V", AccessFlags = 1025)]
						void OnZoom(bool zoomIn) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>The <c>ZoomControls </c> class displays a simple set of controls used for zooming and provides callbacks to register for events. </para>    
		/// </summary>
		/// <java-name>
		/// android/widget/ZoomControls
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomControls", AccessFlags = 33)]
		public partial class ZoomControls : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ZoomControls(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ZoomControls(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnZoomInClickListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomInClickListener(global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnZoomOutClickListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomOutClickListener(global::Android.Views.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long speed) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsZoomInEnabled
				/// </java-name>
				[Dot42.DexImport("setIsZoomInEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsZoomInEnabled(bool isEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsZoomOutEnabled
				/// </java-name>
				[Dot42.DexImport("setIsZoomOutEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsZoomOutEnabled(bool isEnabled) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal ZoomControls() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasFocus
				/// </java-name>
				public override bool HasFocus
				{
						[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

}

