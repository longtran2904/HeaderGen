#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Layout Element", 140)]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
    {
        protected LayoutElement();

        public virtual bool ignoreLayout { get; set; }
        public virtual float minWidth { get; set; }
        public virtual float minHeight { get; set; }
        public virtual float preferredWidth { get; set; }
        public virtual float preferredHeight { get; set; }
        public virtual float flexibleWidth { get; set; }
        public virtual float flexibleHeight { get; set; }
        public virtual int layoutPriority { get; set; }

        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();
        protected override void OnEnable();
        protected override void OnTransformParentChanged();
        protected override void OnDisable();
        protected override void OnDidApplyAnimationProperties();
        protected override void OnBeforeTransformParentChanged();
        protected void SetDirty();
        protected override void OnValidate();
    }
}
