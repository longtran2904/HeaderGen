#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers.Binary
{
    public static class BinaryPrimitives
    {
        public static double ReadDoubleBigEndian(ReadOnlySpan<byte> source);
        public static Half ReadHalfBigEndian(ReadOnlySpan<byte> source);
        public static short ReadInt16BigEndian(ReadOnlySpan<byte> source);
        public static int ReadInt32BigEndian(ReadOnlySpan<byte> source);
        public static long ReadInt64BigEndian(ReadOnlySpan<byte> source);
        public static Int128 ReadInt128BigEndian(ReadOnlySpan<byte> source);
        public static nint ReadIntPtrBigEndian(ReadOnlySpan<byte> source);
        public static float ReadSingleBigEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static ushort ReadUInt16BigEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static uint ReadUInt32BigEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static ulong ReadUInt64BigEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static UInt128 ReadUInt128BigEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static nuint ReadUIntPtrBigEndian(ReadOnlySpan<byte> source);
        public static bool TryReadDoubleBigEndian(ReadOnlySpan<byte> source, out double value);
        public static bool TryReadHalfBigEndian(ReadOnlySpan<byte> source, out Half value);
        public static bool TryReadInt16BigEndian(ReadOnlySpan<byte> source, out short value);
        public static bool TryReadInt32BigEndian(ReadOnlySpan<byte> source, out int value);
        public static bool TryReadInt64BigEndian(ReadOnlySpan<byte> source, out long value);
        public static bool TryReadInt128BigEndian(ReadOnlySpan<byte> source, out Int128 value);
        public static bool TryReadIntPtrBigEndian(ReadOnlySpan<byte> source, out nint value);
        public static bool TryReadSingleBigEndian(ReadOnlySpan<byte> source, out float value);
        [CLSCompliant(False)]
        public static bool TryReadUInt16BigEndian(ReadOnlySpan<byte> source, out ushort value);
        [CLSCompliant(False)]
        public static bool TryReadUInt32BigEndian(ReadOnlySpan<byte> source, out uint value);
        [CLSCompliant(False)]
        public static bool TryReadUInt64BigEndian(ReadOnlySpan<byte> source, out ulong value);
        [CLSCompliant(False)]
        public static bool TryReadUInt128BigEndian(ReadOnlySpan<byte> source, out UInt128 value);
        [CLSCompliant(False)]
        public static bool TryReadUIntPtrBigEndian(ReadOnlySpan<byte> source, out nuint value);
        public static double ReadDoubleLittleEndian(ReadOnlySpan<byte> source);
        public static Half ReadHalfLittleEndian(ReadOnlySpan<byte> source);
        public static short ReadInt16LittleEndian(ReadOnlySpan<byte> source);
        public static int ReadInt32LittleEndian(ReadOnlySpan<byte> source);
        public static long ReadInt64LittleEndian(ReadOnlySpan<byte> source);
        public static Int128 ReadInt128LittleEndian(ReadOnlySpan<byte> source);
        public static nint ReadIntPtrLittleEndian(ReadOnlySpan<byte> source);
        public static float ReadSingleLittleEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static ushort ReadUInt16LittleEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static uint ReadUInt32LittleEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static ulong ReadUInt64LittleEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static UInt128 ReadUInt128LittleEndian(ReadOnlySpan<byte> source);
        [CLSCompliant(False)]
        public static nuint ReadUIntPtrLittleEndian(ReadOnlySpan<byte> source);
        public static bool TryReadDoubleLittleEndian(ReadOnlySpan<byte> source, out double value);
        public static bool TryReadHalfLittleEndian(ReadOnlySpan<byte> source, out Half value);
        public static bool TryReadInt16LittleEndian(ReadOnlySpan<byte> source, out short value);
        public static bool TryReadInt32LittleEndian(ReadOnlySpan<byte> source, out int value);
        public static bool TryReadInt64LittleEndian(ReadOnlySpan<byte> source, out long value);
        public static bool TryReadInt128LittleEndian(ReadOnlySpan<byte> source, out Int128 value);
        public static bool TryReadIntPtrLittleEndian(ReadOnlySpan<byte> source, out nint value);
        public static bool TryReadSingleLittleEndian(ReadOnlySpan<byte> source, out float value);
        [CLSCompliant(False)]
        public static bool TryReadUInt16LittleEndian(ReadOnlySpan<byte> source, out ushort value);
        [CLSCompliant(False)]
        public static bool TryReadUInt32LittleEndian(ReadOnlySpan<byte> source, out uint value);
        [CLSCompliant(False)]
        public static bool TryReadUInt64LittleEndian(ReadOnlySpan<byte> source, out ulong value);
        [CLSCompliant(False)]
        public static bool TryReadUInt128LittleEndian(ReadOnlySpan<byte> source, out UInt128 value);
        [CLSCompliant(False)]
        public static bool TryReadUIntPtrLittleEndian(ReadOnlySpan<byte> source, out nuint value);
        [CLSCompliant(False)]
        public static sbyte ReverseEndianness(sbyte value);
        public static short ReverseEndianness(short value);
        public static int ReverseEndianness(int value);
        public static long ReverseEndianness(long value);
        public static nint ReverseEndianness(nint value);
        public static Int128 ReverseEndianness(Int128 value);
        public static byte ReverseEndianness(byte value);
        [CLSCompliant(False)]
        public static ushort ReverseEndianness(ushort value);
        [CLSCompliant(False)]
        public static uint ReverseEndianness(uint value);
        [CLSCompliant(False)]
        public static ulong ReverseEndianness(ulong value);
        [CLSCompliant(False)]
        public static nuint ReverseEndianness(nuint value);
        [CLSCompliant(False)]
        public static UInt128 ReverseEndianness(UInt128 value);
        [CLSCompliant(False)]
        public static void ReverseEndianness(ReadOnlySpan<ushort> source, Span<ushort> destination);
        public static void ReverseEndianness(ReadOnlySpan<short> source, Span<short> destination);
        [CLSCompliant(False)]
        public static void ReverseEndianness(ReadOnlySpan<uint> source, Span<uint> destination);
        public static void ReverseEndianness(ReadOnlySpan<int> source, Span<int> destination);
        [CLSCompliant(False)]
        public static void ReverseEndianness(ReadOnlySpan<ulong> source, Span<ulong> destination);
        public static void ReverseEndianness(ReadOnlySpan<long> source, Span<long> destination);
        [CLSCompliant(False)]
        public static void ReverseEndianness(ReadOnlySpan<nuint> source, Span<nuint> destination);
        public static void ReverseEndianness(ReadOnlySpan<nint> source, Span<nint> destination);
        [CLSCompliant(False)]
        public static void ReverseEndianness(ReadOnlySpan<UInt128> source, Span<UInt128> destination);
        public static void ReverseEndianness(ReadOnlySpan<Int128> source, Span<Int128> destination);
        public static void WriteDoubleBigEndian(Span<byte> destination, double value);
        public static void WriteHalfBigEndian(Span<byte> destination, Half value);
        public static void WriteInt16BigEndian(Span<byte> destination, short value);
        public static void WriteInt32BigEndian(Span<byte> destination, int value);
        public static void WriteInt64BigEndian(Span<byte> destination, long value);
        public static void WriteInt128BigEndian(Span<byte> destination, Int128 value);
        public static void WriteIntPtrBigEndian(Span<byte> destination, nint value);
        public static void WriteSingleBigEndian(Span<byte> destination, float value);
        [CLSCompliant(False)]
        public static void WriteUInt16BigEndian(Span<byte> destination, ushort value);
        [CLSCompliant(False)]
        public static void WriteUInt32BigEndian(Span<byte> destination, uint value);
        [CLSCompliant(False)]
        public static void WriteUInt64BigEndian(Span<byte> destination, ulong value);
        [CLSCompliant(False)]
        public static void WriteUInt128BigEndian(Span<byte> destination, UInt128 value);
        [CLSCompliant(False)]
        public static void WriteUIntPtrBigEndian(Span<byte> destination, nuint value);
        public static bool TryWriteDoubleBigEndian(Span<byte> destination, double value);
        public static bool TryWriteHalfBigEndian(Span<byte> destination, Half value);
        public static bool TryWriteInt16BigEndian(Span<byte> destination, short value);
        public static bool TryWriteInt32BigEndian(Span<byte> destination, int value);
        public static bool TryWriteInt64BigEndian(Span<byte> destination, long value);
        public static bool TryWriteInt128BigEndian(Span<byte> destination, Int128 value);
        public static bool TryWriteIntPtrBigEndian(Span<byte> destination, nint value);
        public static bool TryWriteSingleBigEndian(Span<byte> destination, float value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt16BigEndian(Span<byte> destination, ushort value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt32BigEndian(Span<byte> destination, uint value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt64BigEndian(Span<byte> destination, ulong value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt128BigEndian(Span<byte> destination, UInt128 value);
        [CLSCompliant(False)]
        public static bool TryWriteUIntPtrBigEndian(Span<byte> destination, nuint value);
        public static void WriteDoubleLittleEndian(Span<byte> destination, double value);
        public static void WriteHalfLittleEndian(Span<byte> destination, Half value);
        public static void WriteInt16LittleEndian(Span<byte> destination, short value);
        public static void WriteInt32LittleEndian(Span<byte> destination, int value);
        public static void WriteInt64LittleEndian(Span<byte> destination, long value);
        public static void WriteInt128LittleEndian(Span<byte> destination, Int128 value);
        public static void WriteIntPtrLittleEndian(Span<byte> destination, nint value);
        public static void WriteSingleLittleEndian(Span<byte> destination, float value);
        [CLSCompliant(False)]
        public static void WriteUInt16LittleEndian(Span<byte> destination, ushort value);
        [CLSCompliant(False)]
        public static void WriteUInt32LittleEndian(Span<byte> destination, uint value);
        [CLSCompliant(False)]
        public static void WriteUInt64LittleEndian(Span<byte> destination, ulong value);
        [CLSCompliant(False)]
        public static void WriteUInt128LittleEndian(Span<byte> destination, UInt128 value);
        [CLSCompliant(False)]
        public static void WriteUIntPtrLittleEndian(Span<byte> destination, nuint value);
        public static bool TryWriteDoubleLittleEndian(Span<byte> destination, double value);
        public static bool TryWriteHalfLittleEndian(Span<byte> destination, Half value);
        public static bool TryWriteInt16LittleEndian(Span<byte> destination, short value);
        public static bool TryWriteInt32LittleEndian(Span<byte> destination, int value);
        public static bool TryWriteInt64LittleEndian(Span<byte> destination, long value);
        public static bool TryWriteInt128LittleEndian(Span<byte> destination, Int128 value);
        public static bool TryWriteIntPtrLittleEndian(Span<byte> destination, nint value);
        public static bool TryWriteSingleLittleEndian(Span<byte> destination, float value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt16LittleEndian(Span<byte> destination, ushort value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt32LittleEndian(Span<byte> destination, uint value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt64LittleEndian(Span<byte> destination, ulong value);
        [CLSCompliant(False)]
        public static bool TryWriteUInt128LittleEndian(Span<byte> destination, UInt128 value);
        [CLSCompliant(False)]
        public static bool TryWriteUIntPtrLittleEndian(Span<byte> destination, nuint value);
    }
}
