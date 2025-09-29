#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class Slider : BaseSlider<float>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public Slider();
        public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0);
        public Slider(string label, float start = 0, float end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0);

        public class UxmlFactory : UxmlFactory<Slider, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription>
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
