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
    public struct int4x2 : IEquatable<int4x2>, IFormattable
    {
        public int4 c0;
        public int4 c1;
        public static readonly int4x2 zero;

        public int4x2(int4 c0, int4 c1);
        public int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31);
        public int4x2(int v);
        public int4x2(bool v);
        public int4x2(bool4x2 v);
        public int4x2(uint v);
        public int4x2(uint4x2 v);
        public int4x2(float v);
        public int4x2(float4x2 v);
        public int4x2(double v);
        public int4x2(double4x2 v);

        public ref int4 this[int index] { get; }

        public bool Equals(int4x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int4x2 operator *(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator *(int4x2 lhs, int rhs);
        public static int4x2 operator *(int lhs, int4x2 rhs);
        public static int4x2 operator +(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator +(int4x2 lhs, int rhs);
        public static int4x2 operator +(int lhs, int4x2 rhs);
        public static int4x2 operator -(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator -(int4x2 lhs, int rhs);
        public static int4x2 operator -(int lhs, int4x2 rhs);
        public static int4x2 operator /(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator /(int4x2 lhs, int rhs);
        public static int4x2 operator /(int lhs, int4x2 rhs);
        public static int4x2 operator %(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator %(int4x2 lhs, int rhs);
        public static int4x2 operator %(int lhs, int4x2 rhs);
        public static int4x2 operator ++(int4x2 val);
        public static int4x2 operator --(int4x2 val);
        public static bool4x2 operator <(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator <(int4x2 lhs, int rhs);
        public static bool4x2 operator <(int lhs, int4x2 rhs);
        public static bool4x2 operator <=(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator <=(int4x2 lhs, int rhs);
        public static bool4x2 operator <=(int lhs, int4x2 rhs);
        public static bool4x2 operator >(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator >(int4x2 lhs, int rhs);
        public static bool4x2 operator >(int lhs, int4x2 rhs);
        public static bool4x2 operator >=(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator >=(int4x2 lhs, int rhs);
        public static bool4x2 operator >=(int lhs, int4x2 rhs);
        public static int4x2 operator -(int4x2 val);
        public static int4x2 operator +(int4x2 val);
        public static int4x2 operator <<(int4x2 x, int n);
        public static int4x2 operator >>(int4x2 x, int n);
        public static bool4x2 operator ==(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator ==(int4x2 lhs, int rhs);
        public static bool4x2 operator ==(int lhs, int4x2 rhs);
        public static bool4x2 operator !=(int4x2 lhs, int4x2 rhs);
        public static bool4x2 operator !=(int4x2 lhs, int rhs);
        public static bool4x2 operator !=(int lhs, int4x2 rhs);
        public static int4x2 operator ~(int4x2 val);
        public static int4x2 operator &(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator &(int4x2 lhs, int rhs);
        public static int4x2 operator &(int lhs, int4x2 rhs);
        public static int4x2 operator |(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator |(int4x2 lhs, int rhs);
        public static int4x2 operator |(int lhs, int4x2 rhs);
        public static int4x2 operator ^(int4x2 lhs, int4x2 rhs);
        public static int4x2 operator ^(int4x2 lhs, int rhs);
        public static int4x2 operator ^(int lhs, int4x2 rhs);

        public static implicit operator int4x2(int v);
        public static explicit operator int4x2(bool v);
        public static explicit operator int4x2(bool4x2 v);
        public static explicit operator int4x2(uint v);
        public static explicit operator int4x2(uint4x2 v);
        public static explicit operator int4x2(float v);
        public static explicit operator int4x2(float4x2 v);
        public static explicit operator int4x2(double v);
        public static explicit operator int4x2(double4x2 v);
    }
}
