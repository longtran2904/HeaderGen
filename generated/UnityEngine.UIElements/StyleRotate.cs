#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleRotate : IEquatable<StyleRotate>, IStyleValue<Rotate>
    {
        public StyleRotate(Rotate v);
        public StyleRotate(StyleKeyword keyword);

        public Rotate value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleRotate other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleRotate lhs, StyleRotate rhs);
        public static bool operator !=(StyleRotate lhs, StyleRotate rhs);

        public static implicit operator StyleRotate(StyleKeyword keyword);
        public static implicit operator StyleRotate(Rotate v);
    }
}
