#region Unity.2D.Tilemap.Extras.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Tilemaps
{
    [CustomGridBrush(True, False, False, "GameObject Brush")]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/GameObjectBrush.html")]
    public class GameObjectBrush : GridBrushBase
    {

        [HideInInspector]
        public GameObject hiddenGrid;
        public Vector3 m_Anchor;

        public GameObjectBrush();

        public Vector3Int size { get; set; }
        public Vector3Int pivot { get; set; }
        public BrushCell[] cells { get; }
        public int cellCount { get; }

        public void Init(Vector3Int size);
        public void Init(Vector3Int size, Vector3Int pivot);
        public override void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public override void Rotate(RotationDirection direction, GridLayout.CellLayout layout);
        public override void Flip(FlipAxis flip, GridLayout.CellLayout layout);
        public override void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot);
        public override void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public override void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public void Reset();
        public void UpdateSizeAndPivot(Vector3Int size, Vector3Int pivot);
        public void SetGameObject(Vector3Int position, GameObject go);
        public void SetOffset(Vector3Int position, Vector3 offset);
        public void SetOrientation(Vector3Int position, Quaternion orientation);
        public void SetScale(Vector3Int position, Vector3 scale);
        public int GetCellIndex(Vector3Int brushPosition);
        public int GetCellIndex(int x, int y, int z);
        public int GetCellIndex(int x, int y, int z, int sizex, int sizey, int sizez);
        public int GetCellIndexWrapAround(int x, int y, int z);
        public override int GetHashCode();
        public class BrushCell
        {

            public BrushCell();

            public GameObject gameObject { get; set; }
            public Vector3 offset { get; set; }
            public Vector3 scale { get; set; }
            public Quaternion orientation { get; set; }

            public override int GetHashCode();
        }
    }
}
