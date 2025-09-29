#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/EditorUserSettings.h")]
    [StaticAccessor("GetEditorUserSettings()", StaticAccessorType.Dot)]
    public sealed class EditorUserSettings : UnityEngine.Object
    {

        [NativeProperty("VCAutomaticAdd")]
        public static bool AutomaticAdd { get; set; }
        [NativeProperty("VCWorkOffline")]
        public static bool WorkOffline { get; set; }
        [NativeProperty("VCShowFailedCheckout")]
        public static bool showFailedCheckout { get; set; }
        [NativeProperty("VCOverwriteFailedCheckoutAssets")]
        public static bool overwriteFailedCheckoutAssets { get; set; }
        [NativeProperty("VCProjectOverlayIcons")]
        public static bool overlayIcons { get; set; }
        [NativeProperty("VCHierarchyOverlayIcons")]
        public static bool hierarchyOverlayIcons { get; set; }
        [NativeProperty("VCOtherOverlayIcons")]
        public static bool otherOverlayIcons { get; set; }
        [NativeProperty("VCAllowAsyncUpdate")]
        public static bool allowAsyncStatusUpdate { get; set; }
        [NativeProperty("ArtifactGarbageCollection")]
        public static bool artifactGarbageCollection { get; set; }
        public static SemanticMergeMode semanticMergeMode { get; set; }
        public static int desiredImportWorkerCount { get; set; }
        public static int standbyImportWorkerCount { get; set; }
        public static int idleImportWorkerShutdownDelayMilliseconds { get; set; }

        public static string GetConfigValue(string name);
        public static void SetConfigValue(string name, string value);
    }
}
