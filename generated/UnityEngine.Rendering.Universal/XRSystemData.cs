#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public class XRSystemData : ScriptableObject
    {
        public ShaderResources shaders;

        public XRSystemData();

        [ReloadGroup]
        public sealed class ShaderResources
        {
            [Reload("Shaders/XR/XROcclusionMesh.shader", ReloadAttribute.Package.Root)]
            public Shader xrOcclusionMeshPS;
            [Reload("Shaders/XR/XRMirrorView.shader", ReloadAttribute.Package.Root)]
            public Shader xrMirrorViewPS;

            public ShaderResources();
        }
    }
}
