#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Runtime.InteropServices.ObjectiveC
{
    [CLSCompliant(False)]
    [SupportedOSPlatform("macos")]
    public static class ObjectiveCMarshal
    {

        public static void Initialize(delegate* unmanaged<void> beginEndCallback, delegate* unmanaged<nint, int> isReferencedCallback, delegate* unmanaged<nint, void> trackedObjectEnteredFinalization, UnhandledExceptionPropagationHandler unhandledExceptionPropagationHandler);
        public static GCHandle CreateReferenceTrackingHandle(object obj, out Span<nint> taggedMemory);
        public static void SetMessageSendCallback(MessageSendFunction msgSendFunction, nint func);
        public static void SetMessageSendPendingException(Exception exception);
        public delegate delegate* unmanaged<nint, void> UnhandledExceptionPropagationHandler(Exception exception, RuntimeMethodHandle lastMethod, out nint context);
        public enum MessageSendFunction
        {

            MsgSend = 0,
            MsgSendFpret = 1,
            MsgSendStret = 2,
            MsgSendSuper = 3,
            MsgSendSuperStret = 4
        }
    }
}
