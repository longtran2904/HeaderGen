#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEditor.Experimental
{
    public sealed class Lightmapping
    {

        public Lightmapping();

        [StaticAccessor("ProgressiveRuntimeManager::Get()", StaticAccessorType.Arrow)]
        public static bool probesIgnoreDirectEnvironment { get; set; }
        [Obsolete("UnityEditor.Experimental.Lightmapping.extractAmbientOcclusion is obsolete, use Lightmapping.lightingSettings.extractAO instead. ", False)]
        public static bool extractAmbientOcclusion { get; set; }

        public static event Action additionalBakedProbesCompleted;

        [StaticAccessor("ProgressiveRuntimeManager::Get()", StaticAccessorType.Arrow)]
        public static void SetCustomBakeInputs(Vector4[] inputData, int sampleCount);
        [StaticAccessor("ProgressiveRuntimeManager::Get()", StaticAccessorType.Arrow)]
        public static bool GetCustomBakeResults(out Vector4[] results);
        [FreeFunction]
        [NativeThrows]
        public static bool BakeAsync(Scene targetScene);
        [FreeFunction]
        [NativeThrows]
        public static bool Bake(Scene targetScene);
        [Obsolete("Please use the new GetAdditionalBakedProbes with added octahedral depth map data.", False)]
        public static bool GetAdditionalBakedProbes(int id, NativeArray<SphericalHarmonicsL2> outBakedProbeSH, NativeArray<float> outBakedProbeValidity);
        public static bool GetAdditionalBakedProbes(int id, NativeArray<SphericalHarmonicsL2> outBakedProbeSH, NativeArray<float> outBakedProbeValidity, NativeArray<float> outBakedProbeOctahedralDepth);
        [FreeFunction]
        public static void SetAdditionalBakedProbes(int id, Vector3[] positions);
        [FreeFunction]
        public static void SetLightDirty(Light light);
    }
}
