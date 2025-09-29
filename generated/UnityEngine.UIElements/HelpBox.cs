#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class HelpBox : VisualElement
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string iconUssClassName;
        public static readonly string iconInfoUssClassName;
        public static readonly string iconwarningUssClassName;
        public static readonly string iconErrorUssClassName;

        public HelpBox();
        public HelpBox(string text, HelpBoxMessageType messageType);

        public string text { get; set; }
        public HelpBoxMessageType messageType { get; set; }
        public class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
