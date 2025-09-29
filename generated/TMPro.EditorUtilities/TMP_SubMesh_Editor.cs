#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro.EditorUtilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TMP_SubMesh))]
    public class TMP_SubMesh_Editor : Editor
    {

        public TMP_SubMesh_Editor();

        public void OnEnable();
        public override void OnInspectorGUI();
    }
}
