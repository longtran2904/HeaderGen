#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct LODParameters : IEquatable<LODParameters>
    {

        public bool isOrthographic { get; set; }
        public Vector3 cameraPosition { get; set; }
        public float fieldOfView { get; set; }
        public float orthoSize { get; set; }
        public int cameraPixelHeight { get; set; }

        public bool Equals(LODParameters other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(LODParameters left, LODParameters right);
        public static bool operator !=(LODParameters left, LODParameters right);
    }
}
