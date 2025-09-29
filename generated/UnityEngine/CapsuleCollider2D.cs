#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/CapsuleCollider2D.h")]
    public sealed class CapsuleCollider2D : Collider2D
    {
        public CapsuleCollider2D();

        public Vector2 size { get; set; }
        public CapsuleDirection2D direction { get; set; }
    }
}
