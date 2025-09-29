#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion, IStateMachineBoxAwareAwaiter
    {

        public bool IsCompleted { get; }

        public TResult GetResult();
        public void OnCompleted(Action continuation);
        public void UnsafeOnCompleted(Action continuation);
    }
}
