#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Slider), True)]
    public class SliderEditor : SelectableEditor
    {
        public SliderEditor();

        protected override void OnEnable();
        public override void OnInspectorGUI();
    }
}
