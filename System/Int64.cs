// Copyright (C) 2014 dot42
//
// Original filename: Int64.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Globalization;
using Android.Graphics;
using Dot42;
using Dot42.Internal;
using Java.Lang;

namespace System
{
	partial struct Int64: IFormattable
	{
        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format(this, provider);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format)
        {
            return NumberFormatter.Format(format, this, null);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, this, provider);
        }

        public static long Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        /// <summary>
        /// Try to parse the given string into a long value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, out long result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch (NumberFormatException)
            {
                result = 0L;
                return false;
            }
        }

        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
        {
            try
            {
                if ((style & NumberStyles.AllowHexSpecifier) != 0)
                    result = Parse(s, 16);
                else
                    result = Parse(s);
                return true;
            }
            catch (NumberFormatException)
            {
                result = 0L;
                return false;
            }
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(long other)
        {
            return other == this;
        }
    }
}

