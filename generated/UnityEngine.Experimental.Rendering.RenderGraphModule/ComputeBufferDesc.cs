#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct ComputeBufferDesc
    {

        public int count;
        public int stride;
        public ComputeBufferType type;
        public string name;

        public ComputeBufferDesc(int count, int stride);
        public ComputeBufferDesc(int count, int stride, ComputeBufferType type);

        public override int GetHashCode();
    }
}
