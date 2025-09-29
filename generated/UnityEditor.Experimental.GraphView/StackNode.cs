#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class StackNode : Node, IDropTarget
    {

        public StackNode();

        public VisualElement headerContainer { get; }
        public override VisualElement contentContainer { get; }
        protected bool dragEntered { get; }
        public Func<GraphElement, VisualElement> dropPreviewTemplate { get; set; }
        protected virtual bool hasMultipleSelectionSupport { get; }

        protected override void ExecuteDefaultAction(EventBase evt);
        protected virtual bool AcceptsElement(GraphElement element, ref int proposedIndex, int maxIndex);
        public void AddElement(GraphElement element);
        public void InsertElement(int index, GraphElement element);
        public void RemoveElement(GraphElement element);
        protected override void OnCustomStyleResolved(ICustomStyle styles);
        protected virtual void OnSeparatorContextualMenuEvent(ContextualMenuPopulateEvent evt, int separatorIndex);
        public virtual int GetInsertionIndex(Vector2 worldPosition);
        public virtual void OnStartDragging(GraphElement ge);
        public override void CollectElements(HashSet<GraphElement> collectedElementSet, Func<GraphElement, bool> conditionFunc);
        public bool CanAcceptDrop(List<ISelectable> selection);
        public virtual bool DragExited();
        public virtual bool DragPerform(DragPerformEvent evt, IEnumerable<ISelectable> selection, IDropTarget dropTarget, ISelection dragSource);
        public virtual bool DragUpdated(DragUpdatedEvent evt, IEnumerable<ISelectable> selection, IDropTarget dropTarget, ISelection dragSource);
        public virtual bool DragEnter(DragEnterEvent evt, IEnumerable<ISelectable> selection, IDropTarget enteredTarget, ISelection dragSource);
        public virtual bool DragLeave(DragLeaveEvent evt, IEnumerable<ISelectable> selection, IDropTarget leftTarget, ISelection dragSource);
    }
}
