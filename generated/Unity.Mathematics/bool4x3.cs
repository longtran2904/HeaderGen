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
    public struct bool4x3 : IEquatable<bool4x3>
    {
        public bool4 c0;
        public bool4 c1;
        public bool4 c2;

        public bool4x3(bool4 c0, bool4 c1, bool4 c2);
        public bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32);
        public bool4x3(bool v);

        public ref bool4 this[int index] { get; }

        public bool Equals(bool4x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool4x3 operator ==(bool4x3 lhs, bool4x3 rhs);
        public static bool4x3 operator ==(bool4x3 lhs, bool rhs);
        public static bool4x3 operator ==(bool lhs, bool4x3 rhs);
        public static bool4x3 operator !=(bool4x3 lhs, bool4x3 rhs);
        public static bool4x3 operator !=(bool4x3 lhs, bool rhs);
        public static bool4x3 operator !=(bool lhs, bool4x3 rhs);
        public static bool4x3 operator !(bool4x3 val);
        public static bool4x3 operator &(bool4x3 lhs, bool4x3 rhs);
        public static bool4x3 operator &(bool4x3 lhs, bool rhs);
        public static bool4x3 operator &(bool lhs, bool4x3 rhs);
        public static bool4x3 operator |(bool4x3 lhs, bool4x3 rhs);
        public static bool4x3 operator |(bool4x3 lhs, bool rhs);
        public static bool4x3 operator |(bool lhs, bool4x3 rhs);
        public static bool4x3 operator ^(bool4x3 lhs, bool4x3 rhs);
        public static bool4x3 operator ^(bool4x3 lhs, bool rhs);
        public static bool4x3 operator ^(bool lhs, bool4x3 rhs);

        public static implicit operator bool4x3(bool v);
    }
}
