#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
    public sealed class PhysicsMaterial2D : Object
    {

        public PhysicsMaterial2D();
        public PhysicsMaterial2D(string name);

        public float bounciness { get; set; }
        public float friction { get; set; }
    }
}
