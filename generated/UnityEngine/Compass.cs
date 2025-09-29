#region UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll
#endregion

namespace UnityEngine
{
    public class Compass
    {

        public Compass();

        public float magneticHeading { get; }
        public float trueHeading { get; }
        public float headingAccuracy { get; }
        public Vector3 rawVector { get; }
        public double timestamp { get; }
        public bool enabled { get; set; }
    }
}
