#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;

namespace System.Threading
{
    public sealed class ReaderWriterLock : CriticalFinalizerObject
    {
        public ReaderWriterLock();

        public bool IsReaderLockHeld { get; }
        public bool IsWriterLockHeld { get; }
        public int WriterSeqNum { get; }

        public bool AnyWritersSince(int seqNum);
        [UnsupportedOSPlatform("browser")]
        public void AcquireReaderLock(int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public void AcquireReaderLock(TimeSpan timeout);
        public void AcquireWriterLock(int millisecondsTimeout);
        public void AcquireWriterLock(TimeSpan timeout);
        public void ReleaseReaderLock();
        public void ReleaseWriterLock();
        [UnsupportedOSPlatform("browser")]
        public LockCookie UpgradeToWriterLock(int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public LockCookie UpgradeToWriterLock(TimeSpan timeout);
        public void DowngradeFromWriterLock(ref LockCookie lockCookie);
        public LockCookie ReleaseLock();
        [UnsupportedOSPlatform("browser")]
        public void RestoreLock(ref LockCookie lockCookie);
    }
}
