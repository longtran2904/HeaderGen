#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/InputBindings.h")]
    [NativeHeader("Runtime/Input/LocationService.h")]
    public class LocationService
    {
        public LocationService();

        public bool isEnabledByUser { get; }
        public LocationServiceStatus status { get; }
        public LocationInfo lastData { get; }

        public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters);
        public void Start(float desiredAccuracyInMeters);
        public void Start();
        public void Stop();
    }
}
