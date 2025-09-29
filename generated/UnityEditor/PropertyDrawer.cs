#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor
{
    public abstract class PropertyDrawer : GUIDrawer
    {

        protected PropertyDrawer();

        public PropertyAttribute attribute { get; }
        public FieldInfo fieldInfo { get; }

        public virtual void OnGUI(Rect position, SerializedProperty property, GUIContent label);
        public virtual VisualElement CreatePropertyGUI(SerializedProperty property);
        public virtual float GetPropertyHeight(SerializedProperty property, GUIContent label);
        public virtual bool CanCacheInspectorGUI(SerializedProperty property);
    }
}
