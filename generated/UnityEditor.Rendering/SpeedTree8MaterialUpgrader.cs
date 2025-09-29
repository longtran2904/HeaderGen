#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering
{
    public class SpeedTree8MaterialUpgrader : MaterialUpgrader
    {
        public SpeedTree8MaterialUpgrader(string sourceShaderName, string destShaderName, MaterialFinalizer finalizer = null);

        public static void PostprocessSpeedTree8Materials(GameObject speedtree, SpeedTreeImporter stImporter, MaterialFinalizer finalizer = null);
        public static void SpeedTree8MaterialFinalizer(Material material);
    }
}
