#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class EdgeControl : VisualElement
    {

        public const float k_MinEdgeWidth = 1.75F;

        public EdgeControl();

        public Orientation inputOrientation { get; set; }
        public Orientation outputOrientation { get; set; }
        [Obsolete("Use inputColor and/or outputColor")]
        public Color edgeColor { get; set; }
        public Color inputColor { get; set; }
        public Color outputColor { get; set; }
        public Color fromCapColor { get; set; }
        public Color toCapColor { get; set; }
        public float capRadius { get; set; }
        public int edgeWidth { get; set; }
        public float interceptWidth { get; set; }
        public Vector2 from { get; set; }
        public Vector2 to { get; set; }
        public Vector2[] controlPoints { get; }
        public bool drawFromCap { get; set; }
        public bool drawToCap { get; set; }

        public override bool ContainsPoint(Vector2 localPoint);
        public override bool Overlaps(Rect rect);
        protected virtual void PointsChanged();
        public virtual void UpdateLayout();
        protected virtual void UpdateRenderPoints();
        protected virtual void ComputeControlPoints();
    }
}
