#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Purchasing
{
    [NativeHeader("Modules/UnityConnect/UnityPurchasing/UnityPurchasingSettings.h")]
    [StaticAccessor("GetUnityPurchasingSettings()", StaticAccessorType.Dot)]
    public static class PurchasingSettings
    {

        public static bool enabled { get; set; }
    }
}
