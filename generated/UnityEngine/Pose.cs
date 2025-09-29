#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    public struct Pose : IEquatable<Pose>
    {
        public Vector3 position;
        public Quaternion rotation;

        public Pose(Vector3 position, Quaternion rotation);

        public Vector3 forward { get; }
        public Vector3 right { get; }
        public Vector3 up { get; }
        public static Pose identity { get; }

        public override string ToString();
        public string ToString(string format);
        public Pose GetTransformedBy(Pose lhs);
        public Pose GetTransformedBy(Transform lhs);
        public override bool Equals(object obj);
        public bool Equals(Pose other);
        public override int GetHashCode();

        public static bool operator ==(Pose a, Pose b);
        public static bool operator !=(Pose a, Pose b);
    }
}
