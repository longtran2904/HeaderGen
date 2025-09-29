#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public static class BitOperations
    {
        public static bool IsPow2(int value);
        [CLSCompliant(False)]
        public static bool IsPow2(uint value);
        public static bool IsPow2(long value);
        [CLSCompliant(False)]
        public static bool IsPow2(ulong value);
        public static bool IsPow2(nint value);
        [CLSCompliant(False)]
        public static bool IsPow2(nuint value);
        [CLSCompliant(False)]
        public static uint RoundUpToPowerOf2(uint value);
        [CLSCompliant(False)]
        public static ulong RoundUpToPowerOf2(ulong value);
        [CLSCompliant(False)]
        public static nuint RoundUpToPowerOf2(nuint value);
        [CLSCompliant(False)]
        public static int LeadingZeroCount(uint value);
        [CLSCompliant(False)]
        public static int LeadingZeroCount(ulong value);
        [CLSCompliant(False)]
        public static int LeadingZeroCount(nuint value);
        [CLSCompliant(False)]
        public static int Log2(uint value);
        [CLSCompliant(False)]
        public static int Log2(ulong value);
        [CLSCompliant(False)]
        public static int Log2(nuint value);
        [CLSCompliant(False)]
        public static int PopCount(uint value);
        [CLSCompliant(False)]
        public static int PopCount(ulong value);
        [CLSCompliant(False)]
        public static int PopCount(nuint value);
        public static int TrailingZeroCount(int value);
        [CLSCompliant(False)]
        public static int TrailingZeroCount(uint value);
        public static int TrailingZeroCount(long value);
        [CLSCompliant(False)]
        public static int TrailingZeroCount(ulong value);
        public static int TrailingZeroCount(nint value);
        [CLSCompliant(False)]
        public static int TrailingZeroCount(nuint value);
        [CLSCompliant(False)]
        public static uint RotateLeft(uint value, int offset);
        [CLSCompliant(False)]
        public static ulong RotateLeft(ulong value, int offset);
        [CLSCompliant(False)]
        public static nuint RotateLeft(nuint value, int offset);
        [CLSCompliant(False)]
        public static uint RotateRight(uint value, int offset);
        [CLSCompliant(False)]
        public static ulong RotateRight(ulong value, int offset);
        [CLSCompliant(False)]
        public static nuint RotateRight(nuint value, int offset);
        [CLSCompliant(False)]
        public static uint Crc32C(uint crc, byte data);
        [CLSCompliant(False)]
        public static uint Crc32C(uint crc, ushort data);
        [CLSCompliant(False)]
        public static uint Crc32C(uint crc, uint data);
        [CLSCompliant(False)]
        public static uint Crc32C(uint crc, ulong data);
    }
}
