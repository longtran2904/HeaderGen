#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Scale : IEquatable<Scale>
    {
        public Scale(Vector3 scale);

        public Vector3 value { get; set; }

        public static Scale None();
        public bool Equals(Scale other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Scale lhs, Scale rhs);
        public static bool operator !=(Scale lhs, Scale rhs);
    }
}
