#region UnityEngine.ClusterRendererModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClusterRendererModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/ClusterRenderer/ClusterNetwork.h")]
    public class ClusterNetwork
    {
        public ClusterNetwork();

        public static bool isMasterOfCluster { get; }
        public static bool isDisconnected { get; }
        public static int nodeIndex { get; set; }
    }
}
