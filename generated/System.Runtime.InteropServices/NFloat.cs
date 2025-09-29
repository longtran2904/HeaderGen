#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System.Runtime.InteropServices
{
    public readonly struct NFloat : IAdditionOperators<NFloat, NFloat, NFloat>, IAdditiveIdentity<NFloat, NFloat>, IBinaryFloatingPointIeee754<NFloat>, IBinaryNumber<NFloat>, IBitwiseOperators<NFloat, NFloat, NFloat>, IComparable, IComparable<NFloat>, IComparisonOperators<NFloat, NFloat, bool>, IDecrementOperators<NFloat>, IDivisionOperators<NFloat, NFloat, NFloat>, IEqualityOperators<NFloat, NFloat, bool>, IEquatable<NFloat>, IExponentialFunctions<NFloat>, IFloatingPoint<NFloat>, IFloatingPointConstants<NFloat>, IFloatingPointIeee754<NFloat>, IFormattable, IHyperbolicFunctions<NFloat>, IIncrementOperators<NFloat>, ILogarithmicFunctions<NFloat>, IMinMaxValue<NFloat>, IModulusOperators<NFloat, NFloat, NFloat>, IMultiplicativeIdentity<NFloat, NFloat>, IMultiplyOperators<NFloat, NFloat, NFloat>, INumber<NFloat>, INumberBase<NFloat>, IParsable<NFloat>, IPowerFunctions<NFloat>, IRootFunctions<NFloat>, ISignedNumber<NFloat>, ISpanFormattable, ISpanParsable<NFloat>, ISubtractionOperators<NFloat, NFloat, NFloat>, ITrigonometricFunctions<NFloat>, IUnaryNegationOperators<NFloat, NFloat>, IUnaryPlusOperators<NFloat, NFloat>, IUtf8SpanFormattable, IUtf8SpanParsable<NFloat>
    {
        public NFloat(float value);
        public NFloat(double value);

        public static NFloat Epsilon { get; }
        public static NFloat MaxValue { get; }
        public static NFloat MinValue { get; }
        public static NFloat NaN { get; }
        public static NFloat NegativeInfinity { get; }
        public static NFloat PositiveInfinity { get; }
        public static int Size { get; }
        public double Value { get; }
        public static NFloat E { get; }
        public static NFloat Pi { get; }
        public static NFloat Tau { get; }
        public static NFloat NegativeZero { get; }

        public static bool IsFinite(NFloat value);
        public static bool IsInfinity(NFloat value);
        public static bool IsNaN(NFloat value);
        public static bool IsNegative(NFloat value);
        public static bool IsNegativeInfinity(NFloat value);
        public static bool IsNormal(NFloat value);
        public static bool IsPositiveInfinity(NFloat value);
        public static bool IsSubnormal(NFloat value);
        public static NFloat Parse(string s);
        public static NFloat Parse(string s, NumberStyles style);
        public static NFloat Parse(string s, IFormatProvider provider);
        public static NFloat Parse(string s, NumberStyles style, IFormatProvider provider);
        public static NFloat Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(string s, out NFloat result);
        public static bool TryParse(ReadOnlySpan<char> s, out NFloat result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out NFloat result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out NFloat result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out NFloat result);
        public int CompareTo(object obj);
        public int CompareTo(NFloat other);
        public override bool Equals(object obj);
        public bool Equals(NFloat other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static bool IsPow2(NFloat value);
        public static NFloat Log2(NFloat value);
        public static NFloat Exp(NFloat x);
        public static NFloat ExpM1(NFloat x);
        public static NFloat Exp2(NFloat x);
        public static NFloat Exp2M1(NFloat x);
        public static NFloat Exp10(NFloat x);
        public static NFloat Exp10M1(NFloat x);
        public static NFloat Ceiling(NFloat x);
        public static NFloat Floor(NFloat x);
        public static NFloat Round(NFloat x);
        public static NFloat Round(NFloat x, int digits);
        public static NFloat Round(NFloat x, MidpointRounding mode);
        public static NFloat Round(NFloat x, int digits, MidpointRounding mode);
        public static NFloat Truncate(NFloat x);
        public static NFloat Atan2(NFloat y, NFloat x);
        public static NFloat Atan2Pi(NFloat y, NFloat x);
        public static NFloat BitDecrement(NFloat x);
        public static NFloat BitIncrement(NFloat x);
        public static NFloat FusedMultiplyAdd(NFloat left, NFloat right, NFloat addend);
        public static NFloat Ieee754Remainder(NFloat left, NFloat right);
        public static int ILogB(NFloat x);
        public static NFloat Lerp(NFloat value1, NFloat value2, NFloat amount);
        public static NFloat ReciprocalEstimate(NFloat x);
        public static NFloat ReciprocalSqrtEstimate(NFloat x);
        public static NFloat ScaleB(NFloat x, int n);
        public static NFloat Acosh(NFloat x);
        public static NFloat Asinh(NFloat x);
        public static NFloat Atanh(NFloat x);
        public static NFloat Cosh(NFloat x);
        public static NFloat Sinh(NFloat x);
        public static NFloat Tanh(NFloat x);
        public static NFloat Log(NFloat x);
        public static NFloat Log(NFloat x, NFloat newBase);
        public static NFloat LogP1(NFloat x);
        public static NFloat Log2P1(NFloat x);
        public static NFloat Log10(NFloat x);
        public static NFloat Log10P1(NFloat x);
        public static NFloat Clamp(NFloat value, NFloat min, NFloat max);
        public static NFloat CopySign(NFloat value, NFloat sign);
        public static NFloat Max(NFloat x, NFloat y);
        public static NFloat MaxNumber(NFloat x, NFloat y);
        public static NFloat Min(NFloat x, NFloat y);
        public static NFloat MinNumber(NFloat x, NFloat y);
        public static int Sign(NFloat value);
        public static NFloat Abs(NFloat value);
        public static NFloat CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static NFloat CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static NFloat CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(NFloat value);
        public static bool IsInteger(NFloat value);
        public static bool IsOddInteger(NFloat value);
        public static bool IsPositive(NFloat value);
        public static bool IsRealNumber(NFloat value);
        public static NFloat MaxMagnitude(NFloat x, NFloat y);
        public static NFloat MaxMagnitudeNumber(NFloat x, NFloat y);
        public static NFloat MinMagnitude(NFloat x, NFloat y);
        public static NFloat MinMagnitudeNumber(NFloat x, NFloat y);
        public static bool TryParse(string s, IFormatProvider provider, out NFloat result);
        public static NFloat Pow(NFloat x, NFloat y);
        public static NFloat Cbrt(NFloat x);
        public static NFloat Hypot(NFloat x, NFloat y);
        public static NFloat RootN(NFloat x, int n);
        public static NFloat Sqrt(NFloat x);
        public static NFloat Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out NFloat result);
        public static NFloat Acos(NFloat x);
        public static NFloat AcosPi(NFloat x);
        public static NFloat Asin(NFloat x);
        public static NFloat AsinPi(NFloat x);
        public static NFloat Atan(NFloat x);
        public static NFloat AtanPi(NFloat x);
        public static NFloat Cos(NFloat x);
        public static NFloat CosPi(NFloat x);
        public static NFloat DegreesToRadians(NFloat degrees);
        public static NFloat RadiansToDegrees(NFloat radians);
        public static NFloat Sin(NFloat x);
        public static (NFloat Sin, NFloat Cos) SinCos(NFloat x);
        public static (NFloat SinPi, NFloat CosPi) SinCosPi(NFloat x);
        public static NFloat SinPi(NFloat x);
        public static NFloat Tan(NFloat x);
        public static NFloat TanPi(NFloat x);
        public static NFloat Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out NFloat result);
        public static NFloat Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out NFloat result);

        public static NFloat operator +(NFloat value);
        public static NFloat operator -(NFloat value);
        public static NFloat operator ++(NFloat value);
        public static NFloat operator --(NFloat value);
        public static NFloat operator +(NFloat left, NFloat right);
        public static NFloat operator -(NFloat left, NFloat right);
        public static NFloat operator *(NFloat left, NFloat right);
        public static NFloat operator /(NFloat left, NFloat right);
        public static NFloat operator %(NFloat left, NFloat right);
        public static bool operator ==(NFloat left, NFloat right);
        public static bool operator !=(NFloat left, NFloat right);
        public static bool operator <(NFloat left, NFloat right);
        public static bool operator <=(NFloat left, NFloat right);
        public static bool operator >(NFloat left, NFloat right);
        public static bool operator >=(NFloat left, NFloat right);
        public static explicit operator checked byte(NFloat value);
        public static explicit operator checked char(NFloat value);
        public static explicit operator checked short(NFloat value);
        public static explicit operator checked int(NFloat value);
        public static explicit operator checked long(NFloat value);
        public static explicit operator checked Int128(NFloat value);
        public static explicit operator checked nint(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked sbyte(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked ushort(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked uint(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked ulong(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked UInt128(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator checked nuint(NFloat value);

        public static explicit operator NFloat(decimal value);
        public static explicit operator NFloat(double value);
        public static explicit operator byte(NFloat value);
        public static explicit operator char(NFloat value);
        public static explicit operator decimal(NFloat value);
        public static explicit operator Half(NFloat value);
        public static explicit operator short(NFloat value);
        public static explicit operator int(NFloat value);
        public static explicit operator long(NFloat value);
        public static explicit operator Int128(NFloat value);
        public static explicit operator nint(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator sbyte(NFloat value);
        public static explicit operator float(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator ushort(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator uint(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator ulong(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator UInt128(NFloat value);
        [CLSCompliant(False)]
        public static explicit operator nuint(NFloat value);
        public static implicit operator NFloat(byte value);
        public static implicit operator NFloat(char value);
        public static implicit operator NFloat(Half value);
        public static implicit operator NFloat(short value);
        public static implicit operator NFloat(int value);
        public static implicit operator NFloat(long value);
        public static explicit operator NFloat(Int128 value);
        public static implicit operator NFloat(nint value);
        [CLSCompliant(False)]
        public static implicit operator NFloat(sbyte value);
        public static implicit operator NFloat(float value);
        [CLSCompliant(False)]
        public static implicit operator NFloat(ushort value);
        [CLSCompliant(False)]
        public static implicit operator NFloat(uint value);
        [CLSCompliant(False)]
        public static implicit operator NFloat(ulong value);
        [CLSCompliant(False)]
        public static explicit operator NFloat(UInt128 value);
        [CLSCompliant(False)]
        public static implicit operator NFloat(nuint value);
        public static implicit operator double(NFloat value);
    }
}
