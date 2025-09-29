#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleTransformOrigin : IEquatable<StyleTransformOrigin>, IStyleValue<TransformOrigin>
    {

        public StyleTransformOrigin(TransformOrigin v);
        public StyleTransformOrigin(StyleKeyword keyword);

        public TransformOrigin value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleTransformOrigin other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs);
        public static bool operator !=(StyleTransformOrigin lhs, StyleTransformOrigin rhs);

        public static implicit operator StyleTransformOrigin(StyleKeyword keyword);
        public static implicit operator StyleTransformOrigin(TransformOrigin v);
    }
}
