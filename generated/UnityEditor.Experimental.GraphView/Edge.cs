#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Edge : GraphElement
    {
        public Edge();

        public bool isGhostEdge { get; set; }
        public Port output { get; set; }
        public override bool showInMiniMap { get; }
        public Port input { get; set; }
        public EdgeControl edgeControl { get; }
        public Vector2 candidatePosition { get; set; }
        public int edgeWidth { get; }
        public Color selectedColor { get; }
        public Color defaultColor { get; }
        public Color ghostColor { get; }
        protected Vector2[] PointsAndTangents { get; }

        public override bool Overlaps(Rect rectangle);
        public override bool ContainsPoint(Vector2 localPoint);
        public virtual void OnPortChanged(bool isInput);
        public virtual bool UpdateEdgeControl();
        protected virtual void DrawEdge();
        protected override void OnCustomStyleResolved(ICustomStyle styles);
        public override void OnSelected();
        public override void OnUnselected();
        protected virtual EdgeControl CreateEdgeControl();
    }
}
