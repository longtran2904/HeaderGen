#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
    public sealed class BoxCollider2D : Collider2D
    {
        public BoxCollider2D();

        public Vector2 size { get; set; }
        public float edgeRadius { get; set; }
        public bool autoTiling { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("BoxCollider2D.center has been deprecated. Use BoxCollider2D.offset instead (UnityUpgradable) -> offset", True)]
        public Vector2 center { get; set; }
    }
}
