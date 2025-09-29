#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Apple
{
    [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS || PLATFORM_OSX")]
    [NativeHeader("Runtime/Export/Apple/FrameCaptureMetalScriptBindings.h")]
    public class FrameCapture
    {

        public static bool IsDestinationSupported(FrameCaptureDestination dest);
        public static void BeginCaptureToXcode();
        public static void BeginCaptureToFile(string path);
        public static void EndCapture();
        public static void CaptureNextFrameToXcode();
        public static void CaptureNextFrameToFile(string path);
    }
}
