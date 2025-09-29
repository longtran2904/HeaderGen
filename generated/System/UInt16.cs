#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct UInt16 : IAdditionOperators<ushort, ushort, ushort>, IAdditiveIdentity<ushort, ushort>, IBinaryInteger<ushort>, IBinaryIntegerParseAndFormatInfo<ushort>, IBinaryNumber<ushort>, IBitwiseOperators<ushort, ushort, ushort>, IComparable, IComparable<ushort>, IComparisonOperators<ushort, ushort, bool>, IConvertible, IDecrementOperators<ushort>, IDivisionOperators<ushort, ushort, ushort>, IEqualityOperators<ushort, ushort, bool>, IEquatable<ushort>, IFormattable, IIncrementOperators<ushort>, IMinMaxValue<ushort>, IModulusOperators<ushort, ushort, ushort>, IMultiplicativeIdentity<ushort, ushort>, IMultiplyOperators<ushort, ushort, ushort>, INumber<ushort>, INumberBase<ushort>, IParsable<ushort>, IShiftOperators<ushort, int, ushort>, ISpanFormattable, ISpanParsable<ushort>, ISubtractionOperators<ushort, ushort, ushort>, IUnaryNegationOperators<ushort, ushort>, IUnaryPlusOperators<ushort, ushort>, IUnsignedNumber<ushort>, IUtf8SpanFormattable, IUtf8SpanParsable<ushort>
    {

        public const ushort MaxValue = 65535;
        public const ushort MinValue = 0;

        public int CompareTo(object value);
        public int CompareTo(ushort value);
        public override bool Equals(object obj);
        public bool Equals(ushort obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(IFormatProvider provider);
        public string ToString(string format);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static ushort Parse(string s);
        public static ushort Parse(string s, NumberStyles style);
        public static ushort Parse(string s, IFormatProvider provider);
        public static ushort Parse(string s, NumberStyles style, IFormatProvider provider);
        public static ushort Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out ushort result);
        public static bool TryParse(ReadOnlySpan<char> s, out ushort result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ushort result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out ushort result);
        public TypeCode GetTypeCode();
        public static (ushort Quotient, ushort Remainder) DivRem(ushort left, ushort right);
        public static ushort LeadingZeroCount(ushort value);
        public static ushort PopCount(ushort value);
        public static ushort RotateLeft(ushort value, int rotateAmount);
        public static ushort RotateRight(ushort value, int rotateAmount);
        public static ushort TrailingZeroCount(ushort value);
        public static bool IsPow2(ushort value);
        public static ushort Log2(ushort value);
        public static ushort Clamp(ushort value, ushort min, ushort max);
        public static ushort Max(ushort x, ushort y);
        public static ushort Min(ushort x, ushort y);
        public static int Sign(ushort value);
        public static ushort CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static ushort CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static ushort CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(ushort value);
        public static bool IsOddInteger(ushort value);
        public static bool TryParse(string s, IFormatProvider provider, out ushort result);
        public static ushort Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out ushort result);
        public static ushort Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out ushort result);
        public static ushort Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out ushort result);
    }
}
