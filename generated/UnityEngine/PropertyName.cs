#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct PropertyName : IEquatable<PropertyName>
    {
        public PropertyName(string name);
        public PropertyName(PropertyName other);
        public PropertyName(int id);

        public static bool IsNullOrEmpty(PropertyName prop);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(PropertyName other);
        public override string ToString();

        public static bool operator ==(PropertyName lhs, PropertyName rhs);
        public static bool operator !=(PropertyName lhs, PropertyName rhs);

        public static implicit operator PropertyName(string name);
        public static implicit operator PropertyName(int id);
    }
}
