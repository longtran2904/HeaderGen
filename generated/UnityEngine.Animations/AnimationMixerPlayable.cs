#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>, IPlayable
    {
        public static AnimationMixerPlayable Null { get; }

        [Obsolete("normalizeWeights is obsolete. It has no effect and will be removed.")]
        public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount, bool normalizeWeights);
        public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0);
        public PlayableHandle GetHandle();
        public bool Equals(AnimationMixerPlayable other);

        public static implicit operator Playable(AnimationMixerPlayable playable);
        public static explicit operator AnimationMixerPlayable(Playable playable);
    }
}
