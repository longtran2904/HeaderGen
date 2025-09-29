#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class Focusable : CallbackEventHandler
    {
        protected Focusable();

        public abstract FocusController focusController { get; }
        public bool focusable { get; set; }
        public int tabIndex { get; set; }
        public bool delegatesFocus { get; set; }
        public virtual bool canGrabFocus { get; }

        public virtual void Focus();
        public virtual void Blur();
        protected override void ExecuteDefaultAction(EventBase evt);
    }
}
