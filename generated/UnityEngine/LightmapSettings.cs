#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LightmapSettings.h")]
    [StaticAccessor("GetLightmapSettings()")]
    public sealed class LightmapSettings : Object
    {

        public static LightmapData[] lightmaps { get; set; }
        public static LightmapsMode lightmapsMode { get; set; }
        public static LightProbes lightProbes { get; set; }
        [Obsolete("Use lightmapsMode instead.", False)]
        public static LightmapsModeLegacy lightmapsModeLegacy { get; set; }
        [Obsolete("Use QualitySettings.desiredColorSpace instead.", False)]
        public static ColorSpace bakedColorSpace { get; set; }
    }
}
