#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class BitConverter
    {

        public static readonly bool IsLittleEndian;

        public static byte[] GetBytes(bool value);
        public static bool TryWriteBytes(Span<byte> destination, bool value);
        public static byte[] GetBytes(char value);
        public static bool TryWriteBytes(Span<byte> destination, char value);
        public static byte[] GetBytes(short value);
        public static bool TryWriteBytes(Span<byte> destination, short value);
        public static byte[] GetBytes(int value);
        public static bool TryWriteBytes(Span<byte> destination, int value);
        public static byte[] GetBytes(long value);
        public static bool TryWriteBytes(Span<byte> destination, long value);
        [CLSCompliant(False)]
        public static byte[] GetBytes(ushort value);
        [CLSCompliant(False)]
        public static bool TryWriteBytes(Span<byte> destination, ushort value);
        [CLSCompliant(False)]
        public static byte[] GetBytes(uint value);
        [CLSCompliant(False)]
        public static bool TryWriteBytes(Span<byte> destination, uint value);
        [CLSCompliant(False)]
        public static byte[] GetBytes(ulong value);
        [CLSCompliant(False)]
        public static bool TryWriteBytes(Span<byte> destination, ulong value);
        public static byte[] GetBytes(Half value);
        public static bool TryWriteBytes(Span<byte> destination, Half value);
        public static byte[] GetBytes(float value);
        public static bool TryWriteBytes(Span<byte> destination, float value);
        public static byte[] GetBytes(double value);
        public static bool TryWriteBytes(Span<byte> destination, double value);
        public static char ToChar(byte[] value, int startIndex);
        public static char ToChar(ReadOnlySpan<byte> value);
        public static short ToInt16(byte[] value, int startIndex);
        public static short ToInt16(ReadOnlySpan<byte> value);
        public static int ToInt32(byte[] value, int startIndex);
        public static int ToInt32(ReadOnlySpan<byte> value);
        public static long ToInt64(byte[] value, int startIndex);
        public static long ToInt64(ReadOnlySpan<byte> value);
        [CLSCompliant(False)]
        public static ushort ToUInt16(byte[] value, int startIndex);
        [CLSCompliant(False)]
        public static ushort ToUInt16(ReadOnlySpan<byte> value);
        [CLSCompliant(False)]
        public static uint ToUInt32(byte[] value, int startIndex);
        [CLSCompliant(False)]
        public static uint ToUInt32(ReadOnlySpan<byte> value);
        [CLSCompliant(False)]
        public static ulong ToUInt64(byte[] value, int startIndex);
        [CLSCompliant(False)]
        public static ulong ToUInt64(ReadOnlySpan<byte> value);
        public static Half ToHalf(byte[] value, int startIndex);
        public static Half ToHalf(ReadOnlySpan<byte> value);
        public static float ToSingle(byte[] value, int startIndex);
        public static float ToSingle(ReadOnlySpan<byte> value);
        public static double ToDouble(byte[] value, int startIndex);
        public static double ToDouble(ReadOnlySpan<byte> value);
        public static string ToString(byte[] value, int startIndex, int length);
        public static string ToString(byte[] value);
        public static string ToString(byte[] value, int startIndex);
        public static bool ToBoolean(byte[] value, int startIndex);
        public static bool ToBoolean(ReadOnlySpan<byte> value);
        public static long DoubleToInt64Bits(double value);
        public static double Int64BitsToDouble(long value);
        public static int SingleToInt32Bits(float value);
        public static float Int32BitsToSingle(int value);
        public static short HalfToInt16Bits(Half value);
        public static Half Int16BitsToHalf(short value);
        [CLSCompliant(False)]
        public static ulong DoubleToUInt64Bits(double value);
        [CLSCompliant(False)]
        public static double UInt64BitsToDouble(ulong value);
        [CLSCompliant(False)]
        public static uint SingleToUInt32Bits(float value);
        [CLSCompliant(False)]
        public static float UInt32BitsToSingle(uint value);
        [CLSCompliant(False)]
        public static ushort HalfToUInt16Bits(Half value);
        [CLSCompliant(False)]
        public static Half UInt16BitsToHalf(ushort value);
    }
}
