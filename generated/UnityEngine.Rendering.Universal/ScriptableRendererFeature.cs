#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    [ExcludeFromPreset]
    public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
    {
        protected ScriptableRendererFeature();

        public bool isActive { get; }

        public abstract void Create();
        public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData);
        public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);
        public void SetActive(bool active);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
