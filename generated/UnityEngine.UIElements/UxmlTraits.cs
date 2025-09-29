#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public abstract class UxmlTraits
    {

        protected UxmlTraits();

        public bool canHaveAnyAttribute { get; protected set; }
        public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription { get; }
        public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
    }
}
