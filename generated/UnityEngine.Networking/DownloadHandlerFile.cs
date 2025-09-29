#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerVFS.h")]
    public sealed class DownloadHandlerFile : DownloadHandler
    {

        public DownloadHandlerFile(string path);
        public DownloadHandlerFile(string path, bool append);

        public bool removeFileOnAbort { get; set; }

        protected override NativeArray<byte> GetNativeData();
        protected override byte[] GetData();
        protected override string GetText();
    }
}
