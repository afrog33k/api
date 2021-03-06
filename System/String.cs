// Copyright (C) 2014 dot42
//
// Original filename: String.cs
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

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Dot42;
using Dot42.Internal;
using Java.Lang;
using Java.Util;

namespace System
{
	partial class String : IEnumerable<char>
	{
	    public const string Empty = "";

        /// <summary>
        /// Creates a string with the specified character repeated 'count' times.
        /// </summary>
        public String(char c, int count)
            : this(Constuct(c, count))
        {
        }

        /// <summary>
        ///  Returns the char at index.
        /// </summary>
        [global::System.Runtime.CompilerServices.IndexerName("Chars")]
        public char this[int index]
        {
            [Dot42.DexImport("charAt", "(I)C", AccessFlags = 257)]
            get { return default(char); }
        }
       
        /// <summary>
        /// Returns the number of chars in this string. 
        /// </summary>
        public int Length
        {
            [Dot42.DexImport("length", "()I", AccessFlags = 257)]
            get { return default(int); }
        }


        private static char[] Constuct(char c, int count)
        {
            var result = new char[count];
            Arrays.Fill(result, c);
            return result;
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        [Inline]
        public static int Compare(string strA, string strB)
        {
            return Compare(strA, strB, false);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, string strB, bool ignoreCase)
        {
            if (ReferenceEquals(strA, null) && ReferenceEquals(strB, null)) return 0;
            if (ReferenceEquals(strA, null)) return 1;
            if (ReferenceEquals(strB, null)) return -1;
            if (ignoreCase)
                return strA.CompareToIgnoreCase(strB);
            return strA.CompareTo(strB);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo cutureInfo)
        {
            if (ReferenceEquals(strA, null) && ReferenceEquals(strB, null)) return 0;
            if (ReferenceEquals(strA, null)) return 1;
            if (ReferenceEquals(strB, null)) return -1;
            if (ignoreCase)
                return strA.CompareToIgnoreCase(strB);
            return strA.CompareTo(strB);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, string strB, StringComparison comparisonType)
        {
            var ignoreCase = (comparisonType == StringComparison.InvariantCultureIgnoreCase) ||
                             (comparisonType == StringComparison.CurrentCultureIgnoreCase) ||
                             (comparisonType == StringComparison.OrdinalIgnoreCase);
            return Compare(strA, strB, ignoreCase);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo cultureInfo)
        {
            var a = strA.JavaSubstring(indexA, indexA + length);
            var b = strB.JavaSubstring(indexB, indexB + length);
            
            if (ignoreCase)
                return a.CompareToIgnoreCase(b);
            else
                return a.CompareTo(b);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        [Inline]
        public static int CompareOrdinal(string strA, string strB)
        {
            return Compare(strA, strB, StringComparison.Ordinal);
        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public bool StartsWith(string other, StringComparison comparisonType)
        {
            if (Length < other.Length) 
                return false;

            var ignoreCase = (comparisonType == StringComparison.InvariantCultureIgnoreCase) ||
                             (comparisonType == StringComparison.CurrentCultureIgnoreCase) ||
                             (comparisonType == StringComparison.OrdinalIgnoreCase);
            
            if (!ignoreCase)
                return StartsWith(other);
            
            var _this = this.JavaSubstring(0, other.Length);

            return Compare(_this, other, ignoreCase) == 0;

        }

        /// <summary>
        /// Compare strings
        /// </summary>
        public bool EndsWith(string other, StringComparison comparisonType)
        {
            if (Length < other.Length)
                return false;

            var ignoreCase = (comparisonType == StringComparison.InvariantCultureIgnoreCase) ||
                             (comparisonType == StringComparison.CurrentCultureIgnoreCase) ||
                             (comparisonType == StringComparison.OrdinalIgnoreCase);

            if (!ignoreCase)
                return EndsWith(other);

            var _this = this.JavaSubstring(Length-other.Length, Length);

            return Compare(_this, other, ignoreCase) == 0;

        }

        /// <summary>
        /// Does this string contain the given sub string?
        /// </summary>
        [Inline]
        public bool Contains(string value)
        {
            return Contains((ICharSequence) value);
        }

        /// <summary>
        /// Copy a specified numbers of characters from this string to the given array.
        /// </summary>
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            if (destination == null)
                throw new ArgumentNullException("destination");
            if (sourceIndex < 0)
                throw new ArgumentOutOfRangeException("sourceIndex");
            if (destinationIndex < 0)
                throw new ArgumentOutOfRangeException("destinationIndex");
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (sourceIndex + count > Length)
                throw new ArgumentOutOfRangeException("count");
            if (destinationIndex + count > destination.Length)
                throw new ArgumentOutOfRangeException("count");
            while (count > 0)
            {
                destination[destinationIndex++] = this[sourceIndex++];
                count--;
            }
        }

        /// <summary>
        /// Replaces format items in the given string with a string representation of the given argument.
        /// </summary>
        public static string Format(string format, object arg0)
        {
            var helper = new FormatHelper(null, null, format, arg0);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(string format, object arg0, object arg1)
        {
            var helper = new FormatHelper(null, null, format, arg0, arg1);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(string format, object arg0, object arg1, object arg2)
        {
            var helper = new FormatHelper(null, null, format, arg0, arg1, arg2);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(string format, params object[] args)
        {
            var helper = new FormatHelper(null, null, format, args);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representation of the given argument.
        /// </summary>
        public static string Format(IFormatProvider provider, string format, object arg0)
        {
            var helper = new FormatHelper(null, provider, format, arg0);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(IFormatProvider provider, string format, object arg0, object arg1)
        {
            var helper = new FormatHelper(null, provider, format, arg0, arg1);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            var helper = new FormatHelper(null, provider, format, arg0, arg1, arg2);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Replaces format items in the given string with a string representations of the given arguments.
        /// </summary>
        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
            var helper = new FormatHelper(null, provider, format, args);
            return helper.Format().ToString();
        }

        /// <summary>
        /// Gets the index of the first use of the given character in this string.
        /// </summary>
        /// <returns>The index of the first use of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOf(char ch)
        {
            return IndexOf((int) ch);
        }

        /// <summary>
        /// Gets the index of the first use of the given character in this string.
        /// The search starts at the given index.
        /// </summary>
        /// <returns>The index of the first use of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOf(char ch, int startIndex)
        {
            return IndexOf((int)ch, startIndex);
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOfAny(char[] array)
        {
            return IndexOfAny(array, 0, Length);
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        [Inline]
        public int IndexOfAny(char[] array, int startIndex)
        {
            return IndexOfAny(array, startIndex, Length - startIndex);
        }

        /// <summary>
        /// Gets the index of the first use of any of the given characters in this string.
        /// </summary>
        /// <returns>The index of the first use of any of the given character or -1 if the given character is not used.</returns>
        public int IndexOfAny(char[] array, int startIndex, int count)
        {
            if (startIndex < 0) throw new ArgumentOutOfRangeException("startIndex");
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            var length = Length;
            if (startIndex + count > length) throw new ArgumentOutOfRangeException();
            var arrayLen = array.Length;
            var endIndex = startIndex + count;
            for (var i = startIndex; i < endIndex; i++)
            {
                var ch = this[i];
                for (var j = 0; j < arrayLen; j++)
                {
                    if (array[j] == ch) return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        public int IndexOf(string value, int startIndex, int count)
        {
            if ((count < 0) || (count > (Length - startIndex)))
                throw new ArgumentOutOfRangeException("count");
            if ((startIndex < 0) || (startIndex > Length))
                throw new ArgumentOutOfRangeException("startIndex");
            var subString = JavaSubstring(startIndex, startIndex + count);
            var index = subString.IndexOf(value);
            return (index < 0) ? index : index + startIndex;
        }

        /// <summary>
        /// Reports the zero-based index of the first occurrence of the specified string in this instance. The search starts at a specified character position and examines a specified number of character positions.
        /// </summary>
        public int IndexOf(string value, int startIndex, StringComparison comparison)
        {
            bool isCultureSpecific = comparison == StringComparison.CurrentCulture || comparison == StringComparison.CurrentCultureIgnoreCase;

            bool isNormal = comparison == StringComparison.Ordinal 
                         || comparison == StringComparison.InvariantCulture
                         || comparison == StringComparison.CurrentCulture;

            if (isNormal)
                return IndexOf(value, startIndex);

            if(isCultureSpecific)
                throw new NotImplementedException("IndexOf with local culture not supported");

            return ToUpperInvariant().IndexOf(value.ToUpperInvariant(), startIndex);
        }

        /// <summary>
        /// Returns a new string that right-aligns the characters in this string by padding them with spaces on the left, for a specified total length.
        /// </summary>
        [Inline]
        public string PadLeft(int totalWidth)
        {
            return PadLeft(totalWidth, ' ');
        }

        /// <summary>
        /// Returns a new string that right-aligns the characters in this string by padding them given character on the left, for a specified total length.
        /// </summary>
        public string PadLeft(int totalWidth, char paddingChar)
        {
            var length = Length;
            if (totalWidth <= length) return this;
            
            var builder = new StringBuilder(totalWidth);
            builder.Append(paddingChar, totalWidth - length);
            builder.Append(this);
            
            return builder.ToString();
        }

        /// <summary>
        /// Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.
        /// </summary>
        [Inline]
        public string PadRight(int totalWidth)
        {
            return PadRight(totalWidth, ' ');
        }

        /// <summary>
        /// Returns a new string that left-aligns the characters in this string by padding them given character on the right, for a specified total length.
        /// </summary>
        public string PadRight(int totalWidth, char paddingChar)
        {
            var length = Length;
            if (totalWidth <= length) return this;

            var builder = new StringBuilder(totalWidth);
            builder.Append(this);
            builder.Append(paddingChar,  totalWidth - length);
            return builder.ToString();
        }

        /// <summary>
        /// Return a new instance which is this string with all characters from the given index on removed.
        /// </summary>
        public string Remove(int startIndex)
        {
            if ((startIndex < 0) || (startIndex >= Length))
                throw new ArgumentOutOfRangeException("startIndex");
            return JavaSubstring(0, startIndex);
        }

        /// <summary>
        /// Return a new instance which is this string with count characters from the given index on removed.
        /// </summary>
        public string Remove(int startIndex, int count)
        {
            var len = Length;
            if ((startIndex < 0) || (startIndex >= len))
                throw new ArgumentOutOfRangeException("startIndex");
            if ((count < 0) || (startIndex + count >= len))
                throw new ArgumentOutOfRangeException("count");
            if (count == 0)
                return this;
            if (startIndex == 0)
                return JavaSubstring(count, (len - count + 1));
            var sb = new StringBuilder();
            sb.Append(this, 0, startIndex);
            sb.Append(this, startIndex + count, len - (startIndex + count));
            return sb.ToString();
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(params char[] separator)
        {
            return Split(separator, int.MaxValue, StringSplitOptions.None);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(char[] separator, int count)
        {
            return Split(separator, count, StringSplitOptions.None);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        [Inline]
        public string[] Split(char[] separator, StringSplitOptions options)
        {
            return Split(separator, int.MaxValue, options);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        public string[] Split(string[] separator, StringSplitOptions options)
        {
            // TODO: check if this a correct implementation.
            if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
                throw new ArgumentException("Illegal enum value: " + options + ".");

            string splitPattern = string.Join("|", separator.Select(Java.Util.Regex.Pattern.Quote));

            if(options == StringSplitOptions.None)
                return Split(splitPattern);
            else
                return Split(splitPattern).Where(s=>s.Length != 0);
        }

        /// <summary>
        /// Split this string into parts delimited by the given separators.
        /// </summary>
        public string[] Split(char[] separator, int count, StringSplitOptions options)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be less than zero.");
            if ((options != StringSplitOptions.None) && (options != StringSplitOptions.RemoveEmptyEntries))
                throw new ArgumentException("Illegal enum value: " + options + ".");

            var removeEmptyEntries = (options & StringSplitOptions.RemoveEmptyEntries) != 0;
            var length = Length;
            if ((length == 0) && removeEmptyEntries)
                return new string[0];

            if (count <= 1)
            {
                return count == 0 ? new string[0] : new[] { this };
            }

            var list = new ArrayList<string>();
            var start = 0;
            var index = 0;
            while (index < length)
            {
                if (Contains(separator, this[index]))
                {
                    // Split here
                    if ((!removeEmptyEntries) || (start != index))
                    {
                        list.Add(JavaSubstring(start, index));
                    }

                    index++;
                    start = index;

                    if (list.Count + 1 >= count)
                    {
                        index = length;
                        break;
                    }
                }
                else
                {
                    index++;
                }
            }
            // Add last part (if needed)
            if (start <= index)
            {
                if ((!removeEmptyEntries) || (start != index))
                {
                    list.Add(JavaSubstring(start, index));
                }                
            }
            return list.ToArray<string>(new string[list.Count]);
        }

        /// <summary>
        /// Does the given array contain the given character?
        /// </summary>
        private static bool Contains(char[] array, char value)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
                if (array[i] == value)
                    return true;
            return false;
        }

        /// <summary>
        /// Return a substring of this instance.  
        /// </summary>
        [Dot42.DexImport("substring", "(I)Ljava/lang/String;")]
        public string Substring(int start)
        {
            return default(string);
        }

        /// <summary>
        /// Return a substring of this instance. 
        /// </summary>
        public string Substring(int startIndex, int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            return JavaSubstring(startIndex, startIndex + length);
        }

        /// <summary>
        /// Is the given string null or zero length.
        /// </summary>
        [Inline]
        public static bool IsNullOrEmpty(string value)
        {
            return (value == null) || (value.Length == 0);
        }

        /// <summary>
        /// Is the given string null or consists only of whitespace characters.
        /// </summary>
        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null) return true;
            int len = value.Length;
            for (int i = 0; i < len; ++i)
            {
                if (!char.IsWhiteSpace(value[i]))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, params string[] array)
        {
            if (array.Length == 0)
                return "";
            var sb = new StringBuilder();
            var first = true;
            foreach (var element in array)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, params object[] array)
        {
            if ((array.Length == 0) || (array[0] == null))
                return "";
            var sb = new StringBuilder();
            var first = true;
            foreach (var element in array)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all strings in the array with the given separator between each array element.
        /// </summary>
        public static string Join(string separator, IEnumerable<string> strings)
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var element in strings)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Create a concatenation of all objects in the enumerable with the given separator between each element.
        /// </summary>
        public static string Join<T>(string separator, IEnumerable<T> objects)
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var element in objects)
            {
                if (first)
                {
                    first = false;
                }
                else if (separator != null)
                {
                    sb.Append(separator);
                }
                if (element != null)
                {
                    sb.Append(element);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets a string representation of the given value.
        /// </summary>
        public static string Concat(object value)
        {
            return (value == null) ? string.Empty : value.ToString();
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2)
        {
            var s1 = v1 == null ? null : v1.ToString();
            var s2 = v2 == null ? null : v2.ToString();
            return Concat(s1, s2);
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2, object v3)
        {
            var s1 = v1 == null ? null : v1.ToString();
            var s2 = v2 == null ? null : v2.ToString();
            var s3 = v3 == null ? null : v3.ToString();
            return Concat(s1, s2, s3);
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(object v1, object v2, object v3, object v4)
        {
            var s1 = v1 == null ? null : v1.ToString();
            var s2 = v2 == null ? null : v2.ToString();
            var s3 = v3 == null ? null : v3.ToString();
            var s4 = v4 == null ? null : v4.ToString();
            return Concat(s1, s2, s3, s4);
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(params object[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");

            var length = args.Length;
            var sb = new StringBuilder();
            
            for (var i = 0; i < length; i++)
            {
                var arg = args[i];
                if (arg != null)
                    sb.Append(arg);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Concatenate v1 and v2.
        /// </summary>
        public static string Concat(string v1, string v2)
        {
            if (string.IsNullOrEmpty(v1))
            {
                if (string.IsNullOrEmpty(v2))
                    return string.Empty;
                return v2;
            }
            if (string.IsNullOrEmpty(v2))
                return v1;
            return v1.Concat(v2);
        }

        /// <summary>
        /// Concatenate v1, v2 and v3.
        /// </summary>
        public static string Concat(string v1, string v2, string v3)
        {
            var s1 = v1 ?? string.Empty;
            var s2 = v2 ?? string.Empty;
            var s3 = v3 ?? string.Empty;
            StringBuilder b = new StringBuilder(s1.Length + s2.Length + s3.Length);
            b.Append(s1);
            b.Append(s2);
            b.Append(s3);
            return b.ToString();
        }

        /// <summary>
        /// Concatenate v1, v2, v3 and v4.
        /// </summary>
        public static string Concat(string v1, string v2, string v3, string v4)
        {
            var s1 = v1 ?? string.Empty;
            var s2 = v2 ?? string.Empty;
            var s3 = v3 ?? string.Empty;
            var s4 = v4 ?? string.Empty;
            StringBuilder b = new StringBuilder(s1.Length + s2.Length + s3.Length + s4.Length);
            b.Append(s1);
            b.Append(s2);
            b.Append(s3);
            b.Append(s4);
            return b.ToString();
        }

        /// <summary>
        /// Gets a concatenation of the string representation of the given values.
        /// </summary>
        public static string Concat(params string[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");
            var sb = new StringBuilder();
            var length = args.Length;
            for (var i = 0; i < length; i++)
            {
                var arg = args[i];
                if (arg != null)
                    sb.Append(arg);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Is this string equal to the given string?
        /// </summary>
        [Inline]
        public bool Equals(string other)
        {
            return Equals((object) other);
        }

        /// <summary>
        /// Is string a equal to string b?
        /// </summary>
        [Inline]
        public static bool Equals(string a, string b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a == null) return b == null;
            return a.Equals((object)b);
        }

        [Inline]
	    public static bool Equals(string a, string b, StringComparison comparisonType)
	    {
            if (a == null) return b == null;
            return Compare(a, b, comparisonType) == 0;
	    }

        /// <summary>
        /// Return a new string in which all occurrences of the given old value have been replaced with the given new value.
        /// </summary>
        [Inline]
        public string Replace(string oldValue, string newValue)
        {
            return Replace((ICharSequence) oldValue, (ICharSequence) newValue);
        }

        [Inline]
        public string ToUpper(CultureInfo culture)
        {
            return ToUpper(culture.Locale);
        }

        [Inline]
        public string ToUpperInvariant()
        {
            return ToUpper(CultureInfo.InvariantCulture);
        }

        [Inline]
        public string ToLower(CultureInfo culture)
        {
            return ToLower(culture.Locale);
        }

        [Inline]
        public string ToLowerInvariant()
        {
            return ToLower(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Removes all leading and trailing occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public string Trim(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int start = 0;
            if (trimChars != null && trimChars.Length != 0)
                start = FindNotInTable(0, Length, 1, trimChars);

            int end = 0;
            if (trimChars != null && trimChars.Length != 0)
                end = FindNotInTable(Length - 1, -1, -1, trimChars);

            end++;
            if (start == 0 && end == Length)
                return this;

            return JavaSubstring(start, end);
        }

        /// <summary>
        /// Removes all leading occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public string TrimStart(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int start = 0;
            if (trimChars != null && trimChars.Length != 0)
                start = FindNotInTable(0, Length, 1, trimChars);

            if (start == 0)
                return this;

            return JavaSubstring(start, Length);
        }

        /// <summary>
        /// Removes all trailing occurrences of a set of characters specified in an array from the current object.
        /// </summary>
        public String TrimEnd(params char[] trimChars)
        {
            if (Length == 0)
                return Empty;

            int end = 0;
            if (trimChars != null && trimChars.Length != 0)
                end = FindNotInTable(Length - 1, -1, -1, trimChars);

            end++;
            if (end == Length)
                return this;

            return JavaSubstring(0, end);
        }

        private int FindNotInTable(int pos, int target, int change, char[] table)
        {
            while (pos != target)
            {
                char c = this[pos];
                int x = 0;
                while (x < table.Length)
                {
                    if (c == table[x])
                        break;
                    x++;
                }
                if (x == table.Length)
                    return pos;
                pos += change;
            }
         
            return pos;
        }

        /// <summary>
        /// Is string a equal to string b?
        /// </summary>
        public static bool operator ==(string a, string b)
        {
            return Equals(a, b);
        }

        /// <summary>
        /// Is string a not equal to string b?
        /// </summary>
        public static bool operator !=(string a, string b)
        {
            if (ReferenceEquals(a, b)) return false;
            return !Equals(a, b);
        }

	    IEnumerator<char> IEnumerable<char>.GetEnumerator()
	    {
            // The C# compiler will actually not call this method
            // when using a string in foreach, but instead generate 
            // optimized code.
	        return new StringEnumerator(this);
	    }

	    IEnumerator IEnumerable.GetEnumerator()
	    {
	        return ((IEnumerable<char>)this).GetEnumerator();
	    }
	}
}

