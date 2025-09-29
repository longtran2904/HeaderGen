#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class EdgeConnector<TEdge> : EdgeConnector where TEdge : Edge, new()
    {
        public EdgeConnector(IEdgeConnectorListener listener);

        public override EdgeDragHelper edgeDragHelper { get; }

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
        protected virtual void OnMouseDown(MouseDownEvent e);
        protected virtual void OnMouseMove(MouseMoveEvent e);
        protected virtual void OnMouseUp(MouseUpEvent e);
    }
}
