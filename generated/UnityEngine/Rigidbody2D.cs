#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class Rigidbody2D : Component
    {
        public Rigidbody2D();

        public Vector2 position { get; set; }
        public float rotation { get; set; }
        public Vector2 velocity { get; set; }
        public float angularVelocity { get; set; }
        public bool useAutoMass { get; set; }
        public float mass { get; set; }
        [NativeMethod("Material")]
        public PhysicsMaterial2D sharedMaterial { get; set; }
        public Vector2 centerOfMass { get; set; }
        public Vector2 worldCenterOfMass { get; }
        public float inertia { get; set; }
        public float drag { get; set; }
        public float angularDrag { get; set; }
        public float gravityScale { get; set; }
        public RigidbodyType2D bodyType { get; set; }
        public bool useFullKinematicContacts { get; set; }
        public bool isKinematic { get; set; }
        [NativeMethod("FreezeRotation")]
        [Obsolete("'fixedAngle' is no longer supported. Use constraints instead.", False)]
        public bool fixedAngle { get; set; }
        public bool freezeRotation { get; set; }
        public RigidbodyConstraints2D constraints { get; set; }
        public bool simulated { get; set; }
        public RigidbodyInterpolation2D interpolation { get; set; }
        public RigidbodySleepMode2D sleepMode { get; set; }
        public CollisionDetectionMode2D collisionDetectionMode { get; set; }
        public int attachedColliderCount { get; }

        public void SetRotation(float angle);
        public void SetRotation(Quaternion rotation);
        public void MovePosition(Vector2 position);
        public void MoveRotation(float angle);
        public void MoveRotation(Quaternion rotation);
        public bool IsSleeping();
        public bool IsAwake();
        public void Sleep();
        [NativeMethod("Wake")]
        public void WakeUp();
        public bool IsTouching([NotNull("ArgumentNullException")][Writable] Collider2D collider);
        public bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter);
        public bool IsTouching(ContactFilter2D contactFilter);
        [ExcludeFromDocs]
        public bool IsTouchingLayers();
        public bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);
        public bool OverlapPoint(Vector2 point);
        public ColliderDistance2D Distance([Writable] Collider2D collider);
        public Vector2 ClosestPoint(Vector2 position);
        [ExcludeFromDocs]
        public void AddForce(Vector2 force);
        public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
        [ExcludeFromDocs]
        public void AddRelativeForce(Vector2 relativeForce);
        public void AddRelativeForce(Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
        [ExcludeFromDocs]
        public void AddForceAtPosition(Vector2 force, Vector2 position);
        public void AddForceAtPosition(Vector2 force, Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
        [ExcludeFromDocs]
        public void AddTorque(float torque);
        public void AddTorque(float torque, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
        public Vector2 GetPoint(Vector2 point);
        public Vector2 GetRelativePoint(Vector2 relativePoint);
        public Vector2 GetVector(Vector2 vector);
        public Vector2 GetRelativeVector(Vector2 relativeVector);
        public Vector2 GetPointVelocity(Vector2 point);
        public Vector2 GetRelativePointVelocity(Vector2 relativePoint);
        public int OverlapCollider(ContactFilter2D contactFilter, out Collider2D[] results);
        public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results);
        public int GetContacts(ContactPoint2D[] contacts);
        public int GetContacts(List<ContactPoint2D> contacts);
        public int GetContacts(ContactFilter2D contactFilter, ContactPoint2D[] contacts);
        public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
        public int GetContacts(Collider2D[] colliders);
        public int GetContacts(List<Collider2D> colliders);
        public int GetContacts(ContactFilter2D contactFilter, Collider2D[] colliders);
        public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders);
        public int GetAttachedColliders(out Collider2D[] results);
        public int GetAttachedColliders(List<Collider2D> results);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, RaycastHit2D[] results);
        public int Cast(Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public int Cast(Vector2 direction, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        [ExcludeFromDocs]
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance);
        public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup);
    }
}
