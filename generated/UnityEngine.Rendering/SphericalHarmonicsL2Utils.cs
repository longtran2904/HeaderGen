#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class SphericalHarmonicsL2Utils
    {
        public SphericalHarmonicsL2Utils();

        public static void GetL1(SphericalHarmonicsL2 sh, out Vector3 L1_R, out Vector3 L1_G, out Vector3 L1_B);
        public static void GetL2(SphericalHarmonicsL2 sh, out Vector3 L2_0, out Vector3 L2_1, out Vector3 L2_2, out Vector3 L2_3, out Vector3 L2_4);
        public static void SetL0(ref SphericalHarmonicsL2 sh, Vector3 L0);
        public static void SetL1R(ref SphericalHarmonicsL2 sh, Vector3 L1_R);
        public static void SetL1G(ref SphericalHarmonicsL2 sh, Vector3 L1_G);
        public static void SetL1B(ref SphericalHarmonicsL2 sh, Vector3 L1_B);
        public static void SetL1(ref SphericalHarmonicsL2 sh, Vector3 L1_R, Vector3 L1_G, Vector3 L1_B);
        public static void SetCoefficient(ref SphericalHarmonicsL2 sh, int index, Vector3 coefficient);
        public static Vector3 GetCoefficient(SphericalHarmonicsL2 sh, int index);
    }
}
