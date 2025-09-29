#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Editor/Src/Undo/PropertyUndoManager.h")]
    [NativeHeader("Editor/Src/Animation/AnimationModeSnapshot.h")]
    public struct DrivenRectTransformTracker
    {

        public static void StopRecordingUndo();
        public static void StartRecordingUndo();
        public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties);
        [Obsolete("revertValues parameter is ignored. Please use Clear() instead.")]
        public void Clear(bool revertValues);
        public void Clear();
    }
}
