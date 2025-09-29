#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading.Tasks.Sources
{
    public struct ManualResetValueTaskSourceCore<TResult>
    {

        public bool RunContinuationsAsynchronously { get; set; }
        public short Version { get; }

        public void Reset();
        public void SetResult(TResult result);
        public void SetException(Exception error);
        public ValueTaskSourceStatus GetStatus(short token);
        public TResult GetResult(short token);
        public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
    }
}
