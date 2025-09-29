#region UnityEngine.StreamingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.StreamingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Streaming/StreamingController.h")]
    [RequireComponent(typeof(Camera))]
    public class StreamingController : Behaviour
    {

        public StreamingController();

        public float streamingMipmapBias { get; set; }

        public void SetPreloading(float timeoutSeconds = 0, bool activateCameraOnTimeout = False, Camera disableCameraCuttingFrom = null);
        public void CancelPreloading();
        public bool IsPreloading();
    }
}
