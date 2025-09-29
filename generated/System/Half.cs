#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Half : IAdditionOperators<Half, Half, Half>, IAdditiveIdentity<Half, Half>, IBinaryFloatingPointIeee754<Half>, IBinaryFloatParseAndFormatInfo<Half>, IBinaryNumber<Half>, IBitwiseOperators<Half, Half, Half>, IComparable, IComparable<Half>, IComparisonOperators<Half, Half, bool>, IDecrementOperators<Half>, IDivisionOperators<Half, Half, Half>, IEqualityOperators<Half, Half, bool>, IEquatable<Half>, IExponentialFunctions<Half>, IFloatingPoint<Half>, IFloatingPointConstants<Half>, IFloatingPointIeee754<Half>, IFormattable, IHyperbolicFunctions<Half>, IIncrementOperators<Half>, ILogarithmicFunctions<Half>, IMinMaxValue<Half>, IModulusOperators<Half, Half, Half>, IMultiplicativeIdentity<Half, Half>, IMultiplyOperators<Half, Half, Half>, INumber<Half>, INumberBase<Half>, IParsable<Half>, IPowerFunctions<Half>, IRootFunctions<Half>, ISignedNumber<Half>, ISpanFormattable, ISpanParsable<Half>, ISubtractionOperators<Half, Half, Half>, ITrigonometricFunctions<Half>, IUnaryNegationOperators<Half, Half>, IUnaryPlusOperators<Half, Half>, IUtf8SpanFormattable, IUtf8SpanParsable<Half>
    {
        public static Half Epsilon { get; }
        public static Half PositiveInfinity { get; }
        public static Half NegativeInfinity { get; }
        public static Half NaN { get; }
        public static Half MinValue { get; }
        public static Half MaxValue { get; }
        public static Half E { get; }
        public static Half Pi { get; }
        public static Half Tau { get; }
        public static Half NegativeZero { get; }
        public static Half MultiplicativeIdentity { get; }
        public static Half One { get; }
        public static Half Zero { get; }
        public static Half NegativeOne { get; }

        public static bool IsFinite(Half value);
        public static bool IsInfinity(Half value);
        public static bool IsNaN(Half value);
        public static bool IsNegative(Half value);
        public static bool IsNegativeInfinity(Half value);
        public static bool IsNormal(Half value);
        public static bool IsPositiveInfinity(Half value);
        public static bool IsSubnormal(Half value);
        public static Half Parse(string s);
        public static Half Parse(string s, NumberStyles style);
        public static Half Parse(string s, IFormatProvider provider);
        public static Half Parse(string s, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static Half Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(string s, out Half result);
        public static bool TryParse(ReadOnlySpan<char> s, out Half result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out Half result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Half result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out Half result);
        public int CompareTo(object obj);
        public int CompareTo(Half other);
        public override bool Equals(object obj);
        public bool Equals(Half other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static bool IsPow2(Half value);
        public static Half Log2(Half value);
        public static Half Exp(Half x);
        public static Half ExpM1(Half x);
        public static Half Exp2(Half x);
        public static Half Exp2M1(Half x);
        public static Half Exp10(Half x);
        public static Half Exp10M1(Half x);
        public static Half Ceiling(Half x);
        public static Half Floor(Half x);
        public static Half Round(Half x);
        public static Half Round(Half x, int digits);
        public static Half Round(Half x, MidpointRounding mode);
        public static Half Round(Half x, int digits, MidpointRounding mode);
        public static Half Truncate(Half x);
        public static Half Atan2(Half y, Half x);
        public static Half Atan2Pi(Half y, Half x);
        public static Half BitDecrement(Half x);
        public static Half BitIncrement(Half x);
        public static Half FusedMultiplyAdd(Half left, Half right, Half addend);
        public static Half Ieee754Remainder(Half left, Half right);
        public static int ILogB(Half x);
        public static Half Lerp(Half value1, Half value2, Half amount);
        public static Half ReciprocalEstimate(Half x);
        public static Half ReciprocalSqrtEstimate(Half x);
        public static Half ScaleB(Half x, int n);
        public static Half Acosh(Half x);
        public static Half Asinh(Half x);
        public static Half Atanh(Half x);
        public static Half Cosh(Half x);
        public static Half Sinh(Half x);
        public static Half Tanh(Half x);
        public static Half Log(Half x);
        public static Half Log(Half x, Half newBase);
        public static Half Log10(Half x);
        public static Half LogP1(Half x);
        public static Half Log2P1(Half x);
        public static Half Log10P1(Half x);
        public static Half Clamp(Half value, Half min, Half max);
        public static Half CopySign(Half value, Half sign);
        public static Half Max(Half x, Half y);
        public static Half MaxNumber(Half x, Half y);
        public static Half Min(Half x, Half y);
        public static Half MinNumber(Half x, Half y);
        public static int Sign(Half value);
        public static Half Abs(Half value);
        public static Half CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static Half CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static Half CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(Half value);
        public static bool IsInteger(Half value);
        public static bool IsOddInteger(Half value);
        public static bool IsPositive(Half value);
        public static bool IsRealNumber(Half value);
        public static Half MaxMagnitude(Half x, Half y);
        public static Half MaxMagnitudeNumber(Half x, Half y);
        public static Half MinMagnitude(Half x, Half y);
        public static Half MinMagnitudeNumber(Half x, Half y);
        public static bool TryParse(string s, IFormatProvider provider, out Half result);
        public static Half Pow(Half x, Half y);
        public static Half Cbrt(Half x);
        public static Half Hypot(Half x, Half y);
        public static Half RootN(Half x, int n);
        public static Half Sqrt(Half x);
        public static Half Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out Half result);
        public static Half Acos(Half x);
        public static Half AcosPi(Half x);
        public static Half Asin(Half x);
        public static Half AsinPi(Half x);
        public static Half Atan(Half x);
        public static Half AtanPi(Half x);
        public static Half Cos(Half x);
        public static Half CosPi(Half x);
        public static Half DegreesToRadians(Half degrees);
        public static Half RadiansToDegrees(Half radians);
        public static Half Sin(Half x);
        public static (Half Sin, Half Cos) SinCos(Half x);
        public static (Half SinPi, Half CosPi) SinCosPi(Half x);
        public static Half SinPi(Half x);
        public static Half Tan(Half x);
        public static Half TanPi(Half x);
        public static Half Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out Half result);
        public static Half Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out Half result);

        public static bool operator <(Half left, Half right);
        public static bool operator >(Half left, Half right);
        public static bool operator <=(Half left, Half right);
        public static bool operator >=(Half left, Half right);
        public static bool operator ==(Half left, Half right);
        public static bool operator !=(Half left, Half right);
        public static explicit operator checked byte(Half value);
        public static explicit operator checked char(Half value);
        public static explicit operator checked short(Half value);
        public static explicit operator checked int(Half value);
        public static explicit operator checked long(Half value);
        public static explicit operator checked Int128(Half value);
        public static explicit operator checked nint(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked sbyte(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked ushort(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked uint(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked ulong(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked UInt128(Half value);
        [CLSCompliant(False)]
        public static explicit operator checked nuint(Half value);
        public static Half operator +(Half left, Half right);
        public static Half operator --(Half value);
        public static Half operator /(Half left, Half right);
        public static Half operator ++(Half value);
        public static Half operator %(Half left, Half right);
        public static Half operator *(Half left, Half right);
        public static Half operator -(Half left, Half right);
        public static Half operator -(Half value);
        public static Half operator +(Half value);

        public static explicit operator Half(char value);
        public static explicit operator Half(decimal value);
        public static explicit operator Half(double value);
        public static explicit operator Half(short value);
        public static explicit operator Half(int value);
        public static explicit operator Half(long value);
        public static explicit operator Half(nint value);
        public static explicit operator Half(float value);
        [CLSCompliant(False)]
        public static explicit operator Half(ushort value);
        [CLSCompliant(False)]
        public static explicit operator Half(uint value);
        [CLSCompliant(False)]
        public static explicit operator Half(ulong value);
        [CLSCompliant(False)]
        public static explicit operator Half(nuint value);
        public static explicit operator byte(Half value);
        public static explicit operator char(Half value);
        public static explicit operator decimal(Half value);
        public static explicit operator short(Half value);
        public static explicit operator int(Half value);
        public static explicit operator long(Half value);
        public static explicit operator Int128(Half value);
        public static explicit operator nint(Half value);
        [CLSCompliant(False)]
        public static explicit operator sbyte(Half value);
        [CLSCompliant(False)]
        public static explicit operator ushort(Half value);
        [CLSCompliant(False)]
        public static explicit operator uint(Half value);
        [CLSCompliant(False)]
        public static explicit operator ulong(Half value);
        [CLSCompliant(False)]
        public static explicit operator UInt128(Half value);
        [CLSCompliant(False)]
        public static explicit operator nuint(Half value);
        public static implicit operator Half(byte value);
        [CLSCompliant(False)]
        public static implicit operator Half(sbyte value);
        public static explicit operator double(Half value);
        public static explicit operator float(Half value);
    }
}
