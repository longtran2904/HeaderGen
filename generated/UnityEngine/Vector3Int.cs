#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    [UsedByNativeCode]
    public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
    {
        public Vector3Int(int x, int y);
        public Vector3Int(int x, int y, int z);

        public int this[int index] { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public float magnitude { get; }
        public int sqrMagnitude { get; }
        public static Vector3Int zero { get; }
        public static Vector3Int one { get; }
        public static Vector3Int up { get; }
        public static Vector3Int down { get; }
        public static Vector3Int left { get; }
        public static Vector3Int right { get; }
        public static Vector3Int forward { get; }
        public static Vector3Int back { get; }

        public void Set(int x, int y, int z);
        public static float Distance(Vector3Int a, Vector3Int b);
        public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs);
        public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs);
        public static Vector3Int Scale(Vector3Int a, Vector3Int b);
        public void Scale(Vector3Int scale);
        public void Clamp(Vector3Int min, Vector3Int max);
        public static Vector3Int FloorToInt(Vector3 v);
        public static Vector3Int CeilToInt(Vector3 v);
        public static Vector3Int RoundToInt(Vector3 v);
        public override bool Equals(object other);
        public bool Equals(Vector3Int other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Vector3Int operator +(Vector3Int a, Vector3Int b);
        public static Vector3Int operator -(Vector3Int a, Vector3Int b);
        public static Vector3Int operator *(Vector3Int a, Vector3Int b);
        public static Vector3Int operator -(Vector3Int a);
        public static Vector3Int operator *(Vector3Int a, int b);
        public static Vector3Int operator *(int a, Vector3Int b);
        public static Vector3Int operator /(Vector3Int a, int b);
        public static bool operator ==(Vector3Int lhs, Vector3Int rhs);
        public static bool operator !=(Vector3Int lhs, Vector3Int rhs);

        public static implicit operator Vector3(Vector3Int v);
        public static explicit operator Vector2Int(Vector3Int v);
    }
}
