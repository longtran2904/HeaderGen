#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
    public abstract class ScriptableRendererData : ScriptableObject
    {
        public DebugShaderResources debugShaders;

        protected ScriptableRendererData();

        public List<ScriptableRendererFeature> rendererFeatures { get; }
        public bool useNativeRenderPass { get; set; }

        protected abstract ScriptableRenderer Create();
        public void SetDirty();
        protected virtual void OnValidate();
        protected virtual void OnEnable();

        [ReloadGroup]
        public sealed class DebugShaderResources
        {
            [Reload("Shaders/Debug/DebugReplacement.shader", ReloadAttribute.Package.Root)]
            public Shader debugReplacementPS;

            public DebugShaderResources();
        }
    }
}
