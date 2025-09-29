#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class MeshFilter : Component
    {

        public MeshFilter();

        public Mesh sharedMesh { get; set; }
        public Mesh mesh { get; set; }
    }
}
