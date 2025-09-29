#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/SpringJoint2D.h")]
    public sealed class SpringJoint2D : AnchoredJoint2D
    {
        public SpringJoint2D();

        public bool autoConfigureDistance { get; set; }
        public float distance { get; set; }
        public float dampingRatio { get; set; }
        public float frequency { get; set; }
    }
}
