#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
    [NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
    [RequiredByNativeCode(Optional = False, GenerateProxy = True)]
    public struct ContactPoint2D
    {

        public Vector2 point { get; }
        public Vector2 normal { get; }
        public float separation { get; }
        public float normalImpulse { get; }
        public float tangentImpulse { get; }
        public Vector2 relativeVelocity { get; }
        public Collider2D collider { get; }
        public Collider2D otherCollider { get; }
        public Rigidbody2D rigidbody { get; }
        public Rigidbody2D otherRigidbody { get; }
        public bool enabled { get; }
    }
}
