#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
    [NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>, IPlayable
    {

        public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip);
        public PlayableHandle GetHandle();
        public bool Equals(AnimationClipPlayable other);
        public AnimationClip GetAnimationClip();
        public bool GetApplyFootIK();
        public void SetApplyFootIK(bool value);
        public bool GetApplyPlayableIK();
        public void SetApplyPlayableIK(bool value);

        public static implicit operator Playable(AnimationClipPlayable playable);
        public static explicit operator AnimationClipPlayable(Playable playable);
    }
}
