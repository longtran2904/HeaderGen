#region UnityEngine.VehiclesModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VehiclesModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Vehicles/WheelCollider.h")]
    [NativeHeader("PhysicsScriptingClasses.h")]
    public class WheelCollider : Collider
    {
        public WheelCollider();

        public Vector3 center { get; set; }
        public float radius { get; set; }
        public float suspensionDistance { get; set; }
        public JointSpring suspensionSpring { get; set; }
        public bool suspensionExpansionLimited { get; set; }
        public float forceAppPointDistance { get; set; }
        public float mass { get; set; }
        public float wheelDampingRate { get; set; }
        public WheelFrictionCurve forwardFriction { get; set; }
        public WheelFrictionCurve sidewaysFriction { get; set; }
        public float motorTorque { get; set; }
        public float brakeTorque { get; set; }
        public float steerAngle { get; set; }
        public bool isGrounded { get; }
        public float rpm { get; }
        public float sprungMass { get; set; }

        public void ResetSprungMasses();
        public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);
        public void GetWorldPose(out Vector3 pos, out Quaternion quat);
        public bool GetGroundHit(out WheelHit hit);
    }
}
