#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Build;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [NativeHeader("Editor/Mono/EditorGraphicsSettings.bindings.h")]
    [StaticAccessor("EditorGraphicsSettingsScripting", StaticAccessorType.DoubleColon)]
    public sealed class EditorGraphicsSettings
    {

        public EditorGraphicsSettings();

        public static AlbedoSwatchInfo[] albedoSwatches { get; set; }

        public static TierSettings GetTierSettings(BuildTargetGroup target, GraphicsTier tier);
        public static TierSettings GetTierSettings(NamedBuildTarget target, GraphicsTier tier);
        public static void SetTierSettings(BuildTargetGroup target, GraphicsTier tier, TierSettings settings);
        public static void SetTierSettings(NamedBuildTarget target, GraphicsTier tier, TierSettings settings);
        [Obsolete("Use GetTierSettings() instead (UnityUpgradable) -> GetTierSettings(*)", False)]
        public static PlatformShaderSettings GetShaderSettingsForPlatform(BuildTargetGroup target, ShaderHardwareTier tier);
        [Obsolete("Use SetTierSettings() instead (UnityUpgradable) -> SetTierSettings(*)", False)]
        public static void SetShaderSettingsForPlatform(BuildTargetGroup target, ShaderHardwareTier tier, PlatformShaderSettings settings);
        [Obsolete("Use GraphicsTier instead of ShaderHardwareTier enum", False)]
        public static TierSettings GetTierSettings(BuildTargetGroup target, ShaderHardwareTier tier);
        [Obsolete("Use GraphicsTier instead of ShaderHardwareTier enum", False)]
        public static void SetTierSettings(BuildTargetGroup target, ShaderHardwareTier tier, TierSettings settings);
    }
}
