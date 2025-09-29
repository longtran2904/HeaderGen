#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    public enum DrawCameraMode
    {

        UserDefined = -2147483648,
        Normal = -1,
        Textured = 0,
        Wireframe = 1,
        TexturedWire = 2,
        ShadowCascades = 3,
        RenderPaths = 4,
        AlphaChannel = 5,
        Overdraw = 6,
        Mipmaps = 7,
        DeferredDiffuse = 8,
        DeferredSpecular = 9,
        DeferredSmoothness = 10,
        DeferredNormal = 11,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use RealtimeCharting instead. (UnityUpgradable) -> RealtimeCharting", True)]
        Charting = -12,
        RealtimeCharting = 12,
        Systems = 13,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use RealtimeAlbedo instead. (UnityUpgradable) -> RealtimeAlbedo", True)]
        Albedo = -14,
        RealtimeAlbedo = 14,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use RealtimeEmissive instead. (UnityUpgradable) -> RealtimeEmissive", True)]
        Emissive = -15,
        RealtimeEmissive = 15,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use RealtimeIndirect instead. (UnityUpgradable) -> RealtimeIndirect", True)]
        Irradiance = -16,
        RealtimeIndirect = 16,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use RealtimeDirectionality instead. (UnityUpgradable) -> RealtimeDirectionality", True)]
        Directionality = -17,
        RealtimeDirectionality = 17,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Renamed to better distinguish this mode from new Progressive baked modes. Please use BakedLightmap instead. (UnityUpgradable) -> BakedLightmap", True)]
        Baked = -18,
        BakedLightmap = 18,
        Clustering = 19,
        LitClustering = 20,
        ValidateAlbedo = 21,
        ValidateMetalSpecular = 22,
        ShadowMasks = 23,
        LightOverlap = 24,
        BakedAlbedo = 25,
        BakedEmissive = 26,
        BakedDirectionality = 27,
        BakedTexelValidity = 28,
        BakedIndices = 29,
        BakedCharting = 30,
        SpriteMask = 31,
        BakedUVOverlap = 32,
        TextureStreaming = 33,
        BakedLightmapCulling = 34,
        GIContributorsReceivers = 35
    }
}
