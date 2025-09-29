#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Runtime/Camera/OcclusionCullingSettings.h")]
    [NativeHeader("Editor/Src/OcclusionCulling.h")]
    [NativeHeader("Runtime/Camera/RendererScene.h")]
    public static class StaticOcclusionCulling
    {

        public static bool isRunning { get; }
        [NativeProperty(TargetType = TargetType.Field)]
        [StaticAccessor("GetOcclusionCullingSettings()", StaticAccessorType.Dot)]
        public static float smallestOccluder { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        [StaticAccessor("GetOcclusionCullingSettings()", StaticAccessorType.Dot)]
        public static float smallestHole { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        [StaticAccessor("GetOcclusionCullingSettings()", StaticAccessorType.Dot)]
        public static float backfaceThreshold { get; set; }
        public static bool doesSceneHaveManualPortals { get; }
        [StaticAccessor("GetRendererScene()", StaticAccessorType.Dot)]
        public static int umbraDataSize { get; }

        [NativeName("GenerateTome")]
        public static bool Compute();
        [NativeName("GenerateTomeInBackground")]
        public static bool GenerateInBackground();
        [NativeName("RemoveTempFolder")]
        public static void RemoveCacheFolder();
        public static void Cancel();
        [NativeName("ClearUmbraTome")]
        public static void Clear();
        [StaticAccessor("GetOcclusionCullingSettings()", StaticAccessorType.Dot)]
        public static void SetDefaultOcclusionBakeSettings();
    }
}
