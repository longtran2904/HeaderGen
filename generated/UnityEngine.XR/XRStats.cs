#region UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VRModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    public static class XRStats
    {

        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame);
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool TryGetDroppedFrameCount(out int droppedFrameCount);
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool TryGetFramePresentCount(out int framePresentCount);
    }
}
