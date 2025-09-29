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
    public struct uint2x3 : IEquatable<uint2x3>, IFormattable
    {

        public uint2 c0;
        public uint2 c1;
        public uint2 c2;
        public static readonly uint2x3 zero;

        public uint2x3(uint2 c0, uint2 c1, uint2 c2);
        public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12);
        public uint2x3(uint v);
        public uint2x3(bool v);
        public uint2x3(bool2x3 v);
        public uint2x3(int v);
        public uint2x3(int2x3 v);
        public uint2x3(float v);
        public uint2x3(float2x3 v);
        public uint2x3(double v);
        public uint2x3(double2x3 v);

        public ref uint2 this[int index] { get; }

        public bool Equals(uint2x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint2x3 operator *(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator *(uint2x3 lhs, uint rhs);
        public static uint2x3 operator *(uint lhs, uint2x3 rhs);
        public static uint2x3 operator +(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator +(uint2x3 lhs, uint rhs);
        public static uint2x3 operator +(uint lhs, uint2x3 rhs);
        public static uint2x3 operator -(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator -(uint2x3 lhs, uint rhs);
        public static uint2x3 operator -(uint lhs, uint2x3 rhs);
        public static uint2x3 operator /(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator /(uint2x3 lhs, uint rhs);
        public static uint2x3 operator /(uint lhs, uint2x3 rhs);
        public static uint2x3 operator %(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator %(uint2x3 lhs, uint rhs);
        public static uint2x3 operator %(uint lhs, uint2x3 rhs);
        public static uint2x3 operator ++(uint2x3 val);
        public static uint2x3 operator --(uint2x3 val);
        public static bool2x3 operator <(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator <(uint2x3 lhs, uint rhs);
        public static bool2x3 operator <(uint lhs, uint2x3 rhs);
        public static bool2x3 operator <=(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator <=(uint2x3 lhs, uint rhs);
        public static bool2x3 operator <=(uint lhs, uint2x3 rhs);
        public static bool2x3 operator >(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator >(uint2x3 lhs, uint rhs);
        public static bool2x3 operator >(uint lhs, uint2x3 rhs);
        public static bool2x3 operator >=(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator >=(uint2x3 lhs, uint rhs);
        public static bool2x3 operator >=(uint lhs, uint2x3 rhs);
        public static uint2x3 operator -(uint2x3 val);
        public static uint2x3 operator +(uint2x3 val);
        public static uint2x3 operator <<(uint2x3 x, int n);
        public static uint2x3 operator >>(uint2x3 x, int n);
        public static bool2x3 operator ==(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator ==(uint2x3 lhs, uint rhs);
        public static bool2x3 operator ==(uint lhs, uint2x3 rhs);
        public static bool2x3 operator !=(uint2x3 lhs, uint2x3 rhs);
        public static bool2x3 operator !=(uint2x3 lhs, uint rhs);
        public static bool2x3 operator !=(uint lhs, uint2x3 rhs);
        public static uint2x3 operator ~(uint2x3 val);
        public static uint2x3 operator &(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator &(uint2x3 lhs, uint rhs);
        public static uint2x3 operator &(uint lhs, uint2x3 rhs);
        public static uint2x3 operator |(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator |(uint2x3 lhs, uint rhs);
        public static uint2x3 operator |(uint lhs, uint2x3 rhs);
        public static uint2x3 operator ^(uint2x3 lhs, uint2x3 rhs);
        public static uint2x3 operator ^(uint2x3 lhs, uint rhs);
        public static uint2x3 operator ^(uint lhs, uint2x3 rhs);

        public static implicit operator uint2x3(uint v);
        public static explicit operator uint2x3(bool v);
        public static explicit operator uint2x3(bool2x3 v);
        public static explicit operator uint2x3(int v);
        public static explicit operator uint2x3(int2x3 v);
        public static explicit operator uint2x3(float v);
        public static explicit operator uint2x3(float2x3 v);
        public static explicit operator uint2x3(double v);
        public static explicit operator uint2x3(double2x3 v);
    }
}
