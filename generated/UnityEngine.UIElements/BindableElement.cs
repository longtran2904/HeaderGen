#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class BindableElement : VisualElement, IBindable
    {
        public BindableElement();

        public IBinding binding { get; set; }
        public string bindingPath { get; set; }

        public class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
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
