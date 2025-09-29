#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeClass("Unity::ArticulationBody")]
    [NativeHeader("Modules/Physics/ArticulationBody.h")]
    public class ArticulationBody : Behaviour
    {

        public ArticulationBody();

        public ArticulationJointType jointType { get; set; }
        public Vector3 anchorPosition { get; set; }
        public Vector3 parentAnchorPosition { get; set; }
        public Quaternion anchorRotation { get; set; }
        public Quaternion parentAnchorRotation { get; set; }
        public bool isRoot { get; }
        [Obsolete("computeParentAnchor has been renamed to matchAnchors (UnityUpgradable) -> matchAnchors")]
        public bool computeParentAnchor { get; set; }
        public bool matchAnchors { get; set; }
        public ArticulationDofLock linearLockX { get; set; }
        public ArticulationDofLock linearLockY { get; set; }
        public ArticulationDofLock linearLockZ { get; set; }
        public ArticulationDofLock swingYLock { get; set; }
        public ArticulationDofLock swingZLock { get; set; }
        public ArticulationDofLock twistLock { get; set; }
        public ArticulationDrive xDrive { get; set; }
        public ArticulationDrive yDrive { get; set; }
        public ArticulationDrive zDrive { get; set; }
        public bool immovable { get; set; }
        public bool useGravity { get; set; }
        public float linearDamping { get; set; }
        public float angularDamping { get; set; }
        public float jointFriction { get; set; }
        public Vector3 velocity { get; set; }
        public Vector3 angularVelocity { get; set; }
        public float mass { get; set; }
        public Vector3 centerOfMass { get; set; }
        public Vector3 worldCenterOfMass { get; }
        public Vector3 inertiaTensor { get; set; }
        public Quaternion inertiaTensorRotation { get; set; }
        public float sleepThreshold { get; set; }
        public int solverIterations { get; set; }
        public int solverVelocityIterations { get; set; }
        public float maxAngularVelocity { get; set; }
        public float maxLinearVelocity { get; set; }
        public float maxJointVelocity { get; set; }
        public float maxDepenetrationVelocity { get; set; }
        public ArticulationReducedSpace jointPosition { get; set; }
        public ArticulationReducedSpace jointVelocity { get; set; }
        public ArticulationReducedSpace jointAcceleration { get; set; }
        public ArticulationReducedSpace jointForce { get; set; }
        public int dofCount { get; }
        public int index { get; }
        public CollisionDetectionMode collisionDetectionMode { get; set; }

        public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddForce(Vector3 force);
        public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeForce(Vector3 force);
        public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddTorque(Vector3 torque);
        public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddRelativeTorque(Vector3 torque);
        public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode);
        [ExcludeFromDocs]
        public void AddForceAtPosition(Vector3 force, Vector3 position);
        public void ResetCenterOfMass();
        public void ResetInertiaTensor();
        public void Sleep();
        public bool IsSleeping();
        public void WakeUp();
        public void TeleportRoot(Vector3 position, Quaternion rotation);
        public Vector3 GetClosestPoint(Vector3 point);
        public Vector3 GetRelativePointVelocity(Vector3 relativePoint);
        public Vector3 GetPointVelocity(Vector3 worldPoint);
        public int GetDenseJacobian(ref ArticulationJacobian jacobian);
        public int GetJointPositions(List<float> positions);
        public void SetJointPositions(List<float> positions);
        public int GetJointVelocities(List<float> velocities);
        public void SetJointVelocities(List<float> velocities);
        public int GetJointAccelerations(List<float> accelerations);
        public void SetJointAccelerations(List<float> accelerations);
        public int GetJointForces(List<float> forces);
        public void SetJointForces(List<float> forces);
        public int GetDriveTargets(List<float> targets);
        public void SetDriveTargets(List<float> targets);
        public int GetDriveTargetVelocities(List<float> targetVelocities);
        public void SetDriveTargetVelocities(List<float> targetVelocities);
        public int GetDofStartIndices(List<int> dofStartIndices);
        public void SnapAnchorToClosestContact();
    }
}
