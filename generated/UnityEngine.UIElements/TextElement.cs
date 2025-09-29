#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class TextElement : BindableElement, INotifyValueChanged<string>, ITextElement
    {

        public static readonly string ussClassName;

        public TextElement();

        public virtual string text { get; set; }
        public bool enableRichText { get; set; }
        public bool displayTooltipWhenElided { get; set; }
        public bool isElided { get; }

        public override void HandleEvent(EventBase evt);
        public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);
        protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
        public class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {

            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
