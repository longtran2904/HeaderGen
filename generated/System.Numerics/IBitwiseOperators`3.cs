#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface IBitwiseOperators<TSelf, TOther, TResult> where TSelf : IBitwiseOperators<TSelf, TOther, TResult>
    {

        TResult operator &(TSelf left, TOther right);
        TResult operator |(TSelf left, TOther right);
        TResult operator ^(TSelf left, TOther right);
        TResult operator ~(TSelf value);
    }
}
