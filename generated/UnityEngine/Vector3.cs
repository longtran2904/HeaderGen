#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    [NativeClass("Vector3f")]
    [NativeHeader("Runtime/Math/Vector3.h")]
    [NativeHeader("Runtime/Math/MathScripting.h")]
    [NativeType(Header = "Runtime/Math/Vector3.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Vector3 : IEquatable<Vector3>, IFormattable
    {

        public float x;
        public float y;
        public float z;
        public const float kEpsilon = 1E-05F;
        public const float kEpsilonNormalSqrt = 1E-15F;

        public Vector3(float x, float y, float z);
        public Vector3(float x, float y);

        public float this[int index] { get; set; }
        public Vector3 normalized { get; }
        public float magnitude { get; }
        public float sqrMagnitude { get; }
        public static Vector3 zero { get; }
        public static Vector3 one { get; }
        public static Vector3 forward { get; }
        public static Vector3 back { get; }
        public static Vector3 up { get; }
        public static Vector3 down { get; }
        public static Vector3 left { get; }
        public static Vector3 right { get; }
        public static Vector3 positiveInfinity { get; }
        public static Vector3 negativeInfinity { get; }
        [Obsolete("Use Vector3.forward instead.")]
        public static Vector3 fwd { get; }

        [FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
        public static Vector3 Slerp(Vector3 a, Vector3 b, float t);
        [FreeFunction("VectorScripting::SlerpUnclamped", IsThreadSafe = True)]
        public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t);
        public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent);
        public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal);
        [FreeFunction(IsThreadSafe = True)]
        public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta);
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t);
        public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t);
        public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta);
        [ExcludeFromDocs]
        public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed);
        [ExcludeFromDocs]
        public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime);
        public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime);
        public void Set(float newX, float newY, float newZ);
        public static Vector3 Scale(Vector3 a, Vector3 b);
        public void Scale(Vector3 scale);
        public static Vector3 Cross(Vector3 lhs, Vector3 rhs);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Vector3 other);
        public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal);
        public static Vector3 Normalize(Vector3 value);
        public void Normalize();
        public static float Dot(Vector3 lhs, Vector3 rhs);
        public static Vector3 Project(Vector3 vector, Vector3 onNormal);
        public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal);
        public static float Angle(Vector3 from, Vector3 to);
        public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis);
        public static float Distance(Vector3 a, Vector3 b);
        public static Vector3 ClampMagnitude(Vector3 vector, float maxLength);
        public static float Magnitude(Vector3 vector);
        public static float SqrMagnitude(Vector3 vector);
        public static Vector3 Min(Vector3 lhs, Vector3 rhs);
        public static Vector3 Max(Vector3 lhs, Vector3 rhs);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        [Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
        public static float AngleBetween(Vector3 from, Vector3 to);
        [Obsolete("Use Vector3.ProjectOnPlane instead.")]
        public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat);

        public static Vector3 operator +(Vector3 a, Vector3 b);
        public static Vector3 operator -(Vector3 a, Vector3 b);
        public static Vector3 operator -(Vector3 a);
        public static Vector3 operator *(Vector3 a, float d);
        public static Vector3 operator *(float d, Vector3 a);
        public static Vector3 operator /(Vector3 a, float d);
        public static bool operator ==(Vector3 lhs, Vector3 rhs);
        public static bool operator !=(Vector3 lhs, Vector3 rhs);
    }
}
