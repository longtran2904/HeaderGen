#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
    [NativeHeader("Runtime/VirtualFileSystem/VirtualFileSystem.h")]
    public static class VirtualFileSystem
    {
        [FreeFunction(IsThreadSafe = True)]
        public static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize);
    }
}
