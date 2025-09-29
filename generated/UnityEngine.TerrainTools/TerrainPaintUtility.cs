#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Internal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.TerrainTools
{
    [MovedFrom("UnityEngine.Experimental.TerrainAPI")]
    public static class TerrainPaintUtility
    {
        public static Material GetBuiltinPaintMaterial();
        public static void GetBrushWorldSizeLimits(out float minBrushWorldSize, out float maxBrushWorldSize, float terrainTileWorldSize, int terrainTileTextureResolutionPixels, int minBrushResolutionPixels = 1, int maxBrushResolutionPixels = 8192);
        public static BrushTransform CalculateBrushTransform(Terrain terrain, Vector2 brushCenterTerrainUV, float brushSize, float brushRotationDegrees);
        public static void BuildTransformPaintContextUVToPaintContextUV(PaintContext src, PaintContext dst, out Vector4 scaleOffset);
        public static void SetupTerrainToolMaterialProperties(PaintContext paintContext, in BrushTransform brushXform, Material material);
        public static void ReleaseContextResources(PaintContext ctx);
        public static PaintContext BeginPaintHeightmap(Terrain terrain, Rect boundsInTerrainSpace, [DefaultValue("0")] int extraBorderPixels = 0, [DefaultValue("true")] bool fillOutsideTerrain = True);
        public static void EndPaintHeightmap(PaintContext ctx, string editorUndoName);
        public static PaintContext BeginPaintHoles(Terrain terrain, Rect boundsInTerrainSpace, [DefaultValue("0")] int extraBorderPixels = 0, [DefaultValue("true")] bool fillOutsideTerrain = True);
        public static void EndPaintHoles(PaintContext ctx, string editorUndoName);
        public static PaintContext CollectNormals(Terrain terrain, Rect boundsInTerrainSpace, [DefaultValue("0")] int extraBorderPixels = 0, [DefaultValue("true")] bool fillOutsideTerrain = True);
        public static PaintContext BeginPaintTexture(Terrain terrain, Rect boundsInTerrainSpace, TerrainLayer inputLayer, [DefaultValue("0")] int extraBorderPixels = 0, [DefaultValue("true")] bool fillOutsideTerrain = True);
        public static void EndPaintTexture(PaintContext ctx, string editorUndoName);
        public static Material GetBlitMaterial();
        public static Material GetHeightBlitMaterial();
        public static Material GetCopyTerrainLayerMaterial();
        public static Texture2D GetTerrainAlphaMapChecked(Terrain terrain, int mapIndex);
        public static int FindTerrainLayerIndex(Terrain terrain, TerrainLayer inputLayer);
    }
}
