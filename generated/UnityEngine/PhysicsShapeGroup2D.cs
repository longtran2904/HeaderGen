#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Internal;

namespace UnityEngine
{
    public class PhysicsShapeGroup2D
    {
        public PhysicsShapeGroup2D([DefaultValue("1")] int shapeCapacity = 1, [DefaultValue("8")] int vertexCapacity = 8);

        public int shapeCount { get; }
        public int vertexCount { get; }
        public Matrix4x4 localToWorldMatrix { get; set; }

        public void Clear();
        public void Add(PhysicsShapeGroup2D physicsShapeGroup);
        public void GetShapeData(List<PhysicsShape2D> shapes, List<Vector2> vertices);
        public void GetShapeData(NativeArray<PhysicsShape2D> shapes, NativeArray<Vector2> vertices);
        public void GetShapeVertices(int shapeIndex, List<Vector2> vertices);
        public Vector2 GetShapeVertex(int shapeIndex, int vertexIndex);
        public void SetShapeVertex(int shapeIndex, int vertexIndex, Vector2 vertex);
        public void SetShapeRadius(int shapeIndex, float radius);
        public void SetShapeAdjacentVertices(int shapeIndex, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd);
        public void DeleteShape(int shapeIndex);
        public PhysicsShape2D GetShape(int shapeIndex);
        public int AddCircle(Vector2 center, float radius);
        public int AddCapsule(Vector2 vertex0, Vector2 vertex1, float radius);
        public int AddBox(Vector2 center, Vector2 size, [DefaultValue("0f")] float angle = 0, [DefaultValue("0f")] float edgeRadius = 0);
        public int AddPolygon(List<Vector2> vertices);
        public int AddEdges(List<Vector2> vertices, [DefaultValue("0f")] float edgeRadius = 0);
        public int AddEdges(List<Vector2> vertices, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd, [DefaultValue("0f")] float edgeRadius = 0);
    }
}
