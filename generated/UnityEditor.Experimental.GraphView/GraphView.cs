#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public abstract class GraphView : VisualElement, ISelection
    {
        public UQueryState<Port> ports;

        protected GraphView();

        public Action<NodeCreationContext> nodeCreationRequest { get; set; }
        public GraphViewChanged graphViewChanged { get; set; }
        public Action<Group, string> groupTitleChanged { get; set; }
        public Action<Group, IEnumerable<GraphElement>> elementsAddedToGroup { get; set; }
        public Action<Group, IEnumerable<GraphElement>> elementsRemovedFromGroup { get; set; }
        public Action<StackNode, int, IEnumerable<GraphElement>> elementsInsertedToStackNode { get; set; }
        public Action<StackNode, IEnumerable<GraphElement>> elementsRemovedFromStackNode { get; set; }
        public ElementResized elementResized { get; set; }
        public ViewTransformChanged viewTransformChanged { get; set; }
        public virtual bool supportsWindowedBlackboard { get; }
        public VisualElement contentViewContainer { get; }
        public VisualElement viewport { get; }
        public ITransform viewTransform { get; }
        public bool isReframable { get; set; }
        public override VisualElement contentContainer { get; }
        public PlacematContainer placematContainer { get; }
        public UQueryState<GraphElement> graphElements { get; }
        public UQueryState<Node> nodes { get; }
        public UQueryState<Edge> edges { get; }
        public float minScale { get; }
        public float maxScale { get; }
        public float scaleStep { get; }
        public float referenceScale { get; }
        public float scale { get; }
        public int zoomerMaxElementCountWithPixelCacheRegen { get; set; }
        public List<ISelectable> selection { get; protected set; }
        protected internal virtual bool canCopySelection { get; }
        protected internal virtual bool canCutSelection { get; }
        protected internal virtual bool canPaste { get; }
        protected internal virtual bool canDuplicateSelection { get; }
        protected internal virtual bool canDeleteSelection { get; }
        public SerializeGraphElementsDelegate serializeGraphElements { get; set; }
        public CanPasteSerializedDataDelegate canPasteSerializedData { get; set; }
        public UnserializeAndPasteDelegate unserializeAndPaste { get; set; }
        public DeleteSelectionDelegate deleteSelection { get; set; }

        public void UpdateViewTransform(Vector3 newPosition, Vector3 newScale);
        public bool GetPortCenterOverride(Port port, out Vector2 overriddenPosition);
        public void AddLayer(int index);
        public GraphElement GetElementByGuid(string guid);
        public Node GetNodeByGuid(string guid);
        public Port GetPortByGuid(string guid);
        public Edge GetEdgeByGuid(string guid);
        public void SetupZoom(float minScaleSetup, float maxScaleSetup);
        public void SetupZoom(float minScaleSetup, float maxScaleSetup, float scaleStepSetup, float referenceScaleSetup);
        protected void ValidateTransform();
        public virtual void AddToSelection(ISelectable selectable);
        public virtual void RemoveFromSelection(ISelectable selectable);
        public virtual void ClearSelection();
        public virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected override void ExecuteDefaultAction(EventBase evt);
        public static void CollectElements(IEnumerable<GraphElement> elements, HashSet<GraphElement> collectedElementSet, Func<GraphElement, bool> conditionFunc);
        protected internal virtual void CollectCopyableGraphElements(IEnumerable<GraphElement> elements, HashSet<GraphElement> elementsToCopySet);
        protected internal void CopySelectionCallback();
        protected internal void CutSelectionCallback();
        protected internal void PasteCallback();
        protected internal void DuplicateSelectionCallback();
        protected internal void DeleteSelectionCallback(AskUser askUser);
        protected string SerializeGraphElements(IEnumerable<GraphElement> elements);
        protected bool CanPasteSerializedData(string data);
        protected void UnserializeAndPasteOperation(string operationName, string data);
        protected void DeleteSelectionOperation(string operationName, AskUser askUser);
        public virtual List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter);
        public void AddElement(GraphElement graphElement);
        public void RemoveElement(GraphElement graphElement);
        public virtual EventPropagation DeleteSelection();
        public void DeleteElements(IEnumerable<GraphElement> elementsToRemove);
        public EventPropagation FrameAll();
        public EventPropagation FrameSelection();
        public EventPropagation FrameOrigin();
        public EventPropagation FramePrev();
        public EventPropagation FrameNext();
        public EventPropagation FramePrev(Func<GraphElement, bool> predicate);
        public EventPropagation FrameNext(Func<GraphElement, bool> predicate);
        public virtual Rect CalculateRectToFitAll(VisualElement container);
        public static void CalculateFrameTransform(Rect rectToFit, Rect clientRect, int border, out Vector3 frameTranslation, out Vector3 frameScaling);
        public virtual Blackboard GetBlackboard();
        public virtual void ReleaseBlackboard(Blackboard toRelease);
        protected virtual PlacematContainer CreatePlacematContainer();

        public class Layer : VisualElement
        {
            public Layer();
        }
        public delegate GraphViewChange GraphViewChanged(GraphViewChange graphViewChange);
        public delegate void ElementResized(VisualElement visualElement);
        public delegate void ViewTransformChanged(GraphView graphView);
        public enum FrameType
        {
            All = 0,
            Selection = 1,
            Origin = 2
        }
        public enum AskUser
        {
            AskUser = 0,
            DontAskUser = 1
        }
        public delegate string SerializeGraphElementsDelegate(IEnumerable<GraphElement> elements);
        public delegate bool CanPasteSerializedDataDelegate(string data);
        public delegate void UnserializeAndPasteDelegate(string operationName, string data);
        public delegate void DeleteSelectionDelegate(string operationName, AskUser askUser);
    }
}
