#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct EasingFunction : IEquatable<EasingFunction>
    {
        public EasingFunction(EasingMode mode);

        public EasingMode mode { get; set; }

        public bool Equals(EasingFunction other);
        public override bool Equals(object obj);
        public override string ToString();
        public override int GetHashCode();

        public static bool operator ==(EasingFunction lhs, EasingFunction rhs);
        public static bool operator !=(EasingFunction lhs, EasingFunction rhs);

        public static implicit operator EasingFunction(EasingMode easingMode);
    }
}
