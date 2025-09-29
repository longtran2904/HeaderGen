#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

namespace UnityEditor
{
    [ExcludeFromObjectFactory]
    [NativeHeader("Editor/Src/ContainerWindow.bindings.h")]
    [UsedByNativeCode]
    public class EditorWindow : ScriptableObject
    {
        public EditorWindow();

        public VisualElement rootVisualElement { get; }
        public bool wantsMouseMove { get; set; }
        public bool wantsMouseEnterLeaveWindow { get; set; }
        public bool wantsLessLayoutEvents { get; set; }
        public bool autoRepaintOnSceneChange { get; set; }
        public bool maximized { get; set; }
        public bool hasFocus { get; }
        public bool docked { get; }
        public static EditorWindow focusedWindow { get; }
        public static EditorWindow mouseOverWindow { get; }
        public bool hasUnsavedChanges { get; protected set; }
        public string saveChangesMessage { get; protected set; }
        public Vector2 minSize { get; set; }
        public Vector2 maxSize { get; set; }
        [Obsolete("Use titleContent instead (it supports setting a title icon as well).")]
        public string title { get; set; }
        public GUIContent titleContent { get; set; }
        public int depthBufferBits { get; set; }
        [Obsolete("AA is not supported on EditorWindows", False)]
        public int antiAlias { get; set; }
        public Rect position { get; set; }

        public void BeginWindows();
        public void EndWindows();
        public void ShowNotification(GUIContent notification);
        public void ShowNotification(GUIContent notification, double fadeoutWait);
        public void RemoveNotification();
        public void ShowTab();
        public void Focus();
        public void ShowUtility();
        public void ShowPopup();
        public void ShowModalUtility();
        public void ShowAsDropDown(Rect buttonRect, Vector2 windowSize);
        public void Show();
        public void Show(bool immediateDisplay);
        public void ShowAuxWindow();
        public void ShowModal();
        public static EditorWindow GetWindow(Type t, [DefaultValue("false")] bool utility, [DefaultValue("null")] string title, [DefaultValue("true")] bool focus);
        [ExcludeFromDocs]
        public static EditorWindow GetWindow(Type t, bool utility, string title);
        [ExcludeFromDocs]
        public static EditorWindow GetWindow(Type t, bool utility);
        [ExcludeFromDocs]
        public static EditorWindow GetWindow(Type t);
        public static EditorWindow GetWindowWithRect(Type t, Rect rect, [DefaultValue("false")] bool utility, [DefaultValue("null")] string title);
        [ExcludeFromDocs]
        public static EditorWindow GetWindowWithRect(Type t, Rect rect, bool utility);
        [ExcludeFromDocs]
        public static EditorWindow GetWindowWithRect(Type t, Rect rect);
        public static T GetWindow<T>() where T : EditorWindow;
        public static T GetWindow<T>(bool utility) where T : EditorWindow;
        public static T GetWindow<T>(bool utility, string title) where T : EditorWindow;
        public static T GetWindow<T>(string title) where T : EditorWindow;
        public static T GetWindow<T>(string title, bool focus) where T : EditorWindow;
        public static T GetWindow<T>(bool utility, string title, bool focus) where T : EditorWindow;
        public static T GetWindow<T>(params Type[] desiredDockNextTo) where T : EditorWindow;
        public static T GetWindow<T>(string title, params Type[] desiredDockNextTo) where T : EditorWindow;
        public static T GetWindow<T>(string title, bool focus, params Type[] desiredDockNextTo) where T : EditorWindow;
        public static T CreateWindow<T>(params Type[] desiredDockNextTo) where T : EditorWindow;
        public static T CreateWindow<T>(string title, params Type[] desiredDockNextTo) where T : EditorWindow;
        public static bool HasOpenInstances<T>() where T : EditorWindow;
        public static void FocusWindowIfItsOpen(Type t);
        public static void FocusWindowIfItsOpen<T>() where T : EditorWindow;
        public static T GetWindowWithRect<T>(Rect rect) where T : EditorWindow;
        public static T GetWindowWithRect<T>(Rect rect, bool utility) where T : EditorWindow;
        public static T GetWindowWithRect<T>(Rect rect, bool utility, string title) where T : EditorWindow;
        public static T GetWindowWithRect<T>(Rect rect, bool utility, string title, bool focus) where T : EditorWindow;
        public virtual void SaveChanges();
        public virtual void DiscardChanges();
        public void Close();
        public void Repaint();
        public bool SendEvent(Event e);
        public virtual IEnumerable<Type> GetExtraPaneTypes();
        public bool TryGetOverlay(string id, out Overlay match);
        protected virtual void OnBackingScaleFactorChanged();
    }
}
