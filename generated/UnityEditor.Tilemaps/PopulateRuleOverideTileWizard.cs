#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Tilemaps;

namespace UnityEditor.Tilemaps
{
    [MovedFrom(True, "UnityEditor", null, null)]
    public class PopulateRuleOverideTileWizard : ScriptableWizard
    {
        public Texture2D m_spriteSet;

        public PopulateRuleOverideTileWizard();

        public static void CreateWizard(RuleOverrideTile target);
        public static void CloneWizard(PopulateRuleOverideTileWizard oldWizard);
    }
}
