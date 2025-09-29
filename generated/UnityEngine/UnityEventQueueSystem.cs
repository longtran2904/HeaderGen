#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/UnityEvent/UnityEventQueueSystem.bindings.h")]
    public class UnityEventQueueSystem
    {

        public UnityEventQueueSystem();

        public static string GenerateEventIdForPayload(string eventPayloadName);
        [FreeFunction]
        public static nint GetGlobalEventQueue();
    }
}
