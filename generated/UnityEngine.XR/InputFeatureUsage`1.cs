#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;

namespace UnityEngine.XR
{
    public struct InputFeatureUsage<T> : IEquatable<InputFeatureUsage<T>>
    {
        public InputFeatureUsage(string usageName);

        public string name { get; set; }

        public override bool Equals(object obj);
        public bool Equals(InputFeatureUsage<T> other);
        public override int GetHashCode();

        public static bool operator ==(InputFeatureUsage<T> a, InputFeatureUsage<T> b);
        public static bool operator !=(InputFeatureUsage<T> a, InputFeatureUsage<T> b);

        public static explicit operator InputFeatureUsage(InputFeatureUsage<T> self);
    }
}
