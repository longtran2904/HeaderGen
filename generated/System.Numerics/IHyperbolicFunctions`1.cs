#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface IHyperbolicFunctions<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFloatingPointConstants<TSelf>, IFormattable, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IParsable<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IHyperbolicFunctions<TSelf>
    {

        TSelf Acosh(TSelf x);
        TSelf Asinh(TSelf x);
        TSelf Atanh(TSelf x);
        TSelf Cosh(TSelf x);
        TSelf Sinh(TSelf x);
        TSelf Tanh(TSelf x);
    }
}
