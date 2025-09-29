#region UnityEditor.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEditor.UI.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace UnityEditor.UI
{
    [CustomPropertyDrawer(typeof(SpriteState), True)]
    public class SpriteStateDrawer : PropertyDrawer
    {

        public SpriteStateDrawer();

        public override void OnGUI(Rect rect, SerializedProperty prop, GUIContent label);
        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label);
    }
}
