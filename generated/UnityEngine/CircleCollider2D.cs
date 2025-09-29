#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/CircleCollider2D.h")]
    public sealed class CircleCollider2D : Collider2D
    {

        public CircleCollider2D();

        public float radius { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("CircleCollider2D.center has been deprecated. Use CircleCollider2D.offset instead (UnityUpgradable) -> offset", True)]
        public Vector2 center { get; set; }
    }
}
