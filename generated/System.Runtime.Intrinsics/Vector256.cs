#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Numerics;

namespace System.Runtime.Intrinsics
{
    public static class Vector256
    {

        public static bool IsHardwareAccelerated { get; }

        public static Vector256<T> Abs<T>(Vector256<T> vector);
        public static Vector256<T> Add<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<TTo> As<TFrom, TTo>(this Vector256<TFrom> vector);
        public static Vector256<byte> AsByte<T>(this Vector256<T> vector);
        public static Vector256<double> AsDouble<T>(this Vector256<T> vector);
        public static Vector256<short> AsInt16<T>(this Vector256<T> vector);
        public static Vector256<int> AsInt32<T>(this Vector256<T> vector);
        public static Vector256<long> AsInt64<T>(this Vector256<T> vector);
        public static Vector256<nint> AsNInt<T>(this Vector256<T> vector);
        [CLSCompliant(False)]
        public static Vector256<nuint> AsNUInt<T>(this Vector256<T> vector);
        [CLSCompliant(False)]
        public static Vector256<sbyte> AsSByte<T>(this Vector256<T> vector);
        public static Vector256<float> AsSingle<T>(this Vector256<T> vector);
        [CLSCompliant(False)]
        public static Vector256<ushort> AsUInt16<T>(this Vector256<T> vector);
        [CLSCompliant(False)]
        public static Vector256<uint> AsUInt32<T>(this Vector256<T> vector);
        [CLSCompliant(False)]
        public static Vector256<ulong> AsUInt64<T>(this Vector256<T> vector);
        public static Vector256<T> AsVector256<T>(this Vector<T> value);
        public static Vector<T> AsVector<T>(this Vector256<T> value);
        public static Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<float> Ceiling(Vector256<float> vector);
        public static Vector256<double> Ceiling(Vector256<double> vector);
        public static Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right);
        public static Vector256<double> ConvertToDouble(Vector256<long> vector);
        [CLSCompliant(False)]
        public static Vector256<double> ConvertToDouble(Vector256<ulong> vector);
        public static Vector256<int> ConvertToInt32(Vector256<float> vector);
        public static Vector256<long> ConvertToInt64(Vector256<double> vector);
        public static Vector256<float> ConvertToSingle(Vector256<int> vector);
        [CLSCompliant(False)]
        public static Vector256<float> ConvertToSingle(Vector256<uint> vector);
        [CLSCompliant(False)]
        public static Vector256<uint> ConvertToUInt32(Vector256<float> vector);
        [CLSCompliant(False)]
        public static Vector256<ulong> ConvertToUInt64(Vector256<double> vector);
        public static void CopyTo<T>(this Vector256<T> vector, T[] destination);
        public static void CopyTo<T>(this Vector256<T> vector, T[] destination, int startIndex);
        public static void CopyTo<T>(this Vector256<T> vector, Span<T> destination);
        public static Vector256<T> Create<T>(T value);
        public static Vector256<byte> Create(byte value);
        public static Vector256<double> Create(double value);
        public static Vector256<short> Create(short value);
        public static Vector256<int> Create(int value);
        public static Vector256<long> Create(long value);
        public static Vector256<nint> Create(nint value);
        [CLSCompliant(False)]
        public static Vector256<nuint> Create(nuint value);
        [CLSCompliant(False)]
        public static Vector256<sbyte> Create(sbyte value);
        public static Vector256<float> Create(float value);
        [CLSCompliant(False)]
        public static Vector256<ushort> Create(ushort value);
        [CLSCompliant(False)]
        public static Vector256<uint> Create(uint value);
        [CLSCompliant(False)]
        public static Vector256<ulong> Create(ulong value);
        public static Vector256<T> Create<T>(T[] values);
        public static Vector256<T> Create<T>(T[] values, int index);
        public static Vector256<T> Create<T>(ReadOnlySpan<T> values);
        public static Vector256<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31);
        public static Vector256<double> Create(double e0, double e1, double e2, double e3);
        public static Vector256<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15);
        public static Vector256<int> Create(int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7);
        public static Vector256<long> Create(long e0, long e1, long e2, long e3);
        [CLSCompliant(False)]
        public static Vector256<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31);
        public static Vector256<float> Create(float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7);
        [CLSCompliant(False)]
        public static Vector256<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15);
        [CLSCompliant(False)]
        public static Vector256<uint> Create(uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7);
        [CLSCompliant(False)]
        public static Vector256<ulong> Create(ulong e0, ulong e1, ulong e2, ulong e3);
        public static Vector256<T> Create<T>(Vector128<T> lower, Vector128<T> upper);
        public static Vector256<byte> Create(Vector128<byte> lower, Vector128<byte> upper);
        public static Vector256<double> Create(Vector128<double> lower, Vector128<double> upper);
        public static Vector256<short> Create(Vector128<short> lower, Vector128<short> upper);
        public static Vector256<int> Create(Vector128<int> lower, Vector128<int> upper);
        public static Vector256<long> Create(Vector128<long> lower, Vector128<long> upper);
        public static Vector256<nint> Create(Vector128<nint> lower, Vector128<nint> upper);
        [CLSCompliant(False)]
        public static Vector256<nuint> Create(Vector128<nuint> lower, Vector128<nuint> upper);
        [CLSCompliant(False)]
        public static Vector256<sbyte> Create(Vector128<sbyte> lower, Vector128<sbyte> upper);
        public static Vector256<float> Create(Vector128<float> lower, Vector128<float> upper);
        [CLSCompliant(False)]
        public static Vector256<ushort> Create(Vector128<ushort> lower, Vector128<ushort> upper);
        [CLSCompliant(False)]
        public static Vector256<uint> Create(Vector128<uint> lower, Vector128<uint> upper);
        [CLSCompliant(False)]
        public static Vector256<ulong> Create(Vector128<ulong> lower, Vector128<ulong> upper);
        public static Vector256<T> CreateScalar<T>(T value);
        public static Vector256<byte> CreateScalar(byte value);
        public static Vector256<double> CreateScalar(double value);
        public static Vector256<short> CreateScalar(short value);
        public static Vector256<int> CreateScalar(int value);
        public static Vector256<long> CreateScalar(long value);
        public static Vector256<nint> CreateScalar(nint value);
        [CLSCompliant(False)]
        public static Vector256<nuint> CreateScalar(nuint value);
        [CLSCompliant(False)]
        public static Vector256<sbyte> CreateScalar(sbyte value);
        public static Vector256<float> CreateScalar(float value);
        [CLSCompliant(False)]
        public static Vector256<ushort> CreateScalar(ushort value);
        [CLSCompliant(False)]
        public static Vector256<uint> CreateScalar(uint value);
        [CLSCompliant(False)]
        public static Vector256<ulong> CreateScalar(ulong value);
        public static Vector256<T> CreateScalarUnsafe<T>(T value);
        public static Vector256<byte> CreateScalarUnsafe(byte value);
        public static Vector256<double> CreateScalarUnsafe(double value);
        public static Vector256<short> CreateScalarUnsafe(short value);
        public static Vector256<int> CreateScalarUnsafe(int value);
        public static Vector256<long> CreateScalarUnsafe(long value);
        public static Vector256<nint> CreateScalarUnsafe(nint value);
        [CLSCompliant(False)]
        public static Vector256<nuint> CreateScalarUnsafe(nuint value);
        [CLSCompliant(False)]
        public static Vector256<sbyte> CreateScalarUnsafe(sbyte value);
        public static Vector256<float> CreateScalarUnsafe(float value);
        [CLSCompliant(False)]
        public static Vector256<ushort> CreateScalarUnsafe(ushort value);
        [CLSCompliant(False)]
        public static Vector256<uint> CreateScalarUnsafe(uint value);
        [CLSCompliant(False)]
        public static Vector256<ulong> CreateScalarUnsafe(ulong value);
        public static Vector256<T> Divide<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> Divide<T>(Vector256<T> left, T right);
        public static T Dot<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> Equals<T>(Vector256<T> left, Vector256<T> right);
        public static bool EqualsAll<T>(Vector256<T> left, Vector256<T> right);
        public static bool EqualsAny<T>(Vector256<T> left, Vector256<T> right);
        [CLSCompliant(False)]
        public static uint ExtractMostSignificantBits<T>(this Vector256<T> vector);
        public static Vector256<float> Floor(Vector256<float> vector);
        public static Vector256<double> Floor(Vector256<double> vector);
        public static T GetElement<T>(this Vector256<T> vector, int index);
        public static Vector128<T> GetLower<T>(this Vector256<T> vector);
        public static Vector128<T> GetUpper<T>(this Vector256<T> vector);
        public static Vector256<T> GreaterThan<T>(Vector256<T> left, Vector256<T> right);
        public static bool GreaterThanAll<T>(Vector256<T> left, Vector256<T> right);
        public static bool GreaterThanAny<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> GreaterThanOrEqual<T>(Vector256<T> left, Vector256<T> right);
        public static bool GreaterThanOrEqualAll<T>(Vector256<T> left, Vector256<T> right);
        public static bool GreaterThanOrEqualAny<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> LessThan<T>(Vector256<T> left, Vector256<T> right);
        public static bool LessThanAll<T>(Vector256<T> left, Vector256<T> right);
        public static bool LessThanAny<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> LessThanOrEqual<T>(Vector256<T> left, Vector256<T> right);
        public static bool LessThanOrEqualAll<T>(Vector256<T> left, Vector256<T> right);
        public static bool LessThanOrEqualAny<T>(Vector256<T> left, Vector256<T> right);
        [CLSCompliant(False)]
        public static Vector256<T> Load<T>(T* source);
        [CLSCompliant(False)]
        public static Vector256<T> LoadAligned<T>(T* source);
        [CLSCompliant(False)]
        public static Vector256<T> LoadAlignedNonTemporal<T>(T* source);
        public static Vector256<T> LoadUnsafe<T>(in T source);
        [CLSCompliant(False)]
        public static Vector256<T> LoadUnsafe<T>(in T source, nuint elementOffset);
        public static Vector256<T> Max<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> Min<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> Multiply<T>(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> Multiply<T>(Vector256<T> left, T right);
        public static Vector256<T> Multiply<T>(T left, Vector256<T> right);
        public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper);
        [CLSCompliant(False)]
        public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper);
        public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper);
        public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper);
        [CLSCompliant(False)]
        public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper);
        [CLSCompliant(False)]
        public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper);
        [CLSCompliant(False)]
        public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper);
        public static Vector256<T> Negate<T>(Vector256<T> vector);
        public static Vector256<T> OnesComplement<T>(Vector256<T> vector);
        public static Vector256<byte> ShiftLeft(Vector256<byte> vector, int shiftCount);
        public static Vector256<short> ShiftLeft(Vector256<short> vector, int shiftCount);
        public static Vector256<int> ShiftLeft(Vector256<int> vector, int shiftCount);
        public static Vector256<long> ShiftLeft(Vector256<long> vector, int shiftCount);
        public static Vector256<nint> ShiftLeft(Vector256<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<nuint> ShiftLeft(Vector256<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<ushort> ShiftLeft(Vector256<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<uint> ShiftLeft(Vector256<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<ulong> ShiftLeft(Vector256<ulong> vector, int shiftCount);
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> vector, int shiftCount);
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> vector, int shiftCount);
        public static Vector256<long> ShiftRightArithmetic(Vector256<long> vector, int shiftCount);
        public static Vector256<nint> ShiftRightArithmetic(Vector256<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> vector, int shiftCount);
        public static Vector256<byte> ShiftRightLogical(Vector256<byte> vector, int shiftCount);
        public static Vector256<short> ShiftRightLogical(Vector256<short> vector, int shiftCount);
        public static Vector256<int> ShiftRightLogical(Vector256<int> vector, int shiftCount);
        public static Vector256<long> ShiftRightLogical(Vector256<long> vector, int shiftCount);
        public static Vector256<nint> ShiftRightLogical(Vector256<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<nuint> ShiftRightLogical(Vector256<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> vector, int shiftCount);
        public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices);
        [CLSCompliant(False)]
        public static Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices);
        public static Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices);
        [CLSCompliant(False)]
        public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices);
        public static Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices);
        [CLSCompliant(False)]
        public static Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices);
        public static Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices);
        public static Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices);
        [CLSCompliant(False)]
        public static Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices);
        public static Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices);
        public static Vector256<T> Sqrt<T>(Vector256<T> vector);
        [CLSCompliant(False)]
        public static void Store<T>(this Vector256<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAligned<T>(this Vector256<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAlignedNonTemporal<T>(this Vector256<T> source, T* destination);
        public static void StoreUnsafe<T>(this Vector256<T> source, ref T destination);
        [CLSCompliant(False)]
        public static void StoreUnsafe<T>(this Vector256<T> source, ref T destination, nuint elementOffset);
        public static Vector256<T> Subtract<T>(Vector256<T> left, Vector256<T> right);
        public static T Sum<T>(Vector256<T> vector);
        public static T ToScalar<T>(this Vector256<T> vector);
        public static Vector512<T> ToVector512<T>(this Vector256<T> vector);
        public static Vector512<T> ToVector512Unsafe<T>(this Vector256<T> vector);
        public static bool TryCopyTo<T>(this Vector256<T> vector, Span<T> destination);
        [CLSCompliant(False)]
        public static (Vector256<ushort> Lower, Vector256<ushort> Upper) Widen(Vector256<byte> source);
        public static (Vector256<int> Lower, Vector256<int> Upper) Widen(Vector256<short> source);
        public static (Vector256<long> Lower, Vector256<long> Upper) Widen(Vector256<int> source);
        [CLSCompliant(False)]
        public static (Vector256<short> Lower, Vector256<short> Upper) Widen(Vector256<sbyte> source);
        public static (Vector256<double> Lower, Vector256<double> Upper) Widen(Vector256<float> source);
        [CLSCompliant(False)]
        public static (Vector256<uint> Lower, Vector256<uint> Upper) Widen(Vector256<ushort> source);
        [CLSCompliant(False)]
        public static (Vector256<ulong> Lower, Vector256<ulong> Upper) Widen(Vector256<uint> source);
        [CLSCompliant(False)]
        public static Vector256<ushort> WidenLower(Vector256<byte> source);
        public static Vector256<int> WidenLower(Vector256<short> source);
        public static Vector256<long> WidenLower(Vector256<int> source);
        [CLSCompliant(False)]
        public static Vector256<short> WidenLower(Vector256<sbyte> source);
        public static Vector256<double> WidenLower(Vector256<float> source);
        [CLSCompliant(False)]
        public static Vector256<uint> WidenLower(Vector256<ushort> source);
        [CLSCompliant(False)]
        public static Vector256<ulong> WidenLower(Vector256<uint> source);
        [CLSCompliant(False)]
        public static Vector256<ushort> WidenUpper(Vector256<byte> source);
        public static Vector256<int> WidenUpper(Vector256<short> source);
        public static Vector256<long> WidenUpper(Vector256<int> source);
        [CLSCompliant(False)]
        public static Vector256<short> WidenUpper(Vector256<sbyte> source);
        public static Vector256<double> WidenUpper(Vector256<float> source);
        [CLSCompliant(False)]
        public static Vector256<uint> WidenUpper(Vector256<ushort> source);
        [CLSCompliant(False)]
        public static Vector256<ulong> WidenUpper(Vector256<uint> source);
        public static Vector256<T> WithElement<T>(this Vector256<T> vector, int index, T value);
        public static Vector256<T> WithLower<T>(this Vector256<T> vector, Vector128<T> value);
        public static Vector256<T> WithUpper<T>(this Vector256<T> vector, Vector128<T> value);
        public static Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right);
    }
}
