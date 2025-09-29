#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarButton : Button
    {
        public static readonly string ussClassName;

        public ToolbarButton(Action clickEvent);
        public ToolbarButton();

        public class UxmlFactory : UxmlFactory<ToolbarButton, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : Button.UxmlTraits
        {
            public UxmlTraits();
        }
    }
}
