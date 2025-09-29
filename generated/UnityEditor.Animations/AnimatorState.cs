#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/StateMachineBehaviourScripting.h")]
    [NativeHeader("Editor/Src/Animation/StateMachine.h")]
    [NativeHeader("Editor/Src/Animation/StateMachine.bindings.h")]
    public sealed class AnimatorState : UnityEngine.Object
    {

        public AnimatorState();

        public int nameHash { get; }
        public Motion motion { get; set; }
        public float speed { get; set; }
        public float cycleOffset { get; set; }
        public bool mirror { get; set; }
        public bool iKOnFeet { get; set; }
        public bool writeDefaultValues { get; set; }
        public string tag { get; set; }
        public string speedParameter { get; set; }
        public string cycleOffsetParameter { get; set; }
        public string mirrorParameter { get; set; }
        public string timeParameter { get; set; }
        public bool speedParameterActive { get; set; }
        public bool cycleOffsetParameterActive { get; set; }
        public bool mirrorParameterActive { get; set; }
        public bool timeParameterActive { get; set; }
        public AnimatorStateTransition[] transitions { get; set; }
        public StateMachineBehaviour[] behaviours { get; set; }
        [Obsolete("uniqueName does not exist anymore. Consider using .name instead.", True)]
        public string uniqueName { get; }
        [Obsolete("uniqueNameHash does not exist anymore.", True)]
        public int uniqueNameHash { get; }

        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public StateMachineBehaviour AddStateMachineBehaviour(Type stateMachineBehaviourType);
        public T AddStateMachineBehaviour<T>() where T : StateMachineBehaviour;
        public void AddTransition(AnimatorStateTransition transition);
        public void RemoveTransition(AnimatorStateTransition transition);
        public AnimatorStateTransition AddTransition(AnimatorState destinationState);
        public AnimatorStateTransition AddTransition(AnimatorStateMachine destinationStateMachine);
        public AnimatorStateTransition AddTransition(AnimatorState destinationState, bool defaultExitTime);
        public AnimatorStateTransition AddTransition(AnimatorStateMachine destinationStateMachine, bool defaultExitTime);
        public AnimatorStateTransition AddExitTransition();
        public AnimatorStateTransition AddExitTransition(bool defaultExitTime);
        [Obsolete("GetMotion() is obsolete. Use motion", True)]
        public Motion GetMotion();
    }
}
