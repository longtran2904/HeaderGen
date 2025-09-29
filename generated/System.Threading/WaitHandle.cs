#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
    public abstract class WaitHandle : MarshalByRefObject, IDisposable
    {

        protected static readonly nint InvalidHandle;
        public const int WaitTimeout = 258;

        protected WaitHandle();

        [Obsolete("WaitHandle.Handle has been deprecated. Use the SafeWaitHandle property instead.")]
        public virtual nint Handle { get; set; }
        public SafeWaitHandle SafeWaitHandle { get; set; }

        public virtual void Close();
        protected virtual void Dispose(bool explicitDisposing);
        public void Dispose();
        public virtual bool WaitOne(int millisecondsTimeout);
        public virtual bool WaitOne(TimeSpan timeout);
        public virtual bool WaitOne();
        public virtual bool WaitOne(int millisecondsTimeout, bool exitContext);
        public virtual bool WaitOne(TimeSpan timeout, bool exitContext);
        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout);
        public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout);
        public static bool WaitAll(WaitHandle[] waitHandles);
        public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext);
        public static bool WaitAll(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext);
        public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout);
        public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout);
        public static int WaitAny(WaitHandle[] waitHandles);
        public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext);
        public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext);
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn);
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, TimeSpan timeout, bool exitContext);
        public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext);
    }
}
