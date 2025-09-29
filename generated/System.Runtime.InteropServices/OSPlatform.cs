#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public readonly struct OSPlatform : IEquatable<OSPlatform>
    {
        public static OSPlatform FreeBSD { get; }
        public static OSPlatform Linux { get; }
        public static OSPlatform OSX { get; }
        public static OSPlatform Windows { get; }

        public static OSPlatform Create(string osPlatform);
        public bool Equals(OSPlatform other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(OSPlatform left, OSPlatform right);
        public static bool operator !=(OSPlatform left, OSPlatform right);
    }
}
