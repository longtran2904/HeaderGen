#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleBackground : IEquatable<StyleBackground>, IStyleValue<Background>
    {
        public StyleBackground(Background v);
        public StyleBackground(Texture2D v);
        public StyleBackground(Sprite v);
        public StyleBackground(VectorImage v);
        public StyleBackground(StyleKeyword keyword);

        public Background value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleBackground other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleBackground lhs, StyleBackground rhs);
        public static bool operator !=(StyleBackground lhs, StyleBackground rhs);

        public static implicit operator StyleBackground(StyleKeyword keyword);
        public static implicit operator StyleBackground(Background v);
        public static implicit operator StyleBackground(Texture2D v);
    }
}
