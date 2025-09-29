#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine.Apple.ReplayKit
{
    [NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
    public static class ReplayKit
    {

        public static bool APIAvailable { get; }
        public static bool broadcastingAPIAvailable { get; }
        public static bool recordingAvailable { get; }
        public static bool isRecording { get; }
        public static bool isBroadcasting { get; }
        public static bool isBroadcastingPaused { get; }
        public static bool isPreviewControllerActive { get; }
        public static bool cameraEnabled { get; set; }
        public static bool microphoneEnabled { get; set; }
        public static string broadcastURL { get; }
        public static string lastError { get; }

        public static bool StartRecording([DefaultValue("false")] bool enableMicrophone, [DefaultValue("false")] bool enableCamera);
        public static bool StartRecording(bool enableMicrophone);
        public static bool StartRecording();
        public static void StartBroadcasting(BroadcastStatusCallback callback, [DefaultValue("false")] bool enableMicrophone, [DefaultValue("false")] bool enableCamera);
        public static void StartBroadcasting(BroadcastStatusCallback callback, bool enableMicrophone);
        public static void StartBroadcasting(BroadcastStatusCallback callback);
        [FreeFunction("UnityReplayKitStopRecording")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static bool StopRecording();
        [FreeFunction("UnityReplayKitStopBroadcasting")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static void StopBroadcasting();
        [FreeFunction("UnityReplayKitPauseBroadcasting")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static void PauseBroadcasting();
        [FreeFunction("UnityReplayKitResumeBroadcasting")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static void ResumeBroadcasting();
        [FreeFunction("UnityReplayKitPreview")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static bool Preview();
        [FreeFunction("UnityReplayKitDiscard")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static bool Discard();
        public static bool ShowCameraPreviewAt(float posX, float posY);
        [FreeFunction("UnityReplayKitShowCameraPreviewAt")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static bool ShowCameraPreviewAt(float posX, float posY, float width, float height);
        [FreeFunction("UnityReplayKitHideCameraPreview")]
        [NativeConditional("PLATFORM_IOS || PLATFORM_TVOS")]
        public static void HideCameraPreview();
        public delegate void BroadcastStatusCallback(bool hasStarted, string errorMessage);
    }
}
