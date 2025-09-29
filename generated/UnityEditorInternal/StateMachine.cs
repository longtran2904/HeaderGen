#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditorInternal
{
    [NativeClass(null)]
    [Obsolete("StateMachine is obsolete. Use UnityEditor.Animations.AnimatorStateMachine instead (UnityUpgradable) -> UnityEditor.Animations.AnimatorStateMachine", True)]
    public class StateMachine : UnityEngine.Object
    {

        public StateMachine();

        public State defaultState { get; set; }
        public Vector3 anyStatePosition { get; set; }
        public Vector3 parentStateMachinePosition { get; set; }

        public State GetState(int index);
        public State AddState(string stateName);
        public StateMachine GetStateMachine(int index);
        public StateMachine AddStateMachine(string stateMachineName);
        public Transition AddTransition(State src, State dst);
        public Transition AddAnyStateTransition(State dst);
        public Vector3 GetStateMachinePosition(int i);
        public Transition[] GetTransitionsFromState(State srcState);
    }
}
