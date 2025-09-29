#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/AnimationClip.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
    public static class AnimationPlayableExtensions
    {

        public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : IPlayable, struct;
    }
}
