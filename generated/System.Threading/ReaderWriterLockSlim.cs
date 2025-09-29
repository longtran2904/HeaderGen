#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public class ReaderWriterLockSlim : IDisposable
    {

        public ReaderWriterLockSlim();
        public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy);

        public bool IsReadLockHeld { get; }
        public bool IsUpgradeableReadLockHeld { get; }
        public bool IsWriteLockHeld { get; }
        public LockRecursionPolicy RecursionPolicy { get; }
        public int CurrentReadCount { get; }
        public int RecursiveReadCount { get; }
        public int RecursiveUpgradeCount { get; }
        public int RecursiveWriteCount { get; }
        public int WaitingReadCount { get; }
        public int WaitingUpgradeCount { get; }
        public int WaitingWriteCount { get; }

        public void EnterReadLock();
        public bool TryEnterReadLock(TimeSpan timeout);
        public bool TryEnterReadLock(int millisecondsTimeout);
        public void EnterWriteLock();
        public bool TryEnterWriteLock(TimeSpan timeout);
        public bool TryEnterWriteLock(int millisecondsTimeout);
        public void EnterUpgradeableReadLock();
        public bool TryEnterUpgradeableReadLock(TimeSpan timeout);
        public bool TryEnterUpgradeableReadLock(int millisecondsTimeout);
        public void ExitReadLock();
        public void ExitWriteLock();
        public void ExitUpgradeableReadLock();
        public void Dispose();
    }
}
