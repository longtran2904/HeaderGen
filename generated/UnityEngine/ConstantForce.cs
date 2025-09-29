#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/ConstantForce.h")]
    [RequireComponent(typeof(Rigidbody))]
    public class ConstantForce : Behaviour
    {
        public ConstantForce();

        public Vector3 force { get; set; }
        public Vector3 relativeForce { get; set; }
        public Vector3 torque { get; set; }
        public Vector3 relativeTorque { get; set; }
    }
}
