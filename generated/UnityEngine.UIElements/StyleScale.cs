#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleScale : IEquatable<StyleScale>, IStyleValue<Scale>
    {

        public StyleScale(Scale v);
        public StyleScale(StyleKeyword keyword);

        public Scale value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleScale other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleScale lhs, StyleScale rhs);
        public static bool operator !=(StyleScale lhs, StyleScale rhs);

        public static implicit operator StyleScale(StyleKeyword keyword);
        public static implicit operator StyleScale(Scale v);
    }
}
