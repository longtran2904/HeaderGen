#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
    public class UploadHandler : IDisposable
    {

        ~UploadHandler();

        public byte[] data { get; }
        public string contentType { get; set; }
        public float progress { get; }

        public virtual void Dispose();
    }
}
