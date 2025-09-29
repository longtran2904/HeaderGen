#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum PerObjectData
    {
        None = 0,
        LightProbe = 1,
        ReflectionProbes = 2,
        LightProbeProxyVolume = 4,
        Lightmaps = 8,
        LightData = 16,
        MotionVectors = 32,
        LightIndices = 64,
        ReflectionProbeData = 128,
        OcclusionProbe = 256,
        OcclusionProbeProxyVolume = 512,
        ShadowMask = 1024
    }
}
