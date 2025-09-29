#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeAsStruct]
    [NativeHeader("Editor/Src/Animation/AnimatorControllerLayer.bindings.h")]
    [NativeHeader("Editor/Src/Animation/AnimatorControllerLayer.h")]
    [NativeType(CodegenOptions.Custom, "MonoAnimatorControllerLayer")]
    public class AnimatorControllerLayer
    {

        public AnimatorControllerLayer();

        public string name { get; set; }
        public AnimatorStateMachine stateMachine { get; set; }
        public AvatarMask avatarMask { get; set; }
        public AnimatorLayerBlendingMode blendingMode { get; set; }
        public int syncedLayerIndex { get; set; }
        public bool iKPass { get; set; }
        public float defaultWeight { get; set; }
        public bool syncedLayerAffectsTiming { get; set; }

        public Motion GetOverrideMotion(AnimatorState state);
        public void SetOverrideMotion(AnimatorState state, Motion motion);
        public StateMachineBehaviour[] GetOverrideBehaviours(AnimatorState state);
        public void SetOverrideBehaviours(AnimatorState state, StateMachineBehaviour[] behaviours);
    }
}
