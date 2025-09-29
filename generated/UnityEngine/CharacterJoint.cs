#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("Unity::CharacterJoint")]
    [NativeHeader("Modules/Physics/CharacterJoint.h")]
    public class CharacterJoint : Joint
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("TargetRotation not in use for Unity 5 and assumed disabled.", True)]
        public Quaternion targetRotation;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("TargetAngularVelocity not in use for Unity 5 and assumed disabled.", True)]
        public Vector3 targetAngularVelocity;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("RotationDrive not in use for Unity 5 and assumed disabled.", True)]
        public JointDrive rotationDrive;

        public CharacterJoint();

        public Vector3 swingAxis { get; set; }
        public SoftJointLimitSpring twistLimitSpring { get; set; }
        public SoftJointLimitSpring swingLimitSpring { get; set; }
        public SoftJointLimit lowTwistLimit { get; set; }
        public SoftJointLimit highTwistLimit { get; set; }
        public SoftJointLimit swing1Limit { get; set; }
        public SoftJointLimit swing2Limit { get; set; }
        public bool enableProjection { get; set; }
        public float projectionDistance { get; set; }
        public float projectionAngle { get; set; }
    }
}
