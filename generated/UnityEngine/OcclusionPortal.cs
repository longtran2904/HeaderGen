#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/OcclusionPortal.h")]
    public sealed class OcclusionPortal : Component
    {
        public OcclusionPortal();

        [NativeProperty("IsOpen")]
        public bool open { get; set; }
    }
}
