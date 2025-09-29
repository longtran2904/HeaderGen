#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/Flare.h")]
    public sealed class LensFlare : Behaviour
    {
        public LensFlare();

        public float brightness { get; set; }
        public float fadeSpeed { get; set; }
        public Color color { get; set; }
        public Flare flare { get; set; }
    }
}
