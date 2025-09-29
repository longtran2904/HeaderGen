#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public struct RenderTargetHandle
    {
        public static readonly RenderTargetHandle CameraTarget;

        public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier);

        public int id { get; set; }

        public void Init(string shaderProperty);
        public void Init(RenderTargetIdentifier renderTargetIdentifier);
        public RenderTargetIdentifier Identifier();
        public bool HasInternalRenderTargetId();
        public bool Equals(RenderTargetHandle other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2);
        public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2);
    }
}
