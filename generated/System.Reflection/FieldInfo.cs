#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection
{
    public abstract class FieldInfo : MemberInfo
    {

        protected FieldInfo();

        public override MemberTypes MemberType { get; }
        public abstract FieldAttributes Attributes { get; }
        public abstract Type FieldType { get; }
        public bool IsInitOnly { get; }
        public bool IsLiteral { get; }
        [Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public bool IsNotSerialized { get; }
        public bool IsPinvokeImpl { get; }
        public bool IsSpecialName { get; }
        public bool IsStatic { get; }
        public bool IsAssembly { get; }
        public bool IsFamily { get; }
        public bool IsFamilyAndAssembly { get; }
        public bool IsFamilyOrAssembly { get; }
        public bool IsPrivate { get; }
        public bool IsPublic { get; }
        public virtual bool IsSecurityCritical { get; }
        public virtual bool IsSecuritySafeCritical { get; }
        public virtual bool IsSecurityTransparent { get; }
        public abstract RuntimeFieldHandle FieldHandle { get; }

        public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle);
        public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public abstract object GetValue(object obj);
        public void SetValue(object obj, object value);
        public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);
        [CLSCompliant(False)]
        public virtual void SetValueDirect(TypedReference obj, object value);
        [CLSCompliant(False)]
        public virtual object GetValueDirect(TypedReference obj);
        public virtual object GetRawConstantValue();
        public virtual Type GetModifiedFieldType();
        public virtual Type[] GetOptionalCustomModifiers();
        public virtual Type[] GetRequiredCustomModifiers();

        public static bool operator ==(FieldInfo left, FieldInfo right);
        public static bool operator !=(FieldInfo left, FieldInfo right);
    }
}
