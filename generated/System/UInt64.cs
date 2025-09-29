#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct UInt64 : IAdditionOperators<ulong, ulong, ulong>, IAdditiveIdentity<ulong, ulong>, IBinaryInteger<ulong>, IBinaryIntegerParseAndFormatInfo<ulong>, IBinaryNumber<ulong>, IBitwiseOperators<ulong, ulong, ulong>, IComparable, IComparable<ulong>, IComparisonOperators<ulong, ulong, bool>, IConvertible, IDecrementOperators<ulong>, IDivisionOperators<ulong, ulong, ulong>, IEqualityOperators<ulong, ulong, bool>, IEquatable<ulong>, IFormattable, IIncrementOperators<ulong>, IMinMaxValue<ulong>, IModulusOperators<ulong, ulong, ulong>, IMultiplicativeIdentity<ulong, ulong>, IMultiplyOperators<ulong, ulong, ulong>, INumber<ulong>, INumberBase<ulong>, IParsable<ulong>, IShiftOperators<ulong, int, ulong>, ISpanFormattable, ISpanParsable<ulong>, ISubtractionOperators<ulong, ulong, ulong>, IUnaryNegationOperators<ulong, ulong>, IUnaryPlusOperators<ulong, ulong>, IUnsignedNumber<ulong>, IUtf8SpanFormattable, IUtf8SpanParsable<ulong>
    {

        public const ulong MaxValue = 18446744073709551615;
        public const ulong MinValue = 0;

        public int CompareTo(object value);
        public int CompareTo(ulong value);
        public override bool Equals(object obj);
        public bool Equals(ulong obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static ulong Parse(string s);
        public static ulong Parse(string s, NumberStyles style);
        public static ulong Parse(string s, IFormatProvider provider);
        public static ulong Parse(string s, NumberStyles style, IFormatProvider provider);
        public static ulong Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out ulong result);
        public static bool TryParse(ReadOnlySpan<char> s, out ulong result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ulong result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out ulong result);
        public TypeCode GetTypeCode();
        public static (ulong Quotient, ulong Remainder) DivRem(ulong left, ulong right);
        public static ulong LeadingZeroCount(ulong value);
        public static ulong PopCount(ulong value);
        public static ulong RotateLeft(ulong value, int rotateAmount);
        public static ulong RotateRight(ulong value, int rotateAmount);
        public static ulong TrailingZeroCount(ulong value);
        public static bool IsPow2(ulong value);
        public static ulong Log2(ulong value);
        public static ulong Clamp(ulong value, ulong min, ulong max);
        public static ulong Max(ulong x, ulong y);
        public static ulong Min(ulong x, ulong y);
        public static int Sign(ulong value);
        public static ulong CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static ulong CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static ulong CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(ulong value);
        public static bool IsOddInteger(ulong value);
        public static bool TryParse(string s, IFormatProvider provider, out ulong result);
        public static ulong Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out ulong result);
        public static ulong Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out ulong result);
        public static ulong Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out ulong result);
    }
}
