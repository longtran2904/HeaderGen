#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public struct PoolingAsyncValueTaskMethodBuilder<TResult>
    {

        public ValueTask<TResult> Task { get; }

        public static PoolingAsyncValueTaskMethodBuilder<TResult> Create();
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine;
        public void SetStateMachine(IAsyncStateMachine stateMachine);
        public void SetResult(TResult result);
        public void SetException(Exception exception);
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine;
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine;
    }
}
