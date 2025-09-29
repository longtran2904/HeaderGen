#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public abstract class GraphViewToolWindow : EditorWindow
    {

        protected VisualElement m_ToolbarContainer;
        protected GraphView m_SelectedGraphView;

        protected GraphViewToolWindow();

        protected abstract string ToolName { get; }

        public override IEnumerable<Type> GetExtraPaneTypes();
        public void SelectGraphViewFromWindow(GraphViewEditorWindow window, GraphView graphView, int graphViewIndexInWindow = 0);
        protected void OnEnable();
        protected abstract void OnGraphViewChanging();
        protected abstract void OnGraphViewChanged();
        protected virtual bool IsGraphViewSupported(GraphView gv);
    }
}
