// Copyright (C) 2014 dot42
//
// Original filename: FormatHelper.cs
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
using System;
using System.Globalization;
using System.Text;

namespace Dot42.Internal
{
    internal sealed class FormatHelper
    {
        private readonly StringBuilder result;
        private readonly IFormatProvider provider;
        private readonly string format;
        private readonly int numberOfArguments;
        private int ptr;
        int n, width;
        bool left_align;
        string arg_format;

        private readonly object[] args;
        private readonly object arg0, arg1, arg2;

        internal FormatHelper(StringBuilder result, IFormatProvider provider, string format, object[] args)
        {
            if (format == null)
                throw new ArgumentNullException("format");
            if (args == null)
                throw new ArgumentNullException("args");
            
            this.result = result;
            this.provider = provider;
            this.format = format;
            this.args = args;
            this.numberOfArguments = args.Length;

            if (result == null)
            {
                // Try to approximate the size of result to avoid reallocations
                int i, len;

                len = 0;
                var argLength = args.Length;
                for (i = 0; i < argLength; ++i)
                {
                    string s = GetArg(i) as string;
                    if (s != null)
                        len += s.Length;
                    else
                        break;
                }
                this.result = new StringBuilder(len + format.Length);
            }
        }

        internal FormatHelper(StringBuilder result, IFormatProvider provider, string format, object arg0)
        {
            if (format == null)
                throw new ArgumentNullException("format");

            this.result = result;
            this.provider = provider;
            this.format = format;
            this.arg0 = arg0;
            this.numberOfArguments = 1 ;

            if (result == null)
            {
                // Try to approximate the size of result to avoid reallocations
                int len = format.Length;
                if (arg0 is string)
                    len += ((string) arg0).Length;
                this.result = new StringBuilder(len + format.Length);
            }
        }

        internal FormatHelper(StringBuilder result, IFormatProvider provider, string format, object arg0, object arg1)
        {
            if (format == null)
                throw new ArgumentNullException("format");

            this.result = result;
            this.provider = provider;
            this.format = format;
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.numberOfArguments = 2;

            if (result == null)
            {
                // Try to approximate the size of result to avoid reallocations
                int len = format.Length;
                if (arg0 is string)
                    len += ((string)arg0).Length;
                if (arg1 is string)
                    len += ((string)arg1).Length;
                this.result = new StringBuilder(len + format.Length);
            }
        }

        internal FormatHelper(StringBuilder result, IFormatProvider provider, string format, object arg0, object arg1, object arg2)
        {
            if (format == null)
                throw new ArgumentNullException("format");

            this.result = result;
            this.provider = provider;
            this.format = format;
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.numberOfArguments = 3;

            if (result == null)
            {
                // Try to approximate the size of result to avoid reallocations
                int len = format.Length;
                if (arg0 is string)
                    len += ((string)arg0).Length;
                if (arg1 is string)
                    len += ((string)arg1).Length;
                if (arg2 is string)
                    len += ((string)arg2).Length;
                this.result = new StringBuilder(len + format.Length);
            }
        }

        [Inline]
        public object GetArg(int idx)
        {
            if (args != null)
                return args[idx];
            return idx == 0 ? arg0 
                 : idx == 1 ? arg1 
                 : arg2 ;
        }

        /// <summary>
        /// Perform the actual formatting.
        /// </summary>
        internal StringBuilder Format()
        {
            ptr = 0;
            int start = ptr;
            var formatter = provider != null ? provider.GetFormat(typeof(ICustomFormatter)) as ICustomFormatter : null;

            var formatLength = format.Length;
            while (ptr < formatLength)
            {
                char c = format[ptr++];

                if (c == '{')
                {
                    result.Append(format, start, ptr - start - 1);

                    // check for escaped open bracket

                    if (format[ptr] == '{')
                    {
                        start = ptr++;
                        continue;
                    }

                    // parse specifier
                    ParseFormatSpecifier(format);

                    if (n >= numberOfArguments)
                        throw new FormatException("Index (zero based) must be greater than or equal to zero and less than the size of the argument list.");

                    // format argument
                    object arg = GetArg(n);

                    string str;
                    if (arg == null)
                    {
                        str = string.Empty;
                    }
                    else if (formatter != null)
                    {
                        str = formatter.Format(arg_format, arg, provider);
                    }
                    else
                    {
                        if (provider == null)
                        {
                            // take the allocation reducing shortcut.
                            str = CultureInfo.DefaultCustomFormatter.Format(arg_format, arg, provider);
                        }
                        else
                        {
                            var formattable = arg as IFormattable;
                            str = formattable != null
                                ? formattable.ToString(arg_format, provider)
                                : arg.ToString();
                        }
                    }

                    if (str == null)
                    {
                        str = String.Empty;
                    }

                    // pad formatted string and append to result
                    if (width > str.Length)
                    {
                        const char padchar = ' ';
                        int padlen = width - str.Length;

                        if (left_align)
                        {
                            result.Append(str);
                            result.Append(padchar, padlen);
                        }
                        else
                        {
                            result.Append(padchar, padlen);
                            result.Append(str);
                        }
                    }
                    else
                    {
                        result.Append(str);
                    }

                    start = ptr;
                }
                else if (c == '}' && ptr < format.Length && format[ptr] == '}')
                {
                    result.Append(format, start, ptr - start - 1);
                    start = ptr++;
                }
                else if (c == '}')
                {
                    throw new FormatException("Input string was not in a correct format.");
                }
            }

            if (start < formatLength)
                result.Append(format, start, format.Length - start);

            return result;
        }

        private void ParseFormatSpecifier(string str)
        {
            int max = str.Length;

            // parses format specifier of form:
            //   N,[\ +[-]M][:F]}
            //
            // where:
            // N = argument number (non-negative integer)

            n = ParseDecimal(str);
            if (n < 0)
                throw new FormatException("Input string was not in a correct format.");

            // M = width (non-negative integer)

            if (ptr < max && str[ptr] == ',')
            {
                // White space between ',' and number or sign.
                ++ptr;
                while (ptr < max && Char.IsWhiteSpace(str[ptr]))
                    ++ptr;
                int start = ptr;

                arg_format = str.Substring(start, ptr - start);

                left_align = (ptr < max && str[ptr] == '-');
                if (left_align)
                    ++ptr;

                width = ParseDecimal(str);
                if (width < 0)
                    throw new FormatException("Input string was not in a correct format.");
            }
            else
            {
                width = 0;
                left_align = false;
                arg_format = string.Empty;
            }

            // F = argument format (string)

            if (ptr < max && str[ptr] == ':')
            {
                int start = ++ptr;
                while (ptr < max && str[ptr] != '}')
                    ++ptr;

                arg_format += str.Substring(start, ptr - start);
            }
            else
                arg_format = null;

            if ((ptr >= max) || str[ptr++] != '}')
                throw new FormatException("Input string was not in a correct format.");
        }

        private int ParseDecimal(string str)
        {
            int p = ptr;
            int n = 0;
            int max = str.Length;

            while (p < max)
            {
                char c = str[p];
                if (c < '0' || '9' < c)
                    break;

                n = n * 10 + c - '0';
                ++p;
            }

            if (p == ptr || p == max)
                return -1;

            ptr = p;
            return n;
        }

        internal static int ParseDecimal(string str, int startIndex, int notIncludedEndIndex)
        {
            if (startIndex == notIncludedEndIndex)
                return -1;

            int n = 0;
            while (startIndex < notIncludedEndIndex)
            {
                char c = str[startIndex];
                if (c < '0' || c > '9')
                    return -1;

                n = n * 10 + c - '0';
                ++startIndex;
            }

            return n;
        }

        internal static void Append(StringBuilder sb, int number, int minDigits)
        {
            switch (minDigits)
            {
                case 0:
                case 1:
                    break;
                case 2:
                    if (number < 10) goto pad1;
                    break;
                case 3:
                    if (number < 10)  goto pad2;
                    if (number < 100) goto pad1;
                    break;
                case 4:
                    if (number < 10)   goto pad3;
                    if (number < 100)  goto pad2;
                    if (number < 1000) goto pad1;
                    break;
                case 5:
                    if (number < 10)    goto pad4;
                    if (number < 100)   goto pad3;
                    if (number < 1000)  goto pad2;
                    if (number < 10000) goto pad1;
                    break;
                case 6:
                    if (number < 10)     goto pad5;
                    if (number < 100)    goto pad4;
                    if (number < 1000)   goto pad3;
                    if (number < 10000)  goto pad2;
                    if (number < 100000) goto pad1;
                    break;
                case 7:
                    if (number < 10)      goto pad6;
                    if (number < 100)     goto pad5;
                    if (number < 1000)    goto pad4;
                    if (number < 10000)   goto pad3;
                    if (number < 100000)  goto pad2;
                    if (number < 1000000) goto pad1;
                    break;
                default:
                    // fallback: append number first
                    int sbLength = sb.Length;
                    sb.Append(number);
                    int numDigits = sb.Length - sbLength;

                    // now insert padding zeroes, if required.
                    int add = minDigits - numDigits;
                    if (add > 0)
                    {
                        string zeros = new string('0', add);
                        sb.Insert(sbLength, zeros);
                    }
                    return;
            }

            sb.Append(number);
            return;

            pad1:
            sb.Append('0');
            sb.Append(number);
            return;

            pad2:
            sb.Append("00");
            sb.Append(number);
            return;

            pad3:
            sb.Append("000");
            sb.Append(number);
            return;

            pad4:
            sb.Append("0000");
            sb.Append(number);
            return;

            pad5:
            sb.Append("00000");
            sb.Append(number);
            return;

            pad6:
            sb.Append("000000");
            sb.Append(number);
            return;

            //pad7:
            //sb.Append("0000000");
            //sb.Append(number);
            //return;
        }
    }
}

