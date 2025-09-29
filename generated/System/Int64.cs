#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Int64 : IAdditionOperators<long, long, long>, IAdditiveIdentity<long, long>, IBinaryInteger<long>, IBinaryIntegerParseAndFormatInfo<long>, IBinaryNumber<long>, IBitwiseOperators<long, long, long>, IComparable, IComparable<long>, IComparisonOperators<long, long, bool>, IConvertible, IDecrementOperators<long>, IDivisionOperators<long, long, long>, IEqualityOperators<long, long, bool>, IEquatable<long>, IFormattable, IIncrementOperators<long>, IMinMaxValue<long>, IModulusOperators<long, long, long>, IMultiplicativeIdentity<long, long>, IMultiplyOperators<long, long, long>, INumber<long>, INumberBase<long>, IParsable<long>, IShiftOperators<long, int, long>, ISignedNumber<long>, ISpanFormattable, ISpanParsable<long>, ISubtractionOperators<long, long, long>, IUnaryNegationOperators<long, long>, IUnaryPlusOperators<long, long>, IUtf8SpanFormattable, IUtf8SpanParsable<long>
    {

        public const long MaxValue = 9223372036854775807;
        public const long MinValue = -9223372036854775808;

        public int CompareTo(object value);
        public int CompareTo(long value);
        public override bool Equals(object obj);
        public bool Equals(long obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static long Parse(string s);
        public static long Parse(string s, NumberStyles style);
        public static long Parse(string s, IFormatProvider provider);
        public static long Parse(string s, NumberStyles style, IFormatProvider provider);
        public static long Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out long result);
        public static bool TryParse(ReadOnlySpan<char> s, out long result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out long result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out long result);
        public TypeCode GetTypeCode();
        public static (long Quotient, long Remainder) DivRem(long left, long right);
        public static long LeadingZeroCount(long value);
        public static long PopCount(long value);
        public static long RotateLeft(long value, int rotateAmount);
        public static long RotateRight(long value, int rotateAmount);
        public static long TrailingZeroCount(long value);
        public static bool IsPow2(long value);
        public static long Log2(long value);
        public static long Clamp(long value, long min, long max);
        public static long CopySign(long value, long sign);
        public static long Max(long x, long y);
        public static long Min(long x, long y);
        public static int Sign(long value);
        public static long Abs(long value);
        public static long CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static long CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static long CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(long value);
        public static bool IsNegative(long value);
        public static bool IsOddInteger(long value);
        public static bool IsPositive(long value);
        public static long MaxMagnitude(long x, long y);
        public static long MinMagnitude(long x, long y);
        public static bool TryParse(string s, IFormatProvider provider, out long result);
        public static long Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out long result);
        public static long Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out long result);
        public static long Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out long result);
    }
}
