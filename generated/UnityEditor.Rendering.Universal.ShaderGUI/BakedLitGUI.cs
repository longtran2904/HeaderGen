#region Unity.RenderPipelines.Universal.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Editor.dll
#endregion

namespace UnityEditor.Rendering.Universal.ShaderGUI
{
    public static class BakedLitGUI
    {
        public static void Inputs(BakedLitProperties properties, MaterialEditor materialEditor);

        public struct BakedLitProperties
        {
            public MaterialProperty bumpMapProp;

            public BakedLitProperties(MaterialProperty[] properties);
        }
    }
}
