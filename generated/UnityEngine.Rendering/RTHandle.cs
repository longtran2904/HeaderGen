#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class RTHandle
    {

        public Vector2 scaleFactor { get; }
        public bool useScaling { get; }
        public Vector2Int referenceSize { get; }
        public RTHandleProperties rtHandleProperties { get; }
        public RenderTexture rt { get; }
        public RenderTargetIdentifier nameID { get; }
        public string name { get; }
        public bool isMSAAEnabled { get; }

        public void SetCustomHandleProperties(in RTHandleProperties properties);
        public void ClearCustomHandleProperties();
        public int GetInstanceID();
        public void Release();
        public Vector2Int GetScaledSize(Vector2Int refSize);
        public Vector2Int GetScaledSize();
        public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = FastMemoryFlags.SpillTop, bool copyContents = False);
        public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = FastMemoryFlags.SpillTop);
        public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = True);

        public static implicit operator RenderTargetIdentifier(RTHandle handle);
        public static implicit operator Texture(RTHandle handle);
        public static implicit operator RenderTexture(RTHandle handle);
    }
}
