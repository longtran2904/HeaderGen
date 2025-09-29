#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public abstract class LayoutGroup : UIBehaviour, ILayoutController, ILayoutElement, ILayoutGroup
    {

        [SerializeField]
        protected RectOffset m_Padding;
        [SerializeField]
        protected TextAnchor m_ChildAlignment;
        protected DrivenRectTransformTracker m_Tracker;

        protected LayoutGroup();

        public RectOffset padding { get; set; }
        public TextAnchor childAlignment { get; set; }
        protected RectTransform rectTransform { get; }
        protected List<RectTransform> rectChildren { get; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public virtual void CalculateLayoutInputHorizontal();
        public abstract void CalculateLayoutInputVertical();
        public abstract void SetLayoutHorizontal();
        public abstract void SetLayoutVertical();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDidApplyAnimationProperties();
        protected float GetTotalMinSize(int axis);
        protected float GetTotalPreferredSize(int axis);
        protected float GetTotalFlexibleSize(int axis);
        protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
        protected float GetAlignmentOnAxis(int axis);
        protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
        protected void SetChildAlongAxis(RectTransform rect, int axis, float pos);
        protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor);
        protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size);
        protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor);
        protected override void OnRectTransformDimensionsChange();
        protected virtual void OnTransformChildrenChanged();
        protected void SetProperty<T>(ref T currentValue, T newValue);
        protected void SetDirty();
        protected override void OnValidate();
    }
}
