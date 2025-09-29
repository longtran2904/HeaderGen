#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/RelativeJoint2D.h")]
    public sealed class RelativeJoint2D : Joint2D
    {
        public RelativeJoint2D();

        public float maxForce { get; set; }
        public float maxTorque { get; set; }
        public float correctionScale { get; set; }
        public bool autoConfigureOffset { get; set; }
        public Vector2 linearOffset { get; set; }
        public float angularOffset { get; set; }
        public Vector2 target { get; }
    }
}
