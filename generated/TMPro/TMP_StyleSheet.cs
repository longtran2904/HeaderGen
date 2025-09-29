#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    [ExcludeFromPreset]
    public class TMP_StyleSheet : ScriptableObject
    {
        public TMP_StyleSheet();

        public TMP_Style GetStyle(int hashCode);
        public TMP_Style GetStyle(string name);
        public void RefreshStyles();
    }
}
