//
// RuntimeReflectionExtensions.cs
//
// Authors:
//       Martin Baulig <martin.baulig@xamarin.com>
//       Marek Safar (marek.safar@gmail.com)
//
// Copyright (c) 2013 Xamarin Inc. (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Dot42;
using Dot42.Internal;
using Dot42.Internal.Generics;

namespace System.Reflection
{
    public static class RuntimeReflectionExtensions
	{
		const BindingFlags AllMembersBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
        const BindingFlags AllDeclaredMembersBindingFlags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

       //public static MethodInfo GetRuntimeBaseDefinition(this MethodInfo method)
        //{
        //    if (method == null)
        //        throw new ArgumentNullException("method");

        //    return method.GetBaseDefinition();
        //}

        //public static EventInfo GetRuntimeEvent (this Type type, string name)
        //{
        //    if (type == null)
        //        throw new ArgumentNullException ("type");

        //    return type.GetEvent (name);
        //}

        //public static IEnumerable<EventInfo> GetRuntimeEvents(this Type type)
        //{
        //    if (type == null)
        //        throw new ArgumentNullException("type");

        //    return type.GetEvents(AllMembersBindingFlags);
        //}

        public static FieldInfo GetRuntimeField(this Type type, string name)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return type.GetField(name);
        }

		public static IEnumerable<FieldInfo> GetDeclaredFields (this Type type)
		{
			if (type == null) throw new ArgumentNullException ("type");
            return type.GetFields(AllDeclaredMembersBindingFlags);
		}

        public static FieldInfo GetDeclaredField(this Type type, string name)
        {
            if (type == null) throw new ArgumentNullException("type");
            return type.GetField(name, AllDeclaredMembersBindingFlags);
        }

        public static IEnumerable<FieldInfo> GetRuntimeFields(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return type.GetFields(AllMembersBindingFlags);
        }

        //public static InterfaceMapping GetRuntimeInterfaceMap (this TypeInfo typeInfo, Type interfaceType)
        //{
        //    if (typeInfo == null)
        //        throw new ArgumentNullException ("typeInfo");

        //    return typeInfo.GetInterfaceMap (interfaceType);
        //}

		public static MethodInfo GetRuntimeMethod (this Type type, string name, Type[] parameters)
		{
			if (type == null)
				throw new ArgumentNullException ("type");

			return type.GetMethod (name, parameters);
		}

		public static IEnumerable<MethodInfo> GetRuntimeMethods (this Type type)
		{
			if (type == null)
				throw new ArgumentNullException ("type");

			return type.GetMethods(AllMembersBindingFlags);
		}

        public static MethodInfo GetDeclaredMethod(this Type type, string name, Type[] parameters)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            var trueTrype = GenericsReflection.EnsureTypeDef(type);
            var ret = trueTrype.JavaGetDeclaredMethod(name, parameters);
            return ret == null ? null : new MethodInfo(ret, type);
        }

        public static IEnumerable<MethodInfo> GetDeclaredMethods(this Type type)
        {
            if (type == null) throw new ArgumentNullException("type");

            return type.GetMethods(AllDeclaredMembersBindingFlags);
        }

	    public static IEnumerable<PropertyInfo> GetRuntimeProperties (this Type type)
		{
			if (type == null) throw new ArgumentNullException ("type");
			return type.GetProperties(AllMembersBindingFlags);
		}

		public static PropertyInfo GetRuntimeProperty (this Type type, string name)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			return type.GetProperty (name);
		}

        public static PropertyInfo GetRuntimeProperty(this Type type, string name, BindingFlags flags)
        {
            if (type == null) throw new ArgumentNullException("type");

            return type.GetProperty(name, flags);
        }

        public static IEnumerable<PropertyInfo> GetDeclaredProperties(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            return type.GetProperties(AllDeclaredMembersBindingFlags);
        }

        public static PropertyInfo GetDeclaredProperty(this Type type, string name)
        {
            if (type == null)
                throw new ArgumentNullException("type");
            return type.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static );
        }

        public static PropertyInfo GetDeclaredProperty(this Type type, string name, BindingFlags flags)
        {
            if (type == null) throw new ArgumentNullException("type");

            return type.GetProperty(name, flags|BindingFlags.DeclaredOnly);
        }

        //public static TypeInfo GetTypeInfo(this Type type)
        //{
        //    if (type == null)
        //        throw new ArgumentNullException("type");

        //    return new TypeInfo(type);
        //}

        /// <summary>
        /// this is not supported atm, though should probably be possible to implement.
        /// </summary>
        /// <param name="del"></param>
        /// <returns></returns>
        [Obsolete("doesn't work atm")]
        public static MethodInfo GetMethodInfo(this Delegate del)
        {
            if (del == null)
                throw new ArgumentNullException("del");

            throw new NotImplementedException("Delegate.GetMethodInfo");
        }
	}
}

