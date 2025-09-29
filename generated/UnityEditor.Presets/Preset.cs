#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Presets
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/PresetsEditor/Public/PresetManager.h")]
    [NativeType(Header = "Modules/PresetsEditor/Public/Preset.h")]
    [UsedByNativeCode]
    public sealed class Preset : UnityEngine.Object
    {

        public Preset(UnityEngine.Object source);

        public PropertyModification[] PropertyModifications { get; }
        public string[] excludedProperties { get; set; }

        public bool ApplyTo(UnityEngine.Object target);
        public bool ApplyTo([NotNull("ArgumentNullException")] UnityEngine.Object target, string[] selectedPropertyPaths);
        public bool DataEquals([NotNull("ArgumentNullException")] UnityEngine.Object target);
        public bool UpdateProperties([NotNull("ArgumentNullException")] UnityEngine.Object source);
        public PresetType GetPresetType();
        public string GetTargetFullTypeName();
        public string GetTargetTypeName();
        public bool IsValid();
        public bool CanBeAppliedTo(UnityEngine.Object target);
        [FreeFunction("GetDefaultPresetsForObject")]
        public static Preset[] GetDefaultPresetsForObject([NotNull("ArgumentNullException")] UnityEngine.Object target);
        [Obsolete("Use GetDefaultPresetsForObject to get the full ordered list of default Presets that would be applied to that Object")]
        public static Preset GetDefaultForObject(UnityEngine.Object target);
        [Obsolete("Use GetDefaultPresetsForType to get the full list of default Presets for a given PresetType.")]
        public static Preset GetDefaultForPreset(Preset preset);
        [FreeFunction("GetAllDefaultTypes")]
        public static PresetType[] GetAllDefaultTypes();
        [FreeFunction("GetDefaultPresetsForType")]
        public static DefaultPreset[] GetDefaultPresetsForType(PresetType type);
        [FreeFunction("SetDefaultPresetsForType")]
        public static bool SetDefaultPresetsForType(PresetType type, DefaultPreset[] presets);
        [Obsolete("Use SetDefaultPresetsForType instead.")]
        public static bool SetAsDefault(Preset preset);
        public static void RemoveFromDefault(Preset preset);
        [Obsolete("Use PresetType.IsValidDefault instead.")]
        public static bool IsPresetExcludedFromDefaultPresets(Preset preset);
        [Obsolete("Use PresetType.IsValidDefault instead.")]
        public static bool IsObjectExcludedFromDefaultPresets(UnityEngine.Object target);
        [Obsolete("Use PresetType.IsValid instead.")]
        public static bool IsObjectExcludedFromPresets(UnityEngine.Object target);
    }
}
