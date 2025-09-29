#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarBreadcrumbs : VisualElement
    {
        public static readonly string ussClassName;
        public static readonly string itemClassName;
        public static readonly string firstItemClassName;

        public ToolbarBreadcrumbs();

        public void PushItem(string label, Action clickedEvent = null);
        public void PopItem();

        public class UxmlFactory : UxmlFactory<ToolbarBreadcrumbs>
        {
            public UxmlFactory();
        }
    }
}
