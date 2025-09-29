#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Int32 : IAdditionOperators<int, int, int>, IAdditiveIdentity<int, int>, IBinaryInteger<int>, IBinaryIntegerParseAndFormatInfo<int>, IBinaryNumber<int>, IBitwiseOperators<int, int, int>, IComparable, IComparable<int>, IComparisonOperators<int, int, bool>, IConvertible, IDecrementOperators<int>, IDivisionOperators<int, int, int>, IEqualityOperators<int, int, bool>, IEquatable<int>, IFormattable, IIncrementOperators<int>, IMinMaxValue<int>, IModulusOperators<int, int, int>, IMultiplicativeIdentity<int, int>, IMultiplyOperators<int, int, int>, INumber<int>, INumberBase<int>, IParsable<int>, IShiftOperators<int, int, int>, ISignedNumber<int>, ISpanFormattable, ISpanParsable<int>, ISubtractionOperators<int, int, int>, IUnaryNegationOperators<int, int>, IUnaryPlusOperators<int, int>, IUtf8SpanFormattable, IUtf8SpanParsable<int>
    {

        public const int MaxValue = 2147483647;
        public const int MinValue = -2147483648;

        public int CompareTo(object value);
        public int CompareTo(int value);
        public override bool Equals(object obj);
        public bool Equals(int obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static int Parse(string s);
        public static int Parse(string s, NumberStyles style);
        public static int Parse(string s, IFormatProvider provider);
        public static int Parse(string s, NumberStyles style, IFormatProvider provider);
        public static int Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out int result);
        public static bool TryParse(ReadOnlySpan<char> s, out int result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out int result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result);
        public TypeCode GetTypeCode();
        public static (int Quotient, int Remainder) DivRem(int left, int right);
        public static int LeadingZeroCount(int value);
        public static int PopCount(int value);
        public static int RotateLeft(int value, int rotateAmount);
        public static int RotateRight(int value, int rotateAmount);
        public static int TrailingZeroCount(int value);
        public static bool IsPow2(int value);
        public static int Log2(int value);
        public static int Clamp(int value, int min, int max);
        public static int CopySign(int value, int sign);
        public static int Max(int x, int y);
        public static int Min(int x, int y);
        public static int Sign(int value);
        public static int Abs(int value);
        public static int CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static int CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static int CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(int value);
        public static bool IsNegative(int value);
        public static bool IsOddInteger(int value);
        public static bool IsPositive(int value);
        public static int MaxMagnitude(int x, int y);
        public static int MinMagnitude(int x, int y);
        public static bool TryParse(string s, IFormatProvider provider, out int result);
        public static int Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out int result);
        public static int Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out int result);
        public static int Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out int result);
    }
}
