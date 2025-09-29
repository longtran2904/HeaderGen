#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/OcclusionCullingVisualizationState.h")]
    [NativeHeader("Runtime/Camera/Camera.h")]
    [StaticAccessor("GetOcclusionCullingVisualization()", StaticAccessorType.Arrow)]
    public static class StaticOcclusionCullingVisualization
    {
        public static bool showOcclusionCulling { get; set; }
        [NativeName("ShowPreVis")]
        public static bool showPreVisualization { get; set; }
        public static bool showViewVolumes { get; set; }
        public static bool showDynamicObjectBounds { get; set; }
        public static bool showPortals { get; set; }
        public static bool showVisibilityLines { get; set; }
        public static bool showGeometryCulling { get; set; }
        public static bool isPreviewOcclusionCullingCameraInPVS { get; }
        public static Camera previewOcclusionCamera { get; }
        public static Camera previewOcclucionCamera { get; }
    }
}
