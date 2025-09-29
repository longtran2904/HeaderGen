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
    public struct MeshId : IEquatable<MeshId>
    {
        public static MeshId InvalidId { get; }

        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(MeshId other);

        public static bool operator ==(MeshId id1, MeshId id2);
        public static bool operator !=(MeshId id1, MeshId id2);
    }
}
