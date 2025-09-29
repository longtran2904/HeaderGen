#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class XRGraphics
    {

        public XRGraphics();

        public static float eyeTextureResolutionScale { get; set; }
        public static float renderViewportScale { get; }
        public static bool tryEnable { get; }
        public static bool enabled { get; }
        public static bool isDeviceActive { get; }
        public static string loadedDeviceName { get; }
        public static string[] supportedDevices { get; }
        public static StereoRenderingMode stereoRenderingMode { get; }
        public static RenderTextureDescriptor eyeTextureDesc { get; }
        public static int eyeTextureWidth { get; }
        public static int eyeTextureHeight { get; }
        public enum StereoRenderingMode
        {

            MultiPass = 0,
            SinglePass = 1,
            SinglePassInstanced = 2,
            SinglePassMultiView = 3
        }
    }
}
