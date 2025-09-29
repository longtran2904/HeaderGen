#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/ReflectionProbes.h")]
    public sealed class ReflectionProbe : Behaviour
    {
        public ReflectionProbe();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [NativeName("ProbeType")]
        [Obsolete("type property has been deprecated. Starting with Unity 5.4, the only supported reflection probe type is Cube.", True)]
        public ReflectionProbeType type { get; set; }
        [NativeName("BoxSize")]
        public Vector3 size { get; set; }
        [NativeName("BoxOffset")]
        public Vector3 center { get; set; }
        [NativeName("Near")]
        public float nearClipPlane { get; set; }
        [NativeName("Far")]
        public float farClipPlane { get; set; }
        [NativeName("IntensityMultiplier")]
        public float intensity { get; set; }
        [NativeName("GlobalAABB")]
        public Bounds bounds { get; }
        [NativeName("HDR")]
        public bool hdr { get; set; }
        [NativeName("RenderDynamicObjects")]
        public bool renderDynamicObjects { get; set; }
        public float shadowDistance { get; set; }
        public int resolution { get; set; }
        public int cullingMask { get; set; }
        public ReflectionProbeClearFlags clearFlags { get; set; }
        public Color backgroundColor { get; set; }
        public float blendDistance { get; set; }
        public bool boxProjection { get; set; }
        public ReflectionProbeMode mode { get; set; }
        public int importance { get; set; }
        public ReflectionProbeRefreshMode refreshMode { get; set; }
        public ReflectionProbeTimeSlicingMode timeSlicingMode { get; set; }
        public Texture bakedTexture { get; set; }
        public Texture customBakedTexture { get; set; }
        public RenderTexture realtimeTexture { get; set; }
        public Texture texture { get; }
        public Vector4 textureHDRDecodeValues { get; }
        [StaticAccessor("GetReflectionProbes()")]
        public static int minBakedCubemapResolution { get; }
        [StaticAccessor("GetReflectionProbes()")]
        public static int maxBakedCubemapResolution { get; }
        [StaticAccessor("GetReflectionProbes()")]
        public static Vector4 defaultTextureHDRDecodeValues { get; }
        [StaticAccessor("GetReflectionProbes()")]
        public static Texture defaultTexture { get; }

        public static event Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged;
        [Obsolete("ReflectionProbe.defaultReflectionSet has been deprecated. Use ReflectionProbe.defaultReflectionTexture. (UnityUpgradable) -> UnityEngine.ReflectionProbe.defaultReflectionTexture", True)]
        public static event Action<Cubemap> defaultReflectionSet;
        public static event Action<Texture> defaultReflectionTexture;

        public void Reset();
        public int RenderProbe();
        public int RenderProbe([DefaultValue("null")] RenderTexture targetTexture);
        public bool IsFinishedRendering(int renderId);
        [FreeFunction("CubemapGPUBlend")]
        [NativeHeader("Runtime/Camera/CubemapGPUUtility.h")]
        public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);
        [NativeMethod("UpdateSampleData")]
        [StaticAccessor("GetReflectionProbes()")]
        public static void UpdateCachedState();

        public enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1
        }
    }
}
