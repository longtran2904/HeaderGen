#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public class CountdownEvent : IDisposable
    {

        public CountdownEvent(int initialCount);

        public int CurrentCount { get; }
        public int InitialCount { get; }
        public bool IsSet { get; }
        public WaitHandle WaitHandle { get; }

        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public bool Signal();
        public bool Signal(int signalCount);
        public void AddCount();
        public bool TryAddCount();
        public void AddCount(int signalCount);
        public bool TryAddCount(int signalCount);
        public void Reset();
        public void Reset(int count);
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
    }
}
