#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
    public readonly struct ValueTask : IEquatable<ValueTask>
    {

        public ValueTask(Task task);
        public ValueTask(IValueTaskSource source, short token);

        public static ValueTask CompletedTask { get; }
        public bool IsCompleted { get; }
        public bool IsCompletedSuccessfully { get; }
        public bool IsFaulted { get; }
        public bool IsCanceled { get; }

        public static ValueTask<TResult> FromResult<TResult>(TResult result);
        public static ValueTask FromCanceled(CancellationToken cancellationToken);
        public static ValueTask<TResult> FromCanceled<TResult>(CancellationToken cancellationToken);
        public static ValueTask FromException(Exception exception);
        public static ValueTask<TResult> FromException<TResult>(Exception exception);
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(ValueTask other);
        public Task AsTask();
        public ValueTask Preserve();
        public ValueTaskAwaiter GetAwaiter();
        public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext);

        public static bool operator ==(ValueTask left, ValueTask right);
        public static bool operator !=(ValueTask left, ValueTask right);
    }
}
