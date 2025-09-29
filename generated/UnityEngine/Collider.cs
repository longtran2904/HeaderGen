#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/Collider.h")]
    [RequireComponent(typeof(Transform))]
    [RequiredByNativeCode]
    public class Collider : Component
    {
        public Collider();

        public bool enabled { get; set; }
        public Rigidbody attachedRigidbody { get; }
        public ArticulationBody attachedArticulationBody { get; }
        public bool isTrigger { get; set; }
        public float contactOffset { get; set; }
        public Bounds bounds { get; }
        public bool hasModifiableContacts { get; set; }
        [NativeMethod("Material")]
        public PhysicMaterial sharedMaterial { get; set; }
        public PhysicMaterial material { get; set; }

        public Vector3 ClosestPoint(Vector3 position);
        public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);
        public Vector3 ClosestPointOnBounds(Vector3 position);
    }
}
