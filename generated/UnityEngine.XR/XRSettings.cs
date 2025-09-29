#region UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VRModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    [NativeHeader("Modules/VR/VRModule.h")]
    [NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
    [NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
    [NativeHeader("Runtime/Interfaces/IVRDevice.h")]
    public static class XRSettings
    {
        public static bool enabled { get; set; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static GameViewRenderMode gameViewRenderMode { get; set; }
        [NativeName("Active")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool isDeviceActive { get; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool showDeviceView { get; set; }
        [NativeName("RenderScale")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static float eyeTextureResolutionScale { get; set; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static int eyeTextureWidth { get; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static int eyeTextureHeight { get; }
        [NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
        [NativeName("IntermediateEyeTextureDesc")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static RenderTextureDescriptor eyeTextureDesc { get; }
        [NativeName("DeviceEyeTextureDimension")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static TextureDimension deviceEyeTextureDimension { get; }
        public static float renderViewportScale { get; set; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static float occlusionMaskScale { get; set; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static bool useOcclusionMesh { get; set; }
        [NativeName("DeviceName")]
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static string loadedDeviceName { get; }
        public static string[] supportedDevices { get; }
        [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
        public static StereoRenderingMode stereoRenderingMode { get; }

        public static void LoadDeviceByName(string deviceName);
        public static void LoadDeviceByName(string[] prioritizedDeviceNameList);

        public enum StereoRenderingMode
        {
            MultiPass = 0,
            SinglePass = 1,
            SinglePassInstanced = 2,
            SinglePassMultiview = 3
        }
    }
}
