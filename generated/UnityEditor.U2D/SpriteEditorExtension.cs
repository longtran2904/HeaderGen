#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.U2D
{
    [NativeHeader("Editor/Src/2D/SpriteEditorExtension.h")]
    public static class SpriteEditorExtension
    {
        public static GUID GetSpriteID(this Sprite sprite);
        public static void SetSpriteID(this Sprite sprite, GUID guid);
    }
}
