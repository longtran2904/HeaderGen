#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    [NativeClass("Vector4f")]
    [NativeHeader("Runtime/Math/Vector4.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Vector4 : IEquatable<Vector4>, IFormattable
    {

        public float x;
        public float y;
        public float z;
        public float w;
        public const float kEpsilon = 1E-05F;

        public Vector4(float x, float y, float z, float w);
        public Vector4(float x, float y, float z);
        public Vector4(float x, float y);

        public float this[int index] { get; set; }
        public Vector4 normalized { get; }
        public float magnitude { get; }
        public float sqrMagnitude { get; }
        public static Vector4 zero { get; }
        public static Vector4 one { get; }
        public static Vector4 positiveInfinity { get; }
        public static Vector4 negativeInfinity { get; }

        public void Set(float newX, float newY, float newZ, float newW);
        public static Vector4 Lerp(Vector4 a, Vector4 b, float t);
        public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t);
        public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta);
        public static Vector4 Scale(Vector4 a, Vector4 b);
        public void Scale(Vector4 scale);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Vector4 other);
        public static Vector4 Normalize(Vector4 a);
        public void Normalize();
        public static float Dot(Vector4 a, Vector4 b);
        public static Vector4 Project(Vector4 a, Vector4 b);
        public static float Distance(Vector4 a, Vector4 b);
        public static float Magnitude(Vector4 a);
        public static Vector4 Min(Vector4 lhs, Vector4 rhs);
        public static Vector4 Max(Vector4 lhs, Vector4 rhs);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public static float SqrMagnitude(Vector4 a);
        public float SqrMagnitude();

        public static Vector4 operator +(Vector4 a, Vector4 b);
        public static Vector4 operator -(Vector4 a, Vector4 b);
        public static Vector4 operator -(Vector4 a);
        public static Vector4 operator *(Vector4 a, float d);
        public static Vector4 operator *(float d, Vector4 a);
        public static Vector4 operator /(Vector4 a, float d);
        public static bool operator ==(Vector4 lhs, Vector4 rhs);
        public static bool operator !=(Vector4 lhs, Vector4 rhs);

        public static implicit operator Vector4(Vector3 v);
        public static implicit operator Vector3(Vector4 v);
        public static implicit operator Vector4(Vector2 v);
        public static implicit operator Vector2(Vector4 v);
    }
}
