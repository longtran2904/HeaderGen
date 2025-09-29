#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.WSA
{
    [NativeHeader("Runtime/Export/WSA/WSAApplication.bindings.h")]
    [StaticAccessor("WSAApplicationBindings", StaticAccessorType.DoubleColon)]
    public sealed class Application
    {
        public Application();

        public static string arguments { get; }
        public static string advertisingIdentifier { get; }

        public static event WindowSizeChanged windowSizeChanged;
        public static event WindowActivated windowActivated;

        public static void InvokeOnAppThread(AppCallbackItem item, bool waitUntilDone);
        public static void InvokeOnUIThread(AppCallbackItem item, bool waitUntilDone);
        [ThreadAndSerializationSafe]
        public static bool RunningOnAppThread();
        [ThreadAndSerializationSafe]
        public static bool RunningOnUIThread();
    }
}
