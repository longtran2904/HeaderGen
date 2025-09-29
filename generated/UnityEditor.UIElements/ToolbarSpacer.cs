#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarSpacer : VisualElement
    {

        public static readonly string ussClassName;
        [Obsolete("The `fixedSpacerVariantUssClassName` style has been deprecated as is it now the default style.")]
        public static readonly string fixedSpacerVariantUssClassName;
        public static readonly string flexibleSpacerVariantUssClassName;

        public ToolbarSpacer();

        public bool flex { get; set; }
        public class UxmlFactory : UxmlFactory<ToolbarSpacer>
        {

            public UxmlFactory();
        }
    }
}
