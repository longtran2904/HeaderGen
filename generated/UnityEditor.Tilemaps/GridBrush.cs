#region Unity.2D.Tilemap.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Tilemaps;

namespace UnityEditor.Tilemaps
{
    [MovedFrom(True, "UnityEditor", "UnityEditor", null)]
    public class GridBrush : GridBrushBase
    {

        public GridBrush();

        public Vector3Int size { get; set; }
        public Vector3Int pivot { get; set; }
        public BrushCell[] cells { get; }
        public int cellCount { get; }
        public bool canChangeZPosition { get; set; }

        public void Init(Vector3Int size);
        public void Init(Vector3Int size, Vector3Int pivot);
        public override void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void Rotate(RotationDirection direction, GridLayout.CellLayout layout);
        public override void Flip(FlipAxis flip, GridLayout.CellLayout layout);
        public override void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pickStart);
        public override void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public void Reset();
        public void UpdateSizeAndPivot(Vector3Int size, Vector3Int pivot);
        public void SetTile(Vector3Int position, TileBase tile);
        public void SetMatrix(Vector3Int position, Matrix4x4 matrix);
        public void SetColor(Vector3Int position, Color color);
        public int GetCellIndex(Vector3Int brushPosition);
        public int GetCellIndex(int x, int y, int z);
        public int GetCellIndex(int x, int y, int z, int sizex, int sizey, int sizez);
        public int GetCellIndexWrapAround(int x, int y, int z);
        public override int GetHashCode();
        public class BrushCell
        {

            public BrushCell();

            public TileBase tile { get; set; }
            public Matrix4x4 matrix { get; set; }
            public Color color { get; set; }

            public override int GetHashCode();
        }
    }
}
