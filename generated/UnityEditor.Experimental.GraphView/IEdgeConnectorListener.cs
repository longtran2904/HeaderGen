#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public interface IEdgeConnectorListener
    {

        void OnDropOutsidePort(Edge edge, Vector2 position);
        void OnDrop(GraphView graphView, Edge edge);
    }
}
