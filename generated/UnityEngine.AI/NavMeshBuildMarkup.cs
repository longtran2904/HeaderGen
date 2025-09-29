#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.AI
{
    [NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
    public struct NavMeshBuildMarkup
    {

        public bool overrideArea { get; set; }
        public int area { get; set; }
        public bool ignoreFromBuild { get; set; }
        public Transform root { get; set; }
    }
}
