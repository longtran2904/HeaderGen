#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
    public static class GraphicsDeviceSettings
    {
        [StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
        public static WaitForPresentSyncPoint waitForPresentSyncPoint { get; set; }
        [StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
        public static GraphicsJobsSyncPoint graphicsJobsSyncPoint { get; set; }
    }
}
