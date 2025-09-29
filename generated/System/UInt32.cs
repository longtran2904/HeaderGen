#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct UInt32 : IAdditionOperators<uint, uint, uint>, IAdditiveIdentity<uint, uint>, IBinaryInteger<uint>, IBinaryIntegerParseAndFormatInfo<uint>, IBinaryNumber<uint>, IBitwiseOperators<uint, uint, uint>, IComparable, IComparable<uint>, IComparisonOperators<uint, uint, bool>, IConvertible, IDecrementOperators<uint>, IDivisionOperators<uint, uint, uint>, IEqualityOperators<uint, uint, bool>, IEquatable<uint>, IFormattable, IIncrementOperators<uint>, IMinMaxValue<uint>, IModulusOperators<uint, uint, uint>, IMultiplicativeIdentity<uint, uint>, IMultiplyOperators<uint, uint, uint>, INumber<uint>, INumberBase<uint>, IParsable<uint>, IShiftOperators<uint, int, uint>, ISpanFormattable, ISpanParsable<uint>, ISubtractionOperators<uint, uint, uint>, IUnaryNegationOperators<uint, uint>, IUnaryPlusOperators<uint, uint>, IUnsignedNumber<uint>, IUtf8SpanFormattable, IUtf8SpanParsable<uint>
    {
        public const uint MaxValue = 4294967295;
        public const uint MinValue = 0;

        public int CompareTo(object value);
        public int CompareTo(uint value);
        public override bool Equals(object obj);
        public bool Equals(uint obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static uint Parse(string s);
        public static uint Parse(string s, NumberStyles style);
        public static uint Parse(string s, IFormatProvider provider);
        public static uint Parse(string s, NumberStyles style, IFormatProvider provider);
        public static uint Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out uint result);
        public static bool TryParse(ReadOnlySpan<char> s, out uint result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out uint result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out uint result);
        public TypeCode GetTypeCode();
        public static (uint Quotient, uint Remainder) DivRem(uint left, uint right);
        public static uint LeadingZeroCount(uint value);
        public static uint PopCount(uint value);
        public static uint RotateLeft(uint value, int rotateAmount);
        public static uint RotateRight(uint value, int rotateAmount);
        public static uint TrailingZeroCount(uint value);
        public static bool IsPow2(uint value);
        public static uint Log2(uint value);
        public static uint Clamp(uint value, uint min, uint max);
        public static uint Max(uint x, uint y);
        public static uint Min(uint x, uint y);
        public static int Sign(uint value);
        public static uint CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static uint CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static uint CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(uint value);
        public static bool IsOddInteger(uint value);
        public static bool TryParse(string s, IFormatProvider provider, out uint result);
        public static uint Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out uint result);
        public static uint Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out uint result);
        public static uint Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out uint result);
    }
}
