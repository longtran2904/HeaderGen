#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
    [RequireComponent(typeof(Transform))]
    [RequiredByNativeCode(Optional = True)]
    public class Collider2D : Behaviour
    {
        public Collider2D();

        public float density { get; set; }
        public bool isTrigger { get; set; }
        public bool usedByEffector { get; set; }
        public bool usedByComposite { get; set; }
        public CompositeCollider2D composite { get; }
        public Vector2 offset { get; set; }
        public Rigidbody2D attachedRigidbody { get; }
        public int shapeCount { get; }
        public Bounds bounds { get; }
        public ColliderErrorState2D errorState { get; }
        public PhysicsMaterial2D sharedMaterial { get; set; }
        public float friction { get; }
        public float bounciness { get; }

        [NativeMethod("CreateMesh_Binding")]
        public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation);
        [NativeMethod("GetShapeHash_Binding")]
        public uint GetShapeHash();
        public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup);
        public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [DefaultValue("1")] int shapeCount = 1);
        public bool IsTouching([NotNull("ArgumentNullException")][Writable] Collider2D collider);
        public bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter);
        public bool IsTouching(ContactFilter2D contactFilter);
        [ExcludeFromDocs]
        public bool IsTouchingLayers();
        public bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);
        public bool OverlapPoint(Vector2 point);
        public ColliderDistance2D Distance([Writable] Collider2D collider);
        public int OverlapCollider(ContactFilter2D contactFilter, Collider2D[] results);
        public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results);
        public int GetContacts(ContactPoint2D[] contacts);
        public int GetContacts(List<ContactPoint2D> contacts);
        public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts);
        public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
        public int GetContacts(Collider2D[] colliders);
        public int GetContacts(List<Collider2D> colliders);
        public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders);
        public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, RaycastHit2D[] results, float distance);
        public int Cast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance);
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("true")] bool ignoreSiblingColliders);
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F, [DefaultValue("true")] bool ignoreSiblingColliders = True);
        [ExcludeFromDocs]
        public int Raycast(Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance);
        [ExcludeFromDocs]
        public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
        [ExcludeFromDocs]
        public int Raycast(Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        public int Raycast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("Physics2D.AllLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public int Raycast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        public Vector2 ClosestPoint(Vector2 position);
    }
}
