#region UnityEngine.NVIDIAModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.NVIDIAModule.dll
#endregion

using System;

namespace UnityEngine.NVIDIA
{
    [Flags]
    public enum DLSSFeatureFlags
    {

        None = 0,
        IsHDR = 1,
        MVLowRes = 2,
        MVJittered = 4,
        DepthInverted = 8,
        DoSharpening = 16
    }
}
