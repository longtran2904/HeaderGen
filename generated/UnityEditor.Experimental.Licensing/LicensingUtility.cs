#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Experimental.Licensing
{
    [NativeHeader("Modules/Licensing/Public/LicensingUtility.bindings.h")]
    public static class LicensingUtility
    {
        [NativeMethod("HasEntitlement")]
        public static bool HasEntitlement(string entitlement);
        [NativeMethod("HasEntitlements")]
        public static string[] HasEntitlements(string[] entitlements);
        [NativeMethod("HasEntitlementsExtended")]
        public static EntitlementInfo[] HasEntitlementsExtended(string[] entitlements, bool includeCustomData);
        public static void InvokeLicenseUpdateCallbacks();
        public static bool UpdateLicense();
    }
}
