#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public class ManualResetEventSlim : IDisposable
    {
        public ManualResetEventSlim();
        public ManualResetEventSlim(bool initialState);
        public ManualResetEventSlim(bool initialState, int spinCount);

        public WaitHandle WaitHandle { get; }
        public bool IsSet { get; }
        public int SpinCount { get; }

        public void Set();
        public void Reset();
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
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
