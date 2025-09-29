#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
    [UsedByNativeCode]
    public class HDROutputSettings
    {

        public static HDROutputSettings[] displays;

        public static HDROutputSettings main { get; }
        public bool active { get; }
        public bool available { get; }
        public bool automaticHDRTonemapping { get; set; }
        public ColorGamut displayColorGamut { get; }
        public RenderTextureFormat format { get; }
        public GraphicsFormat graphicsFormat { get; }
        public float paperWhiteNits { get; set; }
        public int maxFullFrameToneMapLuminance { get; }
        public int maxToneMapLuminance { get; }
        public int minToneMapLuminance { get; }
        public bool HDRModeChangeRequested { get; }

        public void RequestHDRModeChange(bool enabled);
        [Obsolete("SetPaperWhiteInNits is deprecated, please use paperWhiteNits instead.")]
        public static void SetPaperWhiteInNits(float paperWhite);
    }
}
