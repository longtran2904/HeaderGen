#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Globalization;

namespace System.Numerics
{
    public interface INumberBase<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFormattable, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, IParsable<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : INumberBase<TSelf>
    {

        TSelf One { get; }
        int Radix { get; }
        TSelf Zero { get; }

        TSelf Abs(TSelf value);
        TSelf CreateChecked<TOther>(TOther value) where TOther : INumberBase<TOther>;
        TSelf CreateSaturating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        TSelf CreateTruncating<TOther>(TOther value) where TOther : INumberBase<TOther>;
        bool IsCanonical(TSelf value);
        bool IsComplexNumber(TSelf value);
        bool IsEvenInteger(TSelf value);
        bool IsFinite(TSelf value);
        bool IsImaginaryNumber(TSelf value);
        bool IsInfinity(TSelf value);
        bool IsInteger(TSelf value);
        bool IsNaN(TSelf value);
        bool IsNegative(TSelf value);
        bool IsNegativeInfinity(TSelf value);
        bool IsNormal(TSelf value);
        bool IsOddInteger(TSelf value);
        bool IsPositive(TSelf value);
        bool IsPositiveInfinity(TSelf value);
        bool IsRealNumber(TSelf value);
        bool IsSubnormal(TSelf value);
        bool IsZero(TSelf value);
        TSelf MaxMagnitude(TSelf x, TSelf y);
        TSelf MaxMagnitudeNumber(TSelf x, TSelf y);
        TSelf MinMagnitude(TSelf x, TSelf y);
        TSelf MinMagnitudeNumber(TSelf x, TSelf y);
        TSelf Parse(string s, NumberStyles style, IFormatProvider provider);
        TSelf Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider);
        TSelf Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider);
        bool TryConvertFromChecked<TOther>(TOther value, out TSelf result) where TOther : INumberBase<TOther>;
        bool TryConvertFromSaturating<TOther>(TOther value, out TSelf result) where TOther : INumberBase<TOther>;
        bool TryConvertFromTruncating<TOther>(TOther value, out TSelf result) where TOther : INumberBase<TOther>;
        bool TryConvertToChecked<TOther>(TSelf value, out TOther result) where TOther : INumberBase<TOther>;
        bool TryConvertToSaturating<TOther>(TSelf value, out TOther result) where TOther : INumberBase<TOther>;
        bool TryConvertToTruncating<TOther>(TSelf value, out TOther result) where TOther : INumberBase<TOther>;
        bool TryParse(string s, NumberStyles style, IFormatProvider provider, out TSelf result);
        bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out TSelf result);
        bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, IFormatProvider provider, out TSelf result);
    }
}
