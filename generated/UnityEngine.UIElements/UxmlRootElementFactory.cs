#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits>
    {

        public UxmlRootElementFactory();

        public override string uxmlName { get; }
        public override string uxmlQualifiedName { get; }
        public override string substituteForTypeName { get; }
        public override string substituteForTypeNamespace { get; }
        public override string substituteForTypeQualifiedName { get; }

        public override VisualElement Create(IUxmlAttributes bag, CreationContext cc);
    }
}
