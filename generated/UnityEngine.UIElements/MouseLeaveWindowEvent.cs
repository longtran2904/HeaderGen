#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
    {
        public MouseLeaveWindowEvent();

        protected override void Init();
        public static MouseLeaveWindowEvent GetPooled(Event systemEvent);
        protected internal override void PostDispatch(IPanel panel);
    }
}
