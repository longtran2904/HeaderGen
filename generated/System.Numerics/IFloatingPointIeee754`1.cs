#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface IFloatingPointIeee754<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IExponentialFunctions<TSelf>, IFloatingPoint<TSelf>, IFloatingPointConstants<TSelf>, IFormattable, IHyperbolicFunctions<TSelf>, IIncrementOperators<TSelf>, ILogarithmicFunctions<TSelf>, IModulusOperators<TSelf, TSelf, TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, INumberBase<TSelf>, IParsable<TSelf>, IPowerFunctions<TSelf>, IRootFunctions<TSelf>, ISignedNumber<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, ITrigonometricFunctions<TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IFloatingPointIeee754<TSelf>
    {
        TSelf Epsilon { get; }
        TSelf NaN { get; }
        TSelf NegativeInfinity { get; }
        TSelf NegativeZero { get; }
        TSelf PositiveInfinity { get; }

        TSelf Atan2(TSelf y, TSelf x);
        TSelf Atan2Pi(TSelf y, TSelf x);
        TSelf BitDecrement(TSelf x);
        TSelf BitIncrement(TSelf x);
        TSelf FusedMultiplyAdd(TSelf left, TSelf right, TSelf addend);
        TSelf Ieee754Remainder(TSelf left, TSelf right);
        int ILogB(TSelf x);
        TSelf Lerp(TSelf value1, TSelf value2, TSelf amount);
        TSelf ReciprocalEstimate(TSelf x);
        TSelf ReciprocalSqrtEstimate(TSelf x);
        TSelf ScaleB(TSelf x, int n);
    }
}
