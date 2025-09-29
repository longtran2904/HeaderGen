#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Graphs
{
    public class EdgeGUI : IEdgeGUI
    {

        public EdgeStyle edgeStyle;
        public static readonly Color kFunctionEdgeColor;
        public static readonly Color kObjectTypeEdgeColor;
        public static readonly Color kSimpleTypeEdgeColor;

        public EdgeGUI();

        public List<int> edgeSelection { get; set; }
        public GraphGUI host { get; set; }

        public void DoEdges();
        public void DoDraggedEdge();
        public void BeginSlotDragging(Slot slot, bool allowStartDrag, bool allowEndDrag);
        public void SlotDragging(Slot slot, bool allowEndDrag, bool allowMultiple);
        public void EndSlotDragging(Slot slot, bool allowMultiple);
        public void EndDragging();
        public Edge FindClosestEdge();
        public enum EdgeStyle
        {

            Angular = 0,
            Curvy = 1
        }
    }
}
