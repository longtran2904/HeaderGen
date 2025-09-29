#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.tvOS
{
    public enum DeviceGeneration
    {
        Unknown = 0,
        [Obsolete("AppleTV1Gen has been renamed. Use AppleTVHD instead (UnityUpgradable) -> AppleTVHD", False)]
        AppleTV1Gen = 1001,
        AppleTVHD = 1001,
        [Obsolete("AppleTV2Gen has been renamed. Use AppleTV4K instead (UnityUpgradable) -> AppleTV4K", False)]
        AppleTV2Gen = 1002,
        AppleTV4K = 1002,
        AppleTV4K2Gen = 1003,
        AppleTV4K3Gen = 1004
    }
}
