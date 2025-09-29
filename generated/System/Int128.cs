#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Int128 : IAdditionOperators<Int128, Int128, Int128>, IAdditiveIdentity<Int128, Int128>, IBinaryInteger<Int128>, IBinaryIntegerParseAndFormatInfo<Int128>, IBinaryNumber<Int128>, IBitwiseOperators<Int128, Int128, Int128>, IComparable, IComparable<Int128>, IComparisonOperators<Int128, Int128, bool>, IDecrementOperators<Int128>, IDivisionOperators<Int128, Int128, Int128>, IEqualityOperators<Int128, Int128, bool>, IEquatable<Int128>, IFormattable, IIncrementOperators<Int128>, IMinMaxValue<Int128>, IModulusOperators<Int128, Int128, Int128>, IMultiplicativeIdentity<Int128, Int128>, IMultiplyOperators<Int128, Int128, Int128>, INumber<Int128>, INumberBase<Int128>, IParsable<Int128>, IShiftOperators<Int128, int, Int128>, ISignedNumber<Int128>, ISpanFormattable, ISpanParsable<Int128>, ISubtractionOperators<Int128, Int128, Int128>, IUnaryNegationOperators<Int128, Int128>, IUnaryPlusOperators<Int128, Int128>, IUtf8SpanFormattable, IUtf8SpanParsable<Int128>
    {

        [CLSCompliant(False)]
        public Int128(ulong upper, ulong lower);

        public static Int128 MinValue { get; }
        public static Int128 MaxValue { get; }
        public static Int128 One { get; }
        public static Int128 Zero { get; }
        public static Int128 NegativeOne { get; }

        public int CompareTo(object value);
        public int CompareTo(Int128 value);
        public override bool Equals(object obj);
        public bool Equals(Int128 other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static Int128 Parse(string s);
        public static Int128 Parse(string s, NumberStyles style);
        public static Int128 Parse(string s, IFormatProvider provider);
        public static Int128 Parse(string s, NumberStyles style, IFormatProvider provider);
        public static Int128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out Int128 result);
        public static bool TryParse(ReadOnlySpan<char> s, out Int128 result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out Int128 result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Int128 result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out Int128 result);
        public static (Int128 Quotient, Int128 Remainder) DivRem(Int128 left, Int128 right);
        public static Int128 LeadingZeroCount(Int128 value);
        public static Int128 PopCount(Int128 value);
        public static Int128 RotateLeft(Int128 value, int rotateAmount);
        public static Int128 RotateRight(Int128 value, int rotateAmount);
        public static Int128 TrailingZeroCount(Int128 value);
        public static bool IsPow2(Int128 value);
        public static Int128 Log2(Int128 value);
        public static Int128 Clamp(Int128 value, Int128 min, Int128 max);
        public static Int128 CopySign(Int128 value, Int128 sign);
        public static Int128 Max(Int128 x, Int128 y);
        public static Int128 Min(Int128 x, Int128 y);
        public static int Sign(Int128 value);
        public static Int128 Abs(Int128 value);
        public static Int128 CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static Int128 CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static Int128 CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(Int128 value);
        public static bool IsNegative(Int128 value);
        public static bool IsOddInteger(Int128 value);
        public static bool IsPositive(Int128 value);
        public static Int128 MaxMagnitude(Int128 x, Int128 y);
        public static Int128 MinMagnitude(Int128 x, Int128 y);
        public static bool TryParse(string s, IFormatProvider provider, out Int128 result);
        public static Int128 Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out Int128 result);
        public static Int128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out Int128 result);
        public static Int128 Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out Int128 result);

        public static explicit operator checked byte(Int128 value);
        public static explicit operator checked char(Int128 value);
        public static explicit operator checked short(Int128 value);
        public static explicit operator checked int(Int128 value);
        public static explicit operator checked long(Int128 value);
        public static explicit operator checked nint(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked sbyte(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked ushort(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked uint(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked ulong(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked UInt128(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator checked nuint(Int128 value);
        public static explicit operator checked Int128(double value);
        public static explicit operator checked Int128(float value);
        public static Int128 operator +(Int128 left, Int128 right);
        public static Int128 operator checked +(Int128 left, Int128 right);
        public static Int128 operator &(Int128 left, Int128 right);
        public static Int128 operator |(Int128 left, Int128 right);
        public static Int128 operator ^(Int128 left, Int128 right);
        public static Int128 operator ~(Int128 value);
        public static bool operator <(Int128 left, Int128 right);
        public static bool operator <=(Int128 left, Int128 right);
        public static bool operator >(Int128 left, Int128 right);
        public static bool operator >=(Int128 left, Int128 right);
        public static Int128 operator --(Int128 value);
        public static Int128 operator checked --(Int128 value);
        public static Int128 operator /(Int128 left, Int128 right);
        public static Int128 operator checked /(Int128 left, Int128 right);
        public static bool operator ==(Int128 left, Int128 right);
        public static bool operator !=(Int128 left, Int128 right);
        public static Int128 operator ++(Int128 value);
        public static Int128 operator checked ++(Int128 value);
        public static Int128 operator %(Int128 left, Int128 right);
        public static Int128 operator *(Int128 left, Int128 right);
        public static Int128 operator checked *(Int128 left, Int128 right);
        public static Int128 operator <<(Int128 value, int shiftAmount);
        public static Int128 operator >>(Int128 value, int shiftAmount);
        public static Int128 operator >>>(Int128 value, int shiftAmount);
        public static Int128 operator -(Int128 left, Int128 right);
        public static Int128 operator checked -(Int128 left, Int128 right);
        public static Int128 operator -(Int128 value);
        public static Int128 operator checked -(Int128 value);
        public static Int128 operator +(Int128 value);

        public static explicit operator byte(Int128 value);
        public static explicit operator char(Int128 value);
        public static explicit operator decimal(Int128 value);
        public static explicit operator double(Int128 value);
        public static explicit operator Half(Int128 value);
        public static explicit operator short(Int128 value);
        public static explicit operator int(Int128 value);
        public static explicit operator long(Int128 value);
        public static explicit operator nint(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator sbyte(Int128 value);
        public static explicit operator float(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator ushort(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator uint(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator ulong(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator UInt128(Int128 value);
        [CLSCompliant(False)]
        public static explicit operator nuint(Int128 value);
        public static explicit operator Int128(decimal value);
        public static explicit operator Int128(double value);
        public static explicit operator Int128(float value);
        public static implicit operator Int128(byte value);
        public static implicit operator Int128(char value);
        public static implicit operator Int128(short value);
        public static implicit operator Int128(int value);
        public static implicit operator Int128(long value);
        public static implicit operator Int128(nint value);
        [CLSCompliant(False)]
        public static implicit operator Int128(sbyte value);
        [CLSCompliant(False)]
        public static implicit operator Int128(ushort value);
        [CLSCompliant(False)]
        public static implicit operator Int128(uint value);
        [CLSCompliant(False)]
        public static implicit operator Int128(ulong value);
        [CLSCompliant(False)]
        public static implicit operator Int128(nuint value);
    }
}
