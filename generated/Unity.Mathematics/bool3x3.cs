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
    public struct bool3x3 : IEquatable<bool3x3>
    {
        public bool3 c0;
        public bool3 c1;
        public bool3 c2;

        public bool3x3(bool3 c0, bool3 c1, bool3 c2);
        public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22);
        public bool3x3(bool v);

        public ref bool3 this[int index] { get; }

        public bool Equals(bool3x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool3x3 operator ==(bool3x3 lhs, bool3x3 rhs);
        public static bool3x3 operator ==(bool3x3 lhs, bool rhs);
        public static bool3x3 operator ==(bool lhs, bool3x3 rhs);
        public static bool3x3 operator !=(bool3x3 lhs, bool3x3 rhs);
        public static bool3x3 operator !=(bool3x3 lhs, bool rhs);
        public static bool3x3 operator !=(bool lhs, bool3x3 rhs);
        public static bool3x3 operator !(bool3x3 val);
        public static bool3x3 operator &(bool3x3 lhs, bool3x3 rhs);
        public static bool3x3 operator &(bool3x3 lhs, bool rhs);
        public static bool3x3 operator &(bool lhs, bool3x3 rhs);
        public static bool3x3 operator |(bool3x3 lhs, bool3x3 rhs);
        public static bool3x3 operator |(bool3x3 lhs, bool rhs);
        public static bool3x3 operator |(bool lhs, bool3x3 rhs);
        public static bool3x3 operator ^(bool3x3 lhs, bool3x3 rhs);
        public static bool3x3 operator ^(bool3x3 lhs, bool rhs);
        public static bool3x3 operator ^(bool lhs, bool3x3 rhs);

        public static implicit operator bool3x3(bool v);
    }
}
