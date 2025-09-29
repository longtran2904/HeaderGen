#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Blackboard : GraphElement, ISelection
    {
        public Blackboard(GraphView associatedGraphView = null);

        public GraphView graphView { get; set; }
        public Action<Blackboard> addItemRequested { get; set; }
        public Action<Blackboard, int, VisualElement> moveItemRequested { get; set; }
        public Action<Blackboard, VisualElement, string> editTextRequested { get; set; }
        public List<ISelectable> selection { get; }
        public override string title { get; set; }
        public string subTitle { get; set; }
        public bool windowed { get; set; }
        public override VisualElement contentContainer { get; }
        public bool scrollable { get; set; }

        public virtual void AddToSelection(ISelectable selectable);
        public virtual void RemoveFromSelection(ISelectable selectable);
        public virtual void ClearSelection();
    }
}
