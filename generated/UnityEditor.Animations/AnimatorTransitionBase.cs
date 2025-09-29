#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/Transition.h")]
    [NativeHeader("Modules/Animation/MecanimUtility.h")]
    public class AnimatorTransitionBase : UnityEngine.Object
    {
        protected AnimatorTransitionBase();

        public bool solo { get; set; }
        public bool mute { get; set; }
        public bool isExit { get; set; }
        public AnimatorStateMachine destinationStateMachine { get; set; }
        public AnimatorState destinationState { get; set; }
        public AnimatorCondition[] conditions { get; set; }

        public string GetDisplayName(UnityEngine.Object source);
        public void AddCondition(AnimatorConditionMode mode, float threshold, string parameter);
        public void RemoveCondition(AnimatorCondition condition);
    }
}
