#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Byte : IAdditionOperators<byte, byte, byte>, IAdditiveIdentity<byte, byte>, IBinaryInteger<byte>, IBinaryIntegerParseAndFormatInfo<byte>, IBinaryNumber<byte>, IBitwiseOperators<byte, byte, byte>, IComparable, IComparable<byte>, IComparisonOperators<byte, byte, bool>, IConvertible, IDecrementOperators<byte>, IDivisionOperators<byte, byte, byte>, IEqualityOperators<byte, byte, bool>, IEquatable<byte>, IFormattable, IIncrementOperators<byte>, IMinMaxValue<byte>, IModulusOperators<byte, byte, byte>, IMultiplicativeIdentity<byte, byte>, IMultiplyOperators<byte, byte, byte>, INumber<byte>, INumberBase<byte>, IParsable<byte>, IShiftOperators<byte, int, byte>, ISpanFormattable, ISpanParsable<byte>, ISubtractionOperators<byte, byte, byte>, IUnaryNegationOperators<byte, byte>, IUnaryPlusOperators<byte, byte>, IUnsignedNumber<byte>, IUtf8SpanFormattable, IUtf8SpanParsable<byte>, IUtfChar<byte>
    {
        public const byte MaxValue = 255;
        public const byte MinValue = 0;

        public int CompareTo(object value);
        public int CompareTo(byte value);
        public override bool Equals(object obj);
        public bool Equals(byte obj);
        public override int GetHashCode();
        public static byte Parse(string s);
        public static byte Parse(string s, NumberStyles style);
        public static byte Parse(string s, IFormatProvider provider);
        public static byte Parse(string s, NumberStyles style, IFormatProvider provider);
        public static byte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out byte result);
        public static bool TryParse(ReadOnlySpan<char> s, out byte result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out byte result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out byte result);
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public TypeCode GetTypeCode();
        public static (byte Quotient, byte Remainder) DivRem(byte left, byte right);
        public static byte LeadingZeroCount(byte value);
        public static byte PopCount(byte value);
        public static byte RotateLeft(byte value, int rotateAmount);
        public static byte RotateRight(byte value, int rotateAmount);
        public static byte TrailingZeroCount(byte value);
        public static bool IsPow2(byte value);
        public static byte Log2(byte value);
        public static byte Clamp(byte value, byte min, byte max);
        public static byte Max(byte x, byte y);
        public static byte Min(byte x, byte y);
        public static int Sign(byte value);
        public static byte CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static byte CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static byte CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(byte value);
        public static bool IsOddInteger(byte value);
        public static bool TryParse(string s, IFormatProvider provider, out byte result);
        public static byte Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out byte result);
        public static byte Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out byte result);
        public static byte Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out byte result);
    }
}
