#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
    [UsedByNativeCode]
    public class AnimatorOverrideController : RuntimeAnimatorController
    {

        public AnimatorOverrideController();
        public AnimatorOverrideController(RuntimeAnimatorController controller);

        public AnimationClip this[string name] { get; set; }
        public AnimationClip this[AnimationClip clip] { get; set; }
        public RuntimeAnimatorController runtimeAnimatorController { get; set; }
        public int overridesCount { get; }
        [Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
        public AnimationClipPair[] clips { get; set; }

        public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides);
        public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides);
    }
}
