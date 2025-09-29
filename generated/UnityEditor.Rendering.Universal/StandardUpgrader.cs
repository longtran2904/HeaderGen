#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Rendering.Universal
{
    public class StandardUpgrader : MaterialUpgrader
    {

        public StandardUpgrader(string oldShaderName);

        public static void UpdateStandardMaterialKeywords(Material material);
        public static void UpdateStandardSpecularMaterialKeywords(Material material);
    }
}
