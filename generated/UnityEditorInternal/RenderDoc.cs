#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor;
using UnityEngine.Bindings;

namespace UnityEditorInternal
{
    [NativeHeader("Editor/Src/RenderDoc/RenderDoc.h")]
    [StaticAccessor("RenderDoc", StaticAccessorType.DoubleColon)]
    public static class RenderDoc
    {

        public static bool IsInstalled();
        public static bool IsLoaded();
        public static bool IsSupported();
        public static void Load();
        public static void BeginCaptureRenderDoc(EditorWindow window);
        public static void EndCaptureRenderDoc(EditorWindow window);
    }
}
