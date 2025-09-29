#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeAsStruct]
    [NativeHeader("Editor/Src/Animation/StateMachineBehaviourContext.h")]
    public class StateMachineBehaviourContext
    {
        [NativeName("m_AnimatorController")]
        public AnimatorController animatorController;
        [NativeName("m_AnimatorObject")]
        public UnityEngine.Object animatorObject;
        [NativeName("m_LayerIndex")]
        public int layerIndex;

        public StateMachineBehaviourContext();
    }
}
