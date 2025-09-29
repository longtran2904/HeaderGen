#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum CullingOptions
    {
        None = 0,
        ForceEvenIfCameraIsNotActive = 1,
        OcclusionCull = 2,
        NeedsLighting = 4,
        NeedsReflectionProbes = 8,
        Stereo = 16,
        DisablePerObjectCulling = 32,
        ShadowCasters = 64
    }
}
