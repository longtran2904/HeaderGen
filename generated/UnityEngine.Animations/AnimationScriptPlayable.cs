#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AnimationScriptPlayable : IAnimationJobPlayable, IEquatable<AnimationScriptPlayable>, IPlayable
    {
        public static AnimationScriptPlayable Null { get; }

        public static AnimationScriptPlayable Create<T>(PlayableGraph graph, T jobData, int inputCount = 0) where T : IAnimationJob, struct;
        public PlayableHandle GetHandle();
        public T GetJobData<T>() where T : IAnimationJob, struct;
        public void SetJobData<T>(T jobData) where T : IAnimationJob, struct;
        public bool Equals(AnimationScriptPlayable other);
        public void SetProcessInputs(bool value);
        public bool GetProcessInputs();

        public static implicit operator Playable(AnimationScriptPlayable playable);
        public static explicit operator AnimationScriptPlayable(Playable playable);
    }
}
