#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using System;
using UnityEditor.EditorTools;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public abstract class TilemapEditorTool : EditorTool
    {
        protected TilemapEditorTool();

        public static EditorTool[] tilemapEditorTools { get; }
        public static float tilemapEditorToolsToolbarSize { get; }
        protected abstract string tooltipStringFormat { get; }
        protected abstract string shortcutId { get; }

        protected static string GetTooltipText(string tooltipStringFormat, string shortcutId);
        protected static string GetKeysFromToolName(string id);
        protected void UpdateTooltip();
        public virtual bool HandleTool(bool isHotControl, GridLayout gridLayout, GameObject brushTarget, Vector3Int gridMousePosition);
        public override bool IsAvailable();
        public static void ToggleActiveEditorTool(Type type);
        public static void SetActiveEditorTool(Type type);

        public class ShortcutContext : IShortcutToolContext
        {
            public ShortcutContext();

            public bool active { get; set; }
        }
    }
}
