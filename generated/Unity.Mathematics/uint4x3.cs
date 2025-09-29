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
    public struct uint4x3 : IEquatable<uint4x3>, IFormattable
    {
        public uint4 c0;
        public uint4 c1;
        public uint4 c2;
        public static readonly uint4x3 zero;

        public uint4x3(uint4 c0, uint4 c1, uint4 c2);
        public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32);
        public uint4x3(uint v);
        public uint4x3(bool v);
        public uint4x3(bool4x3 v);
        public uint4x3(int v);
        public uint4x3(int4x3 v);
        public uint4x3(float v);
        public uint4x3(float4x3 v);
        public uint4x3(double v);
        public uint4x3(double4x3 v);

        public ref uint4 this[int index] { get; }

        public bool Equals(uint4x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint4x3 operator *(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator *(uint4x3 lhs, uint rhs);
        public static uint4x3 operator *(uint lhs, uint4x3 rhs);
        public static uint4x3 operator +(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator +(uint4x3 lhs, uint rhs);
        public static uint4x3 operator +(uint lhs, uint4x3 rhs);
        public static uint4x3 operator -(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator -(uint4x3 lhs, uint rhs);
        public static uint4x3 operator -(uint lhs, uint4x3 rhs);
        public static uint4x3 operator /(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator /(uint4x3 lhs, uint rhs);
        public static uint4x3 operator /(uint lhs, uint4x3 rhs);
        public static uint4x3 operator %(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator %(uint4x3 lhs, uint rhs);
        public static uint4x3 operator %(uint lhs, uint4x3 rhs);
        public static uint4x3 operator ++(uint4x3 val);
        public static uint4x3 operator --(uint4x3 val);
        public static bool4x3 operator <(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator <(uint4x3 lhs, uint rhs);
        public static bool4x3 operator <(uint lhs, uint4x3 rhs);
        public static bool4x3 operator <=(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator <=(uint4x3 lhs, uint rhs);
        public static bool4x3 operator <=(uint lhs, uint4x3 rhs);
        public static bool4x3 operator >(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator >(uint4x3 lhs, uint rhs);
        public static bool4x3 operator >(uint lhs, uint4x3 rhs);
        public static bool4x3 operator >=(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator >=(uint4x3 lhs, uint rhs);
        public static bool4x3 operator >=(uint lhs, uint4x3 rhs);
        public static uint4x3 operator -(uint4x3 val);
        public static uint4x3 operator +(uint4x3 val);
        public static uint4x3 operator <<(uint4x3 x, int n);
        public static uint4x3 operator >>(uint4x3 x, int n);
        public static bool4x3 operator ==(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator ==(uint4x3 lhs, uint rhs);
        public static bool4x3 operator ==(uint lhs, uint4x3 rhs);
        public static bool4x3 operator !=(uint4x3 lhs, uint4x3 rhs);
        public static bool4x3 operator !=(uint4x3 lhs, uint rhs);
        public static bool4x3 operator !=(uint lhs, uint4x3 rhs);
        public static uint4x3 operator ~(uint4x3 val);
        public static uint4x3 operator &(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator &(uint4x3 lhs, uint rhs);
        public static uint4x3 operator &(uint lhs, uint4x3 rhs);
        public static uint4x3 operator |(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator |(uint4x3 lhs, uint rhs);
        public static uint4x3 operator |(uint lhs, uint4x3 rhs);
        public static uint4x3 operator ^(uint4x3 lhs, uint4x3 rhs);
        public static uint4x3 operator ^(uint4x3 lhs, uint rhs);
        public static uint4x3 operator ^(uint lhs, uint4x3 rhs);

        public static implicit operator uint4x3(uint v);
        public static explicit operator uint4x3(bool v);
        public static explicit operator uint4x3(bool4x3 v);
        public static explicit operator uint4x3(int v);
        public static explicit operator uint4x3(int4x3 v);
        public static explicit operator uint4x3(float v);
        public static explicit operator uint4x3(float4x3 v);
        public static explicit operator uint4x3(double v);
        public static explicit operator uint4x3(double4x3 v);
    }
}
