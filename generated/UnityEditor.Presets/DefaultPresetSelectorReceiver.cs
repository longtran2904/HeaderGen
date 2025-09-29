#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Presets
{
    public class DefaultPresetSelectorReceiver : PresetSelectorReceiver
    {

        public DefaultPresetSelectorReceiver();

        public override void OnSelectionChanged(Preset selection);
        public override void OnSelectionClosed(Preset selection);
    }
}
