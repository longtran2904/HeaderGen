#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("Unity::SpringJoint")]
    [NativeHeader("Modules/Physics/SpringJoint.h")]
    public class SpringJoint : Joint
    {
        public SpringJoint();

        public float spring { get; set; }
        public float damper { get; set; }
        public float minDistance { get; set; }
        public float maxDistance { get; set; }
        public float tolerance { get; set; }
    }
}
