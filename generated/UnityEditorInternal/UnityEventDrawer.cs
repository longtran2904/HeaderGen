#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace UnityEditorInternal
{
    [CustomPropertyDrawer(typeof(UnityEventBase), True)]
    public class UnityEventDrawer : PropertyDrawer
    {
        public UnityEventDrawer();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label);
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label);
        public void OnGUI(Rect position);
        protected virtual void SetupReorderableList(ReorderableList list);
        protected virtual void DrawEventHeader(Rect headerRect);
        protected virtual void DrawEvent(Rect rect, int index, bool isActive, bool isFocused);
        protected virtual void OnRemoveEvent(ReorderableList list);
        protected virtual void OnAddEvent(ReorderableList list);
        protected virtual void OnSelectEvent(ReorderableList list);
        protected virtual void OnReorderEvent(ReorderableList list);
        public static bool IsPersistantListenerValid(UnityEventBase dummyEvent, string methodName, UnityEngine.Object uObject, PersistentListenerMode modeEnum, Type argumentType);

        protected class State
        {
            public int lastSelectedIndex;

            public State();
        }
    }
}
