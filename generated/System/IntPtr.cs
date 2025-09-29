#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization;

namespace System
{
    public readonly struct IntPtr : IAdditionOperators<nint, nint, nint>, IAdditiveIdentity<nint, nint>, IBinaryInteger<nint>, IBinaryNumber<nint>, IBitwiseOperators<nint, nint, nint>, IComparable, IComparable<nint>, IComparisonOperators<nint, nint, bool>, IDecrementOperators<nint>, IDivisionOperators<nint, nint, nint>, IEqualityOperators<nint, nint, bool>, IEquatable<nint>, IFormattable, IIncrementOperators<nint>, IMinMaxValue<nint>, IModulusOperators<nint, nint, nint>, IMultiplicativeIdentity<nint, nint>, IMultiplyOperators<nint, nint, nint>, INumber<nint>, INumberBase<nint>, IParsable<nint>, ISerializable, IShiftOperators<nint, int, nint>, ISignedNumber<nint>, ISpanFormattable, ISpanParsable<nint>, ISubtractionOperators<nint, nint, nint>, IUnaryNegationOperators<nint, nint>, IUnaryPlusOperators<nint, nint>, IUtf8SpanFormattable, IUtf8SpanParsable<nint>
    {

        public static readonly nint Zero;

        public IntPtr(int value);
        public IntPtr(long value);
        [CLSCompliant(False)]
        public IntPtr(void* value);

        public static int Size { get; }
        public static nint MaxValue { get; }
        public static nint MinValue { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public int ToInt32();
        public long ToInt64();
        public static nint Add(nint pointer, int offset);
        public static nint Subtract(nint pointer, int offset);
        [CLSCompliant(False)]
        public void* ToPointer();
        public int CompareTo(object value);
        public int CompareTo(nint value);
        public bool Equals(nint other);
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static nint Parse(string s);
        public static nint Parse(string s, NumberStyles style);
        public static nint Parse(string s, IFormatProvider provider);
        public static nint Parse(string s, NumberStyles style, IFormatProvider provider);
        public static nint Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static nint Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out nint result);
        public static bool TryParse(string s, IFormatProvider provider, out nint result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out nint result);
        public static bool TryParse(ReadOnlySpan<char> s, out nint result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out nint result);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out nint result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out nint result);
        public static (nint Quotient, nint Remainder) DivRem(nint left, nint right);
        public static nint LeadingZeroCount(nint value);
        public static nint PopCount(nint value);
        public static nint RotateLeft(nint value, int rotateAmount);
        public static nint RotateRight(nint value, int rotateAmount);
        public static nint TrailingZeroCount(nint value);
        public static bool IsPow2(nint value);
        public static nint Log2(nint value);
        public static nint Clamp(nint value, nint min, nint max);
        public static nint CopySign(nint value, nint sign);
        public static nint Max(nint x, nint y);
        public static nint Min(nint x, nint y);
        public static int Sign(nint value);
        public static nint Abs(nint value);
        public static nint CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static nint CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static nint CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(nint value);
        public static bool IsNegative(nint value);
        public static bool IsOddInteger(nint value);
        public static bool IsPositive(nint value);
        public static nint MaxMagnitude(nint x, nint y);
        public static nint MinMagnitude(nint x, nint y);
        public static nint Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out nint result);
        public static nint Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out nint result);

        public static bool operator ==(nint value1, nint value2);
        public static bool operator !=(nint value1, nint value2);
        public static nint operator +(nint pointer, int offset);
        public static nint operator -(nint pointer, int offset);

        public static explicit operator nint(int value);
        public static explicit operator nint(long value);
        [CLSCompliant(False)]
        public static explicit operator nint(void* value);
        [CLSCompliant(False)]
        public static explicit operator void*(nint value);
        public static explicit operator int(nint value);
        public static explicit operator long(nint value);
    }
}
