#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/BuoyancyEffector2D.h")]
    public class BuoyancyEffector2D : Effector2D
    {

        public BuoyancyEffector2D();

        public float surfaceLevel { get; set; }
        public float density { get; set; }
        public float linearDrag { get; set; }
        public float angularDrag { get; set; }
        public float flowAngle { get; set; }
        public float flowMagnitude { get; set; }
        public float flowVariation { get; set; }
    }
}
