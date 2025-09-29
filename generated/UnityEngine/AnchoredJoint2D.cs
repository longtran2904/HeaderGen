#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/AnchoredJoint2D.h")]
    public class AnchoredJoint2D : Joint2D
    {
        public AnchoredJoint2D();

        public Vector2 anchor { get; set; }
        public Vector2 connectedAnchor { get; set; }
        public bool autoConfigureConnectedAnchor { get; set; }
    }
}
