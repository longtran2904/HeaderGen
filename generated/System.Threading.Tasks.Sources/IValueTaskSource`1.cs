#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading.Tasks.Sources
{
    public interface IValueTaskSource<TResult>
    {
        ValueTaskSourceStatus GetStatus(short token);
        void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
        TResult GetResult(short token);
    }
}
