#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Platform/Interface/DragAndDrop.h")]
    [StaticAccessor("GetDragAndDrop()", StaticAccessorType.Dot)]
    public class DragAndDrop
    {
        public DragAndDrop();

        public static UnityEngine.Object[] objectReferences { get; set; }
        public static string[] paths { get; set; }
        public static int activeControlID { get; set; }
        public static DragAndDropVisualMode visualMode { get; set; }

        public static void PrepareStartDrag();
        public static void StartDrag(string title);
        public static object GetGenericData(string type);
        public static void SetGenericData(string type, object data);
        public static void AcceptDrag();
        public static bool HasHandler(int dropDstId, Delegate handler);
        public static void AddDropHandler(ProjectBrowserDropHandler handler);
        public static void AddDropHandler(SceneDropHandler handler);
        public static void AddDropHandler(HierarchyDropHandler handler);
        public static void AddDropHandler(InspectorDropHandler handler);
        public static void RemoveDropHandler(ProjectBrowserDropHandler handler);
        public static void RemoveDropHandler(SceneDropHandler handler);
        public static void RemoveDropHandler(HierarchyDropHandler handler);
        public static void RemoveDropHandler(InspectorDropHandler handler);

        public delegate DragAndDropVisualMode ProjectBrowserDropHandler(int dragInstanceId, string dropUponPath, bool perform);
        public delegate DragAndDropVisualMode SceneDropHandler(UnityEngine.Object dropUpon, Vector3 worldPosition, Vector2 viewportPosition, Transform parentForDraggedObjects, bool perform);
        public delegate DragAndDropVisualMode InspectorDropHandler(UnityEngine.Object[] targets, bool perform);
        public delegate DragAndDropVisualMode HierarchyDropHandler(int dropTargetInstanceID, HierarchyDropFlags dropMode, Transform parentForDraggedObjects, bool perform);
    }
}
