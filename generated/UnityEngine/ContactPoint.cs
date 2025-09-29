#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/MessageParameters.h")]
    [UsedByNativeCode]
    public struct ContactPoint
    {
        public Vector3 point { get; }
        public Vector3 normal { get; }
        public Collider thisCollider { get; }
        public Collider otherCollider { get; }
        public float separation { get; }
    }
}
