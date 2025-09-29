#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleCursor : IEquatable<StyleCursor>, IStyleValue<Cursor>
    {
        public StyleCursor(Cursor v);
        public StyleCursor(StyleKeyword keyword);

        public Cursor value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleCursor other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleCursor lhs, StyleCursor rhs);
        public static bool operator !=(StyleCursor lhs, StyleCursor rhs);

        public static implicit operator StyleCursor(StyleKeyword keyword);
        public static implicit operator StyleCursor(Cursor v);
    }
}
