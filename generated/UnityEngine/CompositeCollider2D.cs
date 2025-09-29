#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class CompositeCollider2D : Collider2D
    {

        public CompositeCollider2D();

        public GeometryType geometryType { get; set; }
        public GenerationType generationType { get; set; }
        public float vertexDistance { get; set; }
        public float edgeRadius { get; set; }
        public float offsetDistance { get; set; }
        public int pathCount { get; }
        public int pointCount { get; }

        public void GenerateGeometry();
        public int GetPathPointCount(int index);
        public int GetPath(int index, Vector2[] points);
        public int GetPath(int index, List<Vector2> points);
        public enum GeometryType
        {

            Outlines = 0,
            Polygons = 1
        }
        public enum GenerationType
        {

            Synchronous = 0,
            Manual = 1
        }
    }
}
