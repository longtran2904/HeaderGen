#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleColor : IEquatable<StyleColor>, IStyleValue<Color>
    {

        public StyleColor(Color v);
        public StyleColor(StyleKeyword keyword);

        public Color value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleColor other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleColor lhs, StyleColor rhs);
        public static bool operator !=(StyleColor lhs, StyleColor rhs);
        public static bool operator ==(StyleColor lhs, Color rhs);
        public static bool operator !=(StyleColor lhs, Color rhs);

        public static implicit operator StyleColor(StyleKeyword keyword);
        public static implicit operator StyleColor(Color v);
    }
}
