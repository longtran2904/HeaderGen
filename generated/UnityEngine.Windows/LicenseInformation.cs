#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
    [NativeHeader("PlatformDependent/MetroPlayer/Bindings/ApplicationTrialBindings.h")]
    public static class LicenseInformation
    {

        public static bool isOnAppTrial { get; }

        public static string PurchaseApp();
    }
}
