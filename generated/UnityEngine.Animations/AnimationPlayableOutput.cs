#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
    [NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
    [NativeHeader("Modules/Animation/Animator.h")]
    [NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
    public struct AnimationPlayableOutput : IPlayableOutput
    {

        public static AnimationPlayableOutput Null { get; }

        public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target);
        public PlayableOutputHandle GetHandle();
        public Animator GetTarget();
        public void SetTarget(Animator value);

        public static implicit operator PlayableOutput(AnimationPlayableOutput output);
        public static explicit operator AnimationPlayableOutput(PlayableOutput output);
    }
}
