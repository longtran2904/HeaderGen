#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Translate : IEquatable<Translate>
    {

        public Translate(Length x, Length y, float z);
        public Translate(Length x, Length y);

        public Length x { get; set; }
        public Length y { get; set; }
        public float z { get; set; }

        public static Translate None();
        public bool Equals(Translate other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Translate lhs, Translate rhs);
        public static bool operator !=(Translate lhs, Translate rhs);
    }
}
