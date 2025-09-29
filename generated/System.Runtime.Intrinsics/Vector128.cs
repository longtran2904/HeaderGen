#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Numerics;

namespace System.Runtime.Intrinsics
{
    public static class Vector128
    {
        public static bool IsHardwareAccelerated { get; }

        public static Vector128<T> Abs<T>(Vector128<T> vector);
        public static Vector128<T> Add<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<TTo> As<TFrom, TTo>(this Vector128<TFrom> vector);
        public static Vector128<byte> AsByte<T>(this Vector128<T> vector);
        public static Vector128<double> AsDouble<T>(this Vector128<T> vector);
        public static Vector128<short> AsInt16<T>(this Vector128<T> vector);
        public static Vector128<int> AsInt32<T>(this Vector128<T> vector);
        public static Vector128<long> AsInt64<T>(this Vector128<T> vector);
        public static Vector128<nint> AsNInt<T>(this Vector128<T> vector);
        [CLSCompliant(False)]
        public static Vector128<nuint> AsNUInt<T>(this Vector128<T> vector);
        [CLSCompliant(False)]
        public static Vector128<sbyte> AsSByte<T>(this Vector128<T> vector);
        public static Vector128<float> AsSingle<T>(this Vector128<T> vector);
        [CLSCompliant(False)]
        public static Vector128<ushort> AsUInt16<T>(this Vector128<T> vector);
        [CLSCompliant(False)]
        public static Vector128<uint> AsUInt32<T>(this Vector128<T> vector);
        [CLSCompliant(False)]
        public static Vector128<ulong> AsUInt64<T>(this Vector128<T> vector);
        public static Vector128<float> AsVector128(this Vector2 value);
        public static Vector128<float> AsVector128(this Vector3 value);
        public static Vector128<float> AsVector128(this Vector4 value);
        public static Vector128<T> AsVector128<T>(this Vector<T> value);
        public static Vector2 AsVector2(this Vector128<float> value);
        public static Vector3 AsVector3(this Vector128<float> value);
        public static Vector4 AsVector4(this Vector128<float> value);
        public static Vector<T> AsVector<T>(this Vector128<T> value);
        public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<float> Ceiling(Vector128<float> vector);
        public static Vector128<double> Ceiling(Vector128<double> vector);
        public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right);
        public static Vector128<double> ConvertToDouble(Vector128<long> vector);
        [CLSCompliant(False)]
        public static Vector128<double> ConvertToDouble(Vector128<ulong> vector);
        public static Vector128<int> ConvertToInt32(Vector128<float> vector);
        public static Vector128<long> ConvertToInt64(Vector128<double> vector);
        public static Vector128<float> ConvertToSingle(Vector128<int> vector);
        [CLSCompliant(False)]
        public static Vector128<float> ConvertToSingle(Vector128<uint> vector);
        [CLSCompliant(False)]
        public static Vector128<uint> ConvertToUInt32(Vector128<float> vector);
        [CLSCompliant(False)]
        public static Vector128<ulong> ConvertToUInt64(Vector128<double> vector);
        public static void CopyTo<T>(this Vector128<T> vector, T[] destination);
        public static void CopyTo<T>(this Vector128<T> vector, T[] destination, int startIndex);
        public static void CopyTo<T>(this Vector128<T> vector, Span<T> destination);
        public static Vector128<T> Create<T>(T value);
        public static Vector128<byte> Create(byte value);
        public static Vector128<double> Create(double value);
        public static Vector128<short> Create(short value);
        public static Vector128<int> Create(int value);
        public static Vector128<long> Create(long value);
        public static Vector128<nint> Create(nint value);
        [CLSCompliant(False)]
        public static Vector128<nuint> Create(nuint value);
        [CLSCompliant(False)]
        public static Vector128<sbyte> Create(sbyte value);
        public static Vector128<float> Create(float value);
        [CLSCompliant(False)]
        public static Vector128<ushort> Create(ushort value);
        [CLSCompliant(False)]
        public static Vector128<uint> Create(uint value);
        [CLSCompliant(False)]
        public static Vector128<ulong> Create(ulong value);
        public static Vector128<T> Create<T>(T[] values);
        public static Vector128<T> Create<T>(T[] values, int index);
        public static Vector128<T> Create<T>(ReadOnlySpan<T> values);
        public static Vector128<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15);
        public static Vector128<double> Create(double e0, double e1);
        public static Vector128<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7);
        public static Vector128<int> Create(int e0, int e1, int e2, int e3);
        public static Vector128<long> Create(long e0, long e1);
        [CLSCompliant(False)]
        public static Vector128<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15);
        public static Vector128<float> Create(float e0, float e1, float e2, float e3);
        [CLSCompliant(False)]
        public static Vector128<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7);
        [CLSCompliant(False)]
        public static Vector128<uint> Create(uint e0, uint e1, uint e2, uint e3);
        [CLSCompliant(False)]
        public static Vector128<ulong> Create(ulong e0, ulong e1);
        public static Vector128<T> Create<T>(Vector64<T> lower, Vector64<T> upper);
        public static Vector128<byte> Create(Vector64<byte> lower, Vector64<byte> upper);
        public static Vector128<double> Create(Vector64<double> lower, Vector64<double> upper);
        public static Vector128<short> Create(Vector64<short> lower, Vector64<short> upper);
        public static Vector128<int> Create(Vector64<int> lower, Vector64<int> upper);
        public static Vector128<long> Create(Vector64<long> lower, Vector64<long> upper);
        public static Vector128<nint> Create(Vector64<nint> lower, Vector64<nint> upper);
        [CLSCompliant(False)]
        public static Vector128<nuint> Create(Vector64<nuint> lower, Vector64<nuint> upper);
        [CLSCompliant(False)]
        public static Vector128<sbyte> Create(Vector64<sbyte> lower, Vector64<sbyte> upper);
        public static Vector128<float> Create(Vector64<float> lower, Vector64<float> upper);
        [CLSCompliant(False)]
        public static Vector128<ushort> Create(Vector64<ushort> lower, Vector64<ushort> upper);
        [CLSCompliant(False)]
        public static Vector128<uint> Create(Vector64<uint> lower, Vector64<uint> upper);
        [CLSCompliant(False)]
        public static Vector128<ulong> Create(Vector64<ulong> lower, Vector64<ulong> upper);
        public static Vector128<T> CreateScalar<T>(T value);
        public static Vector128<byte> CreateScalar(byte value);
        public static Vector128<double> CreateScalar(double value);
        public static Vector128<short> CreateScalar(short value);
        public static Vector128<int> CreateScalar(int value);
        public static Vector128<long> CreateScalar(long value);
        public static Vector128<nint> CreateScalar(nint value);
        [CLSCompliant(False)]
        public static Vector128<nuint> CreateScalar(nuint value);
        [CLSCompliant(False)]
        public static Vector128<sbyte> CreateScalar(sbyte value);
        public static Vector128<float> CreateScalar(float value);
        [CLSCompliant(False)]
        public static Vector128<ushort> CreateScalar(ushort value);
        [CLSCompliant(False)]
        public static Vector128<uint> CreateScalar(uint value);
        [CLSCompliant(False)]
        public static Vector128<ulong> CreateScalar(ulong value);
        public static Vector128<T> CreateScalarUnsafe<T>(T value);
        public static Vector128<byte> CreateScalarUnsafe(byte value);
        public static Vector128<double> CreateScalarUnsafe(double value);
        public static Vector128<short> CreateScalarUnsafe(short value);
        public static Vector128<int> CreateScalarUnsafe(int value);
        public static Vector128<long> CreateScalarUnsafe(long value);
        public static Vector128<nint> CreateScalarUnsafe(nint value);
        [CLSCompliant(False)]
        public static Vector128<nuint> CreateScalarUnsafe(nuint value);
        [CLSCompliant(False)]
        public static Vector128<sbyte> CreateScalarUnsafe(sbyte value);
        public static Vector128<float> CreateScalarUnsafe(float value);
        [CLSCompliant(False)]
        public static Vector128<ushort> CreateScalarUnsafe(ushort value);
        [CLSCompliant(False)]
        public static Vector128<uint> CreateScalarUnsafe(uint value);
        [CLSCompliant(False)]
        public static Vector128<ulong> CreateScalarUnsafe(ulong value);
        public static Vector128<T> Divide<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> Divide<T>(Vector128<T> left, T right);
        public static T Dot<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> Equals<T>(Vector128<T> left, Vector128<T> right);
        public static bool EqualsAll<T>(Vector128<T> left, Vector128<T> right);
        public static bool EqualsAny<T>(Vector128<T> left, Vector128<T> right);
        [CLSCompliant(False)]
        public static uint ExtractMostSignificantBits<T>(this Vector128<T> vector);
        public static Vector128<float> Floor(Vector128<float> vector);
        public static Vector128<double> Floor(Vector128<double> vector);
        public static T GetElement<T>(this Vector128<T> vector, int index);
        public static Vector64<T> GetLower<T>(this Vector128<T> vector);
        public static Vector64<T> GetUpper<T>(this Vector128<T> vector);
        public static Vector128<T> GreaterThan<T>(Vector128<T> left, Vector128<T> right);
        public static bool GreaterThanAll<T>(Vector128<T> left, Vector128<T> right);
        public static bool GreaterThanAny<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> GreaterThanOrEqual<T>(Vector128<T> left, Vector128<T> right);
        public static bool GreaterThanOrEqualAll<T>(Vector128<T> left, Vector128<T> right);
        public static bool GreaterThanOrEqualAny<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> LessThan<T>(Vector128<T> left, Vector128<T> right);
        public static bool LessThanAll<T>(Vector128<T> left, Vector128<T> right);
        public static bool LessThanAny<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> LessThanOrEqual<T>(Vector128<T> left, Vector128<T> right);
        public static bool LessThanOrEqualAll<T>(Vector128<T> left, Vector128<T> right);
        public static bool LessThanOrEqualAny<T>(Vector128<T> left, Vector128<T> right);
        [CLSCompliant(False)]
        public static Vector128<T> Load<T>(T* source);
        [CLSCompliant(False)]
        public static Vector128<T> LoadAligned<T>(T* source);
        [CLSCompliant(False)]
        public static Vector128<T> LoadAlignedNonTemporal<T>(T* source);
        public static Vector128<T> LoadUnsafe<T>(in T source);
        [CLSCompliant(False)]
        public static Vector128<T> LoadUnsafe<T>(in T source, nuint elementOffset);
        public static Vector128<T> Max<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> Min<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> Multiply<T>(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> Multiply<T>(Vector128<T> left, T right);
        public static Vector128<T> Multiply<T>(T left, Vector128<T> right);
        public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper);
        [CLSCompliant(False)]
        public static Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper);
        public static Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper);
        public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper);
        [CLSCompliant(False)]
        public static Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper);
        [CLSCompliant(False)]
        public static Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper);
        [CLSCompliant(False)]
        public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper);
        public static Vector128<T> Negate<T>(Vector128<T> vector);
        public static Vector128<T> OnesComplement<T>(Vector128<T> vector);
        public static Vector128<byte> ShiftLeft(Vector128<byte> vector, int shiftCount);
        public static Vector128<short> ShiftLeft(Vector128<short> vector, int shiftCount);
        public static Vector128<int> ShiftLeft(Vector128<int> vector, int shiftCount);
        public static Vector128<long> ShiftLeft(Vector128<long> vector, int shiftCount);
        public static Vector128<nint> ShiftLeft(Vector128<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<nuint> ShiftLeft(Vector128<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<ushort> ShiftLeft(Vector128<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<uint> ShiftLeft(Vector128<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<ulong> ShiftLeft(Vector128<ulong> vector, int shiftCount);
        public static Vector128<short> ShiftRightArithmetic(Vector128<short> vector, int shiftCount);
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> vector, int shiftCount);
        public static Vector128<long> ShiftRightArithmetic(Vector128<long> vector, int shiftCount);
        public static Vector128<nint> ShiftRightArithmetic(Vector128<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> vector, int shiftCount);
        public static Vector128<byte> ShiftRightLogical(Vector128<byte> vector, int shiftCount);
        public static Vector128<short> ShiftRightLogical(Vector128<short> vector, int shiftCount);
        public static Vector128<int> ShiftRightLogical(Vector128<int> vector, int shiftCount);
        public static Vector128<long> ShiftRightLogical(Vector128<long> vector, int shiftCount);
        public static Vector128<nint> ShiftRightLogical(Vector128<nint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<nuint> ShiftRightLogical(Vector128<nuint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<uint> ShiftRightLogical(Vector128<uint> vector, int shiftCount);
        [CLSCompliant(False)]
        public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> vector, int shiftCount);
        public static Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices);
        [CLSCompliant(False)]
        public static Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices);
        public static Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices);
        [CLSCompliant(False)]
        public static Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices);
        public static Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices);
        [CLSCompliant(False)]
        public static Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices);
        public static Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices);
        public static Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices);
        [CLSCompliant(False)]
        public static Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices);
        public static Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices);
        public static Vector128<T> Sqrt<T>(Vector128<T> vector);
        [CLSCompliant(False)]
        public static void Store<T>(this Vector128<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAligned<T>(this Vector128<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAlignedNonTemporal<T>(this Vector128<T> source, T* destination);
        public static void StoreUnsafe<T>(this Vector128<T> source, ref T destination);
        [CLSCompliant(False)]
        public static void StoreUnsafe<T>(this Vector128<T> source, ref T destination, nuint elementOffset);
        public static Vector128<T> Subtract<T>(Vector128<T> left, Vector128<T> right);
        public static T Sum<T>(Vector128<T> vector);
        public static T ToScalar<T>(this Vector128<T> vector);
        public static Vector256<T> ToVector256<T>(this Vector128<T> vector);
        public static Vector256<T> ToVector256Unsafe<T>(this Vector128<T> vector);
        public static bool TryCopyTo<T>(this Vector128<T> vector, Span<T> destination);
        [CLSCompliant(False)]
        public static (Vector128<ushort> Lower, Vector128<ushort> Upper) Widen(Vector128<byte> source);
        public static (Vector128<int> Lower, Vector128<int> Upper) Widen(Vector128<short> source);
        public static (Vector128<long> Lower, Vector128<long> Upper) Widen(Vector128<int> source);
        [CLSCompliant(False)]
        public static (Vector128<short> Lower, Vector128<short> Upper) Widen(Vector128<sbyte> source);
        public static (Vector128<double> Lower, Vector128<double> Upper) Widen(Vector128<float> source);
        [CLSCompliant(False)]
        public static (Vector128<uint> Lower, Vector128<uint> Upper) Widen(Vector128<ushort> source);
        [CLSCompliant(False)]
        public static (Vector128<ulong> Lower, Vector128<ulong> Upper) Widen(Vector128<uint> source);
        [CLSCompliant(False)]
        public static Vector128<ushort> WidenLower(Vector128<byte> source);
        public static Vector128<int> WidenLower(Vector128<short> source);
        public static Vector128<long> WidenLower(Vector128<int> source);
        [CLSCompliant(False)]
        public static Vector128<short> WidenLower(Vector128<sbyte> source);
        public static Vector128<double> WidenLower(Vector128<float> source);
        [CLSCompliant(False)]
        public static Vector128<uint> WidenLower(Vector128<ushort> source);
        [CLSCompliant(False)]
        public static Vector128<ulong> WidenLower(Vector128<uint> source);
        [CLSCompliant(False)]
        public static Vector128<ushort> WidenUpper(Vector128<byte> source);
        public static Vector128<int> WidenUpper(Vector128<short> source);
        public static Vector128<long> WidenUpper(Vector128<int> source);
        [CLSCompliant(False)]
        public static Vector128<short> WidenUpper(Vector128<sbyte> source);
        public static Vector128<double> WidenUpper(Vector128<float> source);
        [CLSCompliant(False)]
        public static Vector128<uint> WidenUpper(Vector128<ushort> source);
        [CLSCompliant(False)]
        public static Vector128<ulong> WidenUpper(Vector128<uint> source);
        public static Vector128<T> WithElement<T>(this Vector128<T> vector, int index, T value);
        public static Vector128<T> WithLower<T>(this Vector128<T> vector, Vector64<T> value);
        public static Vector128<T> WithUpper<T>(this Vector128<T> vector, Vector64<T> value);
        public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right);
    }
}
