#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/WheelJoint2D.h")]
    public sealed class WheelJoint2D : AnchoredJoint2D
    {

        public WheelJoint2D();

        public JointSuspension2D suspension { get; set; }
        public bool useMotor { get; set; }
        public JointMotor2D motor { get; set; }
        public float jointTranslation { get; }
        public float jointLinearSpeed { get; }
        public float jointSpeed { get; }
        public float jointAngle { get; }

        public float GetMotorTorque(float timeStep);
    }
}
