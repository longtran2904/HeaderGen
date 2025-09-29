#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public interface IUxmlFactory
    {

        string uxmlName { get; }
        string uxmlNamespace { get; }
        string uxmlQualifiedName { get; }
        bool canHaveAnyAttribute { get; }
        IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription { get; }
        IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
        string substituteForTypeName { get; }
        string substituteForTypeNamespace { get; }
        string substituteForTypeQualifiedName { get; }

        bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
        VisualElement Create(IUxmlAttributes bag, CreationContext cc);
    }
}
