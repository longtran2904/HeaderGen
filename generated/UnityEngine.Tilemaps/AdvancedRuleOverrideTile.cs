#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Tilemaps
{
    [CreateAssetMenu(menuName = "2D/Tiles/Advanced Rule Override Tile", fileName = "New Advanced Rule Override Tile", order = 83)]
    [DefaultMember("Item")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleOverrideTile.html")]
    [MovedFrom(True, "UnityEngine", null, null)]
    public class AdvancedRuleOverrideTile : RuleOverrideTile
    {

        public Sprite m_DefaultSprite;
        public GameObject m_DefaultGameObject;
        public Tile.ColliderType m_DefaultColliderType;
        public List<RuleTile.TilingRuleOutput> m_OverrideTilingRules;

        public AdvancedRuleOverrideTile();

        public RuleTile.TilingRuleOutput this[RuleTile.TilingRule originalRule] { get; set; }

        public void ApplyOverrides(IList<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRuleOutput>> overrides);
        public void GetOverrides(List<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRuleOutput>> overrides, ref int validCount);
        public override void Override();
    }
}
