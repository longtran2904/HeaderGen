#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Animations;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Animations
{
    [NativeHeader("Modules/Animation/AnimatorDefines.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutputExtensions.bindings.h")]
    [StaticAccessor("AnimationPlayableOutputExtensionsBindings", StaticAccessorType.DoubleColon)]
    public static class AnimationPlayableOutputExtensions
    {
        public static AnimationStreamSource GetAnimationStreamSource(this AnimationPlayableOutput output);
        public static void SetAnimationStreamSource(this AnimationPlayableOutput output, AnimationStreamSource streamSource);
        public static ushort GetSortingOrder(this AnimationPlayableOutput output);
        public static void SetSortingOrder(this AnimationPlayableOutput output, ushort sortingOrder);
    }
}
