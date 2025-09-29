#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public class Overlapped
    {

        public Overlapped();
        public Overlapped(int offsetLo, int offsetHi, nint hEvent, IAsyncResult ar);
        [Obsolete("This constructor is not 64-bit compatible and has been deprecated. Use the constructor that accepts an IntPtr for the event handle instead.")]
        public Overlapped(int offsetLo, int offsetHi, int hEvent, IAsyncResult ar);

        public IAsyncResult AsyncResult { get; set; }
        public int OffsetLow { get; set; }
        public int OffsetHigh { get; set; }
        [Obsolete("Overlapped.EventHandle is not 64-bit compatible and has been deprecated. Use EventHandleIntPtr instead.")]
        public int EventHandle { get; set; }
        public nint EventHandleIntPtr { get; set; }

        [CLSCompliant(False)]
        [Obsolete("This overload is not safe and has been deprecated. Use Pack(IOCompletionCallback?, object?) instead.")]
        public NativeOverlapped* Pack(IOCompletionCallback iocb);
        [CLSCompliant(False)]
        public NativeOverlapped* Pack(IOCompletionCallback iocb, object userData);
        [CLSCompliant(False)]
        [Obsolete("This overload is not safe and has been deprecated. Use UnsafePack(IOCompletionCallback?, object?) instead.")]
        public NativeOverlapped* UnsafePack(IOCompletionCallback iocb);
        [CLSCompliant(False)]
        public NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData);
        [CLSCompliant(False)]
        public static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr);
        [CLSCompliant(False)]
        public static void Free(NativeOverlapped* nativeOverlappedPtr);
    }
}
