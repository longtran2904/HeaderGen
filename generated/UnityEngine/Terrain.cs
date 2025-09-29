#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
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
    [NativeHeader("TerrainScriptingClasses.h")]
    [NativeHeader("Runtime/Interfaces/ITerrainManager.h")]
    [NativeHeader("Modules/Terrain/Public/Terrain.h")]
    [StaticAccessor("GetITerrainManager()", StaticAccessorType.Arrow)]
    [UsedByNativeCode]
    public sealed class Terrain : Behaviour
    {
        public Terrain();

        public TerrainData terrainData { get; set; }
        public float treeDistance { get; set; }
        public float treeBillboardDistance { get; set; }
        public float treeCrossFadeLength { get; set; }
        public int treeMaximumFullLODCount { get; set; }
        public float detailObjectDistance { get; set; }
        public float detailObjectDensity { get; set; }
        public float heightmapPixelError { get; set; }
        public int heightmapMaximumLOD { get; set; }
        public float basemapDistance { get; set; }
        [NativeProperty("StaticLightmapIndexInt")]
        public int lightmapIndex { get; set; }
        [NativeProperty("DynamicLightmapIndexInt")]
        public int realtimeLightmapIndex { get; set; }
        [NativeProperty("StaticLightmapST")]
        public Vector4 lightmapScaleOffset { get; set; }
        [NativeProperty("DynamicLightmapST")]
        public Vector4 realtimeLightmapScaleOffset { get; set; }
        [NativeProperty("FreeUnusedRenderingResourcesObsolete")]
        [Obsolete("Terrain.freeUnusedRenderingResources is obsolete; use keepUnusedRenderingResources instead.")]
        public bool freeUnusedRenderingResources { get; set; }
        [NativeProperty("KeepUnusedRenderingResources")]
        public bool keepUnusedRenderingResources { get; set; }
        public ShadowCastingMode shadowCastingMode { get; set; }
        public ReflectionProbeUsage reflectionProbeUsage { get; set; }
        public Material materialTemplate { get; set; }
        public bool drawHeightmap { get; set; }
        public bool allowAutoConnect { get; set; }
        public int groupingID { get; set; }
        public bool drawInstanced { get; set; }
        public RenderTexture normalmapTexture { get; }
        public bool drawTreesAndFoliage { get; set; }
        public Vector3 patchBoundsMultiplier { get; set; }
        public float treeLODBiasMultiplier { get; set; }
        public bool collectDetailPatches { get; set; }
        public TerrainRenderFlags editorRenderFlags { get; set; }
        public bool bakeLightProbesForTrees { get; set; }
        public bool deringLightProbesForTrees { get; set; }
        public bool preserveTreePrototypeLayers { get; set; }
        [StaticAccessor("Terrain", StaticAccessorType.DoubleColon)]
        public static GraphicsFormat heightmapFormat { get; }
        public static TextureFormat heightmapTextureFormat { get; }
        public static RenderTextureFormat heightmapRenderTextureFormat { get; }
        [StaticAccessor("Terrain", StaticAccessorType.DoubleColon)]
        public static GraphicsFormat normalmapFormat { get; }
        public static TextureFormat normalmapTextureFormat { get; }
        public static RenderTextureFormat normalmapRenderTextureFormat { get; }
        [StaticAccessor("Terrain", StaticAccessorType.DoubleColon)]
        public static GraphicsFormat holesFormat { get; }
        public static RenderTextureFormat holesRenderTextureFormat { get; }
        [StaticAccessor("Terrain", StaticAccessorType.DoubleColon)]
        public static GraphicsFormat compressedHolesFormat { get; }
        public static TextureFormat compressedHolesTextureFormat { get; }
        public static Terrain activeTerrain { get; }
        [NativeProperty("ActiveTerrainsScriptingArray")]
        public static Terrain[] activeTerrains { get; }
        public Terrain leftNeighbor { get; }
        public Terrain rightNeighbor { get; }
        public Terrain topNeighbor { get; }
        public Terrain bottomNeighbor { get; }
        public uint renderingLayerMask { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("splatmapDistance is deprecated, please use basemapDistance instead. (UnityUpgradable) -> basemapDistance", True)]
        public float splatmapDistance { get; set; }
        [Obsolete("castShadows is deprecated, please use shadowCastingMode instead.")]
        public bool castShadows { get; set; }
        [Obsolete("Property materialType is not used any more. Set materialTemplate directly.", False)]
        public MaterialType materialType { get; set; }
        [Obsolete("Property legacySpecular is not used any more. Set materialTemplate directly.", False)]
        public Color legacySpecular { get; set; }
        [Obsolete("Property legacyShininess is not used any more. Set materialTemplate directly.", False)]
        public float legacyShininess { get; set; }

        public bool GetKeepUnusedCameraRenderingResources(int cameraInstanceID);
        public void SetKeepUnusedCameraRenderingResources(int cameraInstanceID, bool keepUnused);
        public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result);
        public float SampleHeight(Vector3 worldPosition);
        public void AddTreeInstance(TreeInstance instance);
        public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);
        public Vector3 GetPosition();
        public void Flush();
        [NativeMethod("CopySplatMaterialCustomProps")]
        public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties);
        public void GetSplatMaterialPropertyBlock(MaterialPropertyBlock dest);
        public static void SetConnectivityDirty();
        public static void GetActiveTerrains(List<Terrain> terrainList);
        [UsedByNativeCode]
        public static GameObject CreateTerrainGameObject(TerrainData assignTerrain);
        [Obsolete("Use TerrainData.SyncHeightmap to notify all Terrain instances using the TerrainData.", False)]
        public void ApplyDelayedHeightmapModification();

        [Obsolete("Enum type MaterialType is not used any more.", False)]
        public enum MaterialType
        {
            BuiltInStandard = 0,
            BuiltInLegacyDiffuse = 1,
            BuiltInLegacySpecular = 2,
            Custom = 3
        }
    }
}
