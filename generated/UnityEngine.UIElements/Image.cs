#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class Image : VisualElement
    {
        public static readonly string ussClassName;

        public Image();

        public Texture image { get; set; }
        public Sprite sprite { get; set; }
        public VectorImage vectorImage { get; set; }
        public Rect sourceRect { get; set; }
        public Rect uv { get; set; }
        public ScaleMode scaleMode { get; set; }
        public Color tintColor { get; set; }

        protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);

        public class UxmlFactory : UxmlFactory<Image, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {
            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
        }
    }
}
