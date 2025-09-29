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
    public struct bool2x2 : IEquatable<bool2x2>
    {

        public bool2 c0;
        public bool2 c1;

        public bool2x2(bool2 c0, bool2 c1);
        public bool2x2(bool m00, bool m01, bool m10, bool m11);
        public bool2x2(bool v);

        public ref bool2 this[int index] { get; }

        public bool Equals(bool2x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool2x2 operator ==(bool2x2 lhs, bool2x2 rhs);
        public static bool2x2 operator ==(bool2x2 lhs, bool rhs);
        public static bool2x2 operator ==(bool lhs, bool2x2 rhs);
        public static bool2x2 operator !=(bool2x2 lhs, bool2x2 rhs);
        public static bool2x2 operator !=(bool2x2 lhs, bool rhs);
        public static bool2x2 operator !=(bool lhs, bool2x2 rhs);
        public static bool2x2 operator !(bool2x2 val);
        public static bool2x2 operator &(bool2x2 lhs, bool2x2 rhs);
        public static bool2x2 operator &(bool2x2 lhs, bool rhs);
        public static bool2x2 operator &(bool lhs, bool2x2 rhs);
        public static bool2x2 operator |(bool2x2 lhs, bool2x2 rhs);
        public static bool2x2 operator |(bool2x2 lhs, bool rhs);
        public static bool2x2 operator |(bool lhs, bool2x2 rhs);
        public static bool2x2 operator ^(bool2x2 lhs, bool2x2 rhs);
        public static bool2x2 operator ^(bool2x2 lhs, bool rhs);
        public static bool2x2 operator ^(bool lhs, bool2x2 rhs);

        public static implicit operator bool2x2(bool v);
    }
}
