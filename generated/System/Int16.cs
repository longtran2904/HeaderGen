#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Int16 : IAdditionOperators<short, short, short>, IAdditiveIdentity<short, short>, IBinaryInteger<short>, IBinaryIntegerParseAndFormatInfo<short>, IBinaryNumber<short>, IBitwiseOperators<short, short, short>, IComparable, IComparable<short>, IComparisonOperators<short, short, bool>, IConvertible, IDecrementOperators<short>, IDivisionOperators<short, short, short>, IEqualityOperators<short, short, bool>, IEquatable<short>, IFormattable, IIncrementOperators<short>, IMinMaxValue<short>, IModulusOperators<short, short, short>, IMultiplicativeIdentity<short, short>, IMultiplyOperators<short, short, short>, INumber<short>, INumberBase<short>, IParsable<short>, IShiftOperators<short, int, short>, ISignedNumber<short>, ISpanFormattable, ISpanParsable<short>, ISubtractionOperators<short, short, short>, IUnaryNegationOperators<short, short>, IUnaryPlusOperators<short, short>, IUtf8SpanFormattable, IUtf8SpanParsable<short>
    {

        public const short MaxValue = 32767;
        public const short MinValue = -32768;

        public int CompareTo(object value);
        public int CompareTo(short value);
        public override bool Equals(object obj);
        public bool Equals(short obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static short Parse(string s);
        public static short Parse(string s, NumberStyles style);
        public static short Parse(string s, IFormatProvider provider);
        public static short Parse(string s, NumberStyles style, IFormatProvider provider);
        public static short Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out short result);
        public static bool TryParse(ReadOnlySpan<char> s, out short result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out short result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out short result);
        public TypeCode GetTypeCode();
        public static (short Quotient, short Remainder) DivRem(short left, short right);
        public static short LeadingZeroCount(short value);
        public static short PopCount(short value);
        public static short RotateLeft(short value, int rotateAmount);
        public static short RotateRight(short value, int rotateAmount);
        public static short TrailingZeroCount(short value);
        public static bool IsPow2(short value);
        public static short Log2(short value);
        public static short Clamp(short value, short min, short max);
        public static short CopySign(short value, short sign);
        public static short Max(short x, short y);
        public static short Min(short x, short y);
        public static int Sign(short value);
        public static short Abs(short value);
        public static short CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static short CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static short CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(short value);
        public static bool IsNegative(short value);
        public static bool IsOddInteger(short value);
        public static bool IsPositive(short value);
        public static short MaxMagnitude(short x, short y);
        public static short MinMagnitude(short x, short y);
        public static bool TryParse(string s, IFormatProvider provider, out short result);
        public static short Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out short result);
        public static short Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out short result);
        public static short Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out short result);
    }
}
