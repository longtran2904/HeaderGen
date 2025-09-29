#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/ConstantForce2D.h")]
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class ConstantForce2D : PhysicsUpdateBehaviour2D
    {

        public ConstantForce2D();

        public Vector2 force { get; set; }
        public Vector2 relativeForce { get; set; }
        public float torque { get; set; }
    }
}
