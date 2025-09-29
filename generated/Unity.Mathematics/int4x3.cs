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
    public struct int4x3 : IEquatable<int4x3>, IFormattable
    {

        public int4 c0;
        public int4 c1;
        public int4 c2;
        public static readonly int4x3 zero;

        public int4x3(int4 c0, int4 c1, int4 c2);
        public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32);
        public int4x3(int v);
        public int4x3(bool v);
        public int4x3(bool4x3 v);
        public int4x3(uint v);
        public int4x3(uint4x3 v);
        public int4x3(float v);
        public int4x3(float4x3 v);
        public int4x3(double v);
        public int4x3(double4x3 v);

        public ref int4 this[int index] { get; }

        public bool Equals(int4x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int4x3 operator *(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator *(int4x3 lhs, int rhs);
        public static int4x3 operator *(int lhs, int4x3 rhs);
        public static int4x3 operator +(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator +(int4x3 lhs, int rhs);
        public static int4x3 operator +(int lhs, int4x3 rhs);
        public static int4x3 operator -(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator -(int4x3 lhs, int rhs);
        public static int4x3 operator -(int lhs, int4x3 rhs);
        public static int4x3 operator /(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator /(int4x3 lhs, int rhs);
        public static int4x3 operator /(int lhs, int4x3 rhs);
        public static int4x3 operator %(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator %(int4x3 lhs, int rhs);
        public static int4x3 operator %(int lhs, int4x3 rhs);
        public static int4x3 operator ++(int4x3 val);
        public static int4x3 operator --(int4x3 val);
        public static bool4x3 operator <(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator <(int4x3 lhs, int rhs);
        public static bool4x3 operator <(int lhs, int4x3 rhs);
        public static bool4x3 operator <=(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator <=(int4x3 lhs, int rhs);
        public static bool4x3 operator <=(int lhs, int4x3 rhs);
        public static bool4x3 operator >(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator >(int4x3 lhs, int rhs);
        public static bool4x3 operator >(int lhs, int4x3 rhs);
        public static bool4x3 operator >=(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator >=(int4x3 lhs, int rhs);
        public static bool4x3 operator >=(int lhs, int4x3 rhs);
        public static int4x3 operator -(int4x3 val);
        public static int4x3 operator +(int4x3 val);
        public static int4x3 operator <<(int4x3 x, int n);
        public static int4x3 operator >>(int4x3 x, int n);
        public static bool4x3 operator ==(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator ==(int4x3 lhs, int rhs);
        public static bool4x3 operator ==(int lhs, int4x3 rhs);
        public static bool4x3 operator !=(int4x3 lhs, int4x3 rhs);
        public static bool4x3 operator !=(int4x3 lhs, int rhs);
        public static bool4x3 operator !=(int lhs, int4x3 rhs);
        public static int4x3 operator ~(int4x3 val);
        public static int4x3 operator &(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator &(int4x3 lhs, int rhs);
        public static int4x3 operator &(int lhs, int4x3 rhs);
        public static int4x3 operator |(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator |(int4x3 lhs, int rhs);
        public static int4x3 operator |(int lhs, int4x3 rhs);
        public static int4x3 operator ^(int4x3 lhs, int4x3 rhs);
        public static int4x3 operator ^(int4x3 lhs, int rhs);
        public static int4x3 operator ^(int lhs, int4x3 rhs);

        public static implicit operator int4x3(int v);
        public static explicit operator int4x3(bool v);
        public static explicit operator int4x3(bool4x3 v);
        public static explicit operator int4x3(uint v);
        public static explicit operator int4x3(uint4x3 v);
        public static explicit operator int4x3(float v);
        public static explicit operator int4x3(float4x3 v);
        public static explicit operator int4x3(double v);
        public static explicit operator int4x3(double4x3 v);
    }
}
