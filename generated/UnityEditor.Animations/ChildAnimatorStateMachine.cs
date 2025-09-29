#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/StateMachine.h")]
    [NativeHeader("Editor/Src/Animation/StateMachine.bindings.h")]
    [RequiredByNativeCode]
    public struct ChildAnimatorStateMachine
    {
        public AnimatorStateMachine stateMachine { get; set; }
        public Vector3 position { get; set; }
    }
}
