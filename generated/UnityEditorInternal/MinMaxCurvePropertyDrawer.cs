#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace UnityEditorInternal
{
    [CustomPropertyDrawer(typeof(ParticleSystem.MinMaxCurve))]
    public class MinMaxCurvePropertyDrawer : PropertyDrawer
    {
        public MinMaxCurvePropertyDrawer();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
    }
}
