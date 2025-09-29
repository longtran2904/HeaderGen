#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory, IUxmlFactoryInternal where TCreatedType : VisualElement, new() where TTraits : UxmlTraits, new()
    {
        protected UxmlFactory();

        public virtual string uxmlName { get; }
        public virtual string uxmlNamespace { get; }
        public virtual string uxmlQualifiedName { get; }
        public bool canHaveAnyAttribute { get; }
        public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription { get; }
        public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
        public virtual string substituteForTypeName { get; }
        public virtual string substituteForTypeNamespace { get; }
        public virtual string substituteForTypeQualifiedName { get; }

        public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
        public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc);
    }
}
