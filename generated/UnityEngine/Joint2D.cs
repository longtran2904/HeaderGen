#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Joint2D.h")]
    [RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
    public class Joint2D : Behaviour
    {
        public Joint2D();

        public Rigidbody2D attachedRigidbody { get; }
        public Rigidbody2D connectedBody { get; set; }
        public bool enableCollision { get; set; }
        public float breakForce { get; set; }
        public float breakTorque { get; set; }
        public Vector2 reactionForce { get; }
        public float reactionTorque { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Joint2D.collideConnected has been deprecated. Use Joint2D.enableCollision instead (UnityUpgradable) -> enableCollision", True)]
        public bool collideConnected { get; set; }

        public Vector2 GetReactionForce(float timeStep);
        public float GetReactionTorque(float timeStep);
    }
}
