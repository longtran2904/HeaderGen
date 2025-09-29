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
    public struct int3x2 : IEquatable<int3x2>, IFormattable
    {
        public int3 c0;
        public int3 c1;
        public static readonly int3x2 zero;

        public int3x2(int3 c0, int3 c1);
        public int3x2(int m00, int m01, int m10, int m11, int m20, int m21);
        public int3x2(int v);
        public int3x2(bool v);
        public int3x2(bool3x2 v);
        public int3x2(uint v);
        public int3x2(uint3x2 v);
        public int3x2(float v);
        public int3x2(float3x2 v);
        public int3x2(double v);
        public int3x2(double3x2 v);

        public ref int3 this[int index] { get; }

        public bool Equals(int3x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int3x2 operator *(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator *(int3x2 lhs, int rhs);
        public static int3x2 operator *(int lhs, int3x2 rhs);
        public static int3x2 operator +(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator +(int3x2 lhs, int rhs);
        public static int3x2 operator +(int lhs, int3x2 rhs);
        public static int3x2 operator -(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator -(int3x2 lhs, int rhs);
        public static int3x2 operator -(int lhs, int3x2 rhs);
        public static int3x2 operator /(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator /(int3x2 lhs, int rhs);
        public static int3x2 operator /(int lhs, int3x2 rhs);
        public static int3x2 operator %(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator %(int3x2 lhs, int rhs);
        public static int3x2 operator %(int lhs, int3x2 rhs);
        public static int3x2 operator ++(int3x2 val);
        public static int3x2 operator --(int3x2 val);
        public static bool3x2 operator <(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator <(int3x2 lhs, int rhs);
        public static bool3x2 operator <(int lhs, int3x2 rhs);
        public static bool3x2 operator <=(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator <=(int3x2 lhs, int rhs);
        public static bool3x2 operator <=(int lhs, int3x2 rhs);
        public static bool3x2 operator >(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator >(int3x2 lhs, int rhs);
        public static bool3x2 operator >(int lhs, int3x2 rhs);
        public static bool3x2 operator >=(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator >=(int3x2 lhs, int rhs);
        public static bool3x2 operator >=(int lhs, int3x2 rhs);
        public static int3x2 operator -(int3x2 val);
        public static int3x2 operator +(int3x2 val);
        public static int3x2 operator <<(int3x2 x, int n);
        public static int3x2 operator >>(int3x2 x, int n);
        public static bool3x2 operator ==(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator ==(int3x2 lhs, int rhs);
        public static bool3x2 operator ==(int lhs, int3x2 rhs);
        public static bool3x2 operator !=(int3x2 lhs, int3x2 rhs);
        public static bool3x2 operator !=(int3x2 lhs, int rhs);
        public static bool3x2 operator !=(int lhs, int3x2 rhs);
        public static int3x2 operator ~(int3x2 val);
        public static int3x2 operator &(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator &(int3x2 lhs, int rhs);
        public static int3x2 operator &(int lhs, int3x2 rhs);
        public static int3x2 operator |(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator |(int3x2 lhs, int rhs);
        public static int3x2 operator |(int lhs, int3x2 rhs);
        public static int3x2 operator ^(int3x2 lhs, int3x2 rhs);
        public static int3x2 operator ^(int3x2 lhs, int rhs);
        public static int3x2 operator ^(int lhs, int3x2 rhs);

        public static implicit operator int3x2(int v);
        public static explicit operator int3x2(bool v);
        public static explicit operator int3x2(bool3x2 v);
        public static explicit operator int3x2(uint v);
        public static explicit operator int3x2(uint3x2 v);
        public static explicit operator int3x2(float v);
        public static explicit operator int3x2(float3x2 v);
        public static explicit operator int3x2(double v);
        public static explicit operator int3x2(double3x2 v);
    }
}
