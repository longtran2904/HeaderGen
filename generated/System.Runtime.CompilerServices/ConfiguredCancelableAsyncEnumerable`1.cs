#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;

namespace System.Runtime.CompilerServices
{
    public readonly struct ConfiguredCancelableAsyncEnumerable<T>
    {
        public ConfiguredCancelableAsyncEnumerable<T> ConfigureAwait(bool continueOnCapturedContext);
        public ConfiguredCancelableAsyncEnumerable<T> WithCancellation(CancellationToken cancellationToken);
        public Enumerator GetAsyncEnumerator();

        public readonly struct Enumerator
        {
            public T Current { get; }

            public ConfiguredValueTaskAwaitable<bool> MoveNextAsync();
            public ConfiguredValueTaskAwaitable DisposeAsync();
        }
    }
}
