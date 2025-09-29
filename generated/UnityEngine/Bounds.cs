#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("AABB")]
    [NativeHeader("Runtime/Math/MathScripting.h")]
    [NativeHeader("Runtime/Geometry/Ray.h")]
    [NativeHeader("Runtime/Geometry/AABB.h")]
    [NativeHeader("Runtime/Geometry/Intersection.h")]
    [NativeType(Header = "Runtime/Geometry/AABB.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Bounds : IEquatable<Bounds>, IFormattable
    {
        public Bounds(Vector3 center, Vector3 size);

        public Vector3 center { get; set; }
        public Vector3 size { get; set; }
        public Vector3 extents { get; set; }
        public Vector3 min { get; set; }
        public Vector3 max { get; set; }

        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Bounds other);
        public void SetMinMax(Vector3 min, Vector3 max);
        public void Encapsulate(Vector3 point);
        public void Encapsulate(Bounds bounds);
        public void Expand(float amount);
        public void Expand(Vector3 amount);
        public bool Intersects(Bounds bounds);
        public bool IntersectRay(Ray ray);
        public bool IntersectRay(Ray ray, out float distance);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        [NativeMethod("IsInside", IsThreadSafe = True)]
        public bool Contains(Vector3 point);
        [FreeFunction("BoundsScripting::SqrDistance", IsThreadSafe = True, HasExplicitThis = True)]
        public float SqrDistance(Vector3 point);
        [FreeFunction("BoundsScripting::ClosestPoint", IsThreadSafe = True, HasExplicitThis = True)]
        public Vector3 ClosestPoint(Vector3 point);

        public static bool operator ==(Bounds lhs, Bounds rhs);
        public static bool operator !=(Bounds lhs, Bounds rhs);
    }
}
