#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System.Threading
{
    public static class ThreadPool
    {

        public static long PendingWorkItemCount { get; }
        public static int ThreadCount { get; }
        public static long CompletedWorkItemCount { get; }

        [CLSCompliant(False)]
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce);
        [CLSCompliant(False)]
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce);
        [UnsupportedOSPlatform("browser")]
        public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce);
        public static bool QueueUserWorkItem(WaitCallback callBack);
        public static bool QueueUserWorkItem(WaitCallback callBack, object state);
        public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal);
        public static bool UnsafeQueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal);
        public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state);
        public static bool UnsafeQueueUserWorkItem(IThreadPoolWorkItem callBack, bool preferLocal);
        [CLSCompliant(False)]
        [SupportedOSPlatform("windows")]
        public static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped);
        [Obsolete("ThreadPool.BindHandle(IntPtr) has been deprecated. Use ThreadPool.BindHandle(SafeHandle) instead.")]
        [SupportedOSPlatform("windows")]
        public static bool BindHandle(nint osHandle);
        [SupportedOSPlatform("windows")]
        public static bool BindHandle(SafeHandle osHandle);
        public static bool SetMaxThreads(int workerThreads, int completionPortThreads);
        public static void GetMaxThreads(out int workerThreads, out int completionPortThreads);
        public static bool SetMinThreads(int workerThreads, int completionPortThreads);
        public static void GetMinThreads(out int workerThreads, out int completionPortThreads);
        public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads);
    }
}
