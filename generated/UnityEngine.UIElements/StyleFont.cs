#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleFont : IEquatable<StyleFont>, IStyleValue<Font>
    {

        public StyleFont(Font v);
        public StyleFont(StyleKeyword keyword);

        public Font value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleFont other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleFont lhs, StyleFont rhs);
        public static bool operator !=(StyleFont lhs, StyleFont rhs);

        public static implicit operator StyleFont(StyleKeyword keyword);
        public static implicit operator StyleFont(Font v);
    }
}
