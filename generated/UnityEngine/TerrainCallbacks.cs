#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
    [MovedFrom("UnityEngine.Experimental.TerrainAPI")]
    public static class TerrainCallbacks
    {

        public static event HeightmapChangedCallback heightmapChanged;
        public static event TextureChangedCallback textureChanged;
        public delegate void HeightmapChangedCallback(Terrain terrain, RectInt heightRegion, bool synched);
        public delegate void TextureChangedCallback(Terrain terrain, string textureName, RectInt texelRegion, bool synched);
    }
}
