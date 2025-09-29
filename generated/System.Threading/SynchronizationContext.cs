#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public class SynchronizationContext
    {

        public SynchronizationContext();

        public static SynchronizationContext Current { get; }

        protected void SetWaitNotificationRequired();
        public bool IsWaitNotificationRequired();
        public virtual void Send(SendOrPostCallback d, object state);
        public virtual void Post(SendOrPostCallback d, object state);
        public virtual void OperationStarted();
        public virtual void OperationCompleted();
        [CLSCompliant(False)]
        public virtual int Wait(nint[] waitHandles, bool waitAll, int millisecondsTimeout);
        [CLSCompliant(False)]
        protected static int WaitHelper(nint[] waitHandles, bool waitAll, int millisecondsTimeout);
        public static void SetSynchronizationContext(SynchronizationContext syncContext);
        public virtual SynchronizationContext CreateCopy();
    }
}
