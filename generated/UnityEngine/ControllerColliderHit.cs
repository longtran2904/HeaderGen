#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public class ControllerColliderHit
    {
        public ControllerColliderHit();

        public CharacterController controller { get; }
        public Collider collider { get; }
        public Rigidbody rigidbody { get; }
        public GameObject gameObject { get; }
        public Transform transform { get; }
        public Vector3 point { get; }
        public Vector3 normal { get; }
        public Vector3 moveDirection { get; }
        public float moveLength { get; }
    }
}
