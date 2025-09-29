#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Slider", 34)]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class Slider : Selectable, ICanvasElement, IDragHandler, IInitializePotentialDragHandler
    {

        [SerializeField]
        protected float m_Value;

        protected Slider();

        public RectTransform fillRect { get; set; }
        public RectTransform handleRect { get; set; }
        public Direction direction { get; set; }
        public float minValue { get; set; }
        public float maxValue { get; set; }
        public bool wholeNumbers { get; set; }
        public virtual float value { get; set; }
        public float normalizedValue { get; set; }
        public SliderEvent onValueChanged { get; set; }

        public virtual void SetValueWithoutNotify(float input);
        protected override void OnValidate();
        public virtual void Rebuild(CanvasUpdate executing);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected override void OnEnable();
        protected override void OnDisable();
        protected virtual void Update();
        protected override void OnDidApplyAnimationProperties();
        protected virtual void Set(float input, bool sendCallback = True);
        protected override void OnRectTransformDimensionsChange();
        public override void OnPointerDown(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
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
        public class SliderEvent : UnityEvent<float>
        {

            public SliderEvent();
        }
    }
}
