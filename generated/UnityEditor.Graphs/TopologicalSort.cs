#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Graphs
{
    public sealed class TopologicalSort
    {
        public static List<Node> SortedNodes { get; }
        public static IEnumerable<Node> deadNodes { get; }

        public static void Sort(Graph g);
    }
}
