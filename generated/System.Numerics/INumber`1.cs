#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface INumber<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFormattable, IIncrementOperators<TSelf>, IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IParsable<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : INumber<TSelf>
    {

        TSelf Clamp(TSelf value, TSelf min, TSelf max);
        TSelf CopySign(TSelf value, TSelf sign);
        TSelf Max(TSelf x, TSelf y);
        TSelf MaxNumber(TSelf x, TSelf y);
        TSelf Min(TSelf x, TSelf y);
        TSelf MinNumber(TSelf x, TSelf y);
        int Sign(TSelf value);
    }
}
