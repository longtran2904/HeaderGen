#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine;
using UnityEngine.TextCore.Text;

namespace UnityEditor.TextCore.Text
{
    [CustomPropertyDrawer(typeof(TextStyle))]
    public class TextStylePropertyDrawer : PropertyDrawer
    {
        public static readonly float height;

        public TextStylePropertyDrawer();

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label);
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
