#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class UxmlEnumeration : UxmlTypeRestriction
    {

        public UxmlEnumeration();

        public IEnumerable<string> values { get; set; }

        public override bool Equals(UxmlTypeRestriction other);
    }
}
