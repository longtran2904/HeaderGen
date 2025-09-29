#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/Transition.h")]
    [NativeHeader("Editor/Src/Animation/StateMachine.bindings.h")]
    public class AnimatorStateTransition : AnimatorTransitionBase
    {
        public AnimatorStateTransition();

        public float duration { get; set; }
        public float offset { get; set; }
        public TransitionInterruptionSource interruptionSource { get; set; }
        public bool orderedInterruption { get; set; }
        public float exitTime { get; set; }
        public bool hasExitTime { get; set; }
        public bool hasFixedDuration { get; set; }
        public bool canTransitionToSelf { get; set; }
    }
}
