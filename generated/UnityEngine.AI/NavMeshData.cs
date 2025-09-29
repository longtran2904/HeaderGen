#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.AI
{
    [NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
    public sealed class NavMeshData : Object
    {

        public NavMeshData();
        public NavMeshData(int agentTypeID);

        public Bounds sourceBounds { get; }
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
    }
}
