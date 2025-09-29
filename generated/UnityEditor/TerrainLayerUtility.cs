#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public static class TerrainLayerUtility
    {

        public static int ShowTerrainLayersSelectionHelper(Terrain terrain, int activeTerrainLayer);
        public static void ShowTerrainLayerGUI(Terrain terrain, TerrainLayer terrainLayer, ref Editor terrainLayerEditor, ITerrainLayerCustomUI customGUI);
        public static void ValidateDiffuseTextureUI(Texture2D texture);
        public static bool CheckNormalMapTextureType(Texture2D texture);
        public static void ValidateNormalMapTextureUI(Texture2D texture, bool normalMapTextureType);
        public static void ValidateMaskMapTextureUI(Texture2D texture);
        public static void TilingSettingsUI(TerrainLayer terrainLayer);
        public static void TilingSettingsUI(SerializedProperty tileSize, SerializedProperty tileOffset);
    }
}
