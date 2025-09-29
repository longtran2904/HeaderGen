#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine.UIElements
{
    [DefaultMember("Item")]
    public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
    {

        public StyleSheet this[int index] { get; }
        public int count { get; }

        public void Add(StyleSheet styleSheet);
        public void Clear();
        public bool Remove(StyleSheet styleSheet);
        public bool Contains(StyleSheet styleSheet);
        public bool Equals(VisualElementStyleSheetSet other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(VisualElementStyleSheetSet left, VisualElementStyleSheetSet right);
        public static bool operator !=(VisualElementStyleSheetSet left, VisualElementStyleSheetSet right);
    }
}
