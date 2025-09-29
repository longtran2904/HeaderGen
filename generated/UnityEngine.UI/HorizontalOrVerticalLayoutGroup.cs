#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.UI
{
    [ExecuteAlways]
    public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        [SerializeField]
        protected float m_Spacing;
        [SerializeField]
        protected bool m_ChildForceExpandWidth;
        [SerializeField]
        protected bool m_ChildForceExpandHeight;
        [SerializeField]
        protected bool m_ChildControlWidth;
        [SerializeField]
        protected bool m_ChildControlHeight;
        [SerializeField]
        protected bool m_ChildScaleWidth;
        [SerializeField]
        protected bool m_ChildScaleHeight;
        [SerializeField]
        protected bool m_ReverseArrangement;

        protected HorizontalOrVerticalLayoutGroup();

        public float spacing { get; set; }
        public bool childForceExpandWidth { get; set; }
        public bool childForceExpandHeight { get; set; }
        public bool childControlWidth { get; set; }
        public bool childControlHeight { get; set; }
        public bool childScaleWidth { get; set; }
        public bool childScaleHeight { get; set; }
        public bool reverseArrangement { get; set; }

        protected void CalcAlongAxis(int axis, bool isVertical);
        protected void SetChildrenAlongAxis(int axis, bool isVertical);
        protected override void Reset();
        protected virtual void Update();
    }
}
