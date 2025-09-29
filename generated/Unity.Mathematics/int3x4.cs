#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct int3x4 : IEquatable<int3x4>, IFormattable
    {

        public int3 c0;
        public int3 c1;
        public int3 c2;
        public int3 c3;
        public static readonly int3x4 zero;

        public int3x4(int3 c0, int3 c1, int3 c2, int3 c3);
        public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23);
        public int3x4(int v);
        public int3x4(bool v);
        public int3x4(bool3x4 v);
        public int3x4(uint v);
        public int3x4(uint3x4 v);
        public int3x4(float v);
        public int3x4(float3x4 v);
        public int3x4(double v);
        public int3x4(double3x4 v);

        public ref int3 this[int index] { get; }

        public bool Equals(int3x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int3x4 operator *(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator *(int3x4 lhs, int rhs);
        public static int3x4 operator *(int lhs, int3x4 rhs);
        public static int3x4 operator +(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator +(int3x4 lhs, int rhs);
        public static int3x4 operator +(int lhs, int3x4 rhs);
        public static int3x4 operator -(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator -(int3x4 lhs, int rhs);
        public static int3x4 operator -(int lhs, int3x4 rhs);
        public static int3x4 operator /(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator /(int3x4 lhs, int rhs);
        public static int3x4 operator /(int lhs, int3x4 rhs);
        public static int3x4 operator %(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator %(int3x4 lhs, int rhs);
        public static int3x4 operator %(int lhs, int3x4 rhs);
        public static int3x4 operator ++(int3x4 val);
        public static int3x4 operator --(int3x4 val);
        public static bool3x4 operator <(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator <(int3x4 lhs, int rhs);
        public static bool3x4 operator <(int lhs, int3x4 rhs);
        public static bool3x4 operator <=(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator <=(int3x4 lhs, int rhs);
        public static bool3x4 operator <=(int lhs, int3x4 rhs);
        public static bool3x4 operator >(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator >(int3x4 lhs, int rhs);
        public static bool3x4 operator >(int lhs, int3x4 rhs);
        public static bool3x4 operator >=(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator >=(int3x4 lhs, int rhs);
        public static bool3x4 operator >=(int lhs, int3x4 rhs);
        public static int3x4 operator -(int3x4 val);
        public static int3x4 operator +(int3x4 val);
        public static int3x4 operator <<(int3x4 x, int n);
        public static int3x4 operator >>(int3x4 x, int n);
        public static bool3x4 operator ==(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator ==(int3x4 lhs, int rhs);
        public static bool3x4 operator ==(int lhs, int3x4 rhs);
        public static bool3x4 operator !=(int3x4 lhs, int3x4 rhs);
        public static bool3x4 operator !=(int3x4 lhs, int rhs);
        public static bool3x4 operator !=(int lhs, int3x4 rhs);
        public static int3x4 operator ~(int3x4 val);
        public static int3x4 operator &(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator &(int3x4 lhs, int rhs);
        public static int3x4 operator &(int lhs, int3x4 rhs);
        public static int3x4 operator |(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator |(int3x4 lhs, int rhs);
        public static int3x4 operator |(int lhs, int3x4 rhs);
        public static int3x4 operator ^(int3x4 lhs, int3x4 rhs);
        public static int3x4 operator ^(int3x4 lhs, int rhs);
        public static int3x4 operator ^(int lhs, int3x4 rhs);

        public static implicit operator int3x4(int v);
        public static explicit operator int3x4(bool v);
        public static explicit operator int3x4(bool3x4 v);
        public static explicit operator int3x4(uint v);
        public static explicit operator int3x4(uint3x4 v);
        public static explicit operator int3x4(float v);
        public static explicit operator int3x4(float3x4 v);
        public static explicit operator int3x4(double v);
        public static explicit operator int3x4(double3x4 v);
    }
}
