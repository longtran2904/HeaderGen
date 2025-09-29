#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Graphs
{
    public class GroupNode : Node
    {

        public GroupNode();

        public Graph subGraph { get; }

        public override void NodeUI(GraphGUI host);
        public void AddChildNode(Node node);
        public void DestroyChildNode(Node node);
        public static GroupNode FromNodes(string name, List<Node> nodes, Type graphType);
        public void UnGroup();
        public override string ToString();
    }
}
