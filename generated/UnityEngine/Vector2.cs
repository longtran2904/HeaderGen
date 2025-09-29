#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    [NativeClass("Vector2f")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Vector2 : IEquatable<Vector2>, IFormattable
    {
        public float x;
        public float y;
        public const float kEpsilon = 1E-05F;
        public const float kEpsilonNormalSqrt = 1E-15F;

        public Vector2(float x, float y);

        public float this[int index] { get; set; }
        public Vector2 normalized { get; }
        public float magnitude { get; }
        public float sqrMagnitude { get; }
        public static Vector2 zero { get; }
        public static Vector2 one { get; }
        public static Vector2 up { get; }
        public static Vector2 down { get; }
        public static Vector2 left { get; }
        public static Vector2 right { get; }
        public static Vector2 positiveInfinity { get; }
        public static Vector2 negativeInfinity { get; }

        public void Set(float newX, float newY);
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t);
        public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t);
        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta);
        public static Vector2 Scale(Vector2 a, Vector2 b);
        public void Scale(Vector2 scale);
        public void Normalize();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Vector2 other);
        public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal);
        public static Vector2 Perpendicular(Vector2 inDirection);
        public static float Dot(Vector2 lhs, Vector2 rhs);
        public static float Angle(Vector2 from, Vector2 to);
        public static float SignedAngle(Vector2 from, Vector2 to);
        public static float Distance(Vector2 a, Vector2 b);
        public static Vector2 ClampMagnitude(Vector2 vector, float maxLength);
        public static float SqrMagnitude(Vector2 a);
        public float SqrMagnitude();
        public static Vector2 Min(Vector2 lhs, Vector2 rhs);
        public static Vector2 Max(Vector2 lhs, Vector2 rhs);
        [ExcludeFromDocs]
        public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed);
        [ExcludeFromDocs]
        public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime);
        public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime);

        public static Vector2 operator +(Vector2 a, Vector2 b);
        public static Vector2 operator -(Vector2 a, Vector2 b);
        public static Vector2 operator *(Vector2 a, Vector2 b);
        public static Vector2 operator /(Vector2 a, Vector2 b);
        public static Vector2 operator -(Vector2 a);
        public static Vector2 operator *(Vector2 a, float d);
        public static Vector2 operator *(float d, Vector2 a);
        public static Vector2 operator /(Vector2 a, float d);
        public static bool operator ==(Vector2 lhs, Vector2 rhs);
        public static bool operator !=(Vector2 lhs, Vector2 rhs);

        public static implicit operator Vector2(Vector3 v);
        public static implicit operator Vector3(Vector2 v);
    }
}
