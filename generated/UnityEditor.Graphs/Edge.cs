#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using UnityEngine;

namespace UnityEditor.Graphs
{
    public sealed class Edge
    {

        [SerializeField]
        public Color color;

        public Edge(Slot fromSlot, Slot toSlot);

        public Slot fromSlot { get; set; }
        public Slot toSlot { get; set; }
        public string fromSlotName { get; set; }
        public string toSlotName { get; set; }

        public override string ToString();
    }
}
