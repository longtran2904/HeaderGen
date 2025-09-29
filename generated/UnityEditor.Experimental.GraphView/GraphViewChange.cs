#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public struct GraphViewChange
    {
        public List<GraphElement> elementsToRemove;
        public List<Edge> edgesToCreate;
        public List<GraphElement> movedElements;
        public Vector2 moveDelta;
    }
}
