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
    public struct uint2x4 : IEquatable<uint2x4>, IFormattable
    {
        public uint2 c0;
        public uint2 c1;
        public uint2 c2;
        public uint2 c3;
        public static readonly uint2x4 zero;

        public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3);
        public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13);
        public uint2x4(uint v);
        public uint2x4(bool v);
        public uint2x4(bool2x4 v);
        public uint2x4(int v);
        public uint2x4(int2x4 v);
        public uint2x4(float v);
        public uint2x4(float2x4 v);
        public uint2x4(double v);
        public uint2x4(double2x4 v);

        public ref uint2 this[int index] { get; }

        public bool Equals(uint2x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint2x4 operator *(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator *(uint2x4 lhs, uint rhs);
        public static uint2x4 operator *(uint lhs, uint2x4 rhs);
        public static uint2x4 operator +(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator +(uint2x4 lhs, uint rhs);
        public static uint2x4 operator +(uint lhs, uint2x4 rhs);
        public static uint2x4 operator -(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator -(uint2x4 lhs, uint rhs);
        public static uint2x4 operator -(uint lhs, uint2x4 rhs);
        public static uint2x4 operator /(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator /(uint2x4 lhs, uint rhs);
        public static uint2x4 operator /(uint lhs, uint2x4 rhs);
        public static uint2x4 operator %(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator %(uint2x4 lhs, uint rhs);
        public static uint2x4 operator %(uint lhs, uint2x4 rhs);
        public static uint2x4 operator ++(uint2x4 val);
        public static uint2x4 operator --(uint2x4 val);
        public static bool2x4 operator <(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator <(uint2x4 lhs, uint rhs);
        public static bool2x4 operator <(uint lhs, uint2x4 rhs);
        public static bool2x4 operator <=(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator <=(uint2x4 lhs, uint rhs);
        public static bool2x4 operator <=(uint lhs, uint2x4 rhs);
        public static bool2x4 operator >(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator >(uint2x4 lhs, uint rhs);
        public static bool2x4 operator >(uint lhs, uint2x4 rhs);
        public static bool2x4 operator >=(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator >=(uint2x4 lhs, uint rhs);
        public static bool2x4 operator >=(uint lhs, uint2x4 rhs);
        public static uint2x4 operator -(uint2x4 val);
        public static uint2x4 operator +(uint2x4 val);
        public static uint2x4 operator <<(uint2x4 x, int n);
        public static uint2x4 operator >>(uint2x4 x, int n);
        public static bool2x4 operator ==(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator ==(uint2x4 lhs, uint rhs);
        public static bool2x4 operator ==(uint lhs, uint2x4 rhs);
        public static bool2x4 operator !=(uint2x4 lhs, uint2x4 rhs);
        public static bool2x4 operator !=(uint2x4 lhs, uint rhs);
        public static bool2x4 operator !=(uint lhs, uint2x4 rhs);
        public static uint2x4 operator ~(uint2x4 val);
        public static uint2x4 operator &(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator &(uint2x4 lhs, uint rhs);
        public static uint2x4 operator &(uint lhs, uint2x4 rhs);
        public static uint2x4 operator |(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator |(uint2x4 lhs, uint rhs);
        public static uint2x4 operator |(uint lhs, uint2x4 rhs);
        public static uint2x4 operator ^(uint2x4 lhs, uint2x4 rhs);
        public static uint2x4 operator ^(uint2x4 lhs, uint rhs);
        public static uint2x4 operator ^(uint lhs, uint2x4 rhs);

        public static implicit operator uint2x4(uint v);
        public static explicit operator uint2x4(bool v);
        public static explicit operator uint2x4(bool2x4 v);
        public static explicit operator uint2x4(int v);
        public static explicit operator uint2x4(int2x4 v);
        public static explicit operator uint2x4(float v);
        public static explicit operator uint2x4(float2x4 v);
        public static explicit operator uint2x4(double v);
        public static explicit operator uint2x4(double2x4 v);
    }
}
