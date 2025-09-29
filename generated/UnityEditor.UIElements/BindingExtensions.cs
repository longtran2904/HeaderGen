#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public static class BindingExtensions
    {
        public static readonly string prefabOverrideUssClassName;

        public static void Bind(this VisualElement element, SerializedObject obj);
        public static void Unbind(this VisualElement element);
        public static SerializedProperty BindProperty(this IBindable field, SerializedObject obj);
        public static void BindProperty(this IBindable field, SerializedProperty property);
        public static void TrackPropertyValue(this VisualElement element, SerializedProperty property, Action<SerializedProperty> callback = null);
        public static void TrackSerializedObjectValue(this VisualElement element, SerializedObject obj, Action<SerializedObject> callback = null);
    }
}
