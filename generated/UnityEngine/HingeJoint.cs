#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("Unity::HingeJoint")]
    [NativeHeader("Modules/Physics/HingeJoint.h")]
    public class HingeJoint : Joint
    {
        public HingeJoint();

        public JointMotor motor { get; set; }
        public JointLimits limits { get; set; }
        public JointSpring spring { get; set; }
        public bool useMotor { get; set; }
        public bool useLimits { get; set; }
        public bool useSpring { get; set; }
        public float velocity { get; }
        public float angle { get; }
    }
}
