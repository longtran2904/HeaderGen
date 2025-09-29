#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class VisualElementFocusChangeDirection : FocusChangeDirection
    {

        protected VisualElementFocusChangeDirection(int value);

        public static FocusChangeDirection left { get; }
        public static FocusChangeDirection right { get; }
        protected static VisualElementFocusChangeDirection lastValue { get; }
    }
}
