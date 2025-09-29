#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
    [MovedFrom("Utilities")]
    public static class MaterialQualityUtilities
    {

        public static string[] KeywordNames;
        public static string[] EnumNames;
        public static ShaderKeyword[] Keywords;

        public static MaterialQuality GetHighestQuality(this MaterialQuality levels);
        public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel);
        public static void SetGlobalShaderKeywords(this MaterialQuality level);
        public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd);
        public static int ToFirstIndex(this MaterialQuality level);
        public static MaterialQuality FromIndex(int index);
    }
}
