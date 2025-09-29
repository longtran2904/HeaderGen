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
    public struct bool4x4 : IEquatable<bool4x4>
    {

        public bool4 c0;
        public bool4 c1;
        public bool4 c2;
        public bool4 c3;

        public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3);
        public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33);
        public bool4x4(bool v);

        public ref bool4 this[int index] { get; }

        public bool Equals(bool4x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool4x4 operator ==(bool4x4 lhs, bool4x4 rhs);
        public static bool4x4 operator ==(bool4x4 lhs, bool rhs);
        public static bool4x4 operator ==(bool lhs, bool4x4 rhs);
        public static bool4x4 operator !=(bool4x4 lhs, bool4x4 rhs);
        public static bool4x4 operator !=(bool4x4 lhs, bool rhs);
        public static bool4x4 operator !=(bool lhs, bool4x4 rhs);
        public static bool4x4 operator !(bool4x4 val);
        public static bool4x4 operator &(bool4x4 lhs, bool4x4 rhs);
        public static bool4x4 operator &(bool4x4 lhs, bool rhs);
        public static bool4x4 operator &(bool lhs, bool4x4 rhs);
        public static bool4x4 operator |(bool4x4 lhs, bool4x4 rhs);
        public static bool4x4 operator |(bool4x4 lhs, bool rhs);
        public static bool4x4 operator |(bool lhs, bool4x4 rhs);
        public static bool4x4 operator ^(bool4x4 lhs, bool4x4 rhs);
        public static bool4x4 operator ^(bool4x4 lhs, bool rhs);
        public static bool4x4 operator ^(bool lhs, bool4x4 rhs);

        public static implicit operator bool4x4(bool v);
    }
}
