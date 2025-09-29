#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleLength : IEquatable<StyleLength>, IStyleValue<Length>
    {
        public StyleLength(float v);
        public StyleLength(Length v);
        public StyleLength(StyleKeyword keyword);

        public Length value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleLength other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleLength lhs, StyleLength rhs);
        public static bool operator !=(StyleLength lhs, StyleLength rhs);

        public static implicit operator StyleLength(StyleKeyword keyword);
        public static implicit operator StyleLength(float v);
        public static implicit operator StyleLength(Length v);
    }
}
