#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
    {

        public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0);

        public VertexAttribute attribute { get; set; }
        public VertexAttributeFormat format { get; set; }
        public int dimension { get; set; }
        public int stream { get; set; }

        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(VertexAttributeDescriptor other);

        public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs);
        public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs);
    }
}
