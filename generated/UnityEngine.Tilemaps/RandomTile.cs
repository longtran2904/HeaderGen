#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Random Tile", fileName = "New Random Tile", order = 82)]
    public class RandomTile : Tile
    {
        [SerializeField]
        public Sprite[] m_Sprites;

        public RandomTile();

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
    }
}
