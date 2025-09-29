#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
    [StaticAccessor("VirtualTexturing::Debugging", StaticAccessorType.DoubleColon)]
    public static class Debugging
    {
        [NativeThrows]
        public static bool debugTilesEnabled { get; set; }
        [NativeThrows]
        public static bool resolvingEnabled { get; set; }
        [NativeThrows]
        public static bool flushEveryTickEnabled { get; set; }

        [NativeThrows]
        public static int GetNumHandles();
        [NativeThrows]
        public static void GrabHandleInfo(out Handle debugHandle, int index);
        [NativeThrows]
        public static string GetInfoDump();

        [NativeHeader("Modules/VirtualTexturing/Public/VirtualTexturingDebugHandle.h")]
        [UsedByNativeCode]
        public struct Handle
        {
            public long handle;
            public string group;
            public string name;
            public int numLayers;
            public Material material;
        }
    }
}
