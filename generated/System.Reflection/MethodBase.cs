#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection
{
    public abstract class MethodBase : MemberInfo
    {

        protected MethodBase();

        public abstract MethodAttributes Attributes { get; }
        public virtual MethodImplAttributes MethodImplementationFlags { get; }
        public virtual CallingConventions CallingConvention { get; }
        public bool IsAbstract { get; }
        public bool IsConstructor { get; }
        public bool IsFinal { get; }
        public bool IsHideBySig { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public bool IsVirtual { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public virtual bool IsConstructedGenericMethod { get; }
        public virtual bool IsGenericMethod { get; }
        public virtual bool IsGenericMethodDefinition { get; }
        public virtual bool ContainsGenericParameters { get; }
        public abstract RuntimeMethodHandle MethodHandle { get; }
        public virtual bool IsSecurityCritical { get; }
        public virtual bool IsSecuritySafeCritical { get; }
        public virtual bool IsSecurityTransparent { get; }

        public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle);
        public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType);
        public static MethodBase GetCurrentMethod();
        public abstract ParameterInfo[] GetParameters();
        public abstract MethodImplAttributes GetMethodImplementationFlags();
        public virtual MethodBody GetMethodBody();
        public virtual Type[] GetGenericArguments();
        public object Invoke(object obj, object[] parameters);
        public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(MethodBase left, MethodBase right);
        public static bool operator !=(MethodBase left, MethodBase right);
    }
}
