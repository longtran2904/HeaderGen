#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro.EditorUtilities
{
    [CustomEditor(typeof(TMP_SpriteAsset))]
    public class TMP_SpriteAssetEditor : Editor
    {

        public TMP_SpriteAssetEditor();

        public void OnEnable();
        public override void OnInspectorGUI();
    }
}
