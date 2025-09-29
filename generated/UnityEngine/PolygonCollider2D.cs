#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
    public sealed class PolygonCollider2D : Collider2D
    {

        public PolygonCollider2D();

        public bool autoTiling { get; set; }
        public Vector2[] points { get; set; }
        public int pathCount { get; set; }

        [NativeMethod("GetPointCount")]
        public int GetTotalPointCount();
        public Vector2[] GetPath(int index);
        public void SetPath(int index, Vector2[] points);
        public int GetPath(int index, List<Vector2> points);
        public void SetPath(int index, List<Vector2> points);
        [ExcludeFromDocs]
        public void CreatePrimitive(int sides);
        [ExcludeFromDocs]
        public void CreatePrimitive(int sides, Vector2 scale);
        public void CreatePrimitive(int sides, [DefaultValue("Vector2.one")] Vector2 scale, [DefaultValue("Vector2.zero")] Vector2 offset);
    }
}
