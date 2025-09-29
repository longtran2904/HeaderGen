#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Reflection
{
    public static class CustomAttributeExtensions
    {

        public static Attribute GetCustomAttribute(this Assembly element, Type attributeType);
        public static Attribute GetCustomAttribute(this Module element, Type attributeType);
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType);
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType);
        public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute;
        public static T GetCustomAttribute<T>(this Module element) where T : Attribute;
        public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute;
        public static T GetCustomAttribute<T>(this ParameterInfo element) where T : Attribute;
        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit);
        public static Attribute GetCustomAttribute(this ParameterInfo element, Type attributeType, bool inherit);
        public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute;
        public static T GetCustomAttribute<T>(this ParameterInfo element, bool inherit) where T : Attribute;
        public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element);
        public static IEnumerable<Attribute> GetCustomAttributes(this Module element);
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element);
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element);
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, bool inherit);
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, bool inherit);
        public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element, Type attributeType);
        public static IEnumerable<Attribute> GetCustomAttributes(this Module element, Type attributeType);
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType);
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType);
        public static IEnumerable<T> GetCustomAttributes<T>(this Assembly element) where T : Attribute;
        public static IEnumerable<T> GetCustomAttributes<T>(this Module element) where T : Attribute;
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute;
        public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element) where T : Attribute;
        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit);
        public static IEnumerable<Attribute> GetCustomAttributes(this ParameterInfo element, Type attributeType, bool inherit);
        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute;
        public static IEnumerable<T> GetCustomAttributes<T>(this ParameterInfo element, bool inherit) where T : Attribute;
        public static bool IsDefined(this Assembly element, Type attributeType);
        public static bool IsDefined(this Module element, Type attributeType);
        public static bool IsDefined(this MemberInfo element, Type attributeType);
        public static bool IsDefined(this ParameterInfo element, Type attributeType);
        public static bool IsDefined(this MemberInfo element, Type attributeType, bool inherit);
        public static bool IsDefined(this ParameterInfo element, Type attributeType, bool inherit);
    }
}
