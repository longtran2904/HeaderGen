#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct TimeValue : IEquatable<TimeValue>
    {
        public TimeValue(float value);
        public TimeValue(float value, TimeUnit unit);

        public float value { get; set; }
        public TimeUnit unit { get; set; }

        public bool Equals(TimeValue other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(TimeValue lhs, TimeValue rhs);
        public static bool operator !=(TimeValue lhs, TimeValue rhs);

        public static implicit operator TimeValue(float value);
    }
}
