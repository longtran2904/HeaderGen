#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("Unity::Joint")]
    [NativeHeader("Modules/Physics/Joint.h")]
    [RequireComponent(typeof(Rigidbody))]
    public class Joint : Component
    {
        public Joint();

        public Rigidbody connectedBody { get; set; }
        public ArticulationBody connectedArticulationBody { get; set; }
        public Vector3 axis { get; set; }
        public Vector3 anchor { get; set; }
        public Vector3 connectedAnchor { get; set; }
        public bool autoConfigureConnectedAnchor { get; set; }
        public float breakForce { get; set; }
        public float breakTorque { get; set; }
        public bool enableCollision { get; set; }
        public bool enablePreprocessing { get; set; }
        public float massScale { get; set; }
        public float connectedMassScale { get; set; }
        public Vector3 currentForce { get; }
        public Vector3 currentTorque { get; }
    }
}
