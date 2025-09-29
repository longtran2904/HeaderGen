#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading.Tasks;

namespace System.Threading
{
    public class CancellationTokenSource : IDisposable
    {

        public CancellationTokenSource();
        public CancellationTokenSource(TimeSpan delay);
        public CancellationTokenSource(TimeSpan delay, TimeProvider timeProvider);
        public CancellationTokenSource(int millisecondsDelay);

        public bool IsCancellationRequested { get; }
        public CancellationToken Token { get; }

        public void Cancel();
        public void Cancel(bool throwOnFirstException);
        public Task CancelAsync();
        public void CancelAfter(TimeSpan delay);
        public void CancelAfter(int millisecondsDelay);
        public bool TryReset();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2);
        public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token);
        public static CancellationTokenSource CreateLinkedTokenSource(params CancellationToken[] tokens);
    }
}
