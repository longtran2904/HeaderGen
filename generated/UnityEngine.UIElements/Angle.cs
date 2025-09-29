#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Angle : IEquatable<Angle>
    {
        public Angle(float value);
        public Angle(float value, AngleUnit unit);

        public float value { get; set; }
        public AngleUnit unit { get; set; }

        public static Angle Degrees(float value);
        public float ToDegrees();
        public bool Equals(Angle other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Angle lhs, Angle rhs);
        public static bool operator !=(Angle lhs, Angle rhs);

        public static implicit operator Angle(float value);
    }
}
