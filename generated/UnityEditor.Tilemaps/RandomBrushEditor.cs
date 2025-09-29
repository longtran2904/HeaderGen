#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(RandomBrush))]
    public class RandomBrushEditor : GridBrushEditor
    {

        public RandomBrushEditor();

        public override void PaintPreview(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void ClearPreview();
        public override void OnPaintInspectorGUI();
    }
}
