#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class ConstantBuffer
    {

        public ConstantBuffer();

        public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) where CBType : struct;
        public static void PushGlobal<CBType>(in CBType data, int shaderId) where CBType : struct;
        public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) where CBType : struct;
        public static void Push<CBType>(in CBType data, ComputeShader cs, int shaderId) where CBType : struct;
        public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) where CBType : struct;
        public static void Push<CBType>(in CBType data, Material mat, int shaderId) where CBType : struct;
        public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) where CBType : struct;
        public static void UpdateData<CBType>(in CBType data) where CBType : struct;
        public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) where CBType : struct;
        public static void SetGlobal<CBType>(int shaderId) where CBType : struct;
        public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) where CBType : struct;
        public static void Set<CBType>(ComputeShader cs, int shaderId) where CBType : struct;
        public static void Set<CBType>(Material mat, int shaderId) where CBType : struct;
        public static void ReleaseAll();
    }
}
