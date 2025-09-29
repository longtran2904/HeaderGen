#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/TargetJoint2D.h")]
    public sealed class TargetJoint2D : Joint2D
    {
        public TargetJoint2D();

        public Vector2 anchor { get; set; }
        public Vector2 target { get; set; }
        public bool autoConfigureTarget { get; set; }
        public float maxForce { get; set; }
        public float dampingRatio { get; set; }
        public float frequency { get; set; }
    }
}
