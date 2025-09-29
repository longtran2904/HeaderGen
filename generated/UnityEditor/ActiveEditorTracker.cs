#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Utility/ActiveEditorTracker.bindings.h")]
    public sealed class ActiveEditorTracker
    {
        public ActiveEditorTracker();

        ~ActiveEditorTracker();

        public Editor[] activeEditors { get; }
        public bool isDirty { get; }
        public bool isLocked { get; set; }
        public InspectorMode inspectorMode { get; set; }
        public bool hasComponentsWhichCannotBeMultiEdited { get; }
        public static ActiveEditorTracker sharedTracker { get; }

        public override bool Equals(object o);
        public override int GetHashCode();
        public void Destroy();
        public int GetVisible(int index);
        public void SetVisible(int index, int visible);
        public void ClearDirty();
        public void RebuildIfNecessary();
        public void ForceRebuild();
        public void VerifyModifiedMonoBehaviours();
        [Obsolete("Use Editor.CreateEditor instead")]
        public static Editor MakeCustomEditor(UnityEngine.Object obj);
        public static bool HasCustomEditor(UnityEngine.Object obj);
    }
}
