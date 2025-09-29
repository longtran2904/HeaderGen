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
    public struct uint4x4 : IEquatable<uint4x4>, IFormattable
    {

        public uint4 c0;
        public uint4 c1;
        public uint4 c2;
        public uint4 c3;
        public static readonly uint4x4 identity;
        public static readonly uint4x4 zero;

        public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3);
        public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33);
        public uint4x4(uint v);
        public uint4x4(bool v);
        public uint4x4(bool4x4 v);
        public uint4x4(int v);
        public uint4x4(int4x4 v);
        public uint4x4(float v);
        public uint4x4(float4x4 v);
        public uint4x4(double v);
        public uint4x4(double4x4 v);

        public ref uint4 this[int index] { get; }

        public bool Equals(uint4x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint4x4 operator *(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator *(uint4x4 lhs, uint rhs);
        public static uint4x4 operator *(uint lhs, uint4x4 rhs);
        public static uint4x4 operator +(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator +(uint4x4 lhs, uint rhs);
        public static uint4x4 operator +(uint lhs, uint4x4 rhs);
        public static uint4x4 operator -(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator -(uint4x4 lhs, uint rhs);
        public static uint4x4 operator -(uint lhs, uint4x4 rhs);
        public static uint4x4 operator /(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator /(uint4x4 lhs, uint rhs);
        public static uint4x4 operator /(uint lhs, uint4x4 rhs);
        public static uint4x4 operator %(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator %(uint4x4 lhs, uint rhs);
        public static uint4x4 operator %(uint lhs, uint4x4 rhs);
        public static uint4x4 operator ++(uint4x4 val);
        public static uint4x4 operator --(uint4x4 val);
        public static bool4x4 operator <(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator <(uint4x4 lhs, uint rhs);
        public static bool4x4 operator <(uint lhs, uint4x4 rhs);
        public static bool4x4 operator <=(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator <=(uint4x4 lhs, uint rhs);
        public static bool4x4 operator <=(uint lhs, uint4x4 rhs);
        public static bool4x4 operator >(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator >(uint4x4 lhs, uint rhs);
        public static bool4x4 operator >(uint lhs, uint4x4 rhs);
        public static bool4x4 operator >=(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator >=(uint4x4 lhs, uint rhs);
        public static bool4x4 operator >=(uint lhs, uint4x4 rhs);
        public static uint4x4 operator -(uint4x4 val);
        public static uint4x4 operator +(uint4x4 val);
        public static uint4x4 operator <<(uint4x4 x, int n);
        public static uint4x4 operator >>(uint4x4 x, int n);
        public static bool4x4 operator ==(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator ==(uint4x4 lhs, uint rhs);
        public static bool4x4 operator ==(uint lhs, uint4x4 rhs);
        public static bool4x4 operator !=(uint4x4 lhs, uint4x4 rhs);
        public static bool4x4 operator !=(uint4x4 lhs, uint rhs);
        public static bool4x4 operator !=(uint lhs, uint4x4 rhs);
        public static uint4x4 operator ~(uint4x4 val);
        public static uint4x4 operator &(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator &(uint4x4 lhs, uint rhs);
        public static uint4x4 operator &(uint lhs, uint4x4 rhs);
        public static uint4x4 operator |(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator |(uint4x4 lhs, uint rhs);
        public static uint4x4 operator |(uint lhs, uint4x4 rhs);
        public static uint4x4 operator ^(uint4x4 lhs, uint4x4 rhs);
        public static uint4x4 operator ^(uint4x4 lhs, uint rhs);
        public static uint4x4 operator ^(uint lhs, uint4x4 rhs);

        public static implicit operator uint4x4(uint v);
        public static explicit operator uint4x4(bool v);
        public static explicit operator uint4x4(bool4x4 v);
        public static explicit operator uint4x4(int v);
        public static explicit operator uint4x4(int4x4 v);
        public static explicit operator uint4x4(float v);
        public static explicit operator uint4x4(float4x4 v);
        public static explicit operator uint4x4(double v);
        public static explicit operator uint4x4(double4x4 v);
    }
}
