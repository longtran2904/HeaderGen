#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/BoxCollider.h")]
    [RequiredByNativeCode]
    public class BoxCollider : Collider
    {

        public BoxCollider();

        public Vector3 center { get; set; }
        public Vector3 size { get; set; }
        [Obsolete("Use BoxCollider.size instead. (UnityUpgradable) -> size")]
        public Vector3 extents { get; set; }
    }
}
