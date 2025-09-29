#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEvent, IPointerCaptureEventInternal where T : PointerCaptureEventBase<T>, new()
    {

        protected PointerCaptureEventBase();

        public IEventHandler relatedTarget { get; }
        public int pointerId { get; }

        protected override void Init();
        public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId);
    }
}
