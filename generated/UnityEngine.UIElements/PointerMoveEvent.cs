#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
    {
        public PointerMoveEvent();

        protected override void Init();
        protected internal override void PostDispatch(IPanel panel);
    }
}
