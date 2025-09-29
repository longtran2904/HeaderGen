#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/PhysicsManager.h")]
    [StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
    public class Physics
    {

        public const int IgnoreRaycastLayer = 4;
        public const int DefaultRaycastLayers = -5;
        public const int AllLayers = -1;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Physics.IgnoreRaycastLayer instead. (UnityUpgradable) -> IgnoreRaycastLayer", True)]
        public const int kIgnoreRaycastLayer = 4;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Physics.DefaultRaycastLayers instead. (UnityUpgradable) -> DefaultRaycastLayers", True)]
        public const int kDefaultRaycastLayers = -5;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use Physics.AllLayers instead. (UnityUpgradable) -> AllLayers", True)]
        public const int kAllLayers = -1;

        public Physics();

        public static Vector3 gravity { get; set; }
        public static float defaultContactOffset { get; set; }
        public static float sleepThreshold { get; set; }
        public static bool queriesHitTriggers { get; set; }
        public static bool queriesHitBackfaces { get; set; }
        public static float bounceThreshold { get; set; }
        public static float defaultMaxDepenetrationVelocity { get; set; }
        public static int defaultSolverIterations { get; set; }
        public static int defaultSolverVelocityIterations { get; set; }
        public static float defaultMaxAngularSpeed { get; set; }
        public static bool improvedPatchFriction { get; set; }
        [NativeProperty("DefaultPhysicsSceneHandle", True, TargetType.Function, True)]
        public static PhysicsScene defaultPhysicsScene { get; }
        public static bool autoSimulation { get; set; }
        public static bool autoSyncTransforms { get; set; }
        public static bool reuseCollisionCallbacks { get; set; }
        [StaticAccessor("GetPhysicsManager()")]
        public static float interCollisionDistance { get; set; }
        [StaticAccessor("GetPhysicsManager()")]
        public static float interCollisionStiffness { get; set; }
        [StaticAccessor("GetPhysicsManager()")]
        public static bool interCollisionSettingsToggle { get; set; }
        public static Vector3 clothGravity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Physics.defaultContactOffset or Collider.contactOffset instead.", True)]
        public static float minPenetrationForPenalty { get; set; }
        [Obsolete("Please use bounceThreshold instead. (UnityUpgradable) -> bounceThreshold")]
        public static float bounceTreshold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
        public static float sleepVelocity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
        public static float sleepAngularVelocity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use Rigidbody.maxAngularVelocity instead.", True)]
        public static float maxAngularVelocity { get; set; }
        [Obsolete("Please use Physics.defaultSolverIterations instead. (UnityUpgradable) -> defaultSolverIterations")]
        public static int solverIterationCount { get; set; }
        [Obsolete("Please use Physics.defaultSolverVelocityIterations instead. (UnityUpgradable) -> defaultSolverVelocityIterations")]
        public static int solverVelocityIterationCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("penetrationPenaltyForce has no effect.", True)]
        public static float penetrationPenaltyForce { get; set; }

        public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent;
        public static event Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD;

        public static void IgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2, [DefaultValue("true")] bool ignore);
        [ExcludeFromDocs]
        public static void IgnoreCollision(Collider collider1, Collider collider2);
        [NativeName("IgnoreCollision")]
        public static void IgnoreLayerCollision(int layer1, int layer2, [DefaultValue("true")] bool ignore);
        [ExcludeFromDocs]
        public static void IgnoreLayerCollision(int layer1, int layer2);
        public static bool GetIgnoreLayerCollision(int layer1, int layer2);
        public static bool GetIgnoreCollision([NotNull("NullExceptionObject")] Collider collider1, [NotNull("NullExceptionObject")] Collider collider2);
        public static bool Raycast(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public static bool Raycast(Vector3 origin, Vector3 direction);
        public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo);
        public static bool Raycast(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray, float maxDistance);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray);
        public static bool Raycast(Ray ray, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public static bool Raycast(Ray ray, out RaycastHit hitInfo);
        public static bool Linecast(Vector3 start, Vector3 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool Linecast(Vector3 start, Vector3 end, int layerMask);
        [ExcludeFromDocs]
        public static bool Linecast(Vector3 start, Vector3 end);
        public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask);
        [ExcludeFromDocs]
        public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo);
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction);
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo);
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo);
        public static bool SphereCast(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius, float maxDistance);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius);
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance);
        [ExcludeFromDocs]
        public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo);
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction);
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation);
        [ExcludeFromDocs]
        public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo);
        public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction);
        public static RaycastHit[] RaycastAll(Ray ray, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] RaycastAll(Ray ray, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] RaycastAll(Ray ray);
        public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Ray ray, RaycastHit[] results);
        public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results);
        public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction);
        public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Vector3 origin, float radius, Vector3 direction);
        public static RaycastHit[] SphereCastAll(Ray ray, float radius, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Ray ray, float radius, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] SphereCastAll(Ray ray, float radius);
        public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask);
        [ExcludeFromDocs]
        public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius);
        public static Collider[] OverlapSphere(Vector3 position, float radius, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask);
        [ExcludeFromDocs]
        public static Collider[] OverlapSphere(Vector3 position, float radius);
        public static void Simulate(float step);
        public static void SyncTransforms();
        public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance);
        public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation);
        public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results);
        public static bool CheckSphere(Vector3 position, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool CheckSphere(Vector3 position, float radius, int layerMask);
        [ExcludeFromDocs]
        public static bool CheckSphere(Vector3 position, float radius);
        public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results, float maxDistance);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] results);
        public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results);
        public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results, float maxDistance);
        [ExcludeFromDocs]
        public static int SphereCastNonAlloc(Ray ray, float radius, RaycastHit[] results);
        public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask);
        [ExcludeFromDocs]
        public static bool CheckCapsule(Vector3 start, Vector3 end, float radius);
        public static bool CheckBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("DefaultRaycastLayers")] int layermask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask);
        [ExcludeFromDocs]
        public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation);
        [ExcludeFromDocs]
        public static bool CheckBox(Vector3 center, Vector3 halfExtents);
        public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask);
        [ExcludeFromDocs]
        public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation);
        [ExcludeFromDocs]
        public static Collider[] OverlapBox(Vector3 center, Vector3 halfExtents);
        public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int mask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results);
        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results);
        public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance);
        [ExcludeFromDocs]
        public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation);
        [ExcludeFromDocs]
        public static RaycastHit[] BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction);
        public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction);
        [ExcludeFromDocs]
        public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results);
        public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions);
        [StaticAccessor("GetPhysicsManager()")]
        [ThreadSafe]
        public static void BakeMesh(int meshID, bool convex);
    }
}
