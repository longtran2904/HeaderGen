#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface IFloatingPoint<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFloatingPointConstants<TSelf>, IFormattable, IIncrementOperators<TSelf>, IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, INumberBase<TSelf>, IParsable<TSelf>, ISignedNumber<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IFloatingPoint<TSelf>
    {
        TSelf Ceiling(TSelf x);
        TSelf Floor(TSelf x);
        TSelf Round(TSelf x);
        TSelf Round(TSelf x, int digits);
        TSelf Round(TSelf x, MidpointRounding mode);
        TSelf Round(TSelf x, int digits, MidpointRounding mode);
        TSelf Truncate(TSelf x);
        int GetExponentByteCount();
        int GetExponentShortestBitLength();
        int GetSignificandBitLength();
        int GetSignificandByteCount();
        bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten);
        bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten);
        bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten);
        bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten);
        int WriteExponentBigEndian(byte[] destination);
        int WriteExponentBigEndian(byte[] destination, int startIndex);
        int WriteExponentBigEndian(Span<byte> destination);
        int WriteExponentLittleEndian(byte[] destination);
        int WriteExponentLittleEndian(byte[] destination, int startIndex);
        int WriteExponentLittleEndian(Span<byte> destination);
        int WriteSignificandBigEndian(byte[] destination);
        int WriteSignificandBigEndian(byte[] destination, int startIndex);
        int WriteSignificandBigEndian(Span<byte> destination);
        int WriteSignificandLittleEndian(byte[] destination);
        int WriteSignificandLittleEndian(byte[] destination, int startIndex);
        int WriteSignificandLittleEndian(Span<byte> destination);
    }
}
