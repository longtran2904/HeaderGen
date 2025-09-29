#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public struct HighlightState
    {

        public Color32 color;
        public TMP_Offset padding;

        public HighlightState(Color32 color, TMP_Offset padding);

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(HighlightState other);

        public static bool operator ==(HighlightState lhs, HighlightState rhs);
        public static bool operator !=(HighlightState lhs, HighlightState rhs);
    }
}
