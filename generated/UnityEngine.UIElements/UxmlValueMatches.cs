#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class UxmlValueMatches : UxmlTypeRestriction
    {
        public UxmlValueMatches();

        public string regex { get; set; }

        public override bool Equals(UxmlTypeRestriction other);
    }
}
