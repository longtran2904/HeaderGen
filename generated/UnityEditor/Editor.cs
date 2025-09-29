#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

namespace UnityEditor
{
    [ExcludeFromObjectFactory]
    [NativeHeader("Editor/Mono/Inspector/ScriptBindings/Editor.bindings.h")]
    [RequiredByNativeCode]
    [StaticAccessor("EditorBindings", StaticAccessorType.DoubleColon)]
    public class Editor : ScriptableObject, IPreviewable, IToolModeOwner
    {
        public Editor();

        public UnityEngine.Object target { get; set; }
        public UnityEngine.Object[] targets { get; }
        public SerializedObject serializedObject { get; }

        public static event Action<Editor> finishedDefaultHeaderGUI;

        public static Editor CreateEditorWithContext(UnityEngine.Object[] targetObjects, UnityEngine.Object context, [DefaultValue("null")] Type editorType);
        [ExcludeFromDocs]
        public static Editor CreateEditorWithContext(UnityEngine.Object[] targetObjects, UnityEngine.Object context);
        public static void CreateCachedEditorWithContext(UnityEngine.Object targetObject, UnityEngine.Object context, Type editorType, ref Editor previousEditor);
        public static void CreateCachedEditorWithContext(UnityEngine.Object[] targetObjects, UnityEngine.Object context, Type editorType, ref Editor previousEditor);
        public static void CreateCachedEditor(UnityEngine.Object targetObject, Type editorType, ref Editor previousEditor);
        public static void CreateCachedEditor(UnityEngine.Object[] targetObjects, Type editorType, ref Editor previousEditor);
        [ExcludeFromDocs]
        public static Editor CreateEditor(UnityEngine.Object targetObject);
        public static Editor CreateEditor(UnityEngine.Object targetObject, [DefaultValue("null")] Type editorType);
        [ExcludeFromDocs]
        public static Editor CreateEditor(UnityEngine.Object[] targetObjects);
        public static Editor CreateEditor(UnityEngine.Object[] targetObjects, [DefaultValue("null")] Type editorType);
        protected internal static void DrawPropertiesExcluding(SerializedObject obj, params string[] propertyToExclude);
        public bool DrawDefaultInspector();
        public void Repaint();
        public virtual void OnInspectorGUI();
        public virtual VisualElement CreateInspectorGUI();
        public virtual bool RequiresConstantRepaint();
        public void DrawHeader();
        protected virtual void OnHeaderGUI();
        protected virtual bool ShouldHideOpenButton();
        public static void DrawFoldoutInspector(UnityEngine.Object target, ref Editor editor);
        public virtual bool HasPreviewGUI();
        public virtual GUIContent GetPreviewTitle();
        public virtual Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);
        public virtual void OnPreviewGUI(Rect r, GUIStyle background);
        public virtual void OnInteractivePreviewGUI(Rect r, GUIStyle background);
        public virtual void OnPreviewSettings();
        public virtual string GetInfoString();
        public virtual void DrawPreview(Rect previewArea);
        public virtual void ReloadPreviewInstances();
        public virtual bool UseDefaultMargins();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Initialize(UnityEngine.Object[] targets);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Cleanup();
        public bool MoveNextTarget();
        public void ResetTarget();
    }
}
