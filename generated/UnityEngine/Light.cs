#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/Light.h")]
    [NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
    [RequireComponent(typeof(Transform))]
    [RequireComponent(typeof(Transform))]
    public sealed class Light : Behaviour
    {

        public Light();

        [NativeProperty("LightType")]
        public LightType type { get; set; }
        [NativeProperty("LightShape")]
        public LightShape shape { get; set; }
        public float spotAngle { get; set; }
        public float innerSpotAngle { get; set; }
        public Color color { get; set; }
        public float colorTemperature { get; set; }
        public bool useColorTemperature { get; set; }
        public float intensity { get; set; }
        public float bounceIntensity { get; set; }
        public bool useBoundingSphereOverride { get; set; }
        public Vector4 boundingSphereOverride { get; set; }
        public bool useViewFrustumForShadowCasterCull { get; set; }
        public int shadowCustomResolution { get; set; }
        public float shadowBias { get; set; }
        public float shadowNormalBias { get; set; }
        public float shadowNearPlane { get; set; }
        public bool useShadowMatrixOverride { get; set; }
        public Matrix4x4 shadowMatrixOverride { get; set; }
        public float range { get; set; }
        public Flare flare { get; set; }
        public LightBakingOutput bakingOutput { get; set; }
        public int cullingMask { get; set; }
        public int renderingLayerMask { get; set; }
        public LightShadowCasterMode lightShadowCasterMode { get; set; }
        public float shadowRadius { get; set; }
        public float shadowAngle { get; set; }
        public LightShadows shadows { get; set; }
        public float shadowStrength { get; set; }
        public LightShadowResolution shadowResolution { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Shadow softness is removed in Unity 5.0+", True)]
        public float shadowSoftness { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Shadow softness is removed in Unity 5.0+", True)]
        public float shadowSoftnessFade { get; set; }
        public float[] layerShadowCullDistances { get; set; }
        public float cookieSize { get; set; }
        public Texture cookie { get; set; }
        public LightRenderMode renderMode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("warning bakedIndex has been removed please use bakingOutput.isBaked instead.", True)]
        public int bakedIndex { get; set; }
        public Vector2 areaSize { get; set; }
        public LightmapBakeType lightmapBakeType { get; set; }
        public int commandBufferCount { get; }
        [Obsolete("Use QualitySettings.pixelLightCount instead.")]
        public static int pixelLightCount { get; set; }
        [Obsolete("light.shadowConstantBias was removed, use light.shadowBias", True)]
        public float shadowConstantBias { get; set; }
        [Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", True)]
        public float shadowObjectSizeBias { get; set; }
        [Obsolete("light.attenuate was removed; all lights always attenuate now", True)]
        public bool attenuate { get; set; }
        [Obsolete("Light.lightmappingMode has been deprecated. Use Light.lightmapBakeType instead (UnityUpgradable) -> lightmapBakeType", True)]
        public LightmappingMode lightmappingMode { get; set; }
        [Obsolete("Light.isBaked is no longer supported. Use Light.bakingOutput.isBaked (and other members of Light.bakingOutput) instead.", False)]
        public bool isBaked { get; }
        [Obsolete("Light.alreadyLightmapped is no longer supported. Use Light.bakingOutput instead. Allowing to describe mixed light on top of realtime and baked ones.", False)]
        public bool alreadyLightmapped { get; set; }

        public void Reset();
        public void SetLightDirty();
        public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer);
        [FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = True)]
        public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask);
        public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType);
        [FreeFunction("Light_Bindings::AddCommandBufferAsync", HasExplicitThis = True)]
        public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType);
        public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);
        public void RemoveCommandBuffers(LightEvent evt);
        public void RemoveAllCommandBuffers();
        [FreeFunction("Light_Bindings::GetCommandBuffers", HasExplicitThis = True)]
        public CommandBuffer[] GetCommandBuffers(LightEvent evt);
        [FreeFunction("Light_Bindings::GetLights")]
        public static Light[] GetLights(LightType type, int layer);
    }
}
