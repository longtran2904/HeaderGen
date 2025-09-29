#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Presets
{
    [NativeType(Header = "Modules/PresetsEditor/Public/PresetManager.h")]
    public struct DefaultPreset
    {
        [Obsolete("Use the new getter/setter instead. (UnityUpgradable) -> filter")]
        [SerializeField]
        public string m_Filter;
        [Obsolete("Use the new getter/setter instead. (UnityUpgradable) -> preset")]
        [SerializeField]
        public Preset m_Preset;

        public DefaultPreset(string filter, Preset preset);
        public DefaultPreset(string filter, Preset preset, bool enabled);

        public string filter { get; set; }
        public Preset preset { get; set; }
        public bool enabled { get; set; }
    }
}
