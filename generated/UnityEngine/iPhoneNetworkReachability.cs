#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhoneNetworkReachability enumeration is deprecated. Please use NetworkReachability instead (UnityUpgradable) -> NetworkReachability", True)]
    public enum iPhoneNetworkReachability
    {

        NotReachable = 0,
        ReachableViaCarrierDataNetwork = 1,
        [Obsolete]
        ReachableViaWiFiNetwork = 2
    }
}
