#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
    [NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
    [NativeHeader("Runtime/Graphics/RenderTexture.h")]
    [NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
    [RequiredByNativeCode]
    [StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
    public struct TexturePlayableOutput : IPlayableOutput
    {

        public static TexturePlayableOutput Null { get; }

        public static TexturePlayableOutput Create(PlayableGraph graph, string name, RenderTexture target);
        public PlayableOutputHandle GetHandle();
        public RenderTexture GetTarget();
        public void SetTarget(RenderTexture value);

        public static implicit operator PlayableOutput(TexturePlayableOutput output);
        public static explicit operator TexturePlayableOutput(PlayableOutput output);
    }
}
