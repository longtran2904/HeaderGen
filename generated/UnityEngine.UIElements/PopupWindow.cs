#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class PopupWindow : TextElement
    {

        public static readonly string ussClassName;
        public static readonly string contentUssClassName;

        public PopupWindow();

        public override VisualElement contentContainer { get; }
        public class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextElement.UxmlTraits
        {

            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
        }
    }
}
