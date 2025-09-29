#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
    public class CertificateHandler : IDisposable
    {

        protected CertificateHandler();

        ~CertificateHandler();

        protected virtual bool ValidateCertificate(byte[] certificateData);
        public void Dispose();
    }
}
