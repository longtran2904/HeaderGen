#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleTranslate : IEquatable<StyleTranslate>, IStyleValue<Translate>
    {
        public StyleTranslate(Translate v);
        public StyleTranslate(StyleKeyword keyword);

        public Translate value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleTranslate other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs);
        public static bool operator !=(StyleTranslate lhs, StyleTranslate rhs);

        public static implicit operator StyleTranslate(StyleKeyword keyword);
        public static implicit operator StyleTranslate(Translate v);
    }
}
