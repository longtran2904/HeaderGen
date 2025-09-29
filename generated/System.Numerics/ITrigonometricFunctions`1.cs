#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface ITrigonometricFunctions<TSelf> : IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IFloatingPointConstants<TSelf>, IFormattable, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IParsable<TSelf>, ISpanFormattable, ISpanParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : ITrigonometricFunctions<TSelf>
    {

        TSelf Acos(TSelf x);
        TSelf AcosPi(TSelf x);
        TSelf Asin(TSelf x);
        TSelf AsinPi(TSelf x);
        TSelf Atan(TSelf x);
        TSelf AtanPi(TSelf x);
        TSelf Cos(TSelf x);
        TSelf CosPi(TSelf x);
        TSelf DegreesToRadians(TSelf degrees);
        TSelf RadiansToDegrees(TSelf radians);
        TSelf Sin(TSelf x);
        (TSelf Sin, TSelf Cos) SinCos(TSelf x);
        (TSelf SinPi, TSelf CosPi) SinCosPi(TSelf x);
        TSelf SinPi(TSelf x);
        TSelf Tan(TSelf x);
        TSelf TanPi(TSelf x);
    }
}
