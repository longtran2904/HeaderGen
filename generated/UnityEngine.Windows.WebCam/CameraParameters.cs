#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
    [MovedFrom("UnityEngine.XR.WSA.WebCam")]
    [NativeHeader("PlatformDependent/Win/Webcam/CameraParameters.h")]
    [UsedByNativeCode]
    public struct CameraParameters
    {

        public CameraParameters(WebCamMode webCamMode);

        public float hologramOpacity { get; set; }
        public float frameRate { get; set; }
        public int cameraResolutionWidth { get; set; }
        public int cameraResolutionHeight { get; set; }
        public CapturePixelFormat pixelFormat { get; set; }
    }
}
