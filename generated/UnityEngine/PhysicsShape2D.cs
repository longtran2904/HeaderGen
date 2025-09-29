#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader(Header = "Modules/Physics2D/Public/PhysicsScripting2D.h")]
    [UsedByNativeCode]
    public struct PhysicsShape2D
    {

        public PhysicsShapeType2D shapeType { get; set; }
        public float radius { get; set; }
        public int vertexStartIndex { get; set; }
        public int vertexCount { get; set; }
        public bool useAdjacentStart { get; set; }
        public bool useAdjacentEnd { get; set; }
        public Vector2 adjacentStart { get; set; }
        public Vector2 adjacentEnd { get; set; }
    }
}
