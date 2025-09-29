#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/Transition.h")]
    public struct AnimatorCondition
    {

        public AnimatorConditionMode mode { get; set; }
        public string parameter { get; set; }
        public float threshold { get; set; }
    }
}
