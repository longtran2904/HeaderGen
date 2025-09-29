#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class Button : TextElement
    {

        public static readonly string ussClassName;

        public Button();
        public Button(Action clickEvent);

        public Clickable clickable { get; set; }

        [Obsolete("onClick is obsolete. Use clicked instead (UnityUpgradable) -> clicked", True)]
        public event Action onClick;
        public event Action clicked;

        protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
        public class UxmlFactory : UxmlFactory<Button, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextElement.UxmlTraits
        {

            public UxmlTraits();
        }
    }
}
