#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class BufferedRTHandleSystem : IDisposable
    {

        public BufferedRTHandleSystem();

        public int maxWidth { get; }
        public int maxHeight { get; }
        public RTHandleProperties rtHandleProperties { get; }

        public RTHandle GetFrameRT(int bufferId, int frameIndex);
        public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount);
        public void ReleaseBuffer(int bufferId);
        public void SwapAndSetReferenceSize(int width, int height);
        public void ResetReferenceSize(int width, int height);
        public int GetNumFramesAllocated(int bufferId);
        public Vector2 CalculateRatioAgainstMaxSize(int width, int height);
        public void Dispose();
        public void ReleaseAll();
    }
}
