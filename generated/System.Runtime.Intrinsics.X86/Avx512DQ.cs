#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Intrinsics.X86
{
    [CLSCompliant(False)]
    public abstract class Avx512DQ : Avx512F
    {

        public static bool IsSupported { get; }

        public static Vector512<float> And(Vector512<float> left, Vector512<float> right);
        public static Vector512<double> And(Vector512<double> left, Vector512<double> right);
        public static Vector512<float> AndNot(Vector512<float> left, Vector512<float> right);
        public static Vector512<double> AndNot(Vector512<double> left, Vector512<double> right);
        public static Vector512<int> BroadcastPairScalarToVector512(Vector128<int> value);
        public static Vector512<uint> BroadcastPairScalarToVector512(Vector128<uint> value);
        public static Vector512<float> BroadcastPairScalarToVector512(Vector128<float> value);
        public static Vector512<long> BroadcastVector128ToVector512(long* address);
        public static Vector512<ulong> BroadcastVector128ToVector512(ulong* address);
        public static Vector512<double> BroadcastVector128ToVector512(double* address);
        public static Vector512<int> BroadcastVector256ToVector512(int* address);
        public static Vector512<uint> BroadcastVector256ToVector512(uint* address);
        public static Vector512<float> BroadcastVector256ToVector512(float* address);
        public static Vector256<float> ConvertToVector256Single(Vector512<long> value);
        public static Vector256<float> ConvertToVector256Single(Vector512<ulong> value);
        public static Vector512<double> ConvertToVector512Double(Vector512<long> value);
        public static Vector512<double> ConvertToVector512Double(Vector512<ulong> value);
        public static Vector512<long> ConvertToVector512Int64(Vector256<float> value);
        public static Vector512<long> ConvertToVector512Int64(Vector512<double> value);
        public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector256<float> value);
        public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector512<double> value);
        public static Vector512<ulong> ConvertToVector512UInt64(Vector256<float> value);
        public static Vector512<ulong> ConvertToVector512UInt64(Vector512<double> value);
        public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector256<float> value);
        public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector512<double> value);
        public static Vector128<long> ExtractVector128(Vector512<long> value, byte index);
        public static Vector128<ulong> ExtractVector128(Vector512<ulong> value, byte index);
        public static Vector128<double> ExtractVector128(Vector512<double> value, byte index);
        public static Vector256<int> ExtractVector256(Vector512<int> value, byte index);
        public static Vector256<uint> ExtractVector256(Vector512<uint> value, byte index);
        public static Vector256<float> ExtractVector256(Vector512<float> value, byte index);
        public static Vector512<long> InsertVector128(Vector512<long> value, Vector128<long> data, byte index);
        public static Vector512<ulong> InsertVector128(Vector512<ulong> value, Vector128<ulong> data, byte index);
        public static Vector512<double> InsertVector128(Vector512<double> value, Vector128<double> data, byte index);
        public static Vector512<int> InsertVector256(Vector512<int> value, Vector256<int> data, byte index);
        public static Vector512<uint> InsertVector256(Vector512<uint> value, Vector256<uint> data, byte index);
        public static Vector512<float> InsertVector256(Vector512<float> value, Vector256<float> data, byte index);
        public static Vector512<long> MultiplyLow(Vector512<long> left, Vector512<long> right);
        public static Vector512<ulong> MultiplyLow(Vector512<ulong> left, Vector512<ulong> right);
        public static Vector512<float> Or(Vector512<float> left, Vector512<float> right);
        public static Vector512<double> Or(Vector512<double> left, Vector512<double> right);
        public static Vector512<float> Range(Vector512<float> left, Vector512<float> right, byte control);
        public static Vector512<double> Range(Vector512<double> left, Vector512<double> right, byte control);
        public static Vector128<float> RangeScalar(Vector128<float> left, Vector128<float> right, byte control);
        public static Vector128<double> RangeScalar(Vector128<double> left, Vector128<double> right, byte control);
        public static Vector512<float> Reduce(Vector512<float> value, byte control);
        public static Vector512<double> Reduce(Vector512<double> value, byte control);
        public static Vector128<float> ReduceScalar(Vector128<float> value, byte control);
        public static Vector128<double> ReduceScalar(Vector128<double> value, byte control);
        public static Vector128<float> ReduceScalar(Vector128<float> upper, Vector128<float> value, byte control);
        public static Vector128<double> ReduceScalar(Vector128<double> upper, Vector128<double> value, byte control);
        public static Vector512<float> Xor(Vector512<float> left, Vector512<float> right);
        public static Vector512<double> Xor(Vector512<double> left, Vector512<double> right);
        public abstract class VL : Avx512F.VL
        {

            public static bool IsSupported { get; }

            public static Vector128<int> BroadcastPairScalarToVector128(Vector128<int> value);
            public static Vector128<uint> BroadcastPairScalarToVector128(Vector128<uint> value);
            public static Vector256<int> BroadcastPairScalarToVector256(Vector128<int> value);
            public static Vector256<uint> BroadcastPairScalarToVector256(Vector128<uint> value);
            public static Vector256<float> BroadcastPairScalarToVector256(Vector128<float> value);
            public static Vector128<double> ConvertToVector128Double(Vector128<long> value);
            public static Vector128<double> ConvertToVector128Double(Vector128<ulong> value);
            public static Vector128<long> ConvertToVector128Int64(Vector128<float> value);
            public static Vector128<long> ConvertToVector128Int64(Vector128<double> value);
            public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<float> value);
            public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<double> value);
            public static Vector128<float> ConvertToVector128Single(Vector128<long> value);
            public static Vector128<float> ConvertToVector128Single(Vector256<long> value);
            public static Vector128<float> ConvertToVector128Single(Vector128<ulong> value);
            public static Vector128<float> ConvertToVector128Single(Vector256<ulong> value);
            public static Vector128<ulong> ConvertToVector128UInt64(Vector128<float> value);
            public static Vector128<ulong> ConvertToVector128UInt64(Vector128<double> value);
            public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<float> value);
            public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<double> value);
            public static Vector256<double> ConvertToVector256Double(Vector256<long> value);
            public static Vector256<double> ConvertToVector256Double(Vector256<ulong> value);
            public static Vector256<long> ConvertToVector256Int64(Vector128<float> value);
            public static Vector256<long> ConvertToVector256Int64(Vector256<double> value);
            public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector128<float> value);
            public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector256<double> value);
            public static Vector256<ulong> ConvertToVector256UInt64(Vector128<float> value);
            public static Vector256<ulong> ConvertToVector256UInt64(Vector256<double> value);
            public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector128<float> value);
            public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector256<double> value);
            public static Vector128<long> MultiplyLow(Vector128<long> left, Vector128<long> right);
            public static Vector128<ulong> MultiplyLow(Vector128<ulong> left, Vector128<ulong> right);
            public static Vector256<long> MultiplyLow(Vector256<long> left, Vector256<long> right);
            public static Vector256<ulong> MultiplyLow(Vector256<ulong> left, Vector256<ulong> right);
            public static Vector128<float> Range(Vector128<float> left, Vector128<float> right, byte control);
            public static Vector128<double> Range(Vector128<double> left, Vector128<double> right, byte control);
            public static Vector256<float> Range(Vector256<float> left, Vector256<float> right, byte control);
            public static Vector256<double> Range(Vector256<double> left, Vector256<double> right, byte control);
            public static Vector128<float> Reduce(Vector128<float> value, byte control);
            public static Vector128<double> Reduce(Vector128<double> value, byte control);
            public static Vector256<float> Reduce(Vector256<float> value, byte control);
            public static Vector256<double> Reduce(Vector256<double> value, byte control);
        }
        public abstract class X64 : Avx512F.X64
        {

            public static bool IsSupported { get; }
        }
    }
}
