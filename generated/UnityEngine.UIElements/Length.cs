#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Length : IEquatable<Length>
    {
        public Length(float value);
        public Length(float value, LengthUnit unit);

        public float value { get; set; }
        public LengthUnit unit { get; set; }

        public static Length Percent(float value);
        public bool Equals(Length other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Length lhs, Length rhs);
        public static bool operator !=(Length lhs, Length rhs);

        public static implicit operator Length(float value);
    }
}
