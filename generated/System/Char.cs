#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Char : IAdditionOperators<char, char, char>, IAdditiveIdentity<char, char>, IBinaryInteger<char>, IBinaryIntegerParseAndFormatInfo<char>, IBinaryNumber<char>, IBitwiseOperators<char, char, char>, IComparable, IComparable<char>, IComparisonOperators<char, char, bool>, IConvertible, IDecrementOperators<char>, IDivisionOperators<char, char, char>, IEqualityOperators<char, char, bool>, IEquatable<char>, IFormattable, IIncrementOperators<char>, IMinMaxValue<char>, IModulusOperators<char, char, char>, IMultiplicativeIdentity<char, char>, IMultiplyOperators<char, char, char>, INumber<char>, INumberBase<char>, IParsable<char>, IShiftOperators<char, int, char>, ISpanFormattable, ISpanParsable<char>, ISubtractionOperators<char, char, char>, IUnaryNegationOperators<char, char>, IUnaryPlusOperators<char, char>, IUnsignedNumber<char>, IUtf8SpanFormattable, IUtf8SpanParsable<char>, IUtfChar<char>
    {
        public const char MaxValue = '￿';
        public const char MinValue = '\0';

        public static bool IsAscii(char c);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(char obj);
        public int CompareTo(object value);
        public int CompareTo(char value);
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public static string ToString(char c);
        public static char Parse(string s);
        public static bool TryParse(string s, out char result);
        public static bool IsAsciiLetter(char c);
        public static bool IsAsciiLetterLower(char c);
        public static bool IsAsciiLetterUpper(char c);
        public static bool IsAsciiDigit(char c);
        public static bool IsAsciiLetterOrDigit(char c);
        public static bool IsAsciiHexDigit(char c);
        public static bool IsAsciiHexDigitUpper(char c);
        public static bool IsAsciiHexDigitLower(char c);
        public static bool IsDigit(char c);
        public static bool IsBetween(char c, char minInclusive, char maxInclusive);
        public static bool IsLetter(char c);
        public static bool IsWhiteSpace(char c);
        public static bool IsUpper(char c);
        public static bool IsLower(char c);
        public static bool IsPunctuation(char c);
        public static bool IsLetterOrDigit(char c);
        public static char ToUpper(char c, CultureInfo culture);
        public static char ToUpper(char c);
        public static char ToUpperInvariant(char c);
        public static char ToLower(char c, CultureInfo culture);
        public static char ToLower(char c);
        public static char ToLowerInvariant(char c);
        public TypeCode GetTypeCode();
        public static bool IsControl(char c);
        public static bool IsControl(string s, int index);
        public static bool IsDigit(string s, int index);
        public static bool IsLetter(string s, int index);
        public static bool IsLetterOrDigit(string s, int index);
        public static bool IsLower(string s, int index);
        public static bool IsNumber(char c);
        public static bool IsNumber(string s, int index);
        public static bool IsPunctuation(string s, int index);
        public static bool IsSeparator(char c);
        public static bool IsSeparator(string s, int index);
        public static bool IsSurrogate(char c);
        public static bool IsSurrogate(string s, int index);
        public static bool IsSymbol(char c);
        public static bool IsSymbol(string s, int index);
        public static bool IsUpper(string s, int index);
        public static bool IsWhiteSpace(string s, int index);
        public static UnicodeCategory GetUnicodeCategory(char c);
        public static UnicodeCategory GetUnicodeCategory(string s, int index);
        public static double GetNumericValue(char c);
        public static double GetNumericValue(string s, int index);
        public static bool IsHighSurrogate(char c);
        public static bool IsHighSurrogate(string s, int index);
        public static bool IsLowSurrogate(char c);
        public static bool IsLowSurrogate(string s, int index);
        public static bool IsSurrogatePair(string s, int index);
        public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate);
        public static string ConvertFromUtf32(int utf32);
        public static int ConvertToUtf32(char highSurrogate, char lowSurrogate);
        public static int ConvertToUtf32(string s, int index);
    }
}
