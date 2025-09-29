#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal where T : MouseEventBase<T>, new()
    {

        protected MouseEventBase();

        public EventModifiers modifiers { get; protected set; }
        public Vector2 mousePosition { get; protected set; }
        public Vector2 localMousePosition { get; }
        public Vector2 mouseDelta { get; protected set; }
        public int clickCount { get; protected set; }
        public int button { get; protected set; }
        public int pressedButtons { get; protected set; }
        public bool shiftKey { get; }
        public bool ctrlKey { get; }
        public bool commandKey { get; }
        public bool altKey { get; }
        public bool actionKey { get; }
        public override IEventHandler currentTarget { get; }

        protected override void Init();
        protected internal override void PreDispatch(IPanel panel);
        protected internal override void PostDispatch(IPanel panel);
        public static T GetPooled(Event systemEvent);
        public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers = EventModifiers.None);
        public static T GetPooled(IMouseEvent triggerEvent);
        protected static T GetPooled(IPointerEvent pointerEvent);
    }
}
