#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/SphereCollider.h")]
    [RequiredByNativeCode]
    public class SphereCollider : Collider
    {

        public SphereCollider();

        public Vector3 center { get; set; }
        public float radius { get; set; }
    }
}
