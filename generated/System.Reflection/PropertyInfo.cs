#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection
{
    public abstract class PropertyInfo : MemberInfo
    {
        protected PropertyInfo();

        public override MemberTypes MemberType { get; }
        public abstract Type PropertyType { get; }
        public abstract PropertyAttributes Attributes { get; }
        public bool IsSpecialName { get; }
        public abstract bool CanRead { get; }
        public abstract bool CanWrite { get; }
        public virtual MethodInfo GetMethod { get; }
        public virtual MethodInfo SetMethod { get; }

        public abstract ParameterInfo[] GetIndexParameters();
        public MethodInfo[] GetAccessors();
        public abstract MethodInfo[] GetAccessors(bool nonPublic);
        public MethodInfo GetGetMethod();
        public abstract MethodInfo GetGetMethod(bool nonPublic);
        public MethodInfo GetSetMethod();
        public abstract MethodInfo GetSetMethod(bool nonPublic);
        public virtual Type GetModifiedPropertyType();
        public virtual Type[] GetOptionalCustomModifiers();
        public virtual Type[] GetRequiredCustomModifiers();
        public object GetValue(object obj);
        public virtual object GetValue(object obj, object[] index);
        public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
        public virtual object GetConstantValue();
        public virtual object GetRawConstantValue();
        public void SetValue(object obj, object value);
        public virtual void SetValue(object obj, object value, object[] index);
        public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(PropertyInfo left, PropertyInfo right);
        public static bool operator !=(PropertyInfo left, PropertyInfo right);
    }
}
