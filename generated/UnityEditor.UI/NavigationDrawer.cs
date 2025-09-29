#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CustomPropertyDrawer(typeof(Navigation), True)]
    public class NavigationDrawer : PropertyDrawer
    {

        public NavigationDrawer();

        public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent label);
        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label);
    }
}
