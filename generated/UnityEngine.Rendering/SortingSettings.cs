#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct SortingSettings : IEquatable<SortingSettings>
    {
        public SortingSettings(Camera camera);

        public Matrix4x4 worldToCameraMatrix { get; set; }
        public Vector3 cameraPosition { get; set; }
        public Vector3 customAxis { get; set; }
        public SortingCriteria criteria { get; set; }
        public DistanceMetric distanceMetric { get; set; }

        public bool Equals(SortingSettings other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(SortingSettings left, SortingSettings right);
        public static bool operator !=(SortingSettings left, SortingSettings right);
    }
}
