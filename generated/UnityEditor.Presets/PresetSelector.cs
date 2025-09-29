#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Presets
{
    public class PresetSelector : EditorWindow
    {

        public PresetSelector();

        [EditorHeaderItem(typeof(UnityEngine.Object), -1001)]
        public static bool DrawPresetButton(Rect rectangle, UnityEngine.Object[] targets);
        public static void ShowSelector(UnityEngine.Object[] targets, Preset currentSelection, bool createNewAllowed);
        public static void ShowSelector(UnityEngine.Object target, Preset currentSelection, bool createNewAllowed, PresetSelectorReceiver eventReceiver);
        public static void ShowSelector(PresetType presetType, Preset currentSelection, bool createNewAllowed, PresetSelectorReceiver eventReceiver);
    }
}
