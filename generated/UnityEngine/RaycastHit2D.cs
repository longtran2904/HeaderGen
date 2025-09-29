#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
    [NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct RaycastHit2D
    {

        public Vector2 centroid { get; set; }
        public Vector2 point { get; set; }
        public Vector2 normal { get; set; }
        public float distance { get; set; }
        public float fraction { get; set; }
        public Collider2D collider { get; }
        public Rigidbody2D rigidbody { get; }
        public Transform transform { get; }

        public int CompareTo(RaycastHit2D other);

        public static implicit operator bool(RaycastHit2D hit);
    }
}
