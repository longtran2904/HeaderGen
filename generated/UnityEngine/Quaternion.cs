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
    [NativeHeader("Runtime/Math/MathScripting.h")]
    [NativeType(Header = "Runtime/Math/Quaternion.h")]
    [UsedByNativeCode]
    public struct Quaternion : IEquatable<Quaternion>, IFormattable
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public const float kEpsilon = 1E-06F;

        public Quaternion(float x, float y, float z, float w);

        public float this[int index] { get; set; }
        public static Quaternion identity { get; }
        public Vector3 eulerAngles { get; set; }
        public Quaternion normalized { get; }

        [FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
        public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection);
        [FreeFunction(IsThreadSafe = True)]
        public static Quaternion Inverse(Quaternion rotation);
        [FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
        public static Quaternion Slerp(Quaternion a, Quaternion b, float t);
        [FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
        public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t);
        [FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t);
        [FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = True)]
        public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t);
        [FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
        public static Quaternion AngleAxis(float angle, Vector3 axis);
        [FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
        public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards);
        [ExcludeFromDocs]
        public static Quaternion LookRotation(Vector3 forward);
        public void Set(float newX, float newY, float newZ, float newW);
        public static float Dot(Quaternion a, Quaternion b);
        [ExcludeFromDocs]
        public void SetLookRotation(Vector3 view);
        public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up);
        public static float Angle(Quaternion a, Quaternion b);
        public static Quaternion Euler(float x, float y, float z);
        public static Quaternion Euler(Vector3 euler);
        public void ToAngleAxis(out float angle, out Vector3 axis);
        public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection);
        public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta);
        public static Quaternion Normalize(Quaternion q);
        public void Normalize();
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Quaternion other);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public static Quaternion EulerRotation(float x, float y, float z);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public static Quaternion EulerRotation(Vector3 euler);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public void SetEulerRotation(float x, float y, float z);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public void SetEulerRotation(Vector3 euler);
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
        public Vector3 ToEuler();
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public static Quaternion EulerAngles(float x, float y, float z);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public static Quaternion EulerAngles(Vector3 euler);
        [Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
        public void ToAxisAngle(out Vector3 axis, out float angle);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public void SetEulerAngles(float x, float y, float z);
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
        public void SetEulerAngles(Vector3 euler);
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
        public static Vector3 ToEulerAngles(Quaternion rotation);
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
        public Vector3 ToEulerAngles();
        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
        public void SetAxisAngle(Vector3 axis, float angle);
        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion AxisAngle(Vector3 axis, float angle);

        public static Quaternion operator *(Quaternion lhs, Quaternion rhs);
        public static Vector3 operator *(Quaternion rotation, Vector3 point);
        public static bool operator ==(Quaternion lhs, Quaternion rhs);
        public static bool operator !=(Quaternion lhs, Quaternion rhs);
    }
}
