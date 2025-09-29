#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public class Collision
    {

        public Collision();

        public Vector3 relativeVelocity { get; }
        public Rigidbody rigidbody { get; }
        public ArticulationBody articulationBody { get; }
        public Component body { get; }
        public Collider collider { get; }
        public Transform transform { get; }
        public GameObject gameObject { get; }
        public int contactCount { get; }
        public ContactPoint[] contacts { get; }
        public Vector3 impulse { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Collision.relativeVelocity instead. (UnityUpgradable) -> relativeVelocity", False)]
        public Vector3 impactForceSum { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Will always return zero.", True)]
        public Vector3 frictionForceSum { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Collision.rigidbody, Collision.transform or Collision.collider instead", False)]
        public Component other { get; }

        public ContactPoint GetContact(int index);
        public int GetContacts(ContactPoint[] contacts);
        public int GetContacts(List<ContactPoint> contacts);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Do not use Collision.GetEnumerator(), enumerate using non-allocating array returned by Collision.GetContacts() or enumerate using Collision.GetContact(index) instead.", False)]
        public virtual IEnumerator GetEnumerator();
    }
}
