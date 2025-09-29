#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/QualitySettings.h")]
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    [StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
    public sealed class QualitySettings : Object
    {
        [Obsolete("Use GetQualityLevel and SetQualityLevel", False)]
        public static QualityLevel currentLevel { get; set; }
        public static int pixelLightCount { get; set; }
        [NativeProperty("ShadowQuality")]
        public static ShadowQuality shadows { get; set; }
        public static ShadowProjection shadowProjection { get; set; }
        public static int shadowCascades { get; set; }
        public static float shadowDistance { get; set; }
        [NativeProperty("ShadowResolution")]
        public static ShadowResolution shadowResolution { get; set; }
        [NativeProperty("ShadowmaskMode")]
        public static ShadowmaskMode shadowmaskMode { get; set; }
        public static float shadowNearPlaneOffset { get; set; }
        public static float shadowCascade2Split { get; set; }
        public static Vector3 shadowCascade4Split { get; set; }
        [NativeProperty("LODBias")]
        public static float lodBias { get; set; }
        [NativeProperty("AnisotropicTextures")]
        public static AnisotropicFiltering anisotropicFiltering { get; set; }
        public static int masterTextureLimit { get; set; }
        public static int maximumLODLevel { get; set; }
        public static int particleRaycastBudget { get; set; }
        public static bool softParticles { get; set; }
        public static bool softVegetation { get; set; }
        public static int vSyncCount { get; set; }
        public static int realtimeGICPUUsage { get; set; }
        public static int antiAliasing { get; set; }
        public static int asyncUploadTimeSlice { get; set; }
        public static int asyncUploadBufferSize { get; set; }
        public static bool asyncUploadPersistentBuffer { get; set; }
        public static bool realtimeReflectionProbes { get; set; }
        public static bool billboardsFaceCameraPosition { get; set; }
        public static float resolutionScalingFixedDPIFactor { get; set; }
        public static RenderPipelineAsset renderPipeline { get; set; }
        [Obsolete("blendWeights is obsolete. Use skinWeights instead (UnityUpgradable) -> skinWeights", True)]
        public static BlendWeights blendWeights { get; set; }
        public static SkinWeights skinWeights { get; set; }
        public static bool streamingMipmapsActive { get; set; }
        public static float streamingMipmapsMemoryBudget { get; set; }
        public static int streamingMipmapsRenderersPerFrame { get; set; }
        public static int streamingMipmapsMaxLevelReduction { get; set; }
        public static bool streamingMipmapsAddAllCameras { get; set; }
        public static int streamingMipmapsMaxFileIORequests { get; set; }
        [StaticAccessor("QualitySettingsScripting", StaticAccessorType.DoubleColon)]
        public static int maxQueuedFrames { get; set; }
        [NativeProperty("QualitySettingsNames")]
        public static string[] names { get; }
        public static ColorSpace desiredColorSpace { get; }
        public static ColorSpace activeColorSpace { get; }

        public static void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);
        public static void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);
        public static void SetQualityLevel(int index);
        public static void IncreaseLevel();
        public static void DecreaseLevel();
        [NativeName("SetLODSettings")]
        public static void SetLODSettings(float lodBias, int maximumLODLevel, bool setDirty = True);
        public static RenderPipelineAsset GetRenderPipelineAssetAt(int index);
        [NativeName("GetCurrentIndex")]
        public static int GetQualityLevel();
        [FreeFunction]
        public static Object GetQualitySettings();
        [NativeName("SetCurrentIndex")]
        public static void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);
        public static void GetAllRenderPipelineAssetsForPlatform(string buildTargetGroupName, ref List<RenderPipelineAsset> renderPipelineAssets);
    }
}
