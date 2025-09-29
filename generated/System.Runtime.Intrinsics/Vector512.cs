#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Numerics;

namespace System.Runtime.Intrinsics
{
    public static class Vector512
    {
        public static bool IsHardwareAccelerated { get; }

        public static Vector512<T> Abs<T>(Vector512<T> vector);
        public static Vector512<T> Add<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> AndNot<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<TTo> As<TFrom, TTo>(this Vector512<TFrom> vector);
        public static Vector512<byte> AsByte<T>(this Vector512<T> vector);
        public static Vector512<double> AsDouble<T>(this Vector512<T> vector);
        public static Vector512<short> AsInt16<T>(this Vector512<T> vector);
        public static Vector512<int> AsInt32<T>(this Vector512<T> vector);
        public static Vector512<long> AsInt64<T>(this Vector512<T> vector);
        public static Vector512<nint> AsNInt<T>(this Vector512<T> vector);
        [CLSCompliant(False)]
        public static Vector512<nuint> AsNUInt<T>(this Vector512<T> vector);
        [CLSCompliant(False)]
        public static Vector512<sbyte> AsSByte<T>(this Vector512<T> vector);
        public static Vector512<float> AsSingle<T>(this Vector512<T> vector);
        [CLSCompliant(False)]
        public static Vector512<ushort> AsUInt16<T>(this Vector512<T> vector);
        [CLSCompliant(False)]
        public static Vector512<uint> AsUInt32<T>(this Vector512<T> vector);
        [CLSCompliant(False)]
        public static Vector512<ulong> AsUInt64<T>(this Vector512<T> vector);
        public static Vector512<T> AsVector512<T>(this Vector<T> value);
        public static Vector<T> AsVector<T>(this Vector512<T> value);
        public static Vector512<T> BitwiseAnd<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> BitwiseOr<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<float> Ceiling(Vector512<float> vector);
        public static Vector512<double> Ceiling(Vector512<double> vector);
        public static Vector512<T> ConditionalSelect<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right);
        public static Vector512<double> ConvertToDouble(Vector512<long> vector);
        [CLSCompliant(False)]
        public static Vector512<double> ConvertToDouble(Vector512<ulong> vector);
        public static Vector512<int> ConvertToInt32(Vector512<float> vector);
        public static Vector512<long> ConvertToInt64(Vector512<double> vector);
        public static Vector512<float> ConvertToSingle(Vector512<int> vector);
        [CLSCompliant(False)]
        public static Vector512<float> ConvertToSingle(Vector512<uint> vector);
        [CLSCompliant(False)]
        public static Vector512<uint> ConvertToUInt32(Vector512<float> vector);
        [CLSCompliant(False)]
        public static Vector512<ulong> ConvertToUInt64(Vector512<double> vector);
        public static void CopyTo<T>(this Vector512<T> vector, T[] destination);
        public static void CopyTo<T>(this Vector512<T> vector, T[] destination, int startIndex);
        public static void CopyTo<T>(this Vector512<T> vector, Span<T> destination);
        public static Vector512<T> Create<T>(T value);
        public static Vector512<byte> Create(byte value);
        public static Vector512<double> Create(double value);
        public static Vector512<short> Create(short value);
        public static Vector512<int> Create(int value);
        public static Vector512<long> Create(long value);
        public static Vector512<nint> Create(nint value);
        [CLSCompliant(False)]
        public static Vector512<nuint> Create(nuint value);
        [CLSCompliant(False)]
        public static Vector512<sbyte> Create(sbyte value);
        public static Vector512<float> Create(float value);
        [CLSCompliant(False)]
        public static Vector512<ushort> Create(ushort value);
        [CLSCompliant(False)]
        public static Vector512<uint> Create(uint value);
        [CLSCompliant(False)]
        public static Vector512<ulong> Create(ulong value);
        public static Vector512<T> Create<T>(T[] values);
        public static Vector512<T> Create<T>(T[] values, int index);
        public static Vector512<T> Create<T>(ReadOnlySpan<T> values);
        public static Vector512<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31, byte e32, byte e33, byte e34, byte e35, byte e36, byte e37, byte e38, byte e39, byte e40, byte e41, byte e42, byte e43, byte e44, byte e45, byte e46, byte e47, byte e48, byte e49, byte e50, byte e51, byte e52, byte e53, byte e54, byte e55, byte e56, byte e57, byte e58, byte e59, byte e60, byte e61, byte e62, byte e63);
        public static Vector512<double> Create(double e0, double e1, double e2, double e3, double e4, double e5, double e6, double e7);
        public static Vector512<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15, short e16, short e17, short e18, short e19, short e20, short e21, short e22, short e23, short e24, short e25, short e26, short e27, short e28, short e29, short e30, short e31);
        public static Vector512<int> Create(int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7, int e8, int e9, int e10, int e11, int e12, int e13, int e14, int e15);
        public static Vector512<long> Create(long e0, long e1, long e2, long e3, long e4, long e5, long e6, long e7);
        [CLSCompliant(False)]
        public static Vector512<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31, sbyte e32, sbyte e33, sbyte e34, sbyte e35, sbyte e36, sbyte e37, sbyte e38, sbyte e39, sbyte e40, sbyte e41, sbyte e42, sbyte e43, sbyte e44, sbyte e45, sbyte e46, sbyte e47, sbyte e48, sbyte e49, sbyte e50, sbyte e51, sbyte e52, sbyte e53, sbyte e54, sbyte e55, sbyte e56, sbyte e57, sbyte e58, sbyte e59, sbyte e60, sbyte e61, sbyte e62, sbyte e63);
        public static Vector512<float> Create(float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7, float e8, float e9, float e10, float e11, float e12, float e13, float e14, float e15);
        [CLSCompliant(False)]
        public static Vector512<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15, ushort e16, ushort e17, ushort e18, ushort e19, ushort e20, ushort e21, ushort e22, ushort e23, ushort e24, ushort e25, ushort e26, ushort e27, ushort e28, ushort e29, ushort e30, ushort e31);
        [CLSCompliant(False)]
        public static Vector512<uint> Create(uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7, uint e8, uint e9, uint e10, uint e11, uint e12, uint e13, uint e14, uint e15);
        [CLSCompliant(False)]
        public static Vector512<ulong> Create(ulong e0, ulong e1, ulong e2, ulong e3, ulong e4, ulong e5, ulong e6, ulong e7);
        public static Vector512<T> Create<T>(Vector256<T> lower, Vector256<T> upper);
        public static Vector512<byte> Create(Vector256<byte> lower, Vector256<byte> upper);
        public static Vector512<double> Create(Vector256<double> lower, Vector256<double> upper);
        public static Vector512<short> Create(Vector256<short> lower, Vector256<short> upper);
        public static Vector512<int> Create(Vector256<int> lower, Vector256<int> upper);
        public static Vector512<long> Create(Vector256<long> lower, Vector256<long> upper);
        public static Vector512<nint> Create(Vector256<nint> lower, Vector256<nint> upper);
        [CLSCompliant(False)]
        public static Vector512<nuint> Create(Vector256<nuint> lower, Vector256<nuint> upper);
        [CLSCompliant(False)]
        public static Vector512<sbyte> Create(Vector256<sbyte> lower, Vector256<sbyte> upper);
        public static Vector512<float> Create(Vector256<float> lower, Vector256<float> upper);
        [CLSCompliant(False)]
        public static Vector512<ushort> Create(Vector256<ushort> lower, Vector256<ushort> upper);
        [CLSCompliant(False)]
        public static Vector512<uint> Create(Vector256<uint> lower, Vector256<uint> upper);
        [CLSCompliant(False)]
        public static Vector512<ulong> Create(Vector256<ulong> lower, Vector256<ulong> upper);
        public static Vector512<T> CreateScalar<T>(T value);
        public static Vector512<byte> CreateScalar(byte value);
        public static Vector512<double> CreateScalar(double value);
        public static Vector512<short> CreateScalar(short value);
        public static Vector512<int> CreateScalar(int value);
        public static Vector512<long> CreateScalar(long value);
        public static Vector512<nint> CreateScalar(nint value);
        [CLSCompliant(False)]
        public static Vector512<nuint> CreateScalar(nuint value);
        [CLSCompliant(False)]
        public static Vector512<sbyte> CreateScalar(sbyte value);
        public static Vector512<float> CreateScalar(float value);
        [CLSCompliant(False)]
        public static Vector512<ushort> CreateScalar(ushort value);
        [CLSCompliant(False)]
        public static Vector512<uint> CreateScalar(uint value);
        [CLSCompliant(False)]
        public static Vector512<ulong> CreateScalar(ulong value);
        public static Vector512<T> CreateScalarUnsafe<T>(T value);
        public static Vector512<byte> CreateScalarUnsafe(byte value);
        public static Vector512<double> CreateScalarUnsafe(double value);
        public static Vector512<short> CreateScalarUnsafe(short value);
        public static Vector512<int> CreateScalarUnsafe(int value);
        public static Vector512<long> CreateScalarUnsafe(long value);
        public static Vector512<nint> CreateScalarUnsafe(nint value);
        [CLSCompliant(False)]
        public static Vector512<nuint> CreateScalarUnsafe(nuint value);
        [CLSCompliant(False)]
        public static Vector512<sbyte> CreateScalarUnsafe(sbyte value);
        public static Vector512<float> CreateScalarUnsafe(float value);
        [CLSCompliant(False)]
        public static Vector512<ushort> CreateScalarUnsafe(ushort value);
        [CLSCompliant(False)]
        public static Vector512<uint> CreateScalarUnsafe(uint value);
        [CLSCompliant(False)]
        public static Vector512<ulong> CreateScalarUnsafe(ulong value);
        public static Vector512<T> Divide<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> Divide<T>(Vector512<T> left, T right);
        public static T Dot<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> Equals<T>(Vector512<T> left, Vector512<T> right);
        public static bool EqualsAll<T>(Vector512<T> left, Vector512<T> right);
        public static bool EqualsAny<T>(Vector512<T> left, Vector512<T> right);
        [CLSCompliant(False)]
        public static ulong ExtractMostSignificantBits<T>(this Vector512<T> vector);
        public static Vector512<float> Floor(Vector512<float> vector);
        public static Vector512<double> Floor(Vector512<double> vector);
        public static T GetElement<T>(this Vector512<T> vector, int index);
        public static Vector256<T> GetLower<T>(this Vector512<T> vector);
        public static Vector256<T> GetUpper<T>(this Vector512<T> vector);
        public static Vector512<T> GreaterThan<T>(Vector512<T> left, Vector512<T> right);
        public static bool GreaterThanAll<T>(Vector512<T> left, Vector512<T> right);
        public static bool GreaterThanAny<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> GreaterThanOrEqual<T>(Vector512<T> left, Vector512<T> right);
        public static bool GreaterThanOrEqualAll<T>(Vector512<T> left, Vector512<T> right);
        public static bool GreaterThanOrEqualAny<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> LessThan<T>(Vector512<T> left, Vector512<T> right);
        public static bool LessThanAll<T>(Vector512<T> left, Vector512<T> right);
        public static bool LessThanAny<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> LessThanOrEqual<T>(Vector512<T> left, Vector512<T> right);
        public static bool LessThanOrEqualAll<T>(Vector512<T> left, Vector512<T> right);
        public static bool LessThanOrEqualAny<T>(Vector512<T> left, Vector512<T> right);
        [CLSCompliant(False)]
        public static Vector512<T> Load<T>(T* source);
        [CLSCompliant(False)]
        public static Vector512<T> LoadAligned<T>(T* source);
        [CLSCompliant(False)]
        public static Vector512<T> LoadAlignedNonTemporal<T>(T* source);
        public static Vector512<T> LoadUnsafe<T>(in T source);
        [CLSCompliant(False)]
        public static Vector512<T> LoadUnsafe<T>(in T source, nuint elementOffset);
        public static Vector512<T> Max<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> Min<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> Multiply<T>(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> Multiply<T>(Vector512<T> left, T right);
        public static Vector512<T> Multiply<T>(T left, Vector512<T> right);
        public static Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper);
        [CLSCompliant(False)]
        public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper);
        public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper);
        public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper);
        [CLSCompliant(False)]
        public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper);
        [CLSCompliant(False)]
        public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper);
        [CLSCompliant(False)]
        public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper);
        public static Vector512<T> Negate<T>(Vector512<T> vector);
        public static Vector512<T> OnesComplement<T>(Vector512<T> vector);
        public static Vector512<byte> ShiftLeft(Vector512<byte> vector, int shiftCount);
        public static Vector512<short> ShiftLeft(Vector512<short> vector, int shiftCount);
        public static Vector512<int> ShiftLeft(Vector512<int> vector, int shiftCount);
        public static Vector512<long> ShiftLeft(Vector512<long> vector, int shiftCount);
        public static Vector512<nint> ShiftLeft(Vector512<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<nuint> ShiftLeft(Vector512<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<sbyte> ShiftLeft(Vector512<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<ushort> ShiftLeft(Vector512<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<uint> ShiftLeft(Vector512<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<ulong> ShiftLeft(Vector512<ulong> vector, int shiftCount);
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> vector, int shiftCount);
        public static Vector512<int> ShiftRightArithmetic(Vector512<int> vector, int shiftCount);
        public static Vector512<long> ShiftRightArithmetic(Vector512<long> vector, int shiftCount);
        public static Vector512<nint> ShiftRightArithmetic(Vector512<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> vector, int shiftCount);
        public static Vector512<byte> ShiftRightLogical(Vector512<byte> vector, int shiftCount);
        public static Vector512<short> ShiftRightLogical(Vector512<short> vector, int shiftCount);
        public static Vector512<int> ShiftRightLogical(Vector512<int> vector, int shiftCount);
        public static Vector512<long> ShiftRightLogical(Vector512<long> vector, int shiftCount);
        public static Vector512<nint> ShiftRightLogical(Vector512<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<nuint> ShiftRightLogical(Vector512<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<uint> ShiftRightLogical(Vector512<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> vector, int shiftCount);
        public static Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices);
        [CLSCompliant(False)]
        public static Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices);
        public static Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices);
        [CLSCompliant(False)]
        public static Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices);
        public static Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices);
        [CLSCompliant(False)]
        public static Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices);
        public static Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices);
        public static Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices);
        [CLSCompliant(False)]
        public static Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices);
        public static Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices);
        public static Vector512<T> Sqrt<T>(Vector512<T> vector);
        [CLSCompliant(False)]
        public static void Store<T>(this Vector512<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAligned<T>(this Vector512<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAlignedNonTemporal<T>(this Vector512<T> source, T* destination);
        public static void StoreUnsafe<T>(this Vector512<T> source, ref T destination);
        [CLSCompliant(False)]
        public static void StoreUnsafe<T>(this Vector512<T> source, ref T destination, nuint elementOffset);
        public static Vector512<T> Subtract<T>(Vector512<T> left, Vector512<T> right);
        public static T Sum<T>(Vector512<T> vector);
        public static T ToScalar<T>(this Vector512<T> vector);
        public static bool TryCopyTo<T>(this Vector512<T> vector, Span<T> destination);
        [CLSCompliant(False)]
        public static (Vector512<ushort> Lower, Vector512<ushort> Upper) Widen(Vector512<byte> source);
        public static (Vector512<int> Lower, Vector512<int> Upper) Widen(Vector512<short> source);
        public static (Vector512<long> Lower, Vector512<long> Upper) Widen(Vector512<int> source);
        [CLSCompliant(False)]
        public static (Vector512<short> Lower, Vector512<short> Upper) Widen(Vector512<sbyte> source);
        public static (Vector512<double> Lower, Vector512<double> Upper) Widen(Vector512<float> source);
        [CLSCompliant(False)]
        public static (Vector512<uint> Lower, Vector512<uint> Upper) Widen(Vector512<ushort> source);
        [CLSCompliant(False)]
        public static (Vector512<ulong> Lower, Vector512<ulong> Upper) Widen(Vector512<uint> source);
        [CLSCompliant(False)]
        public static Vector512<ushort> WidenLower(Vector512<byte> source);
        public static Vector512<int> WidenLower(Vector512<short> source);
        public static Vector512<long> WidenLower(Vector512<int> source);
        [CLSCompliant(False)]
        public static Vector512<short> WidenLower(Vector512<sbyte> source);
        public static Vector512<double> WidenLower(Vector512<float> source);
        [CLSCompliant(False)]
        public static Vector512<uint> WidenLower(Vector512<ushort> source);
        [CLSCompliant(False)]
        public static Vector512<ulong> WidenLower(Vector512<uint> source);
        [CLSCompliant(False)]
        public static Vector512<ushort> WidenUpper(Vector512<byte> source);
        public static Vector512<int> WidenUpper(Vector512<short> source);
        public static Vector512<long> WidenUpper(Vector512<int> source);
        [CLSCompliant(False)]
        public static Vector512<short> WidenUpper(Vector512<sbyte> source);
        public static Vector512<double> WidenUpper(Vector512<float> source);
        [CLSCompliant(False)]
        public static Vector512<uint> WidenUpper(Vector512<ushort> source);
        [CLSCompliant(False)]
        public static Vector512<ulong> WidenUpper(Vector512<uint> source);
        public static Vector512<T> WithElement<T>(this Vector512<T> vector, int index, T value);
        public static Vector512<T> WithLower<T>(this Vector512<T> vector, Vector256<T> value);
        public static Vector512<T> WithUpper<T>(this Vector512<T> vector, Vector256<T> value);
        public static Vector512<T> Xor<T>(Vector512<T> left, Vector512<T> right);
    }
}
