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
    public struct int2x4 : IEquatable<int2x4>, IFormattable
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;
        public int2 c3;
        public static readonly int2x4 zero;

        public int2x4(int2 c0, int2 c1, int2 c2, int2 c3);
        public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13);
        public int2x4(int v);
        public int2x4(bool v);
        public int2x4(bool2x4 v);
        public int2x4(uint v);
        public int2x4(uint2x4 v);
        public int2x4(float v);
        public int2x4(float2x4 v);
        public int2x4(double v);
        public int2x4(double2x4 v);

        public ref int2 this[int index] { get; }

        public bool Equals(int2x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int2x4 operator *(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator *(int2x4 lhs, int rhs);
        public static int2x4 operator *(int lhs, int2x4 rhs);
        public static int2x4 operator +(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator +(int2x4 lhs, int rhs);
        public static int2x4 operator +(int lhs, int2x4 rhs);
        public static int2x4 operator -(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator -(int2x4 lhs, int rhs);
        public static int2x4 operator -(int lhs, int2x4 rhs);
        public static int2x4 operator /(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator /(int2x4 lhs, int rhs);
        public static int2x4 operator /(int lhs, int2x4 rhs);
        public static int2x4 operator %(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator %(int2x4 lhs, int rhs);
        public static int2x4 operator %(int lhs, int2x4 rhs);
        public static int2x4 operator ++(int2x4 val);
        public static int2x4 operator --(int2x4 val);
        public static bool2x4 operator <(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator <(int2x4 lhs, int rhs);
        public static bool2x4 operator <(int lhs, int2x4 rhs);
        public static bool2x4 operator <=(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator <=(int2x4 lhs, int rhs);
        public static bool2x4 operator <=(int lhs, int2x4 rhs);
        public static bool2x4 operator >(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator >(int2x4 lhs, int rhs);
        public static bool2x4 operator >(int lhs, int2x4 rhs);
        public static bool2x4 operator >=(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator >=(int2x4 lhs, int rhs);
        public static bool2x4 operator >=(int lhs, int2x4 rhs);
        public static int2x4 operator -(int2x4 val);
        public static int2x4 operator +(int2x4 val);
        public static int2x4 operator <<(int2x4 x, int n);
        public static int2x4 operator >>(int2x4 x, int n);
        public static bool2x4 operator ==(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator ==(int2x4 lhs, int rhs);
        public static bool2x4 operator ==(int lhs, int2x4 rhs);
        public static bool2x4 operator !=(int2x4 lhs, int2x4 rhs);
        public static bool2x4 operator !=(int2x4 lhs, int rhs);
        public static bool2x4 operator !=(int lhs, int2x4 rhs);
        public static int2x4 operator ~(int2x4 val);
        public static int2x4 operator &(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator &(int2x4 lhs, int rhs);
        public static int2x4 operator &(int lhs, int2x4 rhs);
        public static int2x4 operator |(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator |(int2x4 lhs, int rhs);
        public static int2x4 operator |(int lhs, int2x4 rhs);
        public static int2x4 operator ^(int2x4 lhs, int2x4 rhs);
        public static int2x4 operator ^(int2x4 lhs, int rhs);
        public static int2x4 operator ^(int lhs, int2x4 rhs);

        public static implicit operator int2x4(int v);
        public static explicit operator int2x4(bool v);
        public static explicit operator int2x4(bool2x4 v);
        public static explicit operator int2x4(uint v);
        public static explicit operator int2x4(uint2x4 v);
        public static explicit operator int2x4(float v);
        public static explicit operator int2x4(float2x4 v);
        public static explicit operator int2x4(double v);
        public static explicit operator int2x4(double2x4 v);
    }
}
