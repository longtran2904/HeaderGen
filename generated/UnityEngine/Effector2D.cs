#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Effector2D.h")]
    public class Effector2D : Behaviour
    {
        public Effector2D();

        public bool useColliderMask { get; set; }
        public int colliderMask { get; set; }
    }
}
