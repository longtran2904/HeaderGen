#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Rotate : IEquatable<Rotate>
    {
        public Rotate(Angle angle);

        public Angle angle { get; set; }

        public static Rotate None();
        public bool Equals(Rotate other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Rotate lhs, Rotate rhs);
        public static bool operator !=(Rotate lhs, Rotate rhs);
    }
}
