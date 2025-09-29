#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarPopupSearchField : ToolbarSearchField, IToolbarMenuElement
    {
        public ToolbarPopupSearchField();

        public DropdownMenu menu { get; }

        public class UxmlFactory : UxmlFactory<ToolbarPopupSearchField>
        {
            public UxmlFactory();
        }
    }
}
