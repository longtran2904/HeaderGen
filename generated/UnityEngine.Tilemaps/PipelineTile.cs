#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Pipeline Tile", fileName = "New Pipeline Tile", order = 82)]
    public class PipelineTile : TileBase
    {
        [SerializeField]
        public Sprite[] m_Sprites;

        public PipelineTile();

        public override void RefreshTile(Vector3Int position, ITilemap tilemap);
        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
    }
}
