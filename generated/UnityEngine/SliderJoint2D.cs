#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/SliderJoint2D.h")]
    public sealed class SliderJoint2D : AnchoredJoint2D
    {

        public SliderJoint2D();

        public bool autoConfigureAngle { get; set; }
        public float angle { get; set; }
        public bool useMotor { get; set; }
        public bool useLimits { get; set; }
        public JointMotor2D motor { get; set; }
        public JointTranslationLimits2D limits { get; set; }
        public JointLimitState2D limitState { get; }
        public float referenceAngle { get; }
        public float jointTranslation { get; }
        public float jointSpeed { get; }

        public float GetMotorForce(float timeStep);
    }
}
