#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>, IPlayable
    {

        public static AnimationLayerMixerPlayable Null { get; }

        public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0);
        public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization);
        public PlayableHandle GetHandle();
        public bool Equals(AnimationLayerMixerPlayable other);
        public bool IsLayerAdditive(uint layerIndex);
        public void SetLayerAdditive(uint layerIndex, bool value);
        public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask);

        public static implicit operator Playable(AnimationLayerMixerPlayable playable);
        public static explicit operator AnimationLayerMixerPlayable(Playable playable);
    }
}
