#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
    [NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
    [NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
    public struct CullingResults : IEquatable<CullingResults>
    {

        public NativeArray<VisibleLight> visibleLights { get; }
        public NativeArray<VisibleLight> visibleOffscreenVertexLights { get; }
        public NativeArray<VisibleReflectionProbe> visibleReflectionProbes { get; }
        public int lightIndexCount { get; }
        public int reflectionProbeIndexCount { get; }
        public int lightAndReflectionProbeIndexCount { get; }

        public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer);
        public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer);
        public NativeArray<int> GetLightIndexMap(Allocator allocator);
        public void SetLightIndexMap(NativeArray<int> lightIndexMap);
        public NativeArray<int> GetReflectionProbeIndexMap(Allocator allocator);
        public void SetReflectionProbeIndexMap(NativeArray<int> lightIndexMap);
        public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds);
        public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);
        public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);
        public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData);
        public bool Equals(CullingResults other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(CullingResults left, CullingResults right);
        public static bool operator !=(CullingResults left, CullingResults right);
    }
}
