#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization;

namespace System
{
    [CLSCompliant(False)]
    public readonly struct UIntPtr : IAdditionOperators<nuint, nuint, nuint>, IAdditiveIdentity<nuint, nuint>, IBinaryInteger<nuint>, IBinaryNumber<nuint>, IBitwiseOperators<nuint, nuint, nuint>, IComparable, IComparable<nuint>, IComparisonOperators<nuint, nuint, bool>, IDecrementOperators<nuint>, IDivisionOperators<nuint, nuint, nuint>, IEqualityOperators<nuint, nuint, bool>, IEquatable<nuint>, IFormattable, IIncrementOperators<nuint>, IMinMaxValue<nuint>, IModulusOperators<nuint, nuint, nuint>, IMultiplicativeIdentity<nuint, nuint>, IMultiplyOperators<nuint, nuint, nuint>, INumber<nuint>, INumberBase<nuint>, IParsable<nuint>, ISerializable, IShiftOperators<nuint, int, nuint>, ISpanFormattable, ISpanParsable<nuint>, ISubtractionOperators<nuint, nuint, nuint>, IUnaryNegationOperators<nuint, nuint>, IUnaryPlusOperators<nuint, nuint>, IUnsignedNumber<nuint>, IUtf8SpanFormattable, IUtf8SpanParsable<nuint>
    {

        public static readonly nuint Zero;

        public UIntPtr(uint value);
        public UIntPtr(ulong value);
        public UIntPtr(void* value);

        public static int Size { get; }
        public static nuint MaxValue { get; }
        public static nuint MinValue { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public uint ToUInt32();
        public ulong ToUInt64();
        public static nuint Add(nuint pointer, int offset);
        public static nuint Subtract(nuint pointer, int offset);
        public void* ToPointer();
        public int CompareTo(object value);
        public int CompareTo(nuint value);
        public bool Equals(nuint other);
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static nuint Parse(string s);
        public static nuint Parse(string s, NumberStyles style);
        public static nuint Parse(string s, IFormatProvider provider);
        public static nuint Parse(string s, NumberStyles style, IFormatProvider provider);
        public static nuint Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static nuint Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(string s, out nuint result);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out nuint result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out nuint result);
        public static bool TryParse(ReadOnlySpan<char> s, out nuint result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out nuint result);
        public static bool TryParse(string s, IFormatProvider provider, out nuint result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out nuint result);
        public static (nuint Quotient, nuint Remainder) DivRem(nuint left, nuint right);
        public static nuint LeadingZeroCount(nuint value);
        public static nuint PopCount(nuint value);
        public static nuint RotateLeft(nuint value, int rotateAmount);
        public static nuint RotateRight(nuint value, int rotateAmount);
        public static nuint TrailingZeroCount(nuint value);
        public static bool IsPow2(nuint value);
        public static nuint Log2(nuint value);
        public static nuint Clamp(nuint value, nuint min, nuint max);
        public static nuint Max(nuint x, nuint y);
        public static nuint Min(nuint x, nuint y);
        public static int Sign(nuint value);
        public static nuint CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static nuint CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static nuint CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(nuint value);
        public static bool IsOddInteger(nuint value);
        public static nuint Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out nuint result);
        public static nuint Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out nuint result);

        public static bool operator ==(nuint value1, nuint value2);
        public static bool operator !=(nuint value1, nuint value2);
        public static nuint operator +(nuint pointer, int offset);
        public static nuint operator -(nuint pointer, int offset);

        public static explicit operator nuint(uint value);
        public static explicit operator nuint(ulong value);
        public static explicit operator nuint(void* value);
        public static explicit operator void*(nuint value);
        public static explicit operator uint(nuint value);
        public static explicit operator ulong(nuint value);
    }
}
