#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/HingeJoint2D.h")]
    public sealed class HingeJoint2D : AnchoredJoint2D
    {
        public HingeJoint2D();

        public bool useMotor { get; set; }
        public bool useLimits { get; set; }
        public JointMotor2D motor { get; set; }
        public JointAngleLimits2D limits { get; set; }
        public JointLimitState2D limitState { get; }
        public float referenceAngle { get; }
        public float jointAngle { get; }
        public float jointSpeed { get; }

        public float GetMotorTorque(float timeStep);
    }
}
