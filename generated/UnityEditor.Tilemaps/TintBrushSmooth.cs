#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomGridBrush(False, False, False, "Tint Brush (Smooth)")]
    public class TintBrushSmooth : GridBrushBase
    {

        public float m_Blend;
        public Color m_Color;

        public TintBrushSmooth();

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void Erase(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void Pick(GridLayout grid, GameObject brushTarget, BoundsInt position, Vector3Int pivot);
    }
}
