#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/PointEffector2D.h")]
    public class PointEffector2D : Effector2D
    {
        public PointEffector2D();

        public float forceMagnitude { get; set; }
        public float forceVariation { get; set; }
        public float distanceScale { get; set; }
        public float drag { get; set; }
        public float angularDrag { get; set; }
        public EffectorSelection2D forceSource { get; set; }
        public EffectorSelection2D forceTarget { get; set; }
        public EffectorForceMode2D forceMode { get; set; }
    }
}
