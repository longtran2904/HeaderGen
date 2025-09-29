#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/Animator.h")]
    public struct MatchTargetWeightMask
    {

        public MatchTargetWeightMask(Vector3 positionXYZWeight, float rotationWeight);

        public Vector3 positionXYZWeight { get; set; }
        public float rotationWeight { get; set; }
    }
}
