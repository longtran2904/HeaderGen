#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using System;
using UnityEngine.Internal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.TerrainTools
{
    [MovedFrom("UnityEngine.Experimental.TerrainAPI")]
    public class PaintContext
    {
        public PaintContext(Terrain terrain, RectInt pixelRect, int targetTextureWidth, int targetTextureHeight, [DefaultValue("true")] bool sharedBoundaryTexel = True, [DefaultValue("true")] bool fillOutsideTerrain = True);

        public Terrain originTerrain { get; }
        public RectInt pixelRect { get; }
        public int targetTextureWidth { get; }
        public int targetTextureHeight { get; }
        public Vector2 pixelSize { get; }
        public RenderTexture sourceRenderTexture { get; }
        public RenderTexture destinationRenderTexture { get; }
        public RenderTexture oldRenderTexture { get; }
        public int terrainCount { get; }
        public float heightWorldSpaceMin { get; }
        public float heightWorldSpaceSize { get; }
        public static float kNormalizedHeightScale { get; }

        public Terrain GetTerrain(int terrainIndex);
        public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex);
        public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex);
        public static PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, [DefaultValue("0")] int extraBorderPixels = 0, [DefaultValue("true")] bool sharedBoundaryTexel = True, [DefaultValue("true")] bool fillOutsideTerrain = True);
        public void CreateRenderTargets(RenderTextureFormat colorFormat);
        public void Cleanup(bool restoreRenderTexture = True);
        public void Gather(Func<ITerrainInfo, Texture> terrainSource, Color defaultColor, Material blitMaterial = null, int blitPass = 0, Action<ITerrainInfo> beforeBlit = null, Action<ITerrainInfo> afterBlit = null);
        public void Scatter(Func<ITerrainInfo, RenderTexture> terrainDest, Material blitMaterial = null, int blitPass = 0, Action<ITerrainInfo> beforeBlit = null, Action<ITerrainInfo> afterBlit = null);
        public void GatherHeightmap();
        public void ScatterHeightmap(string editorUndoName);
        public void GatherHoles();
        public void ScatterHoles(string editorUndoName);
        public void GatherNormals();
        public void GatherAlphamap(TerrainLayer inputLayer, bool addLayerIfDoesntExist = True);
        public void ScatterAlphamap(string editorUndoName);
        public static void ApplyDelayedActions();

        public interface ITerrainInfo
        {
            Terrain terrain { get; }
            RectInt clippedTerrainPixels { get; }
            RectInt clippedPCPixels { get; }
            RectInt paddedTerrainPixels { get; }
            RectInt paddedPCPixels { get; }
            bool gatherEnable { get; set; }
            bool scatterEnable { get; set; }
            object userData { get; set; }
        }
    }
}
