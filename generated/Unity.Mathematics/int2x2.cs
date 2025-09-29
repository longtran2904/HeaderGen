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
    public struct int2x2 : IEquatable<int2x2>, IFormattable
    {

        public int2 c0;
        public int2 c1;
        public static readonly int2x2 identity;
        public static readonly int2x2 zero;

        public int2x2(int2 c0, int2 c1);
        public int2x2(int m00, int m01, int m10, int m11);
        public int2x2(int v);
        public int2x2(bool v);
        public int2x2(bool2x2 v);
        public int2x2(uint v);
        public int2x2(uint2x2 v);
        public int2x2(float v);
        public int2x2(float2x2 v);
        public int2x2(double v);
        public int2x2(double2x2 v);

        public ref int2 this[int index] { get; }

        public bool Equals(int2x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int2x2 operator *(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator *(int2x2 lhs, int rhs);
        public static int2x2 operator *(int lhs, int2x2 rhs);
        public static int2x2 operator +(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator +(int2x2 lhs, int rhs);
        public static int2x2 operator +(int lhs, int2x2 rhs);
        public static int2x2 operator -(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator -(int2x2 lhs, int rhs);
        public static int2x2 operator -(int lhs, int2x2 rhs);
        public static int2x2 operator /(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator /(int2x2 lhs, int rhs);
        public static int2x2 operator /(int lhs, int2x2 rhs);
        public static int2x2 operator %(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator %(int2x2 lhs, int rhs);
        public static int2x2 operator %(int lhs, int2x2 rhs);
        public static int2x2 operator ++(int2x2 val);
        public static int2x2 operator --(int2x2 val);
        public static bool2x2 operator <(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator <(int2x2 lhs, int rhs);
        public static bool2x2 operator <(int lhs, int2x2 rhs);
        public static bool2x2 operator <=(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator <=(int2x2 lhs, int rhs);
        public static bool2x2 operator <=(int lhs, int2x2 rhs);
        public static bool2x2 operator >(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator >(int2x2 lhs, int rhs);
        public static bool2x2 operator >(int lhs, int2x2 rhs);
        public static bool2x2 operator >=(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator >=(int2x2 lhs, int rhs);
        public static bool2x2 operator >=(int lhs, int2x2 rhs);
        public static int2x2 operator -(int2x2 val);
        public static int2x2 operator +(int2x2 val);
        public static int2x2 operator <<(int2x2 x, int n);
        public static int2x2 operator >>(int2x2 x, int n);
        public static bool2x2 operator ==(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator ==(int2x2 lhs, int rhs);
        public static bool2x2 operator ==(int lhs, int2x2 rhs);
        public static bool2x2 operator !=(int2x2 lhs, int2x2 rhs);
        public static bool2x2 operator !=(int2x2 lhs, int rhs);
        public static bool2x2 operator !=(int lhs, int2x2 rhs);
        public static int2x2 operator ~(int2x2 val);
        public static int2x2 operator &(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator &(int2x2 lhs, int rhs);
        public static int2x2 operator &(int lhs, int2x2 rhs);
        public static int2x2 operator |(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator |(int2x2 lhs, int rhs);
        public static int2x2 operator |(int lhs, int2x2 rhs);
        public static int2x2 operator ^(int2x2 lhs, int2x2 rhs);
        public static int2x2 operator ^(int2x2 lhs, int rhs);
        public static int2x2 operator ^(int lhs, int2x2 rhs);

        public static implicit operator int2x2(int v);
        public static explicit operator int2x2(bool v);
        public static explicit operator int2x2(bool2x2 v);
        public static explicit operator int2x2(uint v);
        public static explicit operator int2x2(uint2x2 v);
        public static explicit operator int2x2(float v);
        public static explicit operator int2x2(float2x2 v);
        public static explicit operator int2x2(double v);
        public static explicit operator int2x2(double2x2 v);
    }
}
