#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class TooltipEvent : EventBase<TooltipEvent>
    {

        public TooltipEvent();

        public string tooltip { get; set; }
        public Rect rect { get; set; }

        protected override void Init();
    }
}
