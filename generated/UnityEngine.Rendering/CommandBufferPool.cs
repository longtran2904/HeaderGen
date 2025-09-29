#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class CommandBufferPool
    {

        public static CommandBuffer Get();
        public static CommandBuffer Get(string name);
        public static void Release(CommandBuffer buffer);
    }
}
