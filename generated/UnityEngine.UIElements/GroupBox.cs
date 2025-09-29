#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class GroupBox : BindableElement, IGroupBox
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;

        public GroupBox();
        public GroupBox(string text);

        public string text { get; set; }

        public class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
