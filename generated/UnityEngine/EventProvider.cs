#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/ETW/EventProvider.bindings.h")]
    public sealed class EventProvider
    {

        public EventProvider();

        [FreeFunction("EventProvider_Bindings::WriteCustomEvent")]
        public static void WriteCustomEvent(int value, string text);
    }
}
