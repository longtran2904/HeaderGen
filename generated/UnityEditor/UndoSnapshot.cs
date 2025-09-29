#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor
{
    [Obsolete("Use Undo.RecordObject before modifying the object instead")]
    public class UndoSnapshot
    {

        public UndoSnapshot(UnityEngine.Object[] objectsToUndo);

        public void Restore();
        public void Dispose();
    }
}
