#region UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VRModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    public static class XRDevice
    {

        [Obsolete("This is obsolete, and should no longer be used. Instead, find the active XRDisplaySubsystem and check that the running property is true (for details, see XRDevice.isPresent documentation).", True)]
        public static bool isPresent { get; }
        [NativeName("DeviceRefreshRate")]
        [StaticAccessor("GetIVRDeviceSwapChain()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static float refreshRate { get; }
        public static float fovZoomFactor { get; set; }

        public static event Action<string> deviceLoaded;

        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static nint GetNativePtr();
        [Obsolete("This is obsolete, and should no longer be used.  Please use XRInputSubsystem.GetTrackingOriginMode.")]
        [StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static TrackingSpaceType GetTrackingSpaceType();
        [Obsolete("This is obsolete, and should no longer be used.  Please use XRInputSubsystem.TrySetTrackingOriginMode.")]
        [StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool SetTrackingSpaceType(TrackingSpaceType trackingSpaceType);
        [NativeName("DisableAutoVRCameraTracking")]
        [StaticAccessor("GetIVRDevice()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static void DisableAutoXRCameraTracking([NotNull("ArgumentNullException")] Camera camera, bool disabled);
        [NativeName("UpdateEyeTextureMSAASetting")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static void UpdateEyeTextureMSAASetting();
    }
}
