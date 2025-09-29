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
    public struct int3x3 : IEquatable<int3x3>, IFormattable
    {

        public int3 c0;
        public int3 c1;
        public int3 c2;
        public static readonly int3x3 identity;
        public static readonly int3x3 zero;

        public int3x3(int3 c0, int3 c1, int3 c2);
        public int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22);
        public int3x3(int v);
        public int3x3(bool v);
        public int3x3(bool3x3 v);
        public int3x3(uint v);
        public int3x3(uint3x3 v);
        public int3x3(float v);
        public int3x3(float3x3 v);
        public int3x3(double v);
        public int3x3(double3x3 v);

        public ref int3 this[int index] { get; }

        public bool Equals(int3x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int3x3 operator *(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator *(int3x3 lhs, int rhs);
        public static int3x3 operator *(int lhs, int3x3 rhs);
        public static int3x3 operator +(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator +(int3x3 lhs, int rhs);
        public static int3x3 operator +(int lhs, int3x3 rhs);
        public static int3x3 operator -(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator -(int3x3 lhs, int rhs);
        public static int3x3 operator -(int lhs, int3x3 rhs);
        public static int3x3 operator /(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator /(int3x3 lhs, int rhs);
        public static int3x3 operator /(int lhs, int3x3 rhs);
        public static int3x3 operator %(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator %(int3x3 lhs, int rhs);
        public static int3x3 operator %(int lhs, int3x3 rhs);
        public static int3x3 operator ++(int3x3 val);
        public static int3x3 operator --(int3x3 val);
        public static bool3x3 operator <(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator <(int3x3 lhs, int rhs);
        public static bool3x3 operator <(int lhs, int3x3 rhs);
        public static bool3x3 operator <=(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator <=(int3x3 lhs, int rhs);
        public static bool3x3 operator <=(int lhs, int3x3 rhs);
        public static bool3x3 operator >(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator >(int3x3 lhs, int rhs);
        public static bool3x3 operator >(int lhs, int3x3 rhs);
        public static bool3x3 operator >=(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator >=(int3x3 lhs, int rhs);
        public static bool3x3 operator >=(int lhs, int3x3 rhs);
        public static int3x3 operator -(int3x3 val);
        public static int3x3 operator +(int3x3 val);
        public static int3x3 operator <<(int3x3 x, int n);
        public static int3x3 operator >>(int3x3 x, int n);
        public static bool3x3 operator ==(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator ==(int3x3 lhs, int rhs);
        public static bool3x3 operator ==(int lhs, int3x3 rhs);
        public static bool3x3 operator !=(int3x3 lhs, int3x3 rhs);
        public static bool3x3 operator !=(int3x3 lhs, int rhs);
        public static bool3x3 operator !=(int lhs, int3x3 rhs);
        public static int3x3 operator ~(int3x3 val);
        public static int3x3 operator &(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator &(int3x3 lhs, int rhs);
        public static int3x3 operator &(int lhs, int3x3 rhs);
        public static int3x3 operator |(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator |(int3x3 lhs, int rhs);
        public static int3x3 operator |(int lhs, int3x3 rhs);
        public static int3x3 operator ^(int3x3 lhs, int3x3 rhs);
        public static int3x3 operator ^(int3x3 lhs, int rhs);
        public static int3x3 operator ^(int lhs, int3x3 rhs);

        public static implicit operator int3x3(int v);
        public static explicit operator int3x3(bool v);
        public static explicit operator int3x3(bool3x3 v);
        public static explicit operator int3x3(uint v);
        public static explicit operator int3x3(uint3x3 v);
        public static explicit operator int3x3(float v);
        public static explicit operator int3x3(float3x3 v);
        public static explicit operator int3x3(double v);
        public static explicit operator int3x3(double3x3 v);
    }
}
