#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/SurfaceEffector2D.h")]
    public class SurfaceEffector2D : Effector2D
    {

        public SurfaceEffector2D();

        public float speed { get; set; }
        public float speedVariation { get; set; }
        public float forceScale { get; set; }
        public bool useContactForce { get; set; }
        public bool useFriction { get; set; }
        public bool useBounce { get; set; }
    }
}
