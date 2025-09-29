#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class Clickable : PointerManipulator
    {

        public Clickable(Action handler, long delay, long interval);
        public Clickable(Action<EventBase> handler);
        public Clickable(Action handler);

        protected bool active { get; set; }
        public Vector2 lastMousePosition { get; }

        public event Action<EventBase> clickedWithEventInfo;
        public event Action clicked;

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
        protected void OnMouseDown(MouseDownEvent evt);
        protected void OnMouseMove(MouseMoveEvent evt);
        protected void OnMouseUp(MouseUpEvent evt);
        protected void Invoke(EventBase evt);
        protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId);
        protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition);
        protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId);
        protected virtual void ProcessCancelEvent(EventBase evt, int pointerId);
    }
}
