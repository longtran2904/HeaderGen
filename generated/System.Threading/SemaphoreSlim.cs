#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace System.Threading
{
    public class SemaphoreSlim : IDisposable
    {

        public SemaphoreSlim(int initialCount);
        public SemaphoreSlim(int initialCount, int maxCount);

        public int CurrentCount { get; }
        public WaitHandle AvailableWaitHandle { get; }

        [UnsupportedOSPlatform("browser")]
        public void Wait();
        [UnsupportedOSPlatform("browser")]
        public void Wait(CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public bool Wait(TimeSpan timeout);
        [UnsupportedOSPlatform("browser")]
        public bool Wait(TimeSpan timeout, CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public bool Wait(int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken);
        public Task WaitAsync();
        public Task WaitAsync(CancellationToken cancellationToken);
        public Task<bool> WaitAsync(int millisecondsTimeout);
        public Task<bool> WaitAsync(TimeSpan timeout);
        public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken);
        public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken);
        public int Release();
        public int Release(int releaseCount);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
