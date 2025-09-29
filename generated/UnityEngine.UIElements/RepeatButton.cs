#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class RepeatButton : TextElement
    {
        public static readonly string ussClassName;

        public RepeatButton();
        public RepeatButton(Action clickEvent, long delay, long interval);

        public void SetAction(Action clickEvent, long delay, long interval);

        public class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : TextElement.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
