#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleInt : IEquatable<StyleInt>, IStyleValue<int>
    {

        public StyleInt(int v);
        public StyleInt(StyleKeyword keyword);

        public int value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleInt other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleInt lhs, StyleInt rhs);
        public static bool operator !=(StyleInt lhs, StyleInt rhs);

        public static implicit operator StyleInt(StyleKeyword keyword);
        public static implicit operator StyleInt(int v);
    }
}
