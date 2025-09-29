#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public interface ISubtractionOperators<TSelf, TOther, TResult> where TSelf : ISubtractionOperators<TSelf, TOther, TResult>
    {

        TResult operator -(TSelf left, TOther right);
        TResult operator checked -(TSelf left, TOther right);
    }
}
