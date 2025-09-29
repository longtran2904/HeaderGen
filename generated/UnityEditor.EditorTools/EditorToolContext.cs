#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.EditorTools
{
    public abstract class EditorToolContext : ScriptableObject, IEditor
    {
        protected EditorToolContext();

        public IEnumerable<UnityEngine.Object> targets { get; }
        public UnityEngine.Object target { get; }

        public virtual void OnActivated();
        public virtual void OnWillBeDeactivated();
        public virtual void OnToolGUI(EditorWindow window);
        public Type ResolveTool(Tool tool);
        protected virtual Type GetEditorToolType(Tool tool);
    }
}
