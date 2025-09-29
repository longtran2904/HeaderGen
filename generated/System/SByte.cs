#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct SByte : IAdditionOperators<sbyte, sbyte, sbyte>, IAdditiveIdentity<sbyte, sbyte>, IBinaryInteger<sbyte>, IBinaryIntegerParseAndFormatInfo<sbyte>, IBinaryNumber<sbyte>, IBitwiseOperators<sbyte, sbyte, sbyte>, IComparable, IComparable<sbyte>, IComparisonOperators<sbyte, sbyte, bool>, IConvertible, IDecrementOperators<sbyte>, IDivisionOperators<sbyte, sbyte, sbyte>, IEqualityOperators<sbyte, sbyte, bool>, IEquatable<sbyte>, IFormattable, IIncrementOperators<sbyte>, IMinMaxValue<sbyte>, IModulusOperators<sbyte, sbyte, sbyte>, IMultiplicativeIdentity<sbyte, sbyte>, IMultiplyOperators<sbyte, sbyte, sbyte>, INumber<sbyte>, INumberBase<sbyte>, IParsable<sbyte>, IShiftOperators<sbyte, int, sbyte>, ISignedNumber<sbyte>, ISpanFormattable, ISpanParsable<sbyte>, ISubtractionOperators<sbyte, sbyte, sbyte>, IUnaryNegationOperators<sbyte, sbyte>, IUnaryPlusOperators<sbyte, sbyte>, IUtf8SpanFormattable, IUtf8SpanParsable<sbyte>
    {

        public const sbyte MaxValue = 127;
        public const sbyte MinValue = -128;

        public int CompareTo(object obj);
        public int CompareTo(sbyte value);
        public override bool Equals(object obj);
        public bool Equals(sbyte obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static sbyte Parse(string s);
        public static sbyte Parse(string s, NumberStyles style);
        public static sbyte Parse(string s, IFormatProvider provider);
        public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider);
        public static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out sbyte result);
        public static bool TryParse(ReadOnlySpan<char> s, out sbyte result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out sbyte result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out sbyte result);
        public TypeCode GetTypeCode();
        public static (sbyte Quotient, sbyte Remainder) DivRem(sbyte left, sbyte right);
        public static sbyte LeadingZeroCount(sbyte value);
        public static sbyte PopCount(sbyte value);
        public static sbyte RotateLeft(sbyte value, int rotateAmount);
        public static sbyte RotateRight(sbyte value, int rotateAmount);
        public static sbyte TrailingZeroCount(sbyte value);
        public static bool IsPow2(sbyte value);
        public static sbyte Log2(sbyte value);
        public static sbyte Clamp(sbyte value, sbyte min, sbyte max);
        public static sbyte CopySign(sbyte value, sbyte sign);
        public static sbyte Max(sbyte x, sbyte y);
        public static sbyte Min(sbyte x, sbyte y);
        public static int Sign(sbyte value);
        public static sbyte Abs(sbyte value);
        public static sbyte CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static sbyte CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static sbyte CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(sbyte value);
        public static bool IsNegative(sbyte value);
        public static bool IsOddInteger(sbyte value);
        public static bool IsPositive(sbyte value);
        public static sbyte MaxMagnitude(sbyte x, sbyte y);
        public static sbyte MinMagnitude(sbyte x, sbyte y);
        public static bool TryParse(string s, IFormatProvider provider, out sbyte result);
        public static sbyte Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out sbyte result);
        public static sbyte Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out sbyte result);
        public static sbyte Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out sbyte result);
    }
}
