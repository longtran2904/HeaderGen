#region UnityEngine.ClusterRendererModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClusterRendererModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [ExcludeFromDocs]
    [NativeHeader("Modules/ClusterRenderer/ClusterSerialization.h")]
    public static class ClusterSerialization
    {

        public static int SaveTimeManagerState(NativeArray<byte> buffer);
        public static bool RestoreTimeManagerState(NativeArray<byte> buffer);
        public static int SaveInputManagerState(NativeArray<byte> buffer);
        public static bool RestoreInputManagerState(NativeArray<byte> buffer);
        public static int SaveClusterInputState(NativeArray<byte> buffer);
        public static bool RestoreClusterInputState(NativeArray<byte> buffer);
    }
}
