#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Graphs
{
    public abstract class GraphGUI : ScriptableObject
    {

        [SerializeField]
        protected Vector2 m_ScrollPosition;
        protected bool m_CenterGraph;
        protected bool m_CenterGraphOnPosition;
        protected Vector2 m_CenterGraphPosition;
        public Rect m_GraphClientArea;
        protected Vector2? m_contextMenuMouseDownPosition;
        [SerializeField]
        protected Graph m_Graph;
        protected EditorWindow m_Host;
        protected IEdgeGUI m_EdgeGUI;
        public DrawSelectionRectCallback drawSelectionRectCallback;
        protected List<NodeTool> m_Tools;
        public List<Node> selection;
        protected const float kGraphPaddingMultiplier = 0.6F;
        protected const float kNodeGridSize = 10;

        protected GraphGUI();

        public Vector2 scrollPosition { get; }
        public float zoomLevel { get; }
        public Graph graph { get; set; }
        public virtual IEdgeGUI edgeGUI { get; }

        protected virtual Vector2 GetCenterPosition();
        public virtual void OnGraphGUI();
        public void BeginGraphGUI(EditorWindow host, Rect position);
        public void EndGraphGUI();
        protected virtual void OnScroll();
        protected void ShowContextMenu();
        protected Graph CopyNodesPasteboardData(out int[] ids);
        protected virtual void CopyNodesToPasteboard();
        protected virtual void PasteNodesPasteboardData(Graph dummyGraph);
        protected virtual void PasteNodesFromPasteboard();
        protected static void OffsetPastedNodePositions(IEnumerable<Node> nodes, Vector2? pastePosition);
        protected virtual void DuplicateNodesThroughPasteboard();
        protected void HandleMenuEvents();
        public void ZoomToGraph(Graph g);
        public virtual void NodeGUI(Node n);
        protected void DragNodes();
        protected static Rect SnapPositionToGrid(Rect position);
        protected static float CeilValueToGrid(float value);
        protected void SelectNode(Node node);
        protected virtual void UpdateUnitySelection();
        protected void DragSelection();
        public void LayoutSlot(Slot s, string title, bool allowStartDrag, bool allowEndDrag, bool allowMultiple, GUIStyle style);
        public void Slot(Rect position, string title, Slot s, bool allowStartDrag, bool allowEndDrag, bool allowMultiple, GUIStyle style);
        public virtual void OnNodeLibraryGUI(EditorWindow host, Rect position);
        public void BeginToolbarGUI(Rect position);
        public void EndToolbarGUI();
        public virtual void OnToolbarGUI();
        protected virtual void AddNode(Node node);
        public virtual void AddTools();
        public virtual void OnEnable();
        public void CenterGraph();
        public void CenterGraph(Vector2 center);
        public virtual void ClearSelection();
        public virtual void SyncGraphToUnitySelection(bool force = False);
        public virtual void DoBackgroundClickAction();
        public class NodeTool
        {

            public string category;
            public GUIContent content;
            public bool visible;
            public CreateNodeFuncDelegate createNodeFunc;

            public NodeTool(string category, string title, CreateNodeFuncDelegate createNodeFunc);
            public delegate Node CreateNodeFuncDelegate();
        }
        public delegate void DrawSelectionRectCallback(Rect selectionRect);
    }
}
