#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Physics2DScriptingClasses.h")]
    [NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
    [NativeHeader("Physics2DScriptingClasses.h")]
    [StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
    public class Physics2D
    {
        public const int IgnoreRaycastLayer = 4;
        public const int DefaultRaycastLayers = -5;
        public const int AllLayers = -1;
        public const int MaxPolygonShapeVertices = 8;

        public Physics2D();

        public static PhysicsScene2D defaultPhysicsScene { get; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static int velocityIterations { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static int positionIterations { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static Vector2 gravity { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool queriesHitTriggers { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool queriesStartInColliders { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool callbacksOnDisable { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool reuseCollisionCallbacks { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool autoSyncTransforms { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static SimulationMode2D simulationMode { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static PhysicsJobOptions2D jobOptions { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float velocityThreshold { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float maxLinearCorrection { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float maxAngularCorrection { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float maxTranslationSpeed { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float maxRotationSpeed { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float defaultContactOffset { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float baumgarteScale { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float baumgarteTOIScale { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float timeToSleep { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float linearSleepTolerance { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float angularSleepTolerance { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool alwaysShowColliders { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool showColliderSleep { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool showColliderContacts { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static bool showColliderAABB { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static float contactArrowScale { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static Color colliderAwakeColor { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static Color colliderAsleepColor { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static Color colliderContactColor { get; set; }
        [StaticAccessor("GetPhysics2DSettings()")]
        public static Color colliderAABBColor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Physics2D.raycastsHitTriggers is deprecated. Use Physics2D.queriesHitTriggers instead. (UnityUpgradable) -> queriesHitTriggers", True)]
        public static bool raycastsHitTriggers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Physics2D.raycastsStartInColliders is deprecated. Use Physics2D.queriesStartInColliders instead. (UnityUpgradable) -> queriesStartInColliders", True)]
        public static bool raycastsStartInColliders { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Physics2D.deleteStopsCallbacks is deprecated.(UnityUpgradable) -> changeStopsCallbacks", True)]
        public static bool deleteStopsCallbacks { get; set; }
        [Obsolete("Physics2D.changeStopsCallbacks is deprecated and will always return false.", False)]
        public static bool changeStopsCallbacks { get; set; }
        [Obsolete("Physics2D.minPenetrationForPenalty is deprecated. Use Physics2D.defaultContactOffset instead. (UnityUpgradable) -> defaultContactOffset", False)]
        public static float minPenetrationForPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Physics2D.autoSimulation is deprecated. Use Physics2D.simulationMode instead.", False)]
        public static bool autoSimulation { get; set; }

        public static bool Simulate(float step);
        public static void SyncTransforms();
        [ExcludeFromDocs]
        public static void IgnoreCollision([Writable] Collider2D collider1, [Writable] Collider2D collider2);
        [NativeMethod("IgnoreCollision_Binding")]
        [StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
        public static void IgnoreCollision([NotNull("ArgumentNullException")][Writable] Collider2D collider1, [NotNull("ArgumentNullException")][Writable] Collider2D collider2, [DefaultValue("true")] bool ignore);
        [NativeMethod("GetIgnoreCollision_Binding")]
        [StaticAccessor("PhysicsScene2D", StaticAccessorType.DoubleColon)]
        public static bool GetIgnoreCollision([NotNull("ArgumentNullException")][Writable] Collider2D collider1, [NotNull("ArgumentNullException")][Writable] Collider2D collider2);
        [ExcludeFromDocs]
        public static void IgnoreLayerCollision(int layer1, int layer2);
        public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore);
        public static bool GetIgnoreLayerCollision(int layer1, int layer2);
        public static void SetLayerCollisionMask(int layer, int layerMask);
        public static int GetLayerCollisionMask(int layer);
        [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
        public static bool IsTouching([NotNull("ArgumentNullException")][Writable] Collider2D collider1, [NotNull("ArgumentNullException")][Writable] Collider2D collider2);
        public static bool IsTouching([Writable] Collider2D collider1, [Writable] Collider2D collider2, ContactFilter2D contactFilter);
        public static bool IsTouching([Writable] Collider2D collider, ContactFilter2D contactFilter);
        [ExcludeFromDocs]
        public static bool IsTouchingLayers([Writable] Collider2D collider);
        [StaticAccessor("PhysicsQuery2D", StaticAccessorType.DoubleColon)]
        public static bool IsTouchingLayers([NotNull("ArgumentNullException")][Writable] Collider2D collider, [DefaultValue("Physics2D.AllLayers")] int layerMask);
        public static ColliderDistance2D Distance([Writable] Collider2D colliderA, [Writable] Collider2D colliderB);
        public static Vector2 ClosestPoint(Vector2 position, Collider2D collider);
        public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody);
        [ExcludeFromDocs]
        public static RaycastHit2D Linecast(Vector2 start, Vector2 end);
        [ExcludeFromDocs]
        public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth);
        public static RaycastHit2D Linecast(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results);
        [ExcludeFromDocs]
        public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end);
        [ExcludeFromDocs]
        public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth);
        public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth);
        public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
        [ExcludeFromDocs]
        public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance);
        [ExcludeFromDocs]
        public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
        [ExcludeFromDocs]
        public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("Physics2D.AllLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        [ExcludeFromDocs]
        public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
        [ExcludeFromDocs]
        public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results);
        public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance);
        public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [DefaultValue("Mathf.Infinity")] float distance = ∞F);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth);
        public static RaycastHit2D[] CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask);
        [ExcludeFromDocs]
        public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth);
        public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static RaycastHit2D GetRayIntersection(Ray ray);
        [ExcludeFromDocs]
        public static RaycastHit2D GetRayIntersection(Ray ray, float distance);
        public static RaycastHit2D GetRayIntersection(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask);
        [ExcludeFromDocs]
        public static RaycastHit2D[] GetRayIntersectionAll(Ray ray);
        [ExcludeFromDocs]
        public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance);
        [RequiredByNativeCode]
        public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask);
        [ExcludeFromDocs]
        public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results);
        [ExcludeFromDocs]
        public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance);
        [RequiredByNativeCode]
        public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapPoint(Vector2 point);
        [ExcludeFromDocs]
        public static Collider2D OverlapPoint(Vector2 point, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth);
        public static Collider2D OverlapPoint(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, [Unmarshalled] Collider2D[] results);
        public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapPointAll(Vector2 point);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth);
        public static Collider2D[] OverlapPointAll(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results);
        [ExcludeFromDocs]
        public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth);
        public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static Collider2D OverlapCircle(Vector2 point, float radius);
        [ExcludeFromDocs]
        public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth);
        public static Collider2D OverlapCircle(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Collider2D[] results);
        public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCircleAll(Vector2 point, float radius);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth);
        public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results);
        [ExcludeFromDocs]
        public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth);
        public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle);
        [ExcludeFromDocs]
        public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
        public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Collider2D[] results);
        public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth);
        public static Collider2D[] OverlapBoxAll(Vector2 point, Vector2 size, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, int layerMask, float minDepth);
        public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB);
        [ExcludeFromDocs]
        public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
        public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Collider2D[] results);
        public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth);
        public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results);
        [ExcludeFromDocs]
        public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth);
        public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
        [ExcludeFromDocs]
        public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
        public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Collider2D[] results);
        public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask);
        [ExcludeFromDocs]
        public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth);
        public static Collider2D[] OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        [ExcludeFromDocs]
        public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results);
        [ExcludeFromDocs]
        public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask);
        [ExcludeFromDocs]
        public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, int layerMask, float minDepth);
        public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth);
        public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] results);
        public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results);
        public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
        public static int GetContacts(Collider2D collider, ContactPoint2D[] contacts);
        public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
        public static int GetContacts(Collider2D collider, Collider2D[] colliders);
        public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Collider2D[] colliders);
        public static int GetContacts(Rigidbody2D rigidbody, ContactPoint2D[] contacts);
        public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, ContactPoint2D[] contacts);
        public static int GetContacts(Rigidbody2D rigidbody, Collider2D[] colliders);
        public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Collider2D[] colliders);
        public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
        public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts);
        public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
        public static int GetContacts(Collider2D collider, List<Collider2D> colliders);
        public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders);
        public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts);
        public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts);
        public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders);
        public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders);
    }
}
