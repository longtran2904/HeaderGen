#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal where T : PointerEventBase<T>, new()
    {
        protected PointerEventBase();

        public int pointerId { get; protected set; }
        public string pointerType { get; protected set; }
        public bool isPrimary { get; protected set; }
        public int button { get; protected set; }
        public int pressedButtons { get; protected set; }
        public Vector3 position { get; protected set; }
        public Vector3 localPosition { get; protected set; }
        public Vector3 deltaPosition { get; protected set; }
        public float deltaTime { get; protected set; }
        public int clickCount { get; protected set; }
        public float pressure { get; protected set; }
        public float tangentialPressure { get; protected set; }
        public float altitudeAngle { get; protected set; }
        public float azimuthAngle { get; protected set; }
        public float twist { get; protected set; }
        public Vector2 radius { get; protected set; }
        public Vector2 radiusVariance { get; protected set; }
        public EventModifiers modifiers { get; protected set; }
        public bool shiftKey { get; }
        public bool ctrlKey { get; }
        public bool commandKey { get; }
        public bool altKey { get; }
        public bool actionKey { get; }
        public override IEventHandler currentTarget { get; }

        protected override void Init();
        public static T GetPooled(Event systemEvent);
        public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None);
        public static T GetPooled(IPointerEvent triggerEvent);
        protected internal override void PreDispatch(IPanel panel);
        protected internal override void PostDispatch(IPanel panel);
    }
}
