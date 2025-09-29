#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class EdgeDragHelper<TEdge> : EdgeDragHelper where TEdge : Edge, new()
    {

        protected List<Port> m_CompatiblePorts;
        protected GraphView m_GraphView;
        protected readonly IEdgeConnectorListener m_Listener;
        protected static NodeAdapter s_nodeAdapter;

        public EdgeDragHelper(IEdgeConnectorListener listener);

        public bool resetPositionOnPan { get; set; }
        public override Edge edgeCandidate { get; set; }
        public override Port draggedPort { get; set; }

        public override void Reset(bool didConnect = False);
        public override bool HandleMouseDown(MouseDownEvent evt);
        public override void HandleMouseMove(MouseMoveEvent evt);
        public override void HandleMouseUp(MouseUpEvent evt);
    }
}
