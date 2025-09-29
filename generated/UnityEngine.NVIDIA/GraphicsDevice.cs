#region UnityEngine.NVIDIAModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.NVIDIAModule.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine.NVIDIA
{
    public class GraphicsDevice
    {

        ~GraphicsDevice();

        public static GraphicsDevice device { get; }
        public static uint version { get; }

        public static GraphicsDevice CreateGraphicsDevice();
        public static GraphicsDevice CreateGraphicsDevice(string projectID);
        public static GraphicsDevice CreateGraphicsDevice(string projectID, string appDir);
        public bool IsFeatureAvailable(GraphicsDeviceFeature featureID);
        public DLSSContext CreateFeature(CommandBuffer cmd, in DLSSCommandInitializationData initSettings);
        public void DestroyFeature(CommandBuffer cmd, DLSSContext dlssContext);
        public void ExecuteDLSS(CommandBuffer cmd, DLSSContext dlssContext, in DLSSTextureTable textures);
        public bool GetOptimalSettings(uint targetWidth, uint targetHeight, DLSSQuality quality, out OptimalDLSSSettingsData optimalSettings);
        public GraphicsDeviceDebugView CreateDebugView();
        public void UpdateDebugView(GraphicsDeviceDebugView debugView);
        public void DeleteDebugView(GraphicsDeviceDebugView debugView);
    }
}
