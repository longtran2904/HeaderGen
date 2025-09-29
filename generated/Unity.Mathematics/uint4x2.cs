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
    public struct uint4x2 : IEquatable<uint4x2>, IFormattable
    {
        public uint4 c0;
        public uint4 c1;
        public static readonly uint4x2 zero;

        public uint4x2(uint4 c0, uint4 c1);
        public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31);
        public uint4x2(uint v);
        public uint4x2(bool v);
        public uint4x2(bool4x2 v);
        public uint4x2(int v);
        public uint4x2(int4x2 v);
        public uint4x2(float v);
        public uint4x2(float4x2 v);
        public uint4x2(double v);
        public uint4x2(double4x2 v);

        public ref uint4 this[int index] { get; }

        public bool Equals(uint4x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint4x2 operator *(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator *(uint4x2 lhs, uint rhs);
        public static uint4x2 operator *(uint lhs, uint4x2 rhs);
        public static uint4x2 operator +(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator +(uint4x2 lhs, uint rhs);
        public static uint4x2 operator +(uint lhs, uint4x2 rhs);
        public static uint4x2 operator -(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator -(uint4x2 lhs, uint rhs);
        public static uint4x2 operator -(uint lhs, uint4x2 rhs);
        public static uint4x2 operator /(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator /(uint4x2 lhs, uint rhs);
        public static uint4x2 operator /(uint lhs, uint4x2 rhs);
        public static uint4x2 operator %(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator %(uint4x2 lhs, uint rhs);
        public static uint4x2 operator %(uint lhs, uint4x2 rhs);
        public static uint4x2 operator ++(uint4x2 val);
        public static uint4x2 operator --(uint4x2 val);
        public static bool4x2 operator <(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator <(uint4x2 lhs, uint rhs);
        public static bool4x2 operator <(uint lhs, uint4x2 rhs);
        public static bool4x2 operator <=(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator <=(uint4x2 lhs, uint rhs);
        public static bool4x2 operator <=(uint lhs, uint4x2 rhs);
        public static bool4x2 operator >(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator >(uint4x2 lhs, uint rhs);
        public static bool4x2 operator >(uint lhs, uint4x2 rhs);
        public static bool4x2 operator >=(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator >=(uint4x2 lhs, uint rhs);
        public static bool4x2 operator >=(uint lhs, uint4x2 rhs);
        public static uint4x2 operator -(uint4x2 val);
        public static uint4x2 operator +(uint4x2 val);
        public static uint4x2 operator <<(uint4x2 x, int n);
        public static uint4x2 operator >>(uint4x2 x, int n);
        public static bool4x2 operator ==(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator ==(uint4x2 lhs, uint rhs);
        public static bool4x2 operator ==(uint lhs, uint4x2 rhs);
        public static bool4x2 operator !=(uint4x2 lhs, uint4x2 rhs);
        public static bool4x2 operator !=(uint4x2 lhs, uint rhs);
        public static bool4x2 operator !=(uint lhs, uint4x2 rhs);
        public static uint4x2 operator ~(uint4x2 val);
        public static uint4x2 operator &(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator &(uint4x2 lhs, uint rhs);
        public static uint4x2 operator &(uint lhs, uint4x2 rhs);
        public static uint4x2 operator |(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator |(uint4x2 lhs, uint rhs);
        public static uint4x2 operator |(uint lhs, uint4x2 rhs);
        public static uint4x2 operator ^(uint4x2 lhs, uint4x2 rhs);
        public static uint4x2 operator ^(uint4x2 lhs, uint rhs);
        public static uint4x2 operator ^(uint lhs, uint4x2 rhs);

        public static implicit operator uint4x2(uint v);
        public static explicit operator uint4x2(bool v);
        public static explicit operator uint4x2(bool4x2 v);
        public static explicit operator uint4x2(int v);
        public static explicit operator uint4x2(int4x2 v);
        public static explicit operator uint4x2(float v);
        public static explicit operator uint4x2(float4x2 v);
        public static explicit operator uint4x2(double v);
        public static explicit operator uint4x2(double4x2 v);
    }
}
