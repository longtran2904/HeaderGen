#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.Universal
{
    public class ParticleUpgrader : MaterialUpgrader
    {

        public ParticleUpgrader(string oldShaderName);

        public static void UpdateStandardSurface(Material material);
        public static void UpdateUnlit(Material material);
        public static void UpdateSurfaceBlendModes(Material material);
    }
}
