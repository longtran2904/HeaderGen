#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public abstract class EventBase : IDisposable
    {

        protected EventBase();

        public virtual long eventTypeId { get; }
        public long timestamp { get; }
        public bool bubbles { get; protected set; }
        public bool tricklesDown { get; protected set; }
        public IEventHandler target { get; set; }
        public bool isPropagationStopped { get; }
        public bool isImmediatePropagationStopped { get; }
        public bool isDefaultPrevented { get; }
        public PropagationPhase propagationPhase { get; }
        public virtual IEventHandler currentTarget { get; }
        public bool dispatch { get; }
        public Event imguiEvent { get; protected set; }
        public Vector2 originalMousePosition { get; }
        protected bool pooled { get; set; }

        protected static long RegisterEventType();
        [Obsolete("Override PreDispatch(IPanel panel) instead.")]
        protected virtual void PreDispatch();
        protected internal virtual void PreDispatch(IPanel panel);
        [Obsolete("Override PostDispatch(IPanel panel) instead.")]
        protected virtual void PostDispatch();
        protected internal virtual void PostDispatch(IPanel panel);
        public void StopPropagation();
        public void StopImmediatePropagation();
        public void PreventDefault();
        protected virtual void Init();
        public abstract void Dispose();
    }
}
