#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Gizmos/GizmoUtil.h")]
    [NativeHeader("Editor/Src/Selection.h")]
    [NativeHeader("Editor/Src/SceneInspector.h")]
    [NativeHeader("Editor/Src/Selection.bindings.h")]
    public sealed class Selection
    {

        public static Action selectionChanged;

        public Selection();

        public static Transform[] transforms { get; }
        public static Transform activeTransform { get; set; }
        public static GameObject[] gameObjects { get; }
        public static GameObject activeGameObject { get; set; }
        public static UnityEngine.Object activeObject { get; set; }
        public static UnityEngine.Object activeContext { get; }
        [NativeName("ActiveID")]
        [StaticAccessor("Selection", StaticAccessorType.DoubleColon)]
        public static int activeInstanceID { get; set; }
        [StaticAccessor("SelectionBindings", StaticAccessorType.DoubleColon)]
        public static UnityEngine.Object[] objects { get; set; }
        [StaticAccessor("SelectionBindings", StaticAccessorType.DoubleColon)]
        public static int[] instanceIDs { get; set; }
        [StaticAccessor("SelectionBindings", StaticAccessorType.DoubleColon)]
        public static string[] assetGUIDs { get; }
        [NativeName("SelectionCount")]
        [StaticAccessor("Selection", StaticAccessorType.DoubleColon)]
        public static int count { get; }

        [NativeMethod("IsSelected")]
        [StaticAccessor("GetSceneTracker()", StaticAccessorType.Dot)]
        public static bool Contains(int instanceID);
        [NativeMethod("SetActiveObjectWithContextInternal", True)]
        public static void SetActiveObjectWithContext(UnityEngine.Object obj, UnityEngine.Object context);
        [NativeMethod("GetTransformSelection", True)]
        public static Transform[] GetTransforms(SelectionMode mode);
        public static bool Contains(UnityEngine.Object obj);
        public static T[] GetFiltered<T>(SelectionMode mode);
        public static UnityEngine.Object[] GetFiltered(Type type, SelectionMode mode);
    }
}
