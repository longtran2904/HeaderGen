#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface IBinaryInteger<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IBinaryNumber<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFormattable, IIncrementOperators<TSelf>, IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, INumberBase<TSelf>, IParsable<TSelf>, IShiftOperators<TSelf, int, TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IBinaryInteger<TSelf>
    {

        (TSelf Quotient, TSelf Remainder) DivRem(TSelf left, TSelf right);
        TSelf LeadingZeroCount(TSelf value);
        TSelf PopCount(TSelf value);
        TSelf ReadBigEndian(byte[] source, bool isUnsigned);
        TSelf ReadBigEndian(byte[] source, int startIndex, bool isUnsigned);
        TSelf ReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned);
        TSelf ReadLittleEndian(byte[] source, bool isUnsigned);
        TSelf ReadLittleEndian(byte[] source, int startIndex, bool isUnsigned);
        TSelf ReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned);
        TSelf RotateLeft(TSelf value, int rotateAmount);
        TSelf RotateRight(TSelf value, int rotateAmount);
        TSelf TrailingZeroCount(TSelf value);
        bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out TSelf value);
        bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out TSelf value);
        int GetByteCount();
        int GetShortestBitLength();
        bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten);
        bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten);
        int WriteBigEndian(byte[] destination);
        int WriteBigEndian(byte[] destination, int startIndex);
        int WriteBigEndian(Span<byte> destination);
        int WriteLittleEndian(byte[] destination);
        int WriteLittleEndian(byte[] destination, int startIndex);
        int WriteLittleEndian(Span<byte> destination);
    }
}
