#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
    [RequiredByNativeCode]
    public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
    {

        public MeshId MeshId { get; }
        public Mesh Mesh { get; }
        public MeshCollider MeshCollider { get; }
        public MeshGenerationStatus Status { get; }
        public MeshVertexAttributes Attributes { get; }
        public ulong Timestamp { get; }
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }
        public Vector3 Scale { get; }

        public override bool Equals(object obj);
        public bool Equals(MeshGenerationResult other);
        public override int GetHashCode();

        public static bool operator ==(MeshGenerationResult lhs, MeshGenerationResult rhs);
        public static bool operator !=(MeshGenerationResult lhs, MeshGenerationResult rhs);
    }
}
