#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Collections.Generic
{
    public sealed class ByteEqualityComparer : EqualityComparer<byte>
    {

        public ByteEqualityComparer();

        public override bool Equals(byte x, byte y);
        public override int GetHashCode(byte b);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
