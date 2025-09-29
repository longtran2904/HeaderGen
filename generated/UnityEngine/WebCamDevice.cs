#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct WebCamDevice
    {
        public string name { get; }
        public bool isFrontFacing { get; }
        public WebCamKind kind { get; }
        public string depthCameraName { get; }
        public bool isAutoFocusPointSupported { get; }
        public Resolution[] availableResolutions { get; }
    }
}
