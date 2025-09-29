#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = False, Inherited = True)]
    public abstract class Attribute
    {

        protected Attribute();

        public virtual object TypeId { get; }

        public static Attribute[] GetCustomAttributes(MemberInfo element, Type attributeType);
        public static Attribute[] GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(MemberInfo element);
        public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit);
        public static bool IsDefined(MemberInfo element, Type attributeType);
        public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit);
        public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType);
        public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(ParameterInfo element);
        public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType);
        public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit);
        public static bool IsDefined(ParameterInfo element, Type attributeType);
        public static bool IsDefined(ParameterInfo element, Type attributeType, bool inherit);
        public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType);
        public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(Module element, Type attributeType);
        public static Attribute[] GetCustomAttributes(Module element);
        public static Attribute[] GetCustomAttributes(Module element, bool inherit);
        public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit);
        public static bool IsDefined(Module element, Type attributeType);
        public static bool IsDefined(Module element, Type attributeType, bool inherit);
        public static Attribute GetCustomAttribute(Module element, Type attributeType);
        public static Attribute GetCustomAttribute(Module element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType);
        public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit);
        public static Attribute[] GetCustomAttributes(Assembly element);
        public static Attribute[] GetCustomAttributes(Assembly element, bool inherit);
        public static bool IsDefined(Assembly element, Type attributeType);
        public static bool IsDefined(Assembly element, Type attributeType, bool inherit);
        public static Attribute GetCustomAttribute(Assembly element, Type attributeType);
        public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public virtual bool Match(object obj);
        public virtual bool IsDefaultAttribute();
    }
}
