#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
    [UsedByNativeCode]
    public readonly struct MeshTransform : IEquatable<MeshTransform>
    {
        public MeshTransform(in MeshId meshId, ulong timestamp, in Vector3 position, in Quaternion rotation, in Vector3 scale);

        public MeshId MeshId { get; }
        public ulong Timestamp { get; }
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }
        public Vector3 Scale { get; }

        public override bool Equals(object obj);
        public bool Equals(MeshTransform other);
        public override int GetHashCode();

        public static bool operator ==(MeshTransform lhs, MeshTransform rhs);
        public static bool operator !=(MeshTransform lhs, MeshTransform rhs);
    }
}
