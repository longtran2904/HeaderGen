#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
    [MovedFrom("UnityEngine.XR.WSA.WebCam")]
    [NativeHeader("PlatformDependent/Win/Webcam/VideoCaptureBindings.h")]
    [StaticAccessor("VideoCaptureBindings", StaticAccessorType.DoubleColon)]
    public class VideoCapture : IDisposable
    {

        ~VideoCapture();

        public static IEnumerable<Resolution> SupportedResolutions { get; }
        public bool IsRecording { get; }

        public static IEnumerable<float> GetSupportedFrameRatesForResolution(Resolution resolution);
        public static void CreateAsync(bool showHolograms, OnVideoCaptureResourceCreatedCallback onCreatedCallback);
        public static void CreateAsync(OnVideoCaptureResourceCreatedCallback onCreatedCallback);
        public void StartVideoModeAsync(CameraParameters setupParams, AudioState audioState, OnVideoModeStartedCallback onVideoModeStartedCallback);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [NativeMethod("VideoCaptureBindings::StopVideoMode", HasExplicitThis = True)]
        public void StopVideoModeAsync([NotNull("ArgumentNullException")] OnVideoModeStoppedCallback onVideoModeStoppedCallback);
        public void StartRecordingAsync(string filename, OnStartedRecordingVideoCallback onStartedRecordingVideoCallback);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [NativeMethod("VideoCaptureBindings::StopRecordingVideoToDisk", HasExplicitThis = True)]
        public void StopRecordingAsync([NotNull("ArgumentNullException")] OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [NativeMethod("VideoCaptureBindings::GetUnsafePointerToVideoDeviceController", HasExplicitThis = True)]
        [ThreadAndSerializationSafe]
        public nint GetUnsafePointerToVideoDeviceController();
        public void Dispose();
        public enum CaptureResultType
        {

            Success = 0,
            UnknownError = 1
        }
        public enum AudioState
        {

            MicAudio = 0,
            ApplicationAudio = 1,
            ApplicationAndMicAudio = 2,
            None = 3
        }
        public struct VideoCaptureResult
        {

            public CaptureResultType resultType;
            public long hResult;

            public bool success { get; }
        }
        public delegate void OnVideoCaptureResourceCreatedCallback(VideoCapture captureObject);
        public delegate void OnVideoModeStartedCallback(VideoCaptureResult result);
        public delegate void OnVideoModeStoppedCallback(VideoCaptureResult result);
        public delegate void OnStartedRecordingVideoCallback(VideoCaptureResult result);
        public delegate void OnStoppedRecordingVideoCallback(VideoCaptureResult result);
    }
}
