#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [CLSCompliant(False)]
    public readonly struct CLong : IEquatable<CLong>
    {

        public CLong(int value);
        public CLong(nint value);

        public nint Value { get; }

        public override bool Equals(object o);
        public bool Equals(CLong other);
        public override int GetHashCode();
        public override string ToString();
    }
}
