#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;
using System.Numerics;

namespace System
{
    public readonly struct Double : IAdditionOperators<double, double, double>, IAdditiveIdentity<double, double>, IBinaryFloatingPointIeee754<double>, IBinaryFloatParseAndFormatInfo<double>, IBinaryNumber<double>, IBitwiseOperators<double, double, double>, IComparable, IComparable<double>, IComparisonOperators<double, double, bool>, IConvertible, IDecrementOperators<double>, IDivisionOperators<double, double, double>, IEqualityOperators<double, double, bool>, IEquatable<double>, IExponentialFunctions<double>, IFloatingPoint<double>, IFloatingPointConstants<double>, IFloatingPointIeee754<double>, IFormattable, IHyperbolicFunctions<double>, IIncrementOperators<double>, ILogarithmicFunctions<double>, IMinMaxValue<double>, IModulusOperators<double, double, double>, IMultiplicativeIdentity<double, double>, IMultiplyOperators<double, double, double>, INumber<double>, INumberBase<double>, IParsable<double>, IPowerFunctions<double>, IRootFunctions<double>, ISignedNumber<double>, ISpanFormattable, ISpanParsable<double>, ISubtractionOperators<double, double, double>, ITrigonometricFunctions<double>, IUnaryNegationOperators<double, double>, IUnaryPlusOperators<double, double>, IUtf8SpanFormattable, IUtf8SpanParsable<double>
    {

        public const double MinValue = -1.7976931348623157E+308;
        public const double MaxValue = 1.7976931348623157E+308;
        public const double Epsilon = 5E-324;
        public const double NegativeInfinity = -∞;
        public const double PositiveInfinity = ∞;
        public const double NaN = NaN;
        public const double NegativeZero = -0;
        public const double E = 2.718281828459045;
        public const double Pi = 3.141592653589793;
        public const double Tau = 6.283185307179586;

        public static bool IsFinite(double d);
        public static bool IsInfinity(double d);
        public static bool IsNaN(double d);
        public static bool IsNegative(double d);
        public static bool IsNegativeInfinity(double d);
        public static bool IsNormal(double d);
        public static bool IsPositiveInfinity(double d);
        public static bool IsSubnormal(double d);
        public int CompareTo(object value);
        public int CompareTo(double value);
        public override bool Equals(object obj);
        public bool Equals(double obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(IFormatProvider provider);
        public string ToString(string format, IFormatProvider provider);
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null);
        public static double Parse(string s);
        public static double Parse(string s, NumberStyles style);
        public static double Parse(string s, IFormatProvider provider);
        public static double Parse(string s, NumberStyles style, IFormatProvider provider);
        public static double Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(string s, out double result);
        public static bool TryParse(ReadOnlySpan<char> s, out double result);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, out double result);
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result);
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out double result);
        public TypeCode GetTypeCode();
        public static bool IsPow2(double value);
        public static double Log2(double value);
        public static double Exp(double x);
        public static double ExpM1(double x);
        public static double Exp2(double x);
        public static double Exp2M1(double x);
        public static double Exp10(double x);
        public static double Exp10M1(double x);
        public static double Ceiling(double x);
        public static double Floor(double x);
        public static double Round(double x);
        public static double Round(double x, int digits);
        public static double Round(double x, MidpointRounding mode);
        public static double Round(double x, int digits, MidpointRounding mode);
        public static double Truncate(double x);
        public static double Atan2(double y, double x);
        public static double Atan2Pi(double y, double x);
        public static double BitDecrement(double x);
        public static double BitIncrement(double x);
        public static double FusedMultiplyAdd(double left, double right, double addend);
        public static double Ieee754Remainder(double left, double right);
        public static int ILogB(double x);
        public static double Lerp(double value1, double value2, double amount);
        public static double ReciprocalEstimate(double x);
        public static double ReciprocalSqrtEstimate(double x);
        public static double ScaleB(double x, int n);
        public static double Acosh(double x);
        public static double Asinh(double x);
        public static double Atanh(double x);
        public static double Cosh(double x);
        public static double Sinh(double x);
        public static double Tanh(double x);
        public static double Log(double x);
        public static double Log(double x, double newBase);
        public static double LogP1(double x);
        public static double Log2P1(double x);
        public static double Log10(double x);
        public static double Log10P1(double x);
        public static double Clamp(double value, double min, double max);
        public static double CopySign(double value, double sign);
        public static double Max(double x, double y);
        public static double MaxNumber(double x, double y);
        public static double Min(double x, double y);
        public static double MinNumber(double x, double y);
        public static int Sign(double value);
        public static double Abs(double value);
        public static double CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static double CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static double CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        public static bool IsEvenInteger(double value);
        public static bool IsInteger(double value);
        public static bool IsOddInteger(double value);
        public static bool IsPositive(double value);
        public static bool IsRealNumber(double value);
        public static double MaxMagnitude(double x, double y);
        public static double MaxMagnitudeNumber(double x, double y);
        public static double MinMagnitude(double x, double y);
        public static double MinMagnitudeNumber(double x, double y);
        public static bool TryParse(string s, IFormatProvider provider, out double result);
        public static double Pow(double x, double y);
        public static double Cbrt(double x);
        public static double Hypot(double x, double y);
        public static double RootN(double x, int n);
        public static double Sqrt(double x);
        public static double Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out double result);
        public static double Acos(double x);
        public static double AcosPi(double x);
        public static double Asin(double x);
        public static double AsinPi(double x);
        public static double Atan(double x);
        public static double AtanPi(double x);
        public static double Cos(double x);
        public static double CosPi(double x);
        public static double DegreesToRadians(double degrees);
        public static double RadiansToDegrees(double radians);
        public static double Sin(double x);
        public static (double Sin, double Cos) SinCos(double x);
        public static (double SinPi, double CosPi) SinCosPi(double x);
        public static double SinPi(double x);
        public static double Tan(double x);
        public static double TanPi(double x);
        public static double Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowThousands | NumberStyles.Float, IFormatProvider provider = null);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out double result);
        public static double Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out double result);

        public static bool operator ==(double left, double right);
        public static bool operator !=(double left, double right);
        public static bool operator <(double left, double right);
        public static bool operator >(double left, double right);
        public static bool operator <=(double left, double right);
        public static bool operator >=(double left, double right);
    }
}
