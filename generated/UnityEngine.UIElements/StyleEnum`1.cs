#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct StyleEnum<T> : IEquatable<StyleEnum<T>>, IStyleValue<T> where T : IConvertible, struct
    {
        public StyleEnum(T v);
        public StyleEnum(StyleKeyword keyword);

        public T value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleEnum<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs);
        public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs);

        public static implicit operator StyleEnum<T>(StyleKeyword keyword);
        public static implicit operator StyleEnum<T>(T v);
    }
}
