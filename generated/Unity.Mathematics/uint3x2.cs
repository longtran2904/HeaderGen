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
    public struct uint3x2 : IEquatable<uint3x2>, IFormattable
    {
        public uint3 c0;
        public uint3 c1;
        public static readonly uint3x2 zero;

        public uint3x2(uint3 c0, uint3 c1);
        public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21);
        public uint3x2(uint v);
        public uint3x2(bool v);
        public uint3x2(bool3x2 v);
        public uint3x2(int v);
        public uint3x2(int3x2 v);
        public uint3x2(float v);
        public uint3x2(float3x2 v);
        public uint3x2(double v);
        public uint3x2(double3x2 v);

        public ref uint3 this[int index] { get; }

        public bool Equals(uint3x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint3x2 operator *(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator *(uint3x2 lhs, uint rhs);
        public static uint3x2 operator *(uint lhs, uint3x2 rhs);
        public static uint3x2 operator +(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator +(uint3x2 lhs, uint rhs);
        public static uint3x2 operator +(uint lhs, uint3x2 rhs);
        public static uint3x2 operator -(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator -(uint3x2 lhs, uint rhs);
        public static uint3x2 operator -(uint lhs, uint3x2 rhs);
        public static uint3x2 operator /(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator /(uint3x2 lhs, uint rhs);
        public static uint3x2 operator /(uint lhs, uint3x2 rhs);
        public static uint3x2 operator %(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator %(uint3x2 lhs, uint rhs);
        public static uint3x2 operator %(uint lhs, uint3x2 rhs);
        public static uint3x2 operator ++(uint3x2 val);
        public static uint3x2 operator --(uint3x2 val);
        public static bool3x2 operator <(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator <(uint3x2 lhs, uint rhs);
        public static bool3x2 operator <(uint lhs, uint3x2 rhs);
        public static bool3x2 operator <=(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator <=(uint3x2 lhs, uint rhs);
        public static bool3x2 operator <=(uint lhs, uint3x2 rhs);
        public static bool3x2 operator >(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator >(uint3x2 lhs, uint rhs);
        public static bool3x2 operator >(uint lhs, uint3x2 rhs);
        public static bool3x2 operator >=(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator >=(uint3x2 lhs, uint rhs);
        public static bool3x2 operator >=(uint lhs, uint3x2 rhs);
        public static uint3x2 operator -(uint3x2 val);
        public static uint3x2 operator +(uint3x2 val);
        public static uint3x2 operator <<(uint3x2 x, int n);
        public static uint3x2 operator >>(uint3x2 x, int n);
        public static bool3x2 operator ==(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator ==(uint3x2 lhs, uint rhs);
        public static bool3x2 operator ==(uint lhs, uint3x2 rhs);
        public static bool3x2 operator !=(uint3x2 lhs, uint3x2 rhs);
        public static bool3x2 operator !=(uint3x2 lhs, uint rhs);
        public static bool3x2 operator !=(uint lhs, uint3x2 rhs);
        public static uint3x2 operator ~(uint3x2 val);
        public static uint3x2 operator &(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator &(uint3x2 lhs, uint rhs);
        public static uint3x2 operator &(uint lhs, uint3x2 rhs);
        public static uint3x2 operator |(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator |(uint3x2 lhs, uint rhs);
        public static uint3x2 operator |(uint lhs, uint3x2 rhs);
        public static uint3x2 operator ^(uint3x2 lhs, uint3x2 rhs);
        public static uint3x2 operator ^(uint3x2 lhs, uint rhs);
        public static uint3x2 operator ^(uint lhs, uint3x2 rhs);

        public static implicit operator uint3x2(uint v);
        public static explicit operator uint3x2(bool v);
        public static explicit operator uint3x2(bool3x2 v);
        public static explicit operator uint3x2(int v);
        public static explicit operator uint3x2(int3x2 v);
        public static explicit operator uint3x2(float v);
        public static explicit operator uint3x2(float3x2 v);
        public static explicit operator uint3x2(double v);
        public static explicit operator uint3x2(double3x2 v);
    }
}
