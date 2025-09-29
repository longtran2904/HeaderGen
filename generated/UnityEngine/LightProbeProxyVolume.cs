#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
    public sealed class LightProbeProxyVolume : Behaviour
    {
        public LightProbeProxyVolume();

        public static bool isFeatureSupported { get; }
        [NativeName("GlobalAABB")]
        public Bounds boundsGlobal { get; }
        [NativeName("BoundingBoxSizeCustom")]
        public Vector3 sizeCustom { get; set; }
        [NativeName("BoundingBoxOriginCustom")]
        public Vector3 originCustom { get; set; }
        public float probeDensity { get; set; }
        public int gridResolutionX { get; set; }
        public int gridResolutionY { get; set; }
        public int gridResolutionZ { get; set; }
        public BoundingBoxMode boundingBoxMode { get; set; }
        public ResolutionMode resolutionMode { get; set; }
        public ProbePositionMode probePositionMode { get; set; }
        public RefreshMode refreshMode { get; set; }
        public QualityMode qualityMode { get; set; }
        public DataFormat dataFormat { get; set; }

        public void Update();

        public enum ResolutionMode
        {
            Automatic = 0,
            Custom = 1
        }
        public enum BoundingBoxMode
        {
            AutomaticLocal = 0,
            AutomaticWorld = 1,
            Custom = 2
        }
        public enum ProbePositionMode
        {
            CellCorner = 0,
            CellCenter = 1
        }
        public enum RefreshMode
        {
            Automatic = 0,
            EveryFrame = 1,
            ViaScripting = 2
        }
        public enum QualityMode
        {
            Low = 0,
            Normal = 1
        }
        public enum DataFormat
        {
            HalfFloat = 0,
            Float = 1
        }
    }
}
