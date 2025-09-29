#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
    public class GridPaintingState : ScriptableSingleton<GridPaintingState>
    {
        public GridPaintingState();

        public static GameObject scenePaintTarget { get; set; }
        public static GridBrushBase gridBrush { get; set; }
        public static IList<GridBrushBase> brushes { get; }
        public static GameObject palette { get; set; }
        public static IList<GameObject> palettes { get; }
        public static GridBrushEditorBase activeBrushEditor { get; }
        public static GameObject[] validTargets { get; }

        public static event Action<GameObject> scenePaintTargetChanged;
        public static event Action<GridBrushBase> brushChanged;
        public static event Action<GameObject> paletteChanged;

        public static bool IsPartOfActivePalette(GameObject target);
    }
}
