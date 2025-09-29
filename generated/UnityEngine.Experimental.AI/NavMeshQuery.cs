#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.AI;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.AI
{
    [NativeContainer]
    [NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
    [NativeHeader("Runtime/Math/Matrix4x4.h")]
    [NativeHeader("Modules/AI/NavMeshExperimental.bindings.h")]
    [StaticAccessor("NavMeshQueryBindings", StaticAccessorType.DoubleColon)]
    public struct NavMeshQuery : IDisposable
    {
        public NavMeshQuery(NavMeshWorld world, Allocator allocator, int pathNodePoolSize = 0);

        public void Dispose();
        public PathQueryStatus BeginFindPath(NavMeshLocation start, NavMeshLocation end, int areaMask = -1, NativeArray<float> costs = null);
        public PathQueryStatus UpdateFindPath(int iterations, out int iterationsPerformed);
        public PathQueryStatus EndFindPath(out int pathSize);
        public int GetPathResult(NativeSlice<PolygonId> path);
        public bool IsValid(PolygonId polygon);
        public bool IsValid(NavMeshLocation location);
        public int GetAgentTypeIdForPolygon(PolygonId polygon);
        public NavMeshLocation CreateLocation(Vector3 position, PolygonId polygon);
        public NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1);
        public void MoveLocations(NativeSlice<NavMeshLocation> locations, NativeSlice<Vector3> targets, NativeSlice<int> areaMasks);
        public void MoveLocationsInSameAreas(NativeSlice<NavMeshLocation> locations, NativeSlice<Vector3> targets, int areaMask = -1);
        public NavMeshLocation MoveLocation(NavMeshLocation location, Vector3 target, int areaMask = -1);
        public bool GetPortalPoints(PolygonId polygon, PolygonId neighbourPolygon, out Vector3 left, out Vector3 right);
        public Matrix4x4 PolygonLocalToWorldMatrix(PolygonId polygon);
        public Matrix4x4 PolygonWorldToLocalMatrix(PolygonId polygon);
        public NavMeshPolyTypes GetPolygonType(PolygonId polygon);
        public PathQueryStatus Raycast(out NavMeshHit hit, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1, NativeArray<float> costs = null);
        public PathQueryStatus Raycast(out NavMeshHit hit, NativeSlice<PolygonId> path, out int pathCount, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1, NativeArray<float> costs = null);
        public PathQueryStatus GetEdgesAndNeighbors(PolygonId node, NativeSlice<Vector3> edgeVertices, NativeSlice<PolygonId> neighbors, NativeSlice<byte> edgeIndices, out int verticesCount, out int neighborsCount);
    }
}
