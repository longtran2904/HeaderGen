#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [Il2CppEagerStaticClassConstruction]
    public struct half : IEquatable<half>, IFormattable
    {
        public ushort value;
        public static readonly half zero;

        public half(half x);
        public half(float v);
        public half(double v);

        public static float MaxValue { get; }
        public static float MinValue { get; }
        public static half MaxValueAsHalf { get; }
        public static half MinValueAsHalf { get; }

        public bool Equals(half rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static bool operator ==(half lhs, half rhs);
        public static bool operator !=(half lhs, half rhs);

        public static explicit operator half(float v);
        public static explicit operator half(double v);
        public static implicit operator float(half d);
        public static implicit operator double(half d);
    }
}
