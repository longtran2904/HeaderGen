#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/MeshCollider.h")]
    [NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
    [RequiredByNativeCode]
    public class MeshCollider : Collider
    {
        public MeshCollider();

        public Mesh sharedMesh { get; set; }
        public bool convex { get; set; }
        public MeshColliderCookingOptions cookingOptions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Configuring smooth sphere collisions is no longer needed.", True)]
        public bool smoothSphereCollisions { get; set; }
        [Obsolete("MeshCollider.skinWidth is no longer used.")]
        public float skinWidth { get; set; }
        [Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
        public bool inflateMesh { get; set; }
    }
}
