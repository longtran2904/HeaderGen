#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public sealed class LightingExplorerTableColumn
    {

        public LightingExplorerTableColumn(DataType type, GUIContent headerContent, string propertyName = null, int width = 100, OnGUIDelegate onGUIDelegate = null, ComparePropertiesDelegate compareDelegate = null, CopyPropertiesDelegate copyDelegate = null, int[] dependencyIndices = null);
        public enum DataType
        {

            Name = 0,
            Checkbox = 1,
            Enum = 2,
            Int = 3,
            Float = 4,
            Color = 5,
            Custom = 20
        }
        public delegate void OnGUIDelegate(Rect r, SerializedProperty prop, SerializedProperty[] dependencies);
        public delegate int ComparePropertiesDelegate(SerializedProperty lhs, SerializedProperty rhs);
        public delegate void CopyPropertiesDelegate(SerializedProperty target, SerializedProperty source);
    }
}
