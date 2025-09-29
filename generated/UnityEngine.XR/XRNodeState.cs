#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [UsedByNativeCode]
    public struct XRNodeState
    {

        public ulong uniqueID { get; set; }
        public XRNode nodeType { get; set; }
        public bool tracked { get; set; }
        public Vector3 position { set; }
        public Quaternion rotation { set; }
        public Vector3 velocity { set; }
        public Vector3 angularVelocity { set; }
        public Vector3 acceleration { set; }
        public Vector3 angularAcceleration { set; }

        public bool TryGetPosition(out Vector3 position);
        public bool TryGetRotation(out Quaternion rotation);
        public bool TryGetVelocity(out Vector3 velocity);
        public bool TryGetAngularVelocity(out Vector3 angularVelocity);
        public bool TryGetAcceleration(out Vector3 acceleration);
        public bool TryGetAngularAcceleration(out Vector3 angularAcceleration);
    }
}
