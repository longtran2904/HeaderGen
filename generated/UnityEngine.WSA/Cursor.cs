#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.WSA
{
    [NativeConditional("PLATFORM_WINRT")]
    [NativeHeader("PlatformDependent/MetroPlayer/MetroCursor.h")]
    public static class Cursor
    {
        [FreeFunction("Cursors::SetHardwareCursor")]
        public static void SetCustomCursor(uint id);
    }
}
