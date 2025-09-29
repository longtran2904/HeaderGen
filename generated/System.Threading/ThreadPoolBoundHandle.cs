#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Threading
{
    public sealed class ThreadPoolBoundHandle : IDeferredDisposable, IDisposable
    {

        ~ThreadPoolBoundHandle();

        public SafeHandle Handle { get; }

        public static ThreadPoolBoundHandle BindHandle(SafeHandle handle);
        [CLSCompliant(False)]
        public NativeOverlapped* AllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData);
        [CLSCompliant(False)]
        public NativeOverlapped* UnsafeAllocateNativeOverlapped(IOCompletionCallback callback, object state, object pinData);
        [CLSCompliant(False)]
        public NativeOverlapped* AllocateNativeOverlapped(PreAllocatedOverlapped preAllocated);
        [CLSCompliant(False)]
        public void FreeNativeOverlapped(NativeOverlapped* overlapped);
        [CLSCompliant(False)]
        public static object GetNativeOverlappedState(NativeOverlapped* overlapped);
        public void Dispose();
    }
}
