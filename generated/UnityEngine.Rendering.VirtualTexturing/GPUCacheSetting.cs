#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/Public/VirtualTexturingSettings.h")]
    [UsedByNativeCode]
    public struct GPUCacheSetting
    {
        public GraphicsFormat format;
        public uint sizeInMegaBytes;
    }
}
