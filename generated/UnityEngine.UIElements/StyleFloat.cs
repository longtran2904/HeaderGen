#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleFloat : IEquatable<StyleFloat>, IStyleValue<float>
    {

        public StyleFloat(float v);
        public StyleFloat(StyleKeyword keyword);

        public float value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleFloat other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleFloat lhs, StyleFloat rhs);
        public static bool operator !=(StyleFloat lhs, StyleFloat rhs);

        public static implicit operator StyleFloat(StyleKeyword keyword);
        public static implicit operator StyleFloat(float v);
    }
}
