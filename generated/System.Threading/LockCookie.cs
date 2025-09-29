#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

namespace System.Threading
{
    public struct LockCookie : IEquatable<LockCookie>
    {

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(LockCookie obj);

        public static bool operator ==(LockCookie a, LockCookie b);
        public static bool operator !=(LockCookie a, LockCookie b);
    }
}
