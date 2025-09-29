#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Undo/UndoManager.h")]
    [NativeHeader("Editor/Src/Undo/ObjectUndo.h")]
    [NativeHeader("Editor/Mono/Undo/Undo.bindings.h")]
    [NativeHeader("Editor/Src/Undo/Undo.h")]
    [NativeHeader("Editor/Src/Undo/AssetUndo.h")]
    [NativeHeader("Editor/Src/Undo/PropertyUndoManager.h")]
    public class Undo
    {
        public static UndoRedoCallback undoRedoPerformed;
        public static WillFlushUndoRecord willFlushUndoRecord;
        public static PostprocessModifications postprocessModifications;

        public Undo();

        public static void RegisterCompleteObjectUndo(UnityEngine.Object objectToUndo, string name);
        public static void RegisterCompleteObjectUndo(UnityEngine.Object[] objectsToUndo, string name);
        public static void SetTransformParent(Transform transform, Transform newParent, string name);
        [FreeFunction("SetTransformParentUndo")]
        public static void SetTransformParent([NotNull("NullExceptionObject")] Transform transform, Transform newParent, bool worldPositionStays, string name);
        [NativeThrows]
        [StaticAccessor("UndoBindings", StaticAccessorType.DoubleColon)]
        public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene, string name);
        public static void RegisterCreatedObjectUndo(UnityEngine.Object objectToUndo, string name);
        public static void DestroyObjectImmediate(UnityEngine.Object objectToUndo);
        [NativeThrows]
        [StaticAccessor("UndoBindings", StaticAccessorType.DoubleColon)]
        public static Component AddComponent([NotNull("ArgumentNullException")] GameObject gameObject, Type type);
        public static T AddComponent<T>(GameObject gameObject) where T : Component;
        [StaticAccessor("UndoBindings", StaticAccessorType.DoubleColon)]
        public static void RegisterImporterUndo(string path, string name);
        [FreeFunction("RegisterChildrenOrderUndo")]
        public static void RegisterChildrenOrderUndo([NotNull("ArgumentNullException")] UnityEngine.Object objectToUndo, string name);
        [FreeFunction("RegisterFullObjectHierarchyUndo")]
        public static void RegisterFullObjectHierarchyUndo([NotNull("ArgumentNullException")] UnityEngine.Object objectToUndo, string name);
        [Obsolete("Use Undo.RegisterFullObjectHierarchyUndo(Object, string) instead")]
        public static void RegisterFullObjectHierarchyUndo(UnityEngine.Object objectToUndo);
        [FreeFunction("RecordUndoDiff")]
        public static void RecordObject(UnityEngine.Object objectToUndo, string name);
        public static void RecordObjects(UnityEngine.Object[] objectsToUndo, string name);
        [NativeMethod("ClearUndoIdentifier")]
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void ClearUndo(UnityEngine.Object identifier);
        [NativeMethod("Undo")]
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void PerformUndo();
        [NativeMethod("Redo")]
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void PerformRedo();
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void IncrementCurrentGroup();
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static int GetCurrentGroup();
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static string GetCurrentGroupName();
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void SetCurrentGroupName(string name);
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void RevertAllInCurrentGroup();
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void RevertAllDownToGroup(int group);
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void CollapseUndoOperations(int groupIndex);
        [StaticAccessor("GetUndoManager()", StaticAccessorType.Dot)]
        public static void ClearAll();
        [Obsolete("Use Undo.RegisterCompleteObjectUndo instead")]
        public static void RegisterUndo(UnityEngine.Object objectToUndo, string name);
        [Obsolete("Use Undo.RegisterCompleteObjectUndo instead")]
        public static void RegisterUndo(UnityEngine.Object[] objectsToUndo, string name);
        [NativeMethod("Flush")]
        [StaticAccessor("GetPropertyUndoManager()", StaticAccessorType.Dot)]
        public static void FlushUndoRecordObjects();
        [Obsolete("Use Undo.RecordObject instead")]
        public static void SetSnapshotTarget(UnityEngine.Object objectToUndo, string name);
        [Obsolete("Use Undo.RecordObject instead")]
        public static void SetSnapshotTarget(UnityEngine.Object[] objectsToUndo, string name);
        [Obsolete("Use Undo.RecordObject instead")]
        public static void ClearSnapshotTarget();
        [Obsolete("Use Undo.RecordObject instead")]
        public static void CreateSnapshot();
        [Obsolete("Use Undo.RecordObject instead")]
        public static void RestoreSnapshot();
        [Obsolete("Use Undo.RecordObject instead")]
        public static void RegisterSnapshot();
        [Obsolete("Use DestroyObjectImmediate, RegisterCreatedObjectUndo or RegisterUndo instead.")]
        public static void RegisterSceneUndo(string name);

        public delegate void UndoRedoCallback();
        public delegate void WillFlushUndoRecord();
        public delegate UndoPropertyModification[] PostprocessModifications(UndoPropertyModification[] modifications);
    }
}
