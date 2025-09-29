#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public struct SpinLock
    {

        public SpinLock(bool enableThreadOwnerTracking);

        public bool IsHeld { get; }
        public bool IsHeldByCurrentThread { get; }
        public bool IsThreadOwnerTrackingEnabled { get; }

        public void Enter(ref bool lockTaken);
        public void TryEnter(ref bool lockTaken);
        public void TryEnter(TimeSpan timeout, ref bool lockTaken);
        public void TryEnter(int millisecondsTimeout, ref bool lockTaken);
        public void Exit();
        public void Exit(bool useMemoryBarrier);
    }
}
