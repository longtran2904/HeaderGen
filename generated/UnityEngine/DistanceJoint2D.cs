#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/DistanceJoint2D.h")]
    public sealed class DistanceJoint2D : AnchoredJoint2D
    {

        public DistanceJoint2D();

        public bool autoConfigureDistance { get; set; }
        public float distance { get; set; }
        public bool maxDistanceOnly { get; set; }
    }
}
