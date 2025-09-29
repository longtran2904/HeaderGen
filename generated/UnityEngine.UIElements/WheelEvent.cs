#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class WheelEvent : MouseEventBase<WheelEvent>
    {

        public WheelEvent();

        public Vector3 delta { get; }

        public static WheelEvent GetPooled(Event systemEvent);
        protected override void Init();
    }
}
