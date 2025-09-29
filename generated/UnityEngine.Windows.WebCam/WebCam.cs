#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
    [MovedFrom("UnityEngine.XR.WSA.WebCam")]
    [NativeHeader("PlatformDependent/Win/Webcam/WebCam.h")]
    [StaticAccessor("WebCam::GetInstance()", StaticAccessorType.Dot)]
    public class WebCam
    {
        public WebCam();

        public static WebCamMode Mode { get; }
    }
}
