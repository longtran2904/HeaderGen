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
    public struct uint2x2 : IEquatable<uint2x2>, IFormattable
    {

        public uint2 c0;
        public uint2 c1;
        public static readonly uint2x2 identity;
        public static readonly uint2x2 zero;

        public uint2x2(uint2 c0, uint2 c1);
        public uint2x2(uint m00, uint m01, uint m10, uint m11);
        public uint2x2(uint v);
        public uint2x2(bool v);
        public uint2x2(bool2x2 v);
        public uint2x2(int v);
        public uint2x2(int2x2 v);
        public uint2x2(float v);
        public uint2x2(float2x2 v);
        public uint2x2(double v);
        public uint2x2(double2x2 v);

        public ref uint2 this[int index] { get; }

        public bool Equals(uint2x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint2x2 operator *(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator *(uint2x2 lhs, uint rhs);
        public static uint2x2 operator *(uint lhs, uint2x2 rhs);
        public static uint2x2 operator +(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator +(uint2x2 lhs, uint rhs);
        public static uint2x2 operator +(uint lhs, uint2x2 rhs);
        public static uint2x2 operator -(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator -(uint2x2 lhs, uint rhs);
        public static uint2x2 operator -(uint lhs, uint2x2 rhs);
        public static uint2x2 operator /(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator /(uint2x2 lhs, uint rhs);
        public static uint2x2 operator /(uint lhs, uint2x2 rhs);
        public static uint2x2 operator %(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator %(uint2x2 lhs, uint rhs);
        public static uint2x2 operator %(uint lhs, uint2x2 rhs);
        public static uint2x2 operator ++(uint2x2 val);
        public static uint2x2 operator --(uint2x2 val);
        public static bool2x2 operator <(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator <(uint2x2 lhs, uint rhs);
        public static bool2x2 operator <(uint lhs, uint2x2 rhs);
        public static bool2x2 operator <=(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator <=(uint2x2 lhs, uint rhs);
        public static bool2x2 operator <=(uint lhs, uint2x2 rhs);
        public static bool2x2 operator >(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator >(uint2x2 lhs, uint rhs);
        public static bool2x2 operator >(uint lhs, uint2x2 rhs);
        public static bool2x2 operator >=(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator >=(uint2x2 lhs, uint rhs);
        public static bool2x2 operator >=(uint lhs, uint2x2 rhs);
        public static uint2x2 operator -(uint2x2 val);
        public static uint2x2 operator +(uint2x2 val);
        public static uint2x2 operator <<(uint2x2 x, int n);
        public static uint2x2 operator >>(uint2x2 x, int n);
        public static bool2x2 operator ==(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator ==(uint2x2 lhs, uint rhs);
        public static bool2x2 operator ==(uint lhs, uint2x2 rhs);
        public static bool2x2 operator !=(uint2x2 lhs, uint2x2 rhs);
        public static bool2x2 operator !=(uint2x2 lhs, uint rhs);
        public static bool2x2 operator !=(uint lhs, uint2x2 rhs);
        public static uint2x2 operator ~(uint2x2 val);
        public static uint2x2 operator &(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator &(uint2x2 lhs, uint rhs);
        public static uint2x2 operator &(uint lhs, uint2x2 rhs);
        public static uint2x2 operator |(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator |(uint2x2 lhs, uint rhs);
        public static uint2x2 operator |(uint lhs, uint2x2 rhs);
        public static uint2x2 operator ^(uint2x2 lhs, uint2x2 rhs);
        public static uint2x2 operator ^(uint2x2 lhs, uint rhs);
        public static uint2x2 operator ^(uint lhs, uint2x2 rhs);

        public static implicit operator uint2x2(uint v);
        public static explicit operator uint2x2(bool v);
        public static explicit operator uint2x2(bool2x2 v);
        public static explicit operator uint2x2(int v);
        public static explicit operator uint2x2(int2x2 v);
        public static explicit operator uint2x2(float v);
        public static explicit operator uint2x2(float2x2 v);
        public static explicit operator uint2x2(double v);
        public static explicit operator uint2x2(double2x2 v);
    }
}
