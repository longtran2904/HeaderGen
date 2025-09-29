#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Sse41 : Ssse3
    {

        public static bool IsSupported { get; }

        public static Vector128<short> Blend(Vector128<short> left, Vector128<short> right, byte control);
        public static Vector128<ushort> Blend(Vector128<ushort> left, Vector128<ushort> right, byte control);
        public static Vector128<float> Blend(Vector128<float> left, Vector128<float> right, byte control);
        public static Vector128<double> Blend(Vector128<double> left, Vector128<double> right, byte control);
        public static Vector128<sbyte> BlendVariable(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask);
        public static Vector128<byte> BlendVariable(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask);
        public static Vector128<short> BlendVariable(Vector128<short> left, Vector128<short> right, Vector128<short> mask);
        public static Vector128<ushort> BlendVariable(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask);
        public static Vector128<int> BlendVariable(Vector128<int> left, Vector128<int> right, Vector128<int> mask);
        public static Vector128<uint> BlendVariable(Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask);
        public static Vector128<long> BlendVariable(Vector128<long> left, Vector128<long> right, Vector128<long> mask);
        public static Vector128<ulong> BlendVariable(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask);
        public static Vector128<float> BlendVariable(Vector128<float> left, Vector128<float> right, Vector128<float> mask);
        public static Vector128<double> BlendVariable(Vector128<double> left, Vector128<double> right, Vector128<double> mask);
        public static Vector128<float> Ceiling(Vector128<float> value);
        public static Vector128<double> Ceiling(Vector128<double> value);
        public static Vector128<float> CeilingScalar(Vector128<float> value);
        public static Vector128<float> CeilingScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> CeilingScalar(Vector128<double> value);
        public static Vector128<double> CeilingScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right);
        public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right);
        public static Vector128<short> ConvertToVector128Int16(Vector128<sbyte> value);
        public static Vector128<short> ConvertToVector128Int16(Vector128<byte> value);
        public static Vector128<int> ConvertToVector128Int32(Vector128<sbyte> value);
        public static Vector128<int> ConvertToVector128Int32(Vector128<byte> value);
        public static Vector128<int> ConvertToVector128Int32(Vector128<short> value);
        public static Vector128<int> ConvertToVector128Int32(Vector128<ushort> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<sbyte> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<byte> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<short> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<ushort> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<int> value);
        public static Vector128<long> ConvertToVector128Int64(Vector128<uint> value);
        public static Vector128<short> ConvertToVector128Int16(sbyte* address);
        public static Vector128<short> ConvertToVector128Int16(byte* address);
        public static Vector128<int> ConvertToVector128Int32(sbyte* address);
        public static Vector128<int> ConvertToVector128Int32(byte* address);
        public static Vector128<int> ConvertToVector128Int32(short* address);
        public static Vector128<int> ConvertToVector128Int32(ushort* address);
        public static Vector128<long> ConvertToVector128Int64(sbyte* address);
        public static Vector128<long> ConvertToVector128Int64(byte* address);
        public static Vector128<long> ConvertToVector128Int64(short* address);
        public static Vector128<long> ConvertToVector128Int64(ushort* address);
        public static Vector128<long> ConvertToVector128Int64(int* address);
        public static Vector128<long> ConvertToVector128Int64(uint* address);
        public static Vector128<float> DotProduct(Vector128<float> left, Vector128<float> right, byte control);
        public static Vector128<double> DotProduct(Vector128<double> left, Vector128<double> right, byte control);
        public static byte Extract(Vector128<byte> value, byte index);
        public static int Extract(Vector128<int> value, byte index);
        public static uint Extract(Vector128<uint> value, byte index);
        public static float Extract(Vector128<float> value, byte index);
        public static Vector128<float> Floor(Vector128<float> value);
        public static Vector128<double> Floor(Vector128<double> value);
        public static Vector128<float> FloorScalar(Vector128<float> value);
        public static Vector128<float> FloorScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> FloorScalar(Vector128<double> value);
        public static Vector128<double> FloorScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<sbyte> Insert(Vector128<sbyte> value, sbyte data, byte index);
        public static Vector128<byte> Insert(Vector128<byte> value, byte data, byte index);
        public static Vector128<int> Insert(Vector128<int> value, int data, byte index);
        public static Vector128<uint> Insert(Vector128<uint> value, uint data, byte index);
        public static Vector128<float> Insert(Vector128<float> value, Vector128<float> data, byte index);
        public static Vector128<sbyte> LoadAlignedVector128NonTemporal(sbyte* address);
        public static Vector128<byte> LoadAlignedVector128NonTemporal(byte* address);
        public static Vector128<short> LoadAlignedVector128NonTemporal(short* address);
        public static Vector128<ushort> LoadAlignedVector128NonTemporal(ushort* address);
        public static Vector128<int> LoadAlignedVector128NonTemporal(int* address);
        public static Vector128<uint> LoadAlignedVector128NonTemporal(uint* address);
        public static Vector128<long> LoadAlignedVector128NonTemporal(long* address);
        public static Vector128<ulong> LoadAlignedVector128NonTemporal(ulong* address);
        public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right);
        public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right);
        public static Vector128<int> Max(Vector128<int> left, Vector128<int> right);
        public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right);
        public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right);
        public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right);
        public static Vector128<int> Min(Vector128<int> left, Vector128<int> right);
        public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right);
        public static Vector128<ushort> MinHorizontal(Vector128<ushort> value);
        public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right, byte mask);
        public static Vector128<long> Multiply(Vector128<int> left, Vector128<int> right);
        public static Vector128<int> MultiplyLow(Vector128<int> left, Vector128<int> right);
        public static Vector128<uint> MultiplyLow(Vector128<uint> left, Vector128<uint> right);
        public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> left, Vector128<int> right);
        public static Vector128<float> RoundCurrentDirection(Vector128<float> value);
        public static Vector128<double> RoundCurrentDirection(Vector128<double> value);
        public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> value);
        public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> value);
        public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<float> RoundToNearestInteger(Vector128<float> value);
        public static Vector128<double> RoundToNearestInteger(Vector128<double> value);
        public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> value);
        public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> value);
        public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value);
        public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value);
        public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> value);
        public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> value);
        public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value);
        public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value);
        public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> value);
        public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> value);
        public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> upper, Vector128<double> value);
        public static Vector128<float> RoundToZero(Vector128<float> value);
        public static Vector128<double> RoundToZero(Vector128<double> value);
        public static Vector128<float> RoundToZeroScalar(Vector128<float> value);
        public static Vector128<float> RoundToZeroScalar(Vector128<float> upper, Vector128<float> value);
        public static Vector128<double> RoundToZeroScalar(Vector128<double> value);
        public static Vector128<double> RoundToZeroScalar(Vector128<double> upper, Vector128<double> value);
        public static bool TestC(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestC(Vector128<byte> left, Vector128<byte> right);
        public static bool TestC(Vector128<short> left, Vector128<short> right);
        public static bool TestC(Vector128<ushort> left, Vector128<ushort> right);
        public static bool TestC(Vector128<int> left, Vector128<int> right);
        public static bool TestC(Vector128<uint> left, Vector128<uint> right);
        public static bool TestC(Vector128<long> left, Vector128<long> right);
        public static bool TestC(Vector128<ulong> left, Vector128<ulong> right);
        public static bool TestNotZAndNotC(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestNotZAndNotC(Vector128<byte> left, Vector128<byte> right);
        public static bool TestNotZAndNotC(Vector128<short> left, Vector128<short> right);
        public static bool TestNotZAndNotC(Vector128<ushort> left, Vector128<ushort> right);
        public static bool TestNotZAndNotC(Vector128<int> left, Vector128<int> right);
        public static bool TestNotZAndNotC(Vector128<uint> left, Vector128<uint> right);
        public static bool TestNotZAndNotC(Vector128<long> left, Vector128<long> right);
        public static bool TestNotZAndNotC(Vector128<ulong> left, Vector128<ulong> right);
        public static bool TestZ(Vector128<sbyte> left, Vector128<sbyte> right);
        public static bool TestZ(Vector128<byte> left, Vector128<byte> right);
        public static bool TestZ(Vector128<short> left, Vector128<short> right);
        public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right);
        public static bool TestZ(Vector128<int> left, Vector128<int> right);
        public static bool TestZ(Vector128<uint> left, Vector128<uint> right);
        public static bool TestZ(Vector128<long> left, Vector128<long> right);
        public static bool TestZ(Vector128<ulong> left, Vector128<ulong> right);
        public abstract class X64 : Ssse3.X64
        {

            public static bool IsSupported { get; }

            public static long Extract(Vector128<long> value, byte index);
            public static ulong Extract(Vector128<ulong> value, byte index);
            public static Vector128<long> Insert(Vector128<long> value, long data, byte index);
            public static Vector128<ulong> Insert(Vector128<ulong> value, ulong data, byte index);
        }
    }
}
