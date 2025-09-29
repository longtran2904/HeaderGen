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
    public struct int2x3 : IEquatable<int2x3>, IFormattable
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;
        public static readonly int2x3 zero;

        public int2x3(int2 c0, int2 c1, int2 c2);
        public int2x3(int m00, int m01, int m02, int m10, int m11, int m12);
        public int2x3(int v);
        public int2x3(bool v);
        public int2x3(bool2x3 v);
        public int2x3(uint v);
        public int2x3(uint2x3 v);
        public int2x3(float v);
        public int2x3(float2x3 v);
        public int2x3(double v);
        public int2x3(double2x3 v);

        public ref int2 this[int index] { get; }

        public bool Equals(int2x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int2x3 operator *(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator *(int2x3 lhs, int rhs);
        public static int2x3 operator *(int lhs, int2x3 rhs);
        public static int2x3 operator +(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator +(int2x3 lhs, int rhs);
        public static int2x3 operator +(int lhs, int2x3 rhs);
        public static int2x3 operator -(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator -(int2x3 lhs, int rhs);
        public static int2x3 operator -(int lhs, int2x3 rhs);
        public static int2x3 operator /(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator /(int2x3 lhs, int rhs);
        public static int2x3 operator /(int lhs, int2x3 rhs);
        public static int2x3 operator %(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator %(int2x3 lhs, int rhs);
        public static int2x3 operator %(int lhs, int2x3 rhs);
        public static int2x3 operator ++(int2x3 val);
        public static int2x3 operator --(int2x3 val);
        public static bool2x3 operator <(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator <(int2x3 lhs, int rhs);
        public static bool2x3 operator <(int lhs, int2x3 rhs);
        public static bool2x3 operator <=(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator <=(int2x3 lhs, int rhs);
        public static bool2x3 operator <=(int lhs, int2x3 rhs);
        public static bool2x3 operator >(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator >(int2x3 lhs, int rhs);
        public static bool2x3 operator >(int lhs, int2x3 rhs);
        public static bool2x3 operator >=(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator >=(int2x3 lhs, int rhs);
        public static bool2x3 operator >=(int lhs, int2x3 rhs);
        public static int2x3 operator -(int2x3 val);
        public static int2x3 operator +(int2x3 val);
        public static int2x3 operator <<(int2x3 x, int n);
        public static int2x3 operator >>(int2x3 x, int n);
        public static bool2x3 operator ==(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator ==(int2x3 lhs, int rhs);
        public static bool2x3 operator ==(int lhs, int2x3 rhs);
        public static bool2x3 operator !=(int2x3 lhs, int2x3 rhs);
        public static bool2x3 operator !=(int2x3 lhs, int rhs);
        public static bool2x3 operator !=(int lhs, int2x3 rhs);
        public static int2x3 operator ~(int2x3 val);
        public static int2x3 operator &(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator &(int2x3 lhs, int rhs);
        public static int2x3 operator &(int lhs, int2x3 rhs);
        public static int2x3 operator |(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator |(int2x3 lhs, int rhs);
        public static int2x3 operator |(int lhs, int2x3 rhs);
        public static int2x3 operator ^(int2x3 lhs, int2x3 rhs);
        public static int2x3 operator ^(int2x3 lhs, int rhs);
        public static int2x3 operator ^(int lhs, int2x3 rhs);

        public static implicit operator int2x3(int v);
        public static explicit operator int2x3(bool v);
        public static explicit operator int2x3(bool2x3 v);
        public static explicit operator int2x3(uint v);
        public static explicit operator int2x3(uint2x3 v);
        public static explicit operator int2x3(float v);
        public static explicit operator int2x3(float2x3 v);
        public static explicit operator int2x3(double v);
        public static explicit operator int2x3(double2x3 v);
    }
}
