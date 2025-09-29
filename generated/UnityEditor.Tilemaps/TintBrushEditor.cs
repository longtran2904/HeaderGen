#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomEditor(typeof(TintBrush))]
    public class TintBrushEditor : GridBrushEditorBase
    {

        public TintBrushEditor();

        public override GameObject[] validTargets { get; }
    }
}
