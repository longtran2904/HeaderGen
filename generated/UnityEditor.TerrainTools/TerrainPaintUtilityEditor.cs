#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.TerrainTools;

namespace UnityEditor.TerrainTools
{
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public static class TerrainPaintUtilityEditor
    {
        public static void ShowDefaultPreviewBrush(Terrain terrain, Texture brushTexture, float brushSize);
        public static Material GetDefaultBrushPreviewMaterial();
        public static void DrawBrushPreview(PaintContext heightmapPC, TerrainBrushPreviewMode previewTexture, Texture brushTexture, BrushTransform brushXform, Material proceduralMaterial, int materialPassIndex);
    }
}
