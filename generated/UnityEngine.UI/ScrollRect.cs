#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Scroll Rect", 37)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    [SelectionBase]
    public class ScrollRect : UIBehaviour, IBeginDragHandler, ICanvasElement, IDragHandler, IEndDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ILayoutController, ILayoutElement, ILayoutGroup, IScrollHandler
    {

        protected Vector2 m_ContentStartPosition;
        protected Bounds m_ContentBounds;

        protected ScrollRect();

        public RectTransform content { get; set; }
        public bool horizontal { get; set; }
        public bool vertical { get; set; }
        public MovementType movementType { get; set; }
        public float elasticity { get; set; }
        public bool inertia { get; set; }
        public float decelerationRate { get; set; }
        public float scrollSensitivity { get; set; }
        public RectTransform viewport { get; set; }
        public Scrollbar horizontalScrollbar { get; set; }
        public Scrollbar verticalScrollbar { get; set; }
        public ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
        public ScrollbarVisibility verticalScrollbarVisibility { get; set; }
        public float horizontalScrollbarSpacing { get; set; }
        public float verticalScrollbarSpacing { get; set; }
        public ScrollRectEvent onValueChanged { get; set; }
        protected RectTransform viewRect { get; }
        public Vector2 velocity { get; set; }
        public Vector2 normalizedPosition { get; set; }
        public float horizontalNormalizedPosition { get; set; }
        public float verticalNormalizedPosition { get; set; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public virtual void Rebuild(CanvasUpdate executing);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected override void OnEnable();
        protected override void OnDisable();
        public override bool IsActive();
        public virtual void StopMovement();
        public virtual void OnScroll(PointerEventData data);
        public virtual void OnInitializePotentialDrag(PointerEventData eventData);
        public virtual void OnBeginDrag(PointerEventData eventData);
        public virtual void OnEndDrag(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
        protected virtual void SetContentAnchoredPosition(Vector2 position);
        protected virtual void LateUpdate();
        protected void UpdatePrevData();
        protected virtual void SetNormalizedPosition(float value, int axis);
        protected override void OnRectTransformDimensionsChange();
        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();
        public virtual void SetLayoutHorizontal();
        public virtual void SetLayoutVertical();
        protected void UpdateBounds();
        protected void SetDirty();
        protected void SetDirtyCaching();
        protected override void OnValidate();
        public enum MovementType
        {

            Unrestricted = 0,
            Elastic = 1,
            Clamped = 2
        }
        public enum ScrollbarVisibility
        {

            Permanent = 0,
            AutoHide = 1,
            AutoHideAndExpandViewport = 2
        }
        public class ScrollRectEvent : UnityEvent<Vector2>
        {

            public ScrollRectEvent();
        }
    }
}
