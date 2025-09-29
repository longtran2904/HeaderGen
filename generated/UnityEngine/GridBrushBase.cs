#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

namespace UnityEngine
{
    public abstract class GridBrushBase : ScriptableObject
    {

        protected GridBrushBase();

        public virtual void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public virtual void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public virtual void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void Select(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
        public virtual void Rotate(RotationDirection direction, GridLayout.CellLayout layout);
        public virtual void Flip(FlipAxis flip, GridLayout.CellLayout layout);
        public virtual void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot);
        public virtual void Move(GridLayout gridLayout, GameObject brushTarget, BoundsInt from, BoundsInt to);
        public virtual void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
        public virtual void ChangeZPosition(int change);
        public virtual void ResetZPosition();
        public enum Tool
        {

            Select = 0,
            Move = 1,
            Paint = 2,
            Box = 3,
            Pick = 4,
            Erase = 5,
            FloodFill = 6
        }
        public enum RotationDirection
        {

            Clockwise = 0,
            CounterClockwise = 1
        }
        public enum FlipAxis
        {

            X = 0,
            Y = 1
        }
    }
}
