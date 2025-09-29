#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
    [ExcludeFromPreset]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DRendererData_overview.html")]
    [MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
    [ReloadGroup]
    public class Renderer2DData : ScriptableRendererData
    {

        public Renderer2DData();

        public float hdrEmulationScale { get; }
        public Light2DBlendStyle[] lightBlendStyles { get; }

        protected override ScriptableRenderer Create();
        protected override void OnEnable();
    }
}
