#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Graphs
{
    public class Slot
    {

        public SlotType type;
        [NonSerialized]
        public List<Edge> edges;

        public Slot();
        public Slot(SlotType type);
        public Slot(SlotType type, string name);
        public Slot(SlotType type, string name, Type dataType);
        public Slot(SlotType type, string name, string title);
        public Slot(SlotType type, string name, string title, Type dataType);

        public string name { get; set; }
        public string title { get; set; }
        public Node node { get; set; }
        public Type dataType { get; set; }
        public string dataTypeString { get; }
        public bool isFlowSlot { get; }
        public bool isDataSlot { get; }
        public bool isInputDataSlot { get; }
        public bool isOutputDataSlot { get; }
        public bool isInputSlot { get; }
        public bool isOutputSlot { get; }
        public bool isGeneric { get; }
        public bool isTarget { get; }

        public void SetGenericArgumentType(Type type);
        public void ResetGenericArgumentType();
        public void RemoveEdge(Edge e);
        public void AddEdge(Edge e);
        public Property GetProperty();
        public override string ToString();
    }
}
