#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
    [NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
    public sealed class NavMeshAgent : Behaviour
    {
        public NavMeshAgent();

        public Vector3 destination { get; set; }
        public float stoppingDistance { get; set; }
        public Vector3 velocity { get; set; }
        [NativeProperty("Position")]
        public Vector3 nextPosition { get; set; }
        public Vector3 steeringTarget { get; }
        public Vector3 desiredVelocity { get; }
        public float remainingDistance { get; }
        public float baseOffset { get; set; }
        public bool isOnOffMeshLink { get; }
        public OffMeshLinkData currentOffMeshLinkData { get; }
        public OffMeshLinkData nextOffMeshLinkData { get; }
        public bool autoTraverseOffMeshLink { get; set; }
        public bool autoBraking { get; set; }
        public bool autoRepath { get; set; }
        public bool hasPath { get; }
        public bool pathPending { get; }
        public bool isPathStale { get; }
        public NavMeshPathStatus pathStatus { get; }
        [NativeProperty("EndPositionOfCurrentPath")]
        public Vector3 pathEndPosition { get; }
        public bool isStopped { get; set; }
        public NavMeshPath path { get; set; }
        public Object navMeshOwner { get; }
        public int agentTypeID { get; set; }
        [Obsolete("Use areaMask instead.")]
        public int walkableMask { get; set; }
        public int areaMask { get; set; }
        public float speed { get; set; }
        public float angularSpeed { get; set; }
        public float acceleration { get; set; }
        public bool updatePosition { get; set; }
        public bool updateRotation { get; set; }
        public bool updateUpAxis { get; set; }
        public float radius { get; set; }
        public float height { get; set; }
        public ObstacleAvoidanceType obstacleAvoidanceType { get; set; }
        public int avoidancePriority { get; set; }
        public bool isOnNavMesh { get; }

        public bool SetDestination(Vector3 target);
        public void ActivateCurrentOffMeshLink(bool activated);
        public void CompleteOffMeshLink();
        public bool Warp(Vector3 newPosition);
        public void Move(Vector3 offset);
        [Obsolete("Set isStopped to true instead.")]
        public void Stop();
        [Obsolete("Set isStopped to true instead.")]
        public void Stop(bool stopUpdates);
        [Obsolete("Set isStopped to false instead.")]
        public void Resume();
        public void ResetPath();
        public bool SetPath([NotNull("ArgumentNullException")] NavMeshPath path);
        [NativeName("DistanceToEdge")]
        public bool FindClosestEdge(out NavMeshHit hit);
        public bool Raycast(Vector3 targetPosition, out NavMeshHit hit);
        public bool CalculatePath(Vector3 targetPosition, NavMeshPath path);
        public bool SamplePathPosition(int areaMask, float maxDistance, out NavMeshHit hit);
        [NativeMethod("SetAreaCost")]
        [Obsolete("Use SetAreaCost instead.")]
        public void SetLayerCost(int layer, float cost);
        [NativeMethod("GetAreaCost")]
        [Obsolete("Use GetAreaCost instead.")]
        public float GetLayerCost(int layer);
        public void SetAreaCost(int areaIndex, float areaCost);
        public float GetAreaCost(int areaIndex);
    }
}
