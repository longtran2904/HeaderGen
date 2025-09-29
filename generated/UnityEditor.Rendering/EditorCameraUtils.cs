#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Rendering
{
    [NativeHeader("Editor/Src/Camera/EditorCameraUtils.h")]
    [RequiredByNativeCode]
    public static class EditorCameraUtils
    {
        public static bool RenderToCubemap(this Camera camera, Texture target, int faceMask, StaticEditorFlags culledFlags);
    }
}
