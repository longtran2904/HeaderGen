#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T>, IMouseCaptureEvent where T : MouseCaptureEventBase<T>, new()
    {
        protected MouseCaptureEventBase();

        public IEventHandler relatedTarget { get; }

        public static T GetPooled(IEventHandler target, IEventHandler relatedTarget);
        protected override void Init();
    }
}
