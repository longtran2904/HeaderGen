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
    public struct MeshInfo : IEquatable<MeshInfo>
    {

        public MeshId MeshId { get; set; }
        public MeshChangeState ChangeState { get; set; }
        public int PriorityHint { get; set; }

        public override bool Equals(object obj);
        public bool Equals(MeshInfo other);
        public override int GetHashCode();

        public static bool operator ==(MeshInfo lhs, MeshInfo rhs);
        public static bool operator !=(MeshInfo lhs, MeshInfo rhs);
    }
}
