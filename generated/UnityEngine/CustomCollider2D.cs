#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/Public/CustomCollider2D.h")]
    public sealed class CustomCollider2D : Collider2D
    {
        public CustomCollider2D();

        [NativeMethod("CustomShapeCount_Binding")]
        public int customShapeCount { get; }
        [NativeMethod("CustomVertexCount_Binding")]
        public int customVertexCount { get; }

        public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup);
        public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [DefaultValue("1")] int shapeCount = 1);
        public int GetCustomShapes(NativeArray<PhysicsShape2D> shapes, NativeArray<Vector2> vertices);
        public void SetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup);
        public void SetCustomShapes(NativeArray<PhysicsShape2D> shapes, NativeArray<Vector2> vertices);
        public void SetCustomShape(PhysicsShapeGroup2D physicsShapeGroup, int srcShapeIndex, int dstShapeIndex);
        public void SetCustomShape(NativeArray<PhysicsShape2D> shapes, NativeArray<Vector2> vertices, int srcShapeIndex, int dstShapeIndex);
        public void ClearCustomShapes(int shapeIndex, int shapeCount);
        [NativeMethod("ClearCustomShapes_Binding")]
        public void ClearCustomShapes();
    }
}
