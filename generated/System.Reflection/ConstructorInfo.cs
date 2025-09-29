#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Reflection
{
    public abstract class ConstructorInfo : MethodBase
    {

        public static readonly string ConstructorName;
        public static readonly string TypeConstructorName;

        protected ConstructorInfo();

        public override MemberTypes MemberType { get; }

        public object Invoke(object[] parameters);
        public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(ConstructorInfo left, ConstructorInfo right);
        public static bool operator !=(ConstructorInfo left, ConstructorInfo right);
    }
}
