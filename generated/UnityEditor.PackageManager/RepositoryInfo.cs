#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.PackageManager
{
    [NativeAsStruct]
    [RequiredByNativeCode]
    public class RepositoryInfo
    {
        public string type { get; }
        public string url { get; }
        public string revision { get; }
        public string path { get; }
    }
}
