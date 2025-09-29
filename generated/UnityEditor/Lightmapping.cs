#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/GI/Lightmapping.bindings.h")]
    public static class Lightmapping
    {

        [Obsolete("OnCompletedFunction.completed is obsolete, please use event bakeCompleted instead. ", False)]
        public static OnCompletedFunction completed;

        public static GIWorkflowMode giWorkflowMode { get; set; }
        public static bool realtimeGI { get; set; }
        public static bool bakedGI { get; set; }
        [Obsolete("Lightmapping.indirectOutputScale is obsolete, use Lightmapping.lightingSettings.indirectScale instead. ", False)]
        public static float indirectOutputScale { get; set; }
        [Obsolete("Lightmapping.bounceBoost is obsolete, use Lightmapping.lightingSettings.albedoBoost instead. ", False)]
        public static float bounceBoost { get; set; }
        public static bool isRunning { get; }
        public static float buildProgress { get; }
        [StaticAccessor("GetLightmapSettings()")]
        public static LightingDataAsset lightingDataAsset { get; set; }
        public static LightingSettings lightingSettings { get; set; }
        [NativeName("LightingSettingsDefaults_Scripting")]
        [StaticAccessor("GetLightmapSettings()")]
        public static LightingSettings lightingSettingsDefaults { get; }
        [Obsolete("lightmapSnapshot has been deprecated. Use lightingDataAsset instead (UnityUpgradable) -> lightingDataAsset", True)]
        public static LightmapSnapshot lightmapSnapshot { get; set; }

        [Obsolete("OnStartedFunction.started is obsolete, please use bakeStarted instead. ", False)]
        public static event OnStartedFunction started;
        public static event Action bakeStarted;
        public static event Action lightingDataUpdated;
        public static event Action lightingDataCleared;
        public static event Action lightingDataAssetCleared;
        public static event Action bakeCompleted;

        [StaticAccessor("GICache", StaticAccessorType.DoubleColon)]
        public static void ClearDiskCache();
        [FreeFunction]
        public static bool BakeAsync();
        [FreeFunction]
        public static bool Bake();
        [FreeFunction("CancelLightmapping")]
        public static void Cancel();
        [FreeFunction]
        public static void ForceStop();
        [FreeFunction]
        public static void Clear();
        [FreeFunction]
        public static void ClearLightingDataAsset();
        public static void Tetrahedralize(Vector3[] positions, out int[] outIndices, out Vector3[] outPositions);
        [FreeFunction]
        public static bool BakeReflectionProbe(ReflectionProbe probe, string path);
        [FreeFunction]
        public static void GetTerrainGIChunks([NotNull("ArgumentNullException")] Terrain terrain, ref int numChunksX, ref int numChunksY);
        public static bool TryGetLightingSettings(out LightingSettings settings);
        [NativeName("SetLightingSettingsForScene")]
        [StaticAccessor("GetLightmapSettingsManager()")]
        public static void SetLightingSettingsForScene(Scene scene, LightingSettings lightingSettings);
        [NativeName("SetLightingSettingsForScenes")]
        [StaticAccessor("GetLightmapSettingsManager()")]
        public static void SetLightingSettingsForScenes(Scene[] scenes, LightingSettings lightingSettings);
        [NativeName("GetLightingSettingsForScene")]
        [StaticAccessor("GetLightmapSettingsManager()")]
        public static LightingSettings GetLightingSettingsForScene(Scene scene);
        public static void BakeMultipleScenes(string[] paths);
        [Obsolete("BakeSelectedAsync has been deprecated. Use BakeAsync instead (UnityUpgradable) -> BakeAsync()", True)]
        public static bool BakeSelectedAsync();
        [Obsolete("BakeSelected has been deprecated. Use Bake instead (UnityUpgradable) -> Bake()", True)]
        public static bool BakeSelected();
        [Obsolete("BakeLightProbesOnlyAsync has been deprecated. Use BakeAsync instead (UnityUpgradable) -> BakeAsync()", True)]
        public static bool BakeLightProbesOnlyAsync();
        [Obsolete("BakeLightProbesOnly has been deprecated. Use Bake instead (UnityUpgradable) -> Bake()", True)]
        public static bool BakeLightProbesOnly();
        [NativeHeader("Runtime/Graphics/LightmapEnums.h")]
        public enum GIWorkflowMode
        {

            Iterative = 0,
            OnDemand = 1,
            Legacy = 2
        }
        public delegate void OnStartedFunction();
        public delegate void OnCompletedFunction();
    }
}
