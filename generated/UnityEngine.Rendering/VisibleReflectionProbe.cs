#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
    {

        public Texture texture { get; }
        public ReflectionProbe reflectionProbe { get; }
        public Bounds bounds { get; set; }
        public Matrix4x4 localToWorldMatrix { get; set; }
        public Vector4 hdrData { get; set; }
        public Vector3 center { get; set; }
        public float blendDistance { get; set; }
        public int importance { get; set; }
        public bool isBoxProjection { get; set; }

        public bool Equals(VisibleReflectionProbe other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right);
        public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right);
    }
}
