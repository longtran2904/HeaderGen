#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
    public sealed class EdgeCollider2D : Collider2D
    {
        public EdgeCollider2D();

        public float edgeRadius { get; set; }
        public int edgeCount { get; }
        public int pointCount { get; }
        public Vector2[] points { get; set; }
        public bool useAdjacentStartPoint { get; set; }
        public bool useAdjacentEndPoint { get; set; }
        public Vector2 adjacentStartPoint { get; set; }
        public Vector2 adjacentEndPoint { get; set; }

        public void Reset();
        [NativeMethod("GetPoints_Binding")]
        public int GetPoints([NotNull("ArgumentNullException")] List<Vector2> points);
        [NativeMethod("SetPoints_Binding")]
        public bool SetPoints([NotNull("ArgumentNullException")] List<Vector2> points);
    }
}
