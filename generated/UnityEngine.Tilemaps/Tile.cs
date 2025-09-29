#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
    [RequiredByNativeCode]
    public class Tile : TileBase
    {
        public Tile();

        public Sprite sprite { get; set; }
        public Color color { get; set; }
        public Matrix4x4 transform { get; set; }
        public GameObject gameObject { get; set; }
        public TileFlags flags { get; set; }
        public ColliderType colliderType { get; set; }

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);

        public enum ColliderType
        {
            None = 0,
            Sprite = 1,
            Grid = 2
        }
    }
}
