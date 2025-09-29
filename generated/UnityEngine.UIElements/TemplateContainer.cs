#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class TemplateContainer : BindableElement
    {
        public TemplateContainer();
        public TemplateContainer(string templateId);

        public string templateId { get; }
        public VisualTreeAsset templateSource { get; }
        public override VisualElement contentContainer { get; }

        public class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
        {
            public UxmlFactory();

            public override string uxmlName { get; }
            public override string uxmlQualifiedName { get; }
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {
            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
