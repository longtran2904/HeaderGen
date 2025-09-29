#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public struct StyleList<T> : IEquatable<StyleList<T>>, IStyleValue<List<T>>
    {

        public StyleList(List<T> v);
        public StyleList(StyleKeyword keyword);

        public List<T> value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleList<T> other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(StyleList<T> lhs, StyleList<T> rhs);
        public static bool operator !=(StyleList<T> lhs, StyleList<T> rhs);

        public static implicit operator StyleList<T>(StyleKeyword keyword);
        public static implicit operator StyleList<T>(List<T> v);
    }
}
