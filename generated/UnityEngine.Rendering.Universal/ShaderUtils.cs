#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public static class ShaderUtils
    {
        public static string GetShaderPath(ShaderPathID id);
        public static ShaderPathID GetEnumFromPath(string path);
        public static bool IsLWShader(Shader shader);
        public static string GetShaderGUID(ShaderPathID id);
    }
}
