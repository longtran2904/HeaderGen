#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class Scroller : VisualElement
    {

        public static readonly string ussClassName;
        public static readonly string horizontalVariantUssClassName;
        public static readonly string verticalVariantUssClassName;
        public static readonly string sliderUssClassName;
        public static readonly string lowButtonUssClassName;
        public static readonly string highButtonUssClassName;

        public Scroller();
        public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical);

        public Slider slider { get; }
        public RepeatButton lowButton { get; }
        public RepeatButton highButton { get; }
        public float value { get; set; }
        public float lowValue { get; set; }
        public float highValue { get; set; }
        public SliderDirection direction { get; set; }

        public event Action<float> valueChanged;

        public void Adjust(float factor);
        public void ScrollPageUp();
        public void ScrollPageDown();
        public void ScrollPageUp(float factor);
        public void ScrollPageDown(float factor);
        public class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {

            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
