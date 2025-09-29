#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarToggle : Toggle
    {
        public static readonly string ussClassName;

        public ToolbarToggle();

        public class UxmlFactory : UxmlFactory<ToolbarToggle, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : Toggle.UxmlTraits
        {
            public UxmlTraits();
        }
    }
}
