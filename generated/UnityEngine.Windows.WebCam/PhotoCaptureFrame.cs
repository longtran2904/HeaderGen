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
    [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
    [NativeHeader("PlatformDependent/Win/Webcam/PhotoCaptureFrame.h")]
    public sealed class PhotoCaptureFrame : IDisposable
    {
        ~PhotoCaptureFrame();

        public int dataLength { get; }
        public bool hasLocationData { get; }
        public CapturePixelFormat pixelFormat { get; }

        public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix);
        public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix);
        public bool TryGetProjectionMatrix(float nearClipPlane, float farClipPlane, out Matrix4x4 projectionMatrix);
        public void UploadImageDataToTexture(Texture2D targetTexture);
        [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")]
        [ThreadAndSerializationSafe]
        public nint GetUnsafePointerToBuffer();
        public void CopyRawImageDataIntoBuffer(List<byte> byteBuffer);
        public void Dispose();
    }
}
