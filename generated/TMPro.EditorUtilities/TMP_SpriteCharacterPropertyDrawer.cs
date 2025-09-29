#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    [CustomPropertyDrawer(typeof(TMP_SpriteCharacter))]
    public class TMP_SpriteCharacterPropertyDrawer : PropertyDrawer
    {
        public TMP_SpriteCharacterPropertyDrawer();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label);
    }
}
