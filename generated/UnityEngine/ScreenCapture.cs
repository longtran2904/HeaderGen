#region UnityEngine.ScreenCaptureModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ScreenCaptureModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/ScreenCapture/Public/CaptureScreenshot.h")]
    public static class ScreenCapture
    {

        public static void CaptureScreenshot(string filename);
        public static void CaptureScreenshot(string filename, int superSize);
        public static void CaptureScreenshot(string filename, StereoScreenCaptureMode stereoCaptureMode);
        public static Texture2D CaptureScreenshotAsTexture();
        public static Texture2D CaptureScreenshotAsTexture(int superSize);
        public static Texture2D CaptureScreenshotAsTexture(StereoScreenCaptureMode stereoCaptureMode);
        public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture);
        public enum StereoScreenCaptureMode
        {

            LeftEye = 1,
            RightEye = 2,
            BothEyes = 3
        }
    }
}
