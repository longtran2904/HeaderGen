#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/CharacterController.h")]
    public class CharacterController : Collider
    {

        public CharacterController();

        public Vector3 velocity { get; }
        public bool isGrounded { get; }
        public CollisionFlags collisionFlags { get; }
        public float radius { get; set; }
        public float height { get; set; }
        public Vector3 center { get; set; }
        public float slopeLimit { get; set; }
        public float stepOffset { get; set; }
        public float skinWidth { get; set; }
        public float minMoveDistance { get; set; }
        public bool detectCollisions { get; set; }
        public bool enableOverlapRecovery { get; set; }

        public bool SimpleMove(Vector3 speed);
        public CollisionFlags Move(Vector3 motion);
    }
}
