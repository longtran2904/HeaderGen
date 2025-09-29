#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Grid Layout Group", 152)]
    public class GridLayoutGroup : LayoutGroup
    {

        [SerializeField]
        protected Corner m_StartCorner;
        [SerializeField]
        protected Axis m_StartAxis;
        [SerializeField]
        protected Vector2 m_CellSize;
        [SerializeField]
        protected Vector2 m_Spacing;
        [SerializeField]
        protected Constraint m_Constraint;
        [SerializeField]
        protected int m_ConstraintCount;

        protected GridLayoutGroup();

        public Corner startCorner { get; set; }
        public Axis startAxis { get; set; }
        public Vector2 cellSize { get; set; }
        public Vector2 spacing { get; set; }
        public Constraint constraint { get; set; }
        public int constraintCount { get; set; }

        protected override void OnValidate();
        public override void CalculateLayoutInputHorizontal();
        public override void CalculateLayoutInputVertical();
        public override void SetLayoutHorizontal();
        public override void SetLayoutVertical();
        public enum Corner
        {

            UpperLeft = 0,
            UpperRight = 1,
            LowerLeft = 2,
            LowerRight = 3
        }
        public enum Axis
        {

            Horizontal = 0,
            Vertical = 1
        }
        public enum Constraint
        {

            Flexible = 0,
            FixedColumnCount = 1,
            FixedRowCount = 2
        }
    }
}
