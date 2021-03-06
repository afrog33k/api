// Copyright (C) 2014 dot42
//
// Original filename: Int16.cs
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

using Dot42;
using Dot42.Internal;
using Java.Lang;

namespace System
{
	partial struct Int16: IFormattable
	{
        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(IFormatProvider provider)
        {
            return NumberFormatter.Format((int)this, provider);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format)
        {
            return NumberFormatter.Format(format, (int)this, null);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public string ToString(string format, IFormatProvider provider)
        {
            return NumberFormatter.Format(format, (int)this, provider);
        }

        public static short Parse(string s, IFormatProvider provider)
        {
            return Parse(s);
        }

        [Inline, DexNative] // avoid boxing, do not generate actual method
        public bool Equals(short other)
        {
            return other == this;
        }


        /// <summary>
        /// Try to parse the given string into a short value.
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        public static bool TryParse(string s, out short result)
        {
            try
            {
                result = Parse(s);
                return true;
            }
            catch (NumberFormatException)
            {
                result = 0;
                return false;
            }
        }
    }
}

