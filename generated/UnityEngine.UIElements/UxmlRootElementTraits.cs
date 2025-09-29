#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class UxmlRootElementTraits : UxmlTraits
    {

        protected UxmlStringAttributeDescription m_Name;

        public UxmlRootElementTraits();

        public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
    }
}
