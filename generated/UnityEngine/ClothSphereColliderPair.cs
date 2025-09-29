#region UnityEngine.ClothModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClothModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Cloth/Cloth.h")]
    [UsedByNativeCode]
    public struct ClothSphereColliderPair
    {

        public ClothSphereColliderPair(SphereCollider a);
        public ClothSphereColliderPair(SphereCollider a, SphereCollider b);

        public SphereCollider first { get; set; }
        public SphereCollider second { get; set; }
    }
}
