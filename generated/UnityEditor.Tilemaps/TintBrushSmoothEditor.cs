#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(TintBrushSmooth))]
    public class TintBrushSmoothEditor : GridBrushEditorBase
    {
        public TintBrushSmoothEditor();

        public TintBrushSmooth brush { get; }
        public override GameObject[] validTargets { get; }

        public override void OnPaintInspectorGUI();
    }
}
