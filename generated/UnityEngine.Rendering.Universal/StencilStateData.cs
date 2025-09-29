#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public class StencilStateData
    {

        public bool overrideStencilState;
        public int stencilReference;
        public CompareFunction stencilCompareFunction;
        public StencilOp passOperation;
        public StencilOp failOperation;
        public StencilOp zFailOperation;

        public StencilStateData();
    }
}
