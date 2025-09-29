#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/PhysicsEditor/PhysicsVisualizationSettings.h")]
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Modules/Physics/Collider.h")]
    [NativeHeader("PhysicsScriptingClasses.h")]
    [StaticAccessor("GetPhysicsVisualizationSettings()", StaticAccessorType.Dot)]
    public static class PhysicsVisualizationSettings
    {
        public static bool devOptions { get; set; }
        public static int dirtyCount { get; }
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated.", True)]
        public static FilterWorkflow filterWorkflow { get; set; }
        public static bool showCollisionGeometry { get; set; }
        public static bool enableMouseSelect { get; set; }
        public static bool useSceneCam { get; set; }
        public static float viewDistance { get; set; }
        public static int terrainTilesMax { get; set; }
        public static bool forceOverdraw { get; set; }
        public static Color staticColor { get; set; }
        public static Color rigidbodyColor { get; set; }
        public static Color kinematicColor { get; set; }
        public static Color articulationBodyColor { get; set; }
        public static Color triggerColor { get; set; }
        public static Color sleepingBodyColor { get; set; }
        public static float baseAlpha { get; set; }
        public static float colorVariance { get; set; }
        public static float dotAlpha { get; set; }
        public static bool forceDot { get; set; }

        public static void Reset();
        public static bool GetShowStaticColliders();
        public static void SetShowStaticColliders(bool show);
        public static bool GetShowTriggers();
        public static void SetShowTriggers(bool show);
        public static bool GetShowRigidbodies();
        public static void SetShowRigidbodies(bool show);
        public static bool GetShowKinematicBodies();
        public static void SetShowKinematicBodies(bool show);
        public static bool GetShowArticulationBodies();
        public static void SetShowArticulationBodies(bool show);
        public static bool GetShowSleepingBodies();
        public static void SetShowSleepingBodies(bool show);
        public static bool GetShowCollisionLayer(int layer);
        public static void SetShowCollisionLayer(int layer, bool show);
        public static int GetShowCollisionLayerMask();
        public static void SetShowCollisionLayerMask(int mask);
        public static bool GetShowBoxColliders();
        public static void SetShowBoxColliders(bool show);
        public static bool GetShowSphereColliders();
        public static void SetShowSphereColliders(bool show);
        public static bool GetShowCapsuleColliders();
        public static void SetShowCapsuleColliders(bool show);
        public static bool GetShowMeshColliders(MeshColliderType colliderType);
        public static void SetShowMeshColliders(MeshColliderType colliderType, bool show);
        public static bool GetShowTerrainColliders();
        public static void SetShowTerrainColliders(bool show);
        public static int GetShowPhysicsSceneMask();
        public static void SetShowPhysicsSceneMask(int mask);
        public static void InitDebugDraw();
        public static void DeinitDebugDraw();
        public static void ClearMouseHighlight();
        public static bool HasMouseHighlight();
        public static void UpdateMouseHighlight(Vector2 screenPos);
        public static GameObject PickClosestGameObject([NotNull("ArgumentNullException")] Camera cam, int layers, Vector2 position, GameObject[] ignore, GameObject[] filter, out int materialIndex);
        public static void SetShowForAllFilters(bool selected);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowStaticColliders(FilterWorkflow filterWorkFlow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowStaticColliders(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowTriggers(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowTriggers(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowRigidbodies(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowRigidbodies(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowKinematicBodies(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowKinematicBodies(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowSleepingBodies(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowSleepingBodies(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowCollisionLayer(FilterWorkflow filterWorkflow, int layer);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowCollisionLayer(FilterWorkflow filterWorkflow, int layer, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static int GetShowCollisionLayerMask(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowCollisionLayerMask(FilterWorkflow filterWorkflow, int mask);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowBoxColliders(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowBoxColliders(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowSphereColliders(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowSphereColliders(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowCapsuleColliders(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowCapsuleColliders(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowMeshColliders(FilterWorkflow filterWorkflow, MeshColliderType colliderType);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowMeshColliders(FilterWorkflow filterWorkflow, MeshColliderType colliderType, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static bool GetShowTerrainColliders(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowTerrainColliders(FilterWorkflow filterWorkflow, bool show);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static int GetShowPhysicsSceneMask(FilterWorkflow filterWorkflow);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowPhysicsSceneMask(FilterWorkflow filterWorkflow, int mask);
        [Obsolete("Enum PhysicsVisualizationSettings.FilterWorkflow has been deprecated. Use APIs without this argument instead", True)]
        public static void SetShowForAllFilters(FilterWorkflow filterWorkflow, bool selected);

        public enum FilterWorkflow
        {
            HideSelectedItems = 0,
            ShowSelectedItems = 1
        }
        public enum MeshColliderType
        {
            Convex = 0,
            NonConvex = 1
        }
    }
}
