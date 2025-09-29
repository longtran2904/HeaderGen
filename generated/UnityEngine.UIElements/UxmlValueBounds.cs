#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class UxmlValueBounds : UxmlTypeRestriction
    {

        public UxmlValueBounds();

        public string min { get; set; }
        public string max { get; set; }
        public bool excludeMin { get; set; }
        public bool excludeMax { get; set; }

        public override bool Equals(UxmlTypeRestriction other);
    }
}
