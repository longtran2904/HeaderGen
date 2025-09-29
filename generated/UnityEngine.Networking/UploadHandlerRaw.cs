#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
    public sealed class UploadHandlerRaw : UploadHandler
    {

        public UploadHandlerRaw(byte[] data);
        public UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership);
        public UploadHandlerRaw(NativeArray<byte>.ReadOnly data);

        public override void Dispose();
    }
}
