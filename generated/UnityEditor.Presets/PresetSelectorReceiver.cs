#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Presets
{
    public abstract class PresetSelectorReceiver : ScriptableObject
    {
        protected PresetSelectorReceiver();

        public virtual void OnSelectionChanged(Preset selection);
        public virtual void OnSelectionClosed(Preset selection);
    }
}
