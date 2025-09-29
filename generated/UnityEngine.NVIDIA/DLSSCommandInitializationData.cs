#region UnityEngine.NVIDIAModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.NVIDIAModule.dll
#endregion

namespace UnityEngine.NVIDIA
{
    public struct DLSSCommandInitializationData
    {
        public uint inputRTWidth { get; set; }
        public uint inputRTHeight { get; set; }
        public uint outputRTWidth { get; set; }
        public uint outputRTHeight { get; set; }
        public DLSSQuality quality { get; set; }
        public DLSSFeatureFlags featureFlags { get; set; }

        public void SetFlag(DLSSFeatureFlags flag, bool value);
        public bool GetFlag(DLSSFeatureFlags flag);
    }
}
