#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/GetInput.h")]
    public class Gyroscope
    {

        public Vector3 rotationRate { get; }
        public Vector3 rotationRateUnbiased { get; }
        public Vector3 gravity { get; }
        public Vector3 userAcceleration { get; }
        public Quaternion attitude { get; }
        public bool enabled { get; set; }
        public float updateInterval { get; set; }
    }
}
