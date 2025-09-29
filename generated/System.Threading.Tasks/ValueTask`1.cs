#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace System.Threading.Tasks
{
    public readonly struct ValueTask<TResult> : IEquatable<ValueTask<TResult>>
    {

        public ValueTask(TResult result);
        public ValueTask(Task<TResult> task);
        public ValueTask(IValueTaskSource<TResult> source, short token);

        public bool IsCompleted { get; }
        public bool IsCompletedSuccessfully { get; }
        public bool IsFaulted { get; }
        public bool IsCanceled { get; }
        public TResult Result { get; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(ValueTask<TResult> other);
        public Task<TResult> AsTask();
        public ValueTask<TResult> Preserve();
        public ValueTaskAwaiter<TResult> GetAwaiter();
        public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext);
        public override string ToString();

        public static bool operator ==(ValueTask<TResult> left, ValueTask<TResult> right);
        public static bool operator !=(ValueTask<TResult> left, ValueTask<TResult> right);
    }
}
