#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public class Collision2D
    {

        public Collision2D();

        public Collider2D collider { get; }
        public Collider2D otherCollider { get; }
        public Rigidbody2D rigidbody { get; }
        public Rigidbody2D otherRigidbody { get; }
        public Transform transform { get; }
        public GameObject gameObject { get; }
        public Vector2 relativeVelocity { get; }
        public bool enabled { get; }
        public ContactPoint2D[] contacts { get; }
        public int contactCount { get; }

        public ContactPoint2D GetContact(int index);
        public int GetContacts(ContactPoint2D[] contacts);
        public int GetContacts(List<ContactPoint2D> contacts);
    }
}
