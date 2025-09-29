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
    [NativeHeader("PlatformDependent/Win/Webcam/PhotoCapture.h")]
    [StaticAccessor("PhotoCapture", StaticAccessorType.DoubleColon)]
    public class PhotoCapture : IDisposable
    {

        ~PhotoCapture();

        public static IEnumerable<Resolution> SupportedResolutions { get; }

        public static void CreateAsync(bool showHolograms, OnCaptureResourceCreatedCallback onCreatedCallback);
        public static void CreateAsync(OnCaptureResourceCreatedCallback onCreatedCallback);
        public void StartPhotoModeAsync(CameraParameters setupParams, OnPhotoModeStartedCallback onPhotoModeStartedCallback);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [NativeName("StopPhotoMode")]
        public void StopPhotoModeAsync(OnPhotoModeStoppedCallback onPhotoModeStoppedCallback);
        public void TakePhotoAsync(string filename, PhotoCaptureFileOutputFormat fileOutputFormat, OnCapturedToDiskCallback onCapturedPhotoToDiskCallback);
        public void TakePhotoAsync(OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [NativeName("GetUnsafePointerToVideoDeviceController")]
        [ThreadAndSerializationSafe]
        public nint GetUnsafePointerToVideoDeviceController();
        public void Dispose();
        public enum CaptureResultType
        {

            Success = 0,
            UnknownError = 1
        }
        public struct PhotoCaptureResult
        {

            public CaptureResultType resultType;
            public long hResult;

            public bool success { get; }
        }
        public delegate void OnCaptureResourceCreatedCallback(PhotoCapture captureObject);
        public delegate void OnPhotoModeStartedCallback(PhotoCaptureResult result);
        public delegate void OnPhotoModeStoppedCallback(PhotoCaptureResult result);
        public delegate void OnCapturedToDiskCallback(PhotoCaptureResult result);
        public delegate void OnCapturedToMemoryCallback(PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame);
    }
}
