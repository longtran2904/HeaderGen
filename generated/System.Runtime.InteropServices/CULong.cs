#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [CLSCompliant(False)]
    public readonly struct CULong : IEquatable<CULong>
    {

        public CULong(uint value);
        public CULong(nuint value);

        public nuint Value { get; }

        public override bool Equals(object o);
        public bool Equals(CULong other);
        public override int GetHashCode();
        public override string ToString();
    }
}
