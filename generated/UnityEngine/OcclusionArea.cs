#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/OcclusionArea.h")]
    public sealed class OcclusionArea : Component
    {
        public OcclusionArea();

        public Vector3 center { get; set; }
        public Vector3 size { get; set; }
    }
}
