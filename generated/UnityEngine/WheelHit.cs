#region UnityEngine.VehiclesModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VehiclesModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Vehicles/WheelCollider.h")]
    public struct WheelHit
    {
        public Collider collider { get; set; }
        public Vector3 point { get; set; }
        public Vector3 normal { get; set; }
        public Vector3 forwardDir { get; set; }
        public Vector3 sidewaysDir { get; set; }
        public float force { get; set; }
        public float forwardSlip { get; set; }
        public float sidewaysSlip { get; set; }
    }
}
