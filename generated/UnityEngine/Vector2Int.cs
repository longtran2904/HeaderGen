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
    [NativeType("Runtime/Math/Vector2Int.h")]
    [UsedByNativeCode]
    public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
    {
        public Vector2Int(int x, int y);

        public int this[int index] { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public float magnitude { get; }
        public int sqrMagnitude { get; }
        public static Vector2Int zero { get; }
        public static Vector2Int one { get; }
        public static Vector2Int up { get; }
        public static Vector2Int down { get; }
        public static Vector2Int left { get; }
        public static Vector2Int right { get; }

        public void Set(int x, int y);
        public static float Distance(Vector2Int a, Vector2Int b);
        public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs);
        public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs);
        public static Vector2Int Scale(Vector2Int a, Vector2Int b);
        public void Scale(Vector2Int scale);
        public void Clamp(Vector2Int min, Vector2Int max);
        public static Vector2Int FloorToInt(Vector2 v);
        public static Vector2Int CeilToInt(Vector2 v);
        public static Vector2Int RoundToInt(Vector2 v);
        public override bool Equals(object other);
        public bool Equals(Vector2Int other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Vector2Int operator -(Vector2Int v);
        public static Vector2Int operator +(Vector2Int a, Vector2Int b);
        public static Vector2Int operator -(Vector2Int a, Vector2Int b);
        public static Vector2Int operator *(Vector2Int a, Vector2Int b);
        public static Vector2Int operator *(int a, Vector2Int b);
        public static Vector2Int operator *(Vector2Int a, int b);
        public static Vector2Int operator /(Vector2Int a, int b);
        public static bool operator ==(Vector2Int lhs, Vector2Int rhs);
        public static bool operator !=(Vector2Int lhs, Vector2Int rhs);

        public static implicit operator Vector2(Vector2Int v);
        public static explicit operator Vector3Int(Vector2Int v);
    }
}
