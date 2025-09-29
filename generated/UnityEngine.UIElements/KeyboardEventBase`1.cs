#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
    {

        protected KeyboardEventBase();

        public EventModifiers modifiers { get; protected set; }
        public char character { get; protected set; }
        public KeyCode keyCode { get; protected set; }
        public bool shiftKey { get; }
        public bool ctrlKey { get; }
        public bool commandKey { get; }
        public bool altKey { get; }
        public bool actionKey { get; }

        protected override void Init();
        public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers);
        public static T GetPooled(Event systemEvent);
    }
}
