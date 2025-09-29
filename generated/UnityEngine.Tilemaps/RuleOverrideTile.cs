#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Rule Override Tile", fileName = "New Rule Override Tile", order = 83)]
    [DefaultMember("Item")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleOverrideTile.html")]
    [MovedFrom(True, "UnityEngine", null, null)]
    public class RuleOverrideTile : TileBase
    {
        public RuleTile m_Tile;
        public List<TileSpritePair> m_Sprites;
        public List<TileGameObjectPair> m_GameObjects;
        [HideInInspector]
        public RuleTile m_InstanceTile;

        public RuleOverrideTile();

        public Sprite this[Sprite originalSprite] { get; set; }
        public GameObject this[GameObject originalGameObject] { get; set; }

        public void ApplyOverrides(IList<KeyValuePair<Sprite, Sprite>> overrides);
        public void ApplyOverrides(IList<KeyValuePair<GameObject, GameObject>> overrides);
        public void GetOverrides(List<KeyValuePair<Sprite, Sprite>> overrides, ref int validCount);
        public void GetOverrides(List<KeyValuePair<GameObject, GameObject>> overrides, ref int validCount);
        public virtual void Override();
        public void PrepareOverride();
        public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData);
        public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
        public override void RefreshTile(Vector3Int position, ITilemap tilemap);
        public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go);

        public class TileSpritePair
        {
            public Sprite m_OriginalSprite;
            public Sprite m_OverrideSprite;

            public TileSpritePair();
        }
        public class TileGameObjectPair
        {
            public GameObject m_OriginalGameObject;
            public GameObject m_OverrideGameObject;

            public TileGameObjectPair();
        }
    }
}
