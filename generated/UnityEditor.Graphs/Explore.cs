#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

namespace UnityEditor.Graphs
{
    public sealed class Explore
    {
        public static event SearchHandler OnDiscoverNode;
        public static event SearchHandler OnDiscoverEdge;

        public static void Traverse(Node v, SearchDirection direction);

        public struct SearchEvent
        {
            public Node node;
            public Edge edge;

            public SearchEvent(Node n, Edge e);
        }
        public delegate void SearchHandler(SearchEvent e);
        public enum SearchDirection
        {
            Forward = 0,
            Backward = 1
        }
    }
}
