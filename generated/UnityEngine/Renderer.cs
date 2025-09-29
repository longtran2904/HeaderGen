#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    [NativeHeader("Runtime/Graphics/Renderer.h")]
    [RequireComponent(typeof(Transform))]
    [UsedByNativeCode]
    public class Renderer : Component
    {

        public Renderer();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property lightmapTilingOffset has been deprecated. Use lightmapScaleOffset (UnityUpgradable) -> lightmapScaleOffset", True)]
        public Vector4 lightmapTilingOffset { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use probeAnchor instead (UnityUpgradable) -> probeAnchor", True)]
        public Transform lightProbeAnchor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use shadowCastingMode instead.", False)]
        public bool castShadows { get; set; }
        [Obsolete("Use motionVectorGenerationMode instead.", False)]
        public bool motionVectors { get; set; }
        [Obsolete("Use lightProbeUsage instead.", False)]
        public bool useLightProbes { get; set; }
        public Bounds bounds { get; set; }
        public Bounds localBounds { get; set; }
        public bool enabled { get; set; }
        public bool isVisible { get; }
        public ShadowCastingMode shadowCastingMode { get; set; }
        public bool receiveShadows { get; set; }
        public bool forceRenderingOff { get; set; }
        public bool staticShadowCaster { get; set; }
        public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
        public LightProbeUsage lightProbeUsage { get; set; }
        public ReflectionProbeUsage reflectionProbeUsage { get; set; }
        public uint renderingLayerMask { get; set; }
        public int rendererPriority { get; set; }
        public RayTracingMode rayTracingMode { get; set; }
        public string sortingLayerName { get; set; }
        public int sortingLayerID { get; set; }
        public int sortingOrder { get; set; }
        [NativeProperty("IsDynamicOccludee")]
        public bool allowOcclusionWhenDynamic { get; set; }
        public bool isPartOfStaticBatch { get; }
        public Matrix4x4 worldToLocalMatrix { get; }
        public Matrix4x4 localToWorldMatrix { get; }
        public GameObject lightProbeProxyVolumeOverride { get; set; }
        public Transform probeAnchor { get; set; }
        public int lightmapIndex { get; set; }
        public int realtimeLightmapIndex { get; set; }
        public Vector4 lightmapScaleOffset { get; set; }
        public Vector4 realtimeLightmapScaleOffset { get; set; }
        public Material[] materials { get; set; }
        public Material material { get; set; }
        public Material sharedMaterial { get; set; }
        public Material[] sharedMaterials { get; set; }

        [NativeName("ResetWorldAABB")]
        public void ResetBounds();
        [NativeName("ResetLocalAABB")]
        public void ResetLocalBounds();
        [FreeFunction(Name = "RendererScripting::HasPropertyBlock", HasExplicitThis = True)]
        public bool HasPropertyBlock();
        public void SetPropertyBlock(MaterialPropertyBlock properties);
        public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);
        public void GetPropertyBlock(MaterialPropertyBlock properties);
        public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex);
        public void GetMaterials(List<Material> m);
        public void GetSharedMaterials(List<Material> m);
        public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result);
    }
}
