#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Experimental.GlobalIllumination
{
    public struct LinearColor
    {

        public float red { get; set; }
        public float green { get; set; }
        public float blue { get; set; }
        public float intensity { get; set; }

        public static LinearColor Convert(Color color, float intensity);
        public static LinearColor Black();
    }
}
