#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization;

namespace System
{
    public readonly struct Decimal : IAdditionOperators<decimal, decimal, decimal>, IAdditiveIdentity<decimal, decimal>, IComparable, IComparable<decimal>, IComparisonOperators<decimal, decimal, bool>, IConvertible, IDecrementOperators<decimal>, IDeserializationCallback, IDivisionOperators<decimal, decimal, decimal>, IEqualityOperators<decimal, decimal, bool>, IEquatable<decimal>, IFloatingPoint<decimal>, IFloatingPointConstants<decimal>, IFormattable, IIncrementOperators<decimal>, IMinMaxValue<decimal>, IModulusOperators<decimal, decimal, decimal>, IMultiplicativeIdentity<decimal, decimal>, IMultiplyOperators<decimal, decimal, decimal>, INumber<decimal>, INumberBase<decimal>, IParsable<decimal>, ISerializable, ISignedNumber<decimal>, ISpanFormattable, ISpanParsable<decimal>, ISubtractionOperators<decimal, decimal, decimal>, IUnaryNegationOperators<decimal, decimal>, IUnaryPlusOperators<decimal, decimal>, IUtf8SpanFormattable, IUtf8SpanParsable<decimal>
    {

        public const decimal Zero = 0;
        public const decimal One = 1;
        public const decimal MinusOne = -1;
        public const decimal MaxValue = 79228162514264337593543950335;
        public const decimal MinValue = -79228162514264337593543950335;

        public Decimal(int value);
        [CLSCompliant(False)]
        public Decimal(uint value);
        public Decimal(long value);
        [CLSCompliant(False)]
        public Decimal(ulong value);
        public Decimal(float value);
        public Decimal(double value);
        public Decimal(int[] bits);
        public Decimal(ReadOnlySpan<int> bits);
        public Decimal(int lo, int mid, int hi, bool isNegative, byte scale);

        public byte Scale { get; }

        public static decimal FromOACurrency(long cy);
        public static long ToOACurrency(decimal value);
        public static decimal Add(decimal d1, decimal d2);
        public static decimal Ceiling(decimal d);
        public static int Compare(decimal d1, decimal d2);
        public int CompareTo(object value);
        public int CompareTo(decimal value);
        public static decimal Divide(decimal d1, decimal d2);
        public override bool Equals(object value);
        public bool Equals(decimal value);
        public override int GetHashCode();
        public static bool Equals(decimal d1, decimal d2);
        public static decimal Floor(decimal d);
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static decimal Parse(string s);
        public static decimal Parse(string s, NumberStyles style);
        public static decimal Parse(string s, IFormatProvider provider);
        public static decimal Parse(string s, NumberStyles style, IFormatProvider provider);
        public static decimal Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Number, IFormatProvider provider = null);
        public static bool TryParse(string s, out decimal result);
        public static bool TryParse(ReadOnlySpan<char> s, out decimal result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out decimal result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out decimal result);
        public static int[] GetBits(decimal d);
        public static int GetBits(decimal d, Span<int> destination);
        public static bool TryGetBits(decimal d, Span<int> destination, out int valuesWritten);
        public static decimal Remainder(decimal d1, decimal d2);
        public static decimal Multiply(decimal d1, decimal d2);
        public static decimal Negate(decimal d);
        public static decimal Round(decimal d);
        public static decimal Round(decimal d, int decimals);
        public static decimal Round(decimal d, MidpointRounding mode);
        public static decimal Round(decimal d, int decimals, MidpointRounding mode);
        public static decimal Subtract(decimal d1, decimal d2);
        public static byte ToByte(decimal value);
        [CLSCompliant(False)]
        public static sbyte ToSByte(decimal value);
        public static short ToInt16(decimal value);
        public static double ToDouble(decimal d);
        public static int ToInt32(decimal d);
        public static long ToInt64(decimal d);
        [CLSCompliant(False)]
        public static ushort ToUInt16(decimal value);
        [CLSCompliant(False)]
        public static uint ToUInt32(decimal d);
        [CLSCompliant(False)]
        public static ulong ToUInt64(decimal d);
        public static float ToSingle(decimal d);
        public static decimal Truncate(decimal d);
        public TypeCode GetTypeCode();
        public static decimal Clamp(decimal value, decimal min, decimal max);
        public static decimal CopySign(decimal value, decimal sign);
        public static decimal Max(decimal x, decimal y);
        public static decimal Min(decimal x, decimal y);
        public static int Sign(decimal d);
        public static decimal Abs(decimal value);
        public static decimal CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static decimal CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static decimal CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsCanonical(decimal value);
        public static bool IsEvenInteger(decimal value);
        public static bool IsInteger(decimal value);
        public static bool IsNegative(decimal value);
        public static bool IsOddInteger(decimal value);
        public static bool IsPositive(decimal value);
        public static decimal MaxMagnitude(decimal x, decimal y);
        public static decimal MinMagnitude(decimal x, decimal y);
        public static bool TryParse(string s, IFormatProvider provider, out decimal result);
        public static decimal Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out decimal result);
        public static decimal Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Number, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out decimal result);
        public static decimal Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out decimal result);

        public static decimal operator +(decimal d);
        public static decimal operator -(decimal d);
        public static decimal operator ++(decimal d);
        public static decimal operator --(decimal d);
        public static decimal operator +(decimal d1, decimal d2);
        public static decimal operator -(decimal d1, decimal d2);
        public static decimal operator *(decimal d1, decimal d2);
        public static decimal operator /(decimal d1, decimal d2);
        public static decimal operator %(decimal d1, decimal d2);
        public static bool operator ==(decimal d1, decimal d2);
        public static bool operator !=(decimal d1, decimal d2);
        public static bool operator <(decimal d1, decimal d2);
        public static bool operator <=(decimal d1, decimal d2);
        public static bool operator >(decimal d1, decimal d2);
        public static bool operator >=(decimal d1, decimal d2);

        public static implicit operator decimal(byte value);
        [CLSCompliant(False)]
        public static implicit operator decimal(sbyte value);
        public static implicit operator decimal(short value);
        [CLSCompliant(False)]
        public static implicit operator decimal(ushort value);
        public static implicit operator decimal(char value);
        public static implicit operator decimal(int value);
        [CLSCompliant(False)]
        public static implicit operator decimal(uint value);
        public static implicit operator decimal(long value);
        [CLSCompliant(False)]
        public static implicit operator decimal(ulong value);
        public static explicit operator decimal(float value);
        public static explicit operator decimal(double value);
        public static explicit operator byte(decimal value);
        [CLSCompliant(False)]
        public static explicit operator sbyte(decimal value);
        public static explicit operator char(decimal value);
        public static explicit operator short(decimal value);
        [CLSCompliant(False)]
        public static explicit operator ushort(decimal value);
        public static explicit operator int(decimal value);
        [CLSCompliant(False)]
        public static explicit operator uint(decimal value);
        public static explicit operator long(decimal value);
        [CLSCompliant(False)]
        public static explicit operator ulong(decimal value);
        public static explicit operator float(decimal value);
        public static explicit operator double(decimal value);
    }
}
