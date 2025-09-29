#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomGridBrush(True, False, False, "Line Brush")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/LineBrush.html")]
    public class LineBrush : GridBrush
    {

        public bool lineStartActive;
        public bool fillGaps;
        public Vector3Int lineStart;

        public LineBrush();

        public bool IsMoving { get; }

        public override void Paint(GridLayout grid, GameObject brushTarget, Vector3Int position);
        public override void MoveStart(GridLayout grid, GameObject brushTarget, BoundsInt position);
        public override void MoveEnd(GridLayout grid, GameObject brushTarget, BoundsInt position);
        public static IEnumerable<Vector2Int> GetPointsOnLine(Vector2Int startPos, Vector2Int endPos, bool fillGaps);
        public static IEnumerable<Vector2Int> GetPointsOnLine(Vector2Int p1, Vector2Int p2);
    }
}
