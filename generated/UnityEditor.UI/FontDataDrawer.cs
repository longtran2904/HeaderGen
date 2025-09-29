#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CustomPropertyDrawer(typeof(FontData), True)]
    public class FontDataDrawer : PropertyDrawer
    {

        public FontDataDrawer();

        protected void Init(SerializedProperty property);
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label);
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
