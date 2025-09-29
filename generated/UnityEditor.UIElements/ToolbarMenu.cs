#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarMenu : TextElement, IToolbarMenuElement
    {

        public static readonly string ussClassName;
        public static readonly string popupVariantUssClassName;
        public static readonly string textUssClassName;
        public static readonly string arrowUssClassName;

        public ToolbarMenu();

        public DropdownMenu menu { get; }
        public override string text { get; set; }
        public Variant variant { get; set; }
        public class UxmlFactory : UxmlFactory<ToolbarMenu, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextElement.UxmlTraits
        {

            public UxmlTraits();
        }
        public enum Variant
        {

            Default = 0,
            Popup = 1
        }
    }
}
