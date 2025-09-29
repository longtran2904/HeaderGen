#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.ObjectModel;
using UnityEditor;
using UnityEngine;

namespace UnityEditorInternal
{
    public class ReorderableList
    {
        public HeaderCallbackDelegate drawHeaderCallback;
        public FooterCallbackDelegate drawFooterCallback;
        public ElementCallbackDelegate drawElementCallback;
        public ElementCallbackDelegate drawElementBackgroundCallback;
        public DrawNoneElementCallback drawNoneElementCallback;
        public ElementHeightCallbackDelegate elementHeightCallback;
        public ReorderCallbackDelegateWithDetails onReorderCallbackWithDetails;
        public ReorderCallbackDelegate onReorderCallback;
        public SelectCallbackDelegate onSelectCallback;
        public AddCallbackDelegate onAddCallback;
        public AddDropdownCallbackDelegate onAddDropdownCallback;
        public RemoveCallbackDelegate onRemoveCallback;
        public DragCallbackDelegate onMouseDragCallback;
        public SelectCallbackDelegate onMouseUpCallback;
        public CanRemoveCallbackDelegate onCanRemoveCallback;
        public CanAddCallbackDelegate onCanAddCallback;
        public ChangedCallbackDelegate onChangedCallback;
        public bool displayAdd;
        public bool displayRemove;
        public float elementHeight;
        public float headerHeight;
        public float footerHeight;
        public bool showDefaultBackground;

        public ReorderableList(IList elements, Type elementType);
        public ReorderableList(IList elements, Type elementType, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton);
        public ReorderableList(SerializedObject serializedObject, SerializedProperty elements);
        public ReorderableList(SerializedObject serializedObject, SerializedProperty elements, bool draggable, bool displayHeader, bool displayAddButton, bool displayRemoveButton);

        public static Defaults defaultBehaviours { get; }
        public SerializedProperty serializedProperty { get; set; }
        public IList list { get; set; }
        public int index { get; set; }
        public ReadOnlyCollection<int> selectedIndices { get; }
        public bool multiSelect { get; set; }
        public bool draggable { get; set; }
        public int count { get; }

        public void ClearSelection();
        public void Select(int index, bool append = False);
        public void SelectRange(int indexFrom, int indexTo);
        public bool IsSelected(int index);
        public void Deselect(int index);
        public void DoLayoutList();
        public void DoList(Rect rect);
        public void DoList(Rect rect, Rect visibleRect);
        public float GetHeight();
        public void GrabKeyboardFocus();
        public void ReleaseKeyboardFocus();
        public bool HasKeyboardControl();

        public delegate void HeaderCallbackDelegate(Rect rect);
        public delegate void FooterCallbackDelegate(Rect rect);
        public delegate void ElementCallbackDelegate(Rect rect, int index, bool isActive, bool isFocused);
        public delegate float ElementHeightCallbackDelegate(int index);
        public delegate void DrawNoneElementCallback(Rect rect);
        public delegate void ReorderCallbackDelegateWithDetails(ReorderableList list, int oldIndex, int newIndex);
        public delegate void ReorderCallbackDelegate(ReorderableList list);
        public delegate void SelectCallbackDelegate(ReorderableList list);
        public delegate void AddCallbackDelegate(ReorderableList list);
        public delegate void AddDropdownCallbackDelegate(Rect buttonRect, ReorderableList list);
        public delegate void RemoveCallbackDelegate(ReorderableList list);
        public delegate void ChangedCallbackDelegate(ReorderableList list);
        public delegate bool CanRemoveCallbackDelegate(ReorderableList list);
        public delegate bool CanAddCallbackDelegate(ReorderableList list);
        public delegate void DragCallbackDelegate(ReorderableList list);
        public class Defaults
        {
            public GUIContent iconToolbarPlus;
            public GUIContent iconToolbarPlusMore;
            public GUIContent iconToolbarMinus;
            public readonly GUIStyle draggingHandle;
            public readonly GUIStyle headerBackground;
            public readonly GUIStyle emptyHeaderBackground;
            public readonly GUIStyle footerBackground;
            public readonly GUIStyle boxBackground;
            public readonly GUIStyle preButton;
            public readonly GUIStyle elementBackground;
            public const int padding = 6;
            public const int dragHandleWidth = 20;

            public Defaults();

            public void DrawFooter(Rect rect, ReorderableList list);
            public void DoAddButton(ReorderableList list);
            public void DoRemoveButton(ReorderableList list);
            public void DrawHeaderBackground(Rect headerRect);
            public void DrawHeader(Rect headerRect, SerializedObject serializedObject, SerializedProperty element, IList elementList);
            public void DrawElementBackground(Rect rect, int index, bool selected, bool focused, bool draggable);
            public void DrawElementDraggingHandle(Rect rect, int index, bool selected, bool focused, bool draggable);
            public void DrawElement(Rect rect, SerializedProperty element, object listItem, bool selected, bool focused, bool draggable);
            public void DrawElement(Rect rect, SerializedProperty element, object listItem, bool selected, bool focused, bool draggable, bool editable);
            public void DrawNoneElement(Rect rect, bool draggable);
            public void DrawOverMaxMultiEditElement(Rect rect, int maxMultiEditElementCount, bool draggable);
        }
    }
}
