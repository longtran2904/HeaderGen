#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public struct CachedAssetBundle
    {

        public CachedAssetBundle(string name, Hash128 hash);

        public string name { get; set; }
        public Hash128 hash { get; set; }
    }
}
