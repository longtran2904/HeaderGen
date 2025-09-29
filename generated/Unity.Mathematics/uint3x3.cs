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
    public struct uint3x3 : IEquatable<uint3x3>, IFormattable
    {

        public uint3 c0;
        public uint3 c1;
        public uint3 c2;
        public static readonly uint3x3 identity;
        public static readonly uint3x3 zero;

        public uint3x3(uint3 c0, uint3 c1, uint3 c2);
        public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22);
        public uint3x3(uint v);
        public uint3x3(bool v);
        public uint3x3(bool3x3 v);
        public uint3x3(int v);
        public uint3x3(int3x3 v);
        public uint3x3(float v);
        public uint3x3(float3x3 v);
        public uint3x3(double v);
        public uint3x3(double3x3 v);

        public ref uint3 this[int index] { get; }

        public bool Equals(uint3x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint3x3 operator *(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator *(uint3x3 lhs, uint rhs);
        public static uint3x3 operator *(uint lhs, uint3x3 rhs);
        public static uint3x3 operator +(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator +(uint3x3 lhs, uint rhs);
        public static uint3x3 operator +(uint lhs, uint3x3 rhs);
        public static uint3x3 operator -(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator -(uint3x3 lhs, uint rhs);
        public static uint3x3 operator -(uint lhs, uint3x3 rhs);
        public static uint3x3 operator /(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator /(uint3x3 lhs, uint rhs);
        public static uint3x3 operator /(uint lhs, uint3x3 rhs);
        public static uint3x3 operator %(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator %(uint3x3 lhs, uint rhs);
        public static uint3x3 operator %(uint lhs, uint3x3 rhs);
        public static uint3x3 operator ++(uint3x3 val);
        public static uint3x3 operator --(uint3x3 val);
        public static bool3x3 operator <(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator <(uint3x3 lhs, uint rhs);
        public static bool3x3 operator <(uint lhs, uint3x3 rhs);
        public static bool3x3 operator <=(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator <=(uint3x3 lhs, uint rhs);
        public static bool3x3 operator <=(uint lhs, uint3x3 rhs);
        public static bool3x3 operator >(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator >(uint3x3 lhs, uint rhs);
        public static bool3x3 operator >(uint lhs, uint3x3 rhs);
        public static bool3x3 operator >=(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator >=(uint3x3 lhs, uint rhs);
        public static bool3x3 operator >=(uint lhs, uint3x3 rhs);
        public static uint3x3 operator -(uint3x3 val);
        public static uint3x3 operator +(uint3x3 val);
        public static uint3x3 operator <<(uint3x3 x, int n);
        public static uint3x3 operator >>(uint3x3 x, int n);
        public static bool3x3 operator ==(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator ==(uint3x3 lhs, uint rhs);
        public static bool3x3 operator ==(uint lhs, uint3x3 rhs);
        public static bool3x3 operator !=(uint3x3 lhs, uint3x3 rhs);
        public static bool3x3 operator !=(uint3x3 lhs, uint rhs);
        public static bool3x3 operator !=(uint lhs, uint3x3 rhs);
        public static uint3x3 operator ~(uint3x3 val);
        public static uint3x3 operator &(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator &(uint3x3 lhs, uint rhs);
        public static uint3x3 operator &(uint lhs, uint3x3 rhs);
        public static uint3x3 operator |(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator |(uint3x3 lhs, uint rhs);
        public static uint3x3 operator |(uint lhs, uint3x3 rhs);
        public static uint3x3 operator ^(uint3x3 lhs, uint3x3 rhs);
        public static uint3x3 operator ^(uint3x3 lhs, uint rhs);
        public static uint3x3 operator ^(uint lhs, uint3x3 rhs);

        public static implicit operator uint3x3(uint v);
        public static explicit operator uint3x3(bool v);
        public static explicit operator uint3x3(bool3x3 v);
        public static explicit operator uint3x3(int v);
        public static explicit operator uint3x3(int3x3 v);
        public static explicit operator uint3x3(float v);
        public static explicit operator uint3x3(float3x3 v);
        public static explicit operator uint3x3(double v);
        public static explicit operator uint3x3(double3x3 v);
    }
}
