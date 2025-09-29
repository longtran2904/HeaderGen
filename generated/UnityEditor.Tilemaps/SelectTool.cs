#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public sealed class SelectTool : TilemapEditorTool
    {

        public SelectTool();

        protected override string tooltipStringFormat { get; }
        protected override string shortcutId { get; }
        public override GUIContent toolbarIcon { get; }
    }
}
