#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StylePropertyName : IEquatable<StylePropertyName>
    {
        public StylePropertyName(string name);

        public static bool IsNullOrEmpty(StylePropertyName propertyName);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(StylePropertyName other);
        public override string ToString();

        public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs);
        public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs);

        public static implicit operator StylePropertyName(string name);
    }
}
