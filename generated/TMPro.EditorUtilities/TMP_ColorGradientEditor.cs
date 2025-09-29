#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;

namespace TMPro.EditorUtilities
{
    [CustomEditor(typeof(TMP_ColorGradient))]
    public class TMP_ColorGradientEditor : Editor
    {

        public TMP_ColorGradientEditor();

        public override void OnInspectorGUI();
    }
}
