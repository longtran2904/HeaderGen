#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/FrictionJoint2D.h")]
    public sealed class FrictionJoint2D : AnchoredJoint2D
    {
        public FrictionJoint2D();

        public float maxForce { get; set; }
        public float maxTorque { get; set; }
    }
}
