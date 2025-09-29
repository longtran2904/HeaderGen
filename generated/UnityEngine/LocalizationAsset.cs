#region UnityEngine.LocalizationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.LocalizationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [MovedFrom("UnityEditor")]
    [NativeClass("LocalizationAsset")]
    [NativeHeader("Modules/Localization/Public/LocalizationAsset.bindings.h")]
    [NativeHeader("Modules/Localization/Public/LocalizationAsset.h")]
    public sealed class LocalizationAsset : Object
    {

        public LocalizationAsset();

        public string localeIsoCode { get; set; }
        public bool isEditorAsset { get; set; }

        [NativeMethod("StoreLocalizedString")]
        public void SetLocalizedString(string original, string localized);
        [NativeMethod("GetLocalized")]
        public string GetLocalizedString(string original);
    }
}
