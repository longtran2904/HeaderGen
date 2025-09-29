#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    [CustomPropertyDrawer(typeof(VerticalAlignmentOptions))]
    public class TMP_VerticalAlignmentDrawer : PropertyDrawer
    {

        public TMP_VerticalAlignmentDrawer();

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label);
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
