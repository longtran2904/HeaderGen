#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
    public class Cursor
    {

        public Cursor();

        public static bool visible { get; set; }
        public static CursorLockMode lockState { get; set; }

        public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode);
    }
}
