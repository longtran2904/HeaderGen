#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
    public class DownloadHandler : IDisposable
    {

        ~DownloadHandler();

        public bool isDone { get; }
        public string error { get; }
        public NativeArray<byte>.ReadOnly nativeData { get; }
        public byte[] data { get; }
        public string text { get; }

        public virtual void Dispose();
        protected virtual NativeArray<byte> GetNativeData();
        protected virtual byte[] GetData();
        protected virtual string GetText();
        [RequiredByNativeCode]
        protected virtual bool ReceiveData(byte[] data, int dataLength);
        [RequiredByNativeCode]
        protected virtual void ReceiveContentLengthHeader(ulong contentLength);
        [Obsolete("Use ReceiveContentLengthHeader")]
        protected virtual void ReceiveContentLength(int contentLength);
        [RequiredByNativeCode]
        protected virtual void CompleteContent();
        [RequiredByNativeCode]
        protected virtual float GetProgress();
        protected static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler;
    }
}
