#region UnityEngine.WindModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.WindModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Wind/Public/Wind.h")]
    public class WindZone : Component
    {

        public WindZone();

        public WindZoneMode mode { get; set; }
        public float radius { get; set; }
        public float windMain { get; set; }
        public float windTurbulence { get; set; }
        public float windPulseMagnitude { get; set; }
        public float windPulseFrequency { get; set; }
    }
}
