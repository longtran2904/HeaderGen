#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomGridBrush(True, False, False, "Tint Brush")]
    public class TintBrush : GridBrushBase
    {
        public Color m_Color;

        public TintBrush();

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void Erase(GridLayout grid, GameObject brushTarget, Vector3Int position);
    }
}
