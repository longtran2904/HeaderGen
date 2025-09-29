#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Threading.Tasks
{
    public class TaskCompletionSource<TResult>
    {
        public TaskCompletionSource();
        public TaskCompletionSource(TaskCreationOptions creationOptions);
        public TaskCompletionSource(object state);
        public TaskCompletionSource(object state, TaskCreationOptions creationOptions);

        public Task<TResult> Task { get; }

        public void SetException(Exception exception);
        public void SetException(IEnumerable<Exception> exceptions);
        public bool TrySetException(Exception exception);
        public bool TrySetException(IEnumerable<Exception> exceptions);
        public void SetResult(TResult result);
        public bool TrySetResult(TResult result);
        public void SetCanceled();
        public void SetCanceled(CancellationToken cancellationToken);
        public bool TrySetCanceled();
        public bool TrySetCanceled(CancellationToken cancellationToken);
    }
}
