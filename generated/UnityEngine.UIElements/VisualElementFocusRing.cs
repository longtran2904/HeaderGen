#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class VisualElementFocusRing : IFocusRing
    {
        public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder);

        public DefaultFocusOrder defaultFocusOrder { get; set; }

        public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);
        public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);

        public enum DefaultFocusOrder
        {
            ChildOrder = 0,
            PositionXY = 1,
            PositionYX = 2
        }
    }
}
