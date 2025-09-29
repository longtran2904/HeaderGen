#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public struct SphericalHarmonicsL1
    {
        public Vector4 shAr;
        public Vector4 shAg;
        public Vector4 shAb;
        public static readonly SphericalHarmonicsL1 zero;

        public override bool Equals(object other);
        public override int GetHashCode();

        public static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs);
        public static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs);
        public static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs);
        public static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs);
        public static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs);
        public static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs);
    }
}
