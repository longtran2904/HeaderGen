#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class SliderInt : BaseSlider<int>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public SliderInt();
        public SliderInt(int start, int end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0);
        public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0);

        public override float pageSize { get; set; }

        public class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
