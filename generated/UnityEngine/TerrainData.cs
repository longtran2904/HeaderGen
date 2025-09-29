#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
    [NativeHeader("TerrainScriptingClasses.h")]
    [UsedByNativeCode]
    public sealed class TerrainData : Object
    {

        public TerrainData();

        [Obsolete("Please use heightmapResolution instead. (UnityUpgradable) -> heightmapResolution", False)]
        public int heightmapWidth { get; }
        [Obsolete("Please use heightmapResolution instead. (UnityUpgradable) -> heightmapResolution", False)]
        public int heightmapHeight { get; }
        public RenderTexture heightmapTexture { get; }
        public int heightmapResolution { get; set; }
        public Vector3 heightmapScale { get; }
        public Texture holesTexture { get; }
        public bool enableHolesTextureCompression { get; set; }
        public int holesResolution { get; }
        public Vector3 size { get; set; }
        public Bounds bounds { get; }
        [Obsolete("Terrain thickness is no longer required by the physics engine. Set appropriate continuous collision detection modes to fast moving bodies.")]
        public float thickness { get; set; }
        public float wavingGrassStrength { get; set; }
        public float wavingGrassAmount { get; set; }
        public float wavingGrassSpeed { get; set; }
        public Color wavingGrassTint { get; set; }
        public int detailWidth { get; }
        public int detailHeight { get; }
        public int detailPatchCount { get; }
        public int detailResolution { get; }
        public int detailResolutionPerPatch { get; }
        public DetailPrototype[] detailPrototypes { get; set; }
        public TreeInstance[] treeInstances { get; set; }
        public int treeInstanceCount { get; }
        public TreePrototype[] treePrototypes { get; set; }
        public int alphamapLayers { get; }
        public int alphamapResolution { get; set; }
        public int alphamapWidth { get; }
        public int alphamapHeight { get; }
        public int baseMapResolution { get; set; }
        public int alphamapTextureCount { get; }
        public Texture2D[] alphamapTextures { get; }
        [Obsolete("Please use the terrainLayers API instead.", False)]
        public SplatPrototype[] splatPrototypes { get; set; }
        public TerrainLayer[] terrainLayers { get; set; }
        public static string AlphamapTextureName { get; }
        public static string HolesTextureName { get; }

        [Obsolete("Please use DirtyHeightmapRegion instead.", False)]
        public void UpdateDirtyRegion(int x, int y, int width, int height, bool syncHeightmapTextureImmediately);
        [NativeName("GetHeightmap().GetHeight")]
        public float GetHeight(int x, int y);
        [NativeName("GetHeightmap().GetInterpolatedHeight")]
        public float GetInterpolatedHeight(float x, float y);
        public float[] GetInterpolatedHeights(float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval);
        public void GetInterpolatedHeights(float[] results, int resultXOffset, int resultYOffset, float xBase, float yBase, int xCount, int yCount, float xInterval, float yInterval);
        public float[] GetHeights(int xBase, int yBase, int width, int height);
        public void SetHeights(int xBase, int yBase, float[] heights);
        [FreeFunction("TerrainDataScriptingInterface::GetPatchMinMaxHeights", HasExplicitThis = True)]
        public PatchExtents[] GetPatchMinMaxHeights();
        [FreeFunction("TerrainDataScriptingInterface::OverrideMinMaxPatchHeights", HasExplicitThis = True)]
        public void OverrideMinMaxPatchHeights(PatchExtents[] minMaxHeights);
        [FreeFunction("TerrainDataScriptingInterface::GetMaximumHeightError", HasExplicitThis = True)]
        public float[] GetMaximumHeightError();
        [FreeFunction("TerrainDataScriptingInterface::OverrideMaximumHeightError", HasExplicitThis = True)]
        public void OverrideMaximumHeightError(float[] maxError);
        public void SetHeightsDelayLOD(int xBase, int yBase, float[] heights);
        public bool IsHole(int x, int y);
        public bool[] GetHoles(int xBase, int yBase, int width, int height);
        public void SetHoles(int xBase, int yBase, bool[] holes);
        public void SetHolesDelayLOD(int xBase, int yBase, bool[] holes);
        [NativeName("GetHeightmap().GetSteepness")]
        public float GetSteepness(float x, float y);
        [NativeName("GetHeightmap().GetInterpolatedNormal")]
        public Vector3 GetInterpolatedNormal(float x, float y);
        public void SetDetailResolution(int detailResolution, int resolutionPerPatch);
        [FreeFunction("TerrainDataScriptingInterface::RefreshPrototypes", HasExplicitThis = True)]
        public void RefreshPrototypes();
        [FreeFunction("TerrainDataScriptingInterface::GetSupportedLayers", HasExplicitThis = True)]
        public int[] GetSupportedLayers(int xBase, int yBase, int totalWidth, int totalHeight);
        [FreeFunction("TerrainDataScriptingInterface::GetDetailLayer", HasExplicitThis = True)]
        public int[] GetDetailLayer(int xBase, int yBase, int width, int height, int layer);
        [FreeFunction("TerrainDataScriptingInterface::ComputeDetailInstanceTransforms", HasExplicitThis = True)]
        public DetailInstanceTransform[] ComputeDetailInstanceTransforms(int patchX, int patchY, int layer, float density, out Bounds bounds);
        public void SetDetailLayer(int xBase, int yBase, int layer, int[] details);
        [FreeFunction("TerrainDataScriptingInterface::GetClampedDetailPatches", HasExplicitThis = True)]
        public Vector2Int[] GetClampedDetailPatches(float density);
        [FreeFunction("TerrainDataScriptingInterface::SetTreeInstances", HasExplicitThis = True)]
        public void SetTreeInstances([NotNull("ArgumentNullException")] TreeInstance[] instances, bool snapToHeightmap);
        public TreeInstance GetTreeInstance(int index);
        [FreeFunction("TerrainDataScriptingInterface::SetTreeInstance", HasExplicitThis = True)]
        [NativeThrows]
        public void SetTreeInstance(int index, TreeInstance instance);
        public float[] GetAlphamaps(int x, int y, int width, int height);
        public void SetAlphamaps(int x, int y, float[] map);
        [NativeName("GetSplatDatabase().SetBaseMapsDirty")]
        public void SetBaseMapDirty();
        [NativeName("GetSplatDatabase().GetAlphaTexture")]
        public Texture2D GetAlphamapTexture(int index);
        public void SetTerrainLayersRegisterUndo(TerrainLayer[] terrainLayers, string undoName);
        [NativeName("GetHeightmap().SyncHeightmapGPUModifications")]
        public void SyncHeightmap();
        public void CopyActiveRenderTextureToHeightmap(RectInt sourceRect, Vector2Int dest, TerrainHeightmapSyncControl syncControl);
        public void DirtyHeightmapRegion(RectInt region, TerrainHeightmapSyncControl syncControl);
        public void CopyActiveRenderTextureToTexture(string textureName, int textureIndex, RectInt sourceRect, Vector2Int dest, bool allowDelayedCPUSync);
        public void DirtyTextureRegion(string textureName, RectInt region, bool allowDelayedCPUSync);
        public void SyncTexture(string textureName);
    }
}
