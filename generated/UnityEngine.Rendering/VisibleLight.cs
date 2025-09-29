#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct VisibleLight : IEquatable<VisibleLight>
    {
        public Light light { get; }
        public LightType lightType { get; set; }
        public Color finalColor { get; set; }
        public Rect screenRect { get; set; }
        public Matrix4x4 localToWorldMatrix { get; set; }
        public float range { get; set; }
        public float spotAngle { get; set; }
        public bool intersectsNearPlane { get; set; }
        public bool intersectsFarPlane { get; set; }

        public bool Equals(VisibleLight other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(VisibleLight left, VisibleLight right);
        public static bool operator !=(VisibleLight left, VisibleLight right);
    }
}
