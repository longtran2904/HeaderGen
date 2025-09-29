#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Scrollbar", 36)]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class Scrollbar : Selectable, IBeginDragHandler, ICanvasElement, IDragHandler, IInitializePotentialDragHandler
    {

        protected Scrollbar();

        public RectTransform handleRect { get; set; }
        public Direction direction { get; set; }
        public float value { get; set; }
        public float size { get; set; }
        public int numberOfSteps { get; set; }
        public ScrollEvent onValueChanged { get; set; }

        public virtual void SetValueWithoutNotify(float input);
        protected override void OnValidate();
        public virtual void Rebuild(CanvasUpdate executing);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected override void OnEnable();
        protected override void OnDisable();
        protected virtual void Update();
        protected override void OnRectTransformDimensionsChange();
        public virtual void OnBeginDrag(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
        public override void OnPointerDown(PointerEventData eventData);
        protected IEnumerator ClickRepeat(PointerEventData eventData);
        protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera);
        public override void OnPointerUp(PointerEventData eventData);
        public override void OnMove(AxisEventData eventData);
        public override Selectable FindSelectableOnLeft();
        public override Selectable FindSelectableOnRight();
        public override Selectable FindSelectableOnUp();
        public override Selectable FindSelectableOnDown();
        public virtual void OnInitializePotentialDrag(PointerEventData eventData);
        public void SetDirection(Direction direction, bool includeRectLayouts);
        public enum Direction
        {

            LeftToRight = 0,
            RightToLeft = 1,
            BottomToTop = 2,
            TopToBottom = 3
        }
        public class ScrollEvent : UnityEvent<float>
        {

            public ScrollEvent();
        }
    }
}
