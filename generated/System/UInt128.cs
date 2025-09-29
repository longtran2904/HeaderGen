#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct UInt128 : IAdditionOperators<UInt128, UInt128, UInt128>, IAdditiveIdentity<UInt128, UInt128>, IBinaryInteger<UInt128>, IBinaryIntegerParseAndFormatInfo<UInt128>, IBinaryNumber<UInt128>, IBitwiseOperators<UInt128, UInt128, UInt128>, IComparable, IComparable<UInt128>, IComparisonOperators<UInt128, UInt128, bool>, IDecrementOperators<UInt128>, IDivisionOperators<UInt128, UInt128, UInt128>, IEqualityOperators<UInt128, UInt128, bool>, IEquatable<UInt128>, IFormattable, IIncrementOperators<UInt128>, IMinMaxValue<UInt128>, IModulusOperators<UInt128, UInt128, UInt128>, IMultiplicativeIdentity<UInt128, UInt128>, IMultiplyOperators<UInt128, UInt128, UInt128>, INumber<UInt128>, INumberBase<UInt128>, IParsable<UInt128>, IShiftOperators<UInt128, int, UInt128>, ISpanFormattable, ISpanParsable<UInt128>, ISubtractionOperators<UInt128, UInt128, UInt128>, IUnaryNegationOperators<UInt128, UInt128>, IUnaryPlusOperators<UInt128, UInt128>, IUnsignedNumber<UInt128>, IUtf8SpanFormattable, IUtf8SpanParsable<UInt128>
    {
        [CLSCompliant(False)]
        public UInt128(ulong upper, ulong lower);

        public static UInt128 MinValue { get; }
        public static UInt128 MaxValue { get; }
        public static UInt128 One { get; }
        public static UInt128 Zero { get; }

        public int CompareTo(object value);
        public int CompareTo(UInt128 value);
        public override bool Equals(object obj);
        public bool Equals(UInt128 other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static UInt128 Parse(string s);
        public static UInt128 Parse(string s, NumberStyles style);
        public static UInt128 Parse(string s, IFormatProvider provider);
        public static UInt128 Parse(string s, NumberStyles style, IFormatProvider provider);
        public static UInt128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out UInt128 result);
        public static bool TryParse(ReadOnlySpan<char> s, out UInt128 result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out UInt128 result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out UInt128 result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out UInt128 result);
        public static (UInt128 Quotient, UInt128 Remainder) DivRem(UInt128 left, UInt128 right);
        public static UInt128 LeadingZeroCount(UInt128 value);
        public static UInt128 PopCount(UInt128 value);
        public static UInt128 RotateLeft(UInt128 value, int rotateAmount);
        public static UInt128 RotateRight(UInt128 value, int rotateAmount);
        public static UInt128 TrailingZeroCount(UInt128 value);
        public static bool IsPow2(UInt128 value);
        public static UInt128 Log2(UInt128 value);
        public static UInt128 Clamp(UInt128 value, UInt128 min, UInt128 max);
        public static UInt128 Max(UInt128 x, UInt128 y);
        public static UInt128 Min(UInt128 x, UInt128 y);
        public static int Sign(UInt128 value);
        public static UInt128 CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static UInt128 CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static UInt128 CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(UInt128 value);
        public static bool IsOddInteger(UInt128 value);
        public static bool TryParse(string s, IFormatProvider provider, out UInt128 result);
        public static UInt128 Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out UInt128 result);
        public static UInt128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out UInt128 result);
        public static UInt128 Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out UInt128 result);

        public static explicit operator checked byte(UInt128 value);
        public static explicit operator checked char(UInt128 value);
        public static explicit operator checked short(UInt128 value);
        public static explicit operator checked int(UInt128 value);
        public static explicit operator checked long(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked Int128(UInt128 value);
        public static explicit operator checked nint(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked sbyte(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked ushort(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked uint(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked ulong(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator checked nuint(UInt128 value);
        public static explicit operator checked UInt128(double value);
        public static explicit operator checked UInt128(short value);
        public static explicit operator checked UInt128(int value);
        public static explicit operator checked UInt128(long value);
        public static explicit operator checked UInt128(nint value);
        [CLSCompliant(False)]
        public static explicit operator checked UInt128(sbyte value);
        public static explicit operator checked UInt128(float value);
        public static UInt128 operator +(UInt128 left, UInt128 right);
        public static UInt128 operator checked +(UInt128 left, UInt128 right);
        public static UInt128 operator &(UInt128 left, UInt128 right);
        public static UInt128 operator |(UInt128 left, UInt128 right);
        public static UInt128 operator ^(UInt128 left, UInt128 right);
        public static UInt128 operator ~(UInt128 value);
        public static bool operator <(UInt128 left, UInt128 right);
        public static bool operator <=(UInt128 left, UInt128 right);
        public static bool operator >(UInt128 left, UInt128 right);
        public static bool operator >=(UInt128 left, UInt128 right);
        public static UInt128 operator --(UInt128 value);
        public static UInt128 operator checked --(UInt128 value);
        public static UInt128 operator /(UInt128 left, UInt128 right);
        public static UInt128 operator checked /(UInt128 left, UInt128 right);
        public static bool operator ==(UInt128 left, UInt128 right);
        public static bool operator !=(UInt128 left, UInt128 right);
        public static UInt128 operator ++(UInt128 value);
        public static UInt128 operator checked ++(UInt128 value);
        public static UInt128 operator %(UInt128 left, UInt128 right);
        public static UInt128 operator *(UInt128 left, UInt128 right);
        public static UInt128 operator checked *(UInt128 left, UInt128 right);
        public static UInt128 operator <<(UInt128 value, int shiftAmount);
        public static UInt128 operator >>(UInt128 value, int shiftAmount);
        public static UInt128 operator >>>(UInt128 value, int shiftAmount);
        public static UInt128 operator -(UInt128 left, UInt128 right);
        public static UInt128 operator checked -(UInt128 left, UInt128 right);
        public static UInt128 operator -(UInt128 value);
        public static UInt128 operator checked -(UInt128 value);
        public static UInt128 operator +(UInt128 value);

        public static explicit operator byte(UInt128 value);
        public static explicit operator char(UInt128 value);
        public static explicit operator decimal(UInt128 value);
        public static explicit operator double(UInt128 value);
        public static explicit operator Half(UInt128 value);
        public static explicit operator short(UInt128 value);
        public static explicit operator int(UInt128 value);
        public static explicit operator long(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator Int128(UInt128 value);
        public static explicit operator nint(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator sbyte(UInt128 value);
        public static explicit operator float(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator ushort(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator uint(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator ulong(UInt128 value);
        [CLSCompliant(False)]
        public static explicit operator nuint(UInt128 value);
        public static explicit operator UInt128(decimal value);
        public static explicit operator UInt128(double value);
        public static explicit operator UInt128(short value);
        public static explicit operator UInt128(int value);
        public static explicit operator UInt128(long value);
        public static explicit operator UInt128(nint value);
        [CLSCompliant(False)]
        public static explicit operator UInt128(sbyte value);
        public static explicit operator UInt128(float value);
        public static implicit operator UInt128(byte value);
        public static implicit operator UInt128(char value);
        [CLSCompliant(False)]
        public static implicit operator UInt128(ushort value);
        [CLSCompliant(False)]
        public static implicit operator UInt128(uint value);
        [CLSCompliant(False)]
        public static implicit operator UInt128(ulong value);
        [CLSCompliant(False)]
        public static implicit operator UInt128(nuint value);
    }
}
