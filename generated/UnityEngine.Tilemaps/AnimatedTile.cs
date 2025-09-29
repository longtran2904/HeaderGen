#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Animated Tile", fileName = "New Animated Tile", order = 82)]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/AnimatedTile.html")]
    public class AnimatedTile : TileBase
    {

        public Sprite[] m_AnimatedSprites;
        public float m_MinSpeed;
        public float m_MaxSpeed;
        public float m_AnimationStartTime;
        public int m_AnimationStartFrame;
        public Tile.ColliderType m_TileColliderType;

        public AnimatedTile();

        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
        public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData);
    }
}
