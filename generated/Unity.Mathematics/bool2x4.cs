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
    public struct bool2x4 : IEquatable<bool2x4>
    {
        public bool2 c0;
        public bool2 c1;
        public bool2 c2;
        public bool2 c3;

        public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3);
        public bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13);
        public bool2x4(bool v);

        public ref bool2 this[int index] { get; }

        public bool Equals(bool2x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool2x4 operator ==(bool2x4 lhs, bool2x4 rhs);
        public static bool2x4 operator ==(bool2x4 lhs, bool rhs);
        public static bool2x4 operator ==(bool lhs, bool2x4 rhs);
        public static bool2x4 operator !=(bool2x4 lhs, bool2x4 rhs);
        public static bool2x4 operator !=(bool2x4 lhs, bool rhs);
        public static bool2x4 operator !=(bool lhs, bool2x4 rhs);
        public static bool2x4 operator !(bool2x4 val);
        public static bool2x4 operator &(bool2x4 lhs, bool2x4 rhs);
        public static bool2x4 operator &(bool2x4 lhs, bool rhs);
        public static bool2x4 operator &(bool lhs, bool2x4 rhs);
        public static bool2x4 operator |(bool2x4 lhs, bool2x4 rhs);
        public static bool2x4 operator |(bool2x4 lhs, bool rhs);
        public static bool2x4 operator |(bool lhs, bool2x4 rhs);
        public static bool2x4 operator ^(bool2x4 lhs, bool2x4 rhs);
        public static bool2x4 operator ^(bool2x4 lhs, bool rhs);
        public static bool2x4 operator ^(bool lhs, bool2x4 rhs);

        public static implicit operator bool2x4(bool v);
    }
}
