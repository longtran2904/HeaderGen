#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro.EditorUtilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TMP_SubMeshUI))]
    public class TMP_SubMeshUI_Editor : Editor
    {
        public TMP_SubMeshUI_Editor();

        public void OnEnable();
        public void OnDisable();
        public override void OnInspectorGUI();
    }
}
