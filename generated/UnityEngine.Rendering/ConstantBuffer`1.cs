#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class ConstantBuffer<CBType> : ConstantBufferBase where CBType : struct
    {
        public ConstantBuffer();

        public void UpdateData(CommandBuffer cmd, in CBType data);
        public void UpdateData(in CBType data);
        public void SetGlobal(CommandBuffer cmd, int shaderId);
        public void SetGlobal(int shaderId);
        public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId);
        public void Set(ComputeShader cs, int shaderId);
        public void Set(Material mat, int shaderId);
        public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId);
        public void PushGlobal(in CBType data, int shaderId);
        public override void Release();
    }
}
