#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleTextShadow : IEquatable<StyleTextShadow>, IStyleValue<TextShadow>
    {

        public StyleTextShadow(TextShadow v);
        public StyleTextShadow(StyleKeyword keyword);

        public TextShadow value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleTextShadow other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs);
        public static bool operator !=(StyleTextShadow lhs, StyleTextShadow rhs);

        public static implicit operator StyleTextShadow(StyleKeyword keyword);
        public static implicit operator StyleTextShadow(TextShadow v);
    }
}
