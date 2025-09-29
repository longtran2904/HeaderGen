#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/Rigidbody.h")]
    [RequireComponent(typeof(Transform))]
    public class Rigidbody : Component
    {
        public Rigidbody();

        public Vector3 velocity { get; set; }
        public Vector3 angularVelocity { get; set; }
        public float drag { get; set; }
        public float angularDrag { get; set; }
        public float mass { get; set; }
        public bool useGravity { get; set; }
        public float maxDepenetrationVelocity { get; set; }
        public bool isKinematic { get; set; }
        public bool freezeRotation { get; set; }
        public RigidbodyConstraints constraints { get; set; }
        public CollisionDetectionMode collisionDetectionMode { get; set; }
        public Vector3 centerOfMass { get; set; }
        public Vector3 worldCenterOfMass { get; }
        public Quaternion inertiaTensorRotation { get; set; }
        public Vector3 inertiaTensor { get; set; }
        public bool detectCollisions { get; set; }
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public RigidbodyInterpolation interpolation { get; set; }
        public int solverIterations { get; set; }
        public float sleepThreshold { get; set; }
        public float maxAngularVelocity { get; set; }
        public int solverVelocityIterations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
        public float sleepVelocity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", True)]
        public float sleepAngularVelocity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Cone friction is no longer supported.", True)]
        public bool useConeFriction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
        public int solverIterationCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
        public int solverVelocityIterationCount { get; set; }

        public void SetDensity(float density);
        public void MovePosition(Vector3 position);
        public void MoveRotation(Quaternion rot);
        public void Sleep();
        public bool IsSleeping();
        public void WakeUp();
        public void ResetCenterOfMass();
        public void ResetInertiaTensor();
        public Vector3 GetRelativePointVelocity(Vector3 relativePoint);
        public Vector3 GetPointVelocity(Vector3 worldPoint);
        public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddForce(Vector3 force);
        public void AddForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddForce(float x, float y, float z);
        public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeForce(Vector3 force);
        public void AddRelativeForce(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeForce(float x, float y, float z);
        public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddTorque(Vector3 torque);
        public void AddTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddTorque(float x, float y, float z);
        public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeTorque(Vector3 torque);
        public void AddRelativeTorque(float x, float y, float z, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeTorque(float x, float y, float z);
        public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddForceAtPosition(Vector3 force, Vector3 position);
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0f")] float upwardsModifier, [DefaultValue("ForceMode.Force)")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier);
        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius);
        public Vector3 ClosestPointOnBounds(Vector3 position);
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo);
        public RaycastHit[] SweepTestAll(Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public RaycastHit[] SweepTestAll(Vector3 direction);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
        public void SetMaxAngularVelocity(float a);
    }
}
