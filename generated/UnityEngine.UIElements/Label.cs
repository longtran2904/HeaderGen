#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class Label : TextElement
    {
        public static readonly string ussClassName;

        public Label();
        public Label(string text);

        public class UxmlFactory : UxmlFactory<Label, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : TextElement.UxmlTraits
        {
            public UxmlTraits();
        }
    }
}
