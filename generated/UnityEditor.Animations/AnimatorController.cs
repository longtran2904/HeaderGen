#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEditor.Animations
{
    [NativeClass(null)]
    [NativeHeader("Editor/Src/Animation/AnimatorController.bindings.h")]
    [NativeHeader("Editor/Src/Animation/StateMachineBehaviourScripting.h")]
    [NativeHeader("Modules/Animation/Animator.h")]
    [NativeHeader("Modules/Animation/AnimatorController.h")]
    public sealed class AnimatorController : RuntimeAnimatorController
    {
        public AnimatorController();

        public AnimatorControllerLayer[] layers { get; set; }
        public AnimatorControllerParameter[] parameters { get; set; }

        public static void SetAnimatorController(Animator animator, AnimatorController controller);
        public string MakeUniqueParameterName(string name);
        public string MakeUniqueLayerName(string name);
        public static StateMachineBehaviourContext[] FindStateMachineBehaviourContext(StateMachineBehaviour behaviour);
        [FreeFunction("AnimatorControllerBindings::Internal_CreateStateMachineBehaviour")]
        public static int CreateStateMachineBehaviour(MonoScript script);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public StateMachineBehaviour AddEffectiveStateMachineBehaviour(Type stateMachineBehaviourType, AnimatorState state, int layerIndex);
        public T AddEffectiveStateMachineBehaviour<T>(AnimatorState state, int layerIndex) where T : StateMachineBehaviour;
        public T[] GetBehaviours<T>() where T : StateMachineBehaviour;
        public void AddLayer(string name);
        public void AddLayer(AnimatorControllerLayer layer);
        public void RemoveLayer(int index);
        public void AddParameter(string name, AnimatorControllerParameterType type);
        public void AddParameter(AnimatorControllerParameter paramater);
        public void RemoveParameter(int index);
        public void RemoveParameter(AnimatorControllerParameter parameter);
        public AnimatorState AddMotion(Motion motion);
        public AnimatorState AddMotion(Motion motion, int layerIndex);
        public AnimatorState CreateBlendTreeInController(string name, out BlendTree tree);
        public AnimatorState CreateBlendTreeInController(string name, out BlendTree tree, int layerIndex);
        public static AnimatorController CreateAnimatorControllerAtPath(string path);
        public static AnimationClip AllocateAnimatorClip(string name);
        public static AnimatorController CreateAnimatorControllerAtPathWithClip(string path, AnimationClip clip);
        public void SetStateEffectiveMotion(AnimatorState state, Motion motion);
        public void SetStateEffectiveMotion(AnimatorState state, Motion motion, int layerIndex);
        public Motion GetStateEffectiveMotion(AnimatorState state);
        public Motion GetStateEffectiveMotion(AnimatorState state, int layerIndex);
        public void SetStateEffectiveBehaviours(AnimatorState state, int layerIndex, StateMachineBehaviour[] behaviours);
        public StateMachineBehaviour[] GetStateEffectiveBehaviours(AnimatorState state, int layerIndex);
    }
}
