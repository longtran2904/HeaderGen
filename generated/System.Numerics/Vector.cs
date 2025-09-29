#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public static class Vector
    {
        public static bool IsHardwareAccelerated { get; }

        public static Vector<T> Abs<T>(Vector<T> value);
        public static Vector<T> Add<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> AndNot<T>(Vector<T> left, Vector<T> right);
        public static Vector<TTo> As<TFrom, TTo>(this Vector<TFrom> vector);
        public static Vector<byte> AsVectorByte<T>(Vector<T> value);
        public static Vector<double> AsVectorDouble<T>(Vector<T> value);
        public static Vector<short> AsVectorInt16<T>(Vector<T> value);
        public static Vector<int> AsVectorInt32<T>(Vector<T> value);
        public static Vector<long> AsVectorInt64<T>(Vector<T> value);
        public static Vector<nint> AsVectorNInt<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static Vector<nuint> AsVectorNUInt<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static Vector<sbyte> AsVectorSByte<T>(Vector<T> value);
        public static Vector<float> AsVectorSingle<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static Vector<ushort> AsVectorUInt16<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static Vector<uint> AsVectorUInt32<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value);
        public static Vector<T> BitwiseAnd<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> BitwiseOr<T>(Vector<T> left, Vector<T> right);
        public static Vector<double> Ceiling(Vector<double> value);
        public static Vector<float> Ceiling(Vector<float> value);
        public static Vector<T> ConditionalSelect<T>(Vector<T> condition, Vector<T> left, Vector<T> right);
        public static Vector<float> ConditionalSelect(Vector<int> condition, Vector<float> left, Vector<float> right);
        public static Vector<double> ConditionalSelect(Vector<long> condition, Vector<double> left, Vector<double> right);
        public static Vector<double> ConvertToDouble(Vector<long> value);
        [CLSCompliant(False)]
        public static Vector<double> ConvertToDouble(Vector<ulong> value);
        public static Vector<int> ConvertToInt32(Vector<float> value);
        public static Vector<long> ConvertToInt64(Vector<double> value);
        public static Vector<float> ConvertToSingle(Vector<int> value);
        [CLSCompliant(False)]
        public static Vector<float> ConvertToSingle(Vector<uint> value);
        [CLSCompliant(False)]
        public static Vector<uint> ConvertToUInt32(Vector<float> value);
        [CLSCompliant(False)]
        public static Vector<ulong> ConvertToUInt64(Vector<double> value);
        public static Vector<T> Divide<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> Divide<T>(Vector<T> left, T right);
        public static T Dot<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right);
        public static Vector<long> Equals(Vector<double> left, Vector<double> right);
        public static Vector<int> Equals(Vector<int> left, Vector<int> right);
        public static Vector<long> Equals(Vector<long> left, Vector<long> right);
        public static Vector<int> Equals(Vector<float> left, Vector<float> right);
        public static bool EqualsAll<T>(Vector<T> left, Vector<T> right);
        public static bool EqualsAny<T>(Vector<T> left, Vector<T> right);
        public static Vector<double> Floor(Vector<double> value);
        public static Vector<float> Floor(Vector<float> value);
        public static T GetElement<T>(this Vector<T> vector, int index);
        public static Vector<T> GreaterThan<T>(Vector<T> left, Vector<T> right);
        public static Vector<long> GreaterThan(Vector<double> left, Vector<double> right);
        public static Vector<int> GreaterThan(Vector<int> left, Vector<int> right);
        public static Vector<long> GreaterThan(Vector<long> left, Vector<long> right);
        public static Vector<int> GreaterThan(Vector<float> left, Vector<float> right);
        public static bool GreaterThanAll<T>(Vector<T> left, Vector<T> right);
        public static bool GreaterThanAny<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> GreaterThanOrEqual<T>(Vector<T> left, Vector<T> right);
        public static Vector<long> GreaterThanOrEqual(Vector<double> left, Vector<double> right);
        public static Vector<int> GreaterThanOrEqual(Vector<int> left, Vector<int> right);
        public static Vector<long> GreaterThanOrEqual(Vector<long> left, Vector<long> right);
        public static Vector<int> GreaterThanOrEqual(Vector<float> left, Vector<float> right);
        public static bool GreaterThanOrEqualAll<T>(Vector<T> left, Vector<T> right);
        public static bool GreaterThanOrEqualAny<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> LessThan<T>(Vector<T> left, Vector<T> right);
        public static Vector<long> LessThan(Vector<double> left, Vector<double> right);
        public static Vector<int> LessThan(Vector<int> left, Vector<int> right);
        public static Vector<long> LessThan(Vector<long> left, Vector<long> right);
        public static Vector<int> LessThan(Vector<float> left, Vector<float> right);
        public static bool LessThanAll<T>(Vector<T> left, Vector<T> right);
        public static bool LessThanAny<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> LessThanOrEqual<T>(Vector<T> left, Vector<T> right);
        public static Vector<long> LessThanOrEqual(Vector<double> left, Vector<double> right);
        public static Vector<int> LessThanOrEqual(Vector<int> left, Vector<int> right);
        public static Vector<long> LessThanOrEqual(Vector<long> left, Vector<long> right);
        public static Vector<int> LessThanOrEqual(Vector<float> left, Vector<float> right);
        public static bool LessThanOrEqualAll<T>(Vector<T> left, Vector<T> right);
        public static bool LessThanOrEqualAny<T>(Vector<T> left, Vector<T> right);
        [CLSCompliant(False)]
        public static Vector<T> Load<T>(T* source);
        [CLSCompliant(False)]
        public static Vector<T> LoadAligned<T>(T* source);
        [CLSCompliant(False)]
        public static Vector<T> LoadAlignedNonTemporal<T>(T* source);
        public static Vector<T> LoadUnsafe<T>(in T source);
        [CLSCompliant(False)]
        public static Vector<T> LoadUnsafe<T>(in T source, nuint elementOffset);
        public static Vector<T> Max<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> Min<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> Multiply<T>(Vector<T> left, Vector<T> right);
        public static Vector<T> Multiply<T>(Vector<T> left, T right);
        public static Vector<T> Multiply<T>(T left, Vector<T> right);
        public static Vector<float> Narrow(Vector<double> low, Vector<double> high);
        [CLSCompliant(False)]
        public static Vector<sbyte> Narrow(Vector<short> low, Vector<short> high);
        public static Vector<short> Narrow(Vector<int> low, Vector<int> high);
        public static Vector<int> Narrow(Vector<long> low, Vector<long> high);
        [CLSCompliant(False)]
        public static Vector<byte> Narrow(Vector<ushort> low, Vector<ushort> high);
        [CLSCompliant(False)]
        public static Vector<ushort> Narrow(Vector<uint> low, Vector<uint> high);
        [CLSCompliant(False)]
        public static Vector<uint> Narrow(Vector<ulong> low, Vector<ulong> high);
        public static Vector<T> Negate<T>(Vector<T> value);
        public static Vector<T> OnesComplement<T>(Vector<T> value);
        public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount);
        public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount);
        public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount);
        public static Vector<long> ShiftLeft(Vector<long> value, int shiftCount);
        public static Vector<nint> ShiftLeft(Vector<nint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<nuint> ShiftLeft(Vector<nuint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftCount);
        public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftCount);
        public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount);
        public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftCount);
        public static Vector<nint> ShiftRightArithmetic(Vector<nint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftCount);
        public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftCount);
        public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftCount);
        public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftCount);
        public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftCount);
        public static Vector<nint> ShiftRightLogical(Vector<nint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<nuint> ShiftRightLogical(Vector<nuint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftCount);
        [CLSCompliant(False)]
        public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftCount);
        public static Vector<T> SquareRoot<T>(Vector<T> value);
        [CLSCompliant(False)]
        public static void Store<T>(this Vector<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAligned<T>(this Vector<T> source, T* destination);
        [CLSCompliant(False)]
        public static void StoreAlignedNonTemporal<T>(this Vector<T> source, T* destination);
        public static void StoreUnsafe<T>(this Vector<T> source, ref T destination);
        [CLSCompliant(False)]
        public static void StoreUnsafe<T>(this Vector<T> source, ref T destination, nuint elementOffset);
        public static Vector<T> Subtract<T>(Vector<T> left, Vector<T> right);
        public static T Sum<T>(Vector<T> value);
        public static T ToScalar<T>(this Vector<T> vector);
        [CLSCompliant(False)]
        public static void Widen(Vector<byte> source, out Vector<ushort> low, out Vector<ushort> high);
        public static void Widen(Vector<short> source, out Vector<int> low, out Vector<int> high);
        public static void Widen(Vector<int> source, out Vector<long> low, out Vector<long> high);
        [CLSCompliant(False)]
        public static void Widen(Vector<sbyte> source, out Vector<short> low, out Vector<short> high);
        public static void Widen(Vector<float> source, out Vector<double> low, out Vector<double> high);
        [CLSCompliant(False)]
        public static void Widen(Vector<ushort> source, out Vector<uint> low, out Vector<uint> high);
        [CLSCompliant(False)]
        public static void Widen(Vector<uint> source, out Vector<ulong> low, out Vector<ulong> high);
        [CLSCompliant(False)]
        public static Vector<ushort> WidenLower(Vector<byte> source);
        public static Vector<int> WidenLower(Vector<short> source);
        public static Vector<long> WidenLower(Vector<int> source);
        [CLSCompliant(False)]
        public static Vector<short> WidenLower(Vector<sbyte> source);
        public static Vector<double> WidenLower(Vector<float> source);
        [CLSCompliant(False)]
        public static Vector<uint> WidenLower(Vector<ushort> source);
        [CLSCompliant(False)]
        public static Vector<ulong> WidenLower(Vector<uint> source);
        [CLSCompliant(False)]
        public static Vector<ushort> WidenUpper(Vector<byte> source);
        public static Vector<int> WidenUpper(Vector<short> source);
        public static Vector<long> WidenUpper(Vector<int> source);
        [CLSCompliant(False)]
        public static Vector<short> WidenUpper(Vector<sbyte> source);
        public static Vector<double> WidenUpper(Vector<float> source);
        [CLSCompliant(False)]
        public static Vector<uint> WidenUpper(Vector<ushort> source);
        [CLSCompliant(False)]
        public static Vector<ulong> WidenUpper(Vector<uint> source);
        public static Vector<T> WithElement<T>(this Vector<T> vector, int index, T value);
        public static Vector<T> Xor<T>(Vector<T> left, Vector<T> right);
    }
}
