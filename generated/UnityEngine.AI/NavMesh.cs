#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Modules/AI/NavMeshManager.h")]
    [NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
    [StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
    public static class NavMesh
    {
        public static OnNavMeshPreUpdate onPreUpdate;
        public const int AllAreas = -1;

        [StaticAccessor("GetNavMeshManager()")]
        public static float avoidancePredictionTime { get; set; }
        [StaticAccessor("GetNavMeshManager()")]
        public static int pathfindingIterationsPerFrame { get; set; }

        public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask);
        public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path);
        public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask);
        public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask);
        [NativeName("SetAreaCost")]
        [Obsolete("Use SetAreaCost instead.")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static void SetLayerCost(int layer, float cost);
        [NativeName("GetAreaCost")]
        [Obsolete("Use GetAreaCost instead.")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static float GetLayerCost(int layer);
        [NativeName("GetAreaFromName")]
        [Obsolete("Use GetAreaFromName instead.")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static int GetNavMeshLayerFromName(string layerName);
        [NativeName("SetAreaCost")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static void SetAreaCost(int areaIndex, float cost);
        [NativeName("GetAreaCost")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static float GetAreaCost(int areaIndex);
        [NativeName("GetAreaFromName")]
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static int GetAreaFromName(string areaName);
        public static NavMeshTriangulation CalculateTriangulation();
        [Obsolete("use NavMesh.CalculateTriangulation() instead.")]
        public static void Triangulate(out Vector3[] vertices, out int[] indices);
        [Obsolete("AddOffMeshLinks has no effect and is deprecated.")]
        public static void AddOffMeshLinks();
        [Obsolete("RestoreNavMesh has no effect and is deprecated.")]
        public static void RestoreNavMesh();
        public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData);
        public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation);
        public static void RemoveNavMeshData(NavMeshDataInstance handle);
        public static NavMeshLinkInstance AddLink(NavMeshLinkData link);
        public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation);
        public static void RemoveLink(NavMeshLinkInstance handle);
        public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, NavMeshQueryFilter filter);
        public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, NavMeshQueryFilter filter);
        public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, NavMeshQueryFilter filter);
        public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, NavMeshQueryFilter filter, NavMeshPath path);
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static NavMeshBuildSettings CreateSettings();
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static void RemoveSettings(int agentTypeID);
        public static NavMeshBuildSettings GetSettingsByID(int agentTypeID);
        [StaticAccessor("GetNavMeshProjectSettings()")]
        public static int GetSettingsCount();
        public static NavMeshBuildSettings GetSettingsByIndex(int index);
        public static string GetSettingsNameFromID(int agentTypeID);
        [NativeName("CleanupAfterCarving")]
        [StaticAccessor("GetNavMeshManager()")]
        public static void RemoveAllNavMeshData();

        public delegate void OnNavMeshPreUpdate();
    }
}
