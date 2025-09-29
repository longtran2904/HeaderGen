#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/FixedJoint2D.h")]
    public sealed class FixedJoint2D : AnchoredJoint2D
    {

        public FixedJoint2D();

        public float dampingRatio { get; set; }
        public float frequency { get; set; }
        public float referenceAngle { get; }
    }
}
