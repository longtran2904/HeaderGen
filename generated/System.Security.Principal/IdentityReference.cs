#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

namespace System.Security.Principal
{
    public abstract class IdentityReference
    {

        public abstract string Value { get; }

        public abstract bool IsValidTargetType(Type targetType);
        public abstract IdentityReference Translate(Type targetType);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(IdentityReference left, IdentityReference right);
        public static bool operator !=(IdentityReference left, IdentityReference right);
    }
}
