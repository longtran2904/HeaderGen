#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/StateMachine.h")]
    [NativeHeader("Editor/Src/Animation/StateMachineBehaviourScripting.h")]
    [NativeHeader("Editor/Src/Animation/StateMachine.bindings.h")]
    public sealed class AnimatorStateMachine : UnityEngine.Object
    {
        public AnimatorStateMachine();

        public ChildAnimatorState[] states { get; set; }
        public ChildAnimatorStateMachine[] stateMachines { get; set; }
        public AnimatorState defaultState { get; set; }
        public Vector3 anyStatePosition { get; set; }
        public Vector3 entryPosition { get; set; }
        public Vector3 exitPosition { get; set; }
        public Vector3 parentStateMachinePosition { get; set; }
        public AnimatorStateTransition[] anyStateTransitions { get; set; }
        public AnimatorTransition[] entryTransitions { get; set; }
        public StateMachineBehaviour[] behaviours { get; set; }

        public AnimatorTransition[] GetStateMachineTransitions(AnimatorStateMachine sourceStateMachine);
        public void SetStateMachineTransitions(AnimatorStateMachine sourceStateMachine, AnimatorTransition[] transitions);
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public StateMachineBehaviour AddStateMachineBehaviour(Type stateMachineBehaviourType);
        public T AddStateMachineBehaviour<T>() where T : StateMachineBehaviour;
        public string MakeUniqueStateName(string name);
        public string MakeUniqueStateMachineName(string name);
        public AnimatorState AddState(string name);
        public AnimatorState AddState(string name, Vector3 position);
        public void AddState(AnimatorState state, Vector3 position);
        public void RemoveState(AnimatorState state);
        public AnimatorStateMachine AddStateMachine(string name);
        public AnimatorStateMachine AddStateMachine(string name, Vector3 position);
        public void AddStateMachine(AnimatorStateMachine stateMachine, Vector3 position);
        public void RemoveStateMachine(AnimatorStateMachine stateMachine);
        public AnimatorStateTransition AddAnyStateTransition(AnimatorState destinationState);
        public AnimatorStateTransition AddAnyStateTransition(AnimatorStateMachine destinationStateMachine);
        public bool RemoveAnyStateTransition(AnimatorStateTransition transition);
        public AnimatorTransition AddStateMachineTransition(AnimatorStateMachine sourceStateMachine);
        public AnimatorTransition AddStateMachineTransition(AnimatorStateMachine sourceStateMachine, AnimatorStateMachine destinationStateMachine);
        public AnimatorTransition AddStateMachineTransition(AnimatorStateMachine sourceStateMachine, AnimatorState destinationState);
        public AnimatorTransition AddStateMachineExitTransition(AnimatorStateMachine sourceStateMachine);
        public bool RemoveStateMachineTransition(AnimatorStateMachine sourceStateMachine, AnimatorTransition transition);
        public AnimatorTransition AddEntryTransition(AnimatorState destinationState);
        public AnimatorTransition AddEntryTransition(AnimatorStateMachine destinationStateMachine);
        public bool RemoveEntryTransition(AnimatorTransition transition);
    }
}
