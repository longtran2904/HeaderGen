#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Placemat : GraphElement
    {

        protected GraphView m_GraphView;

        public Placemat();

        public override string title { get; set; }
        public virtual int ZOrder { get; set; }
        public virtual Color Color { get; set; }
        public Vector2 UncollapsedSize { get; }
        public Vector2 CollapsedSize { get; }
        public Rect ExpandedPosition { get; }
        public IEnumerable<GraphElement> CollapsedElements { get; }
        public virtual bool Collapsed { get; set; }

        public override void SetPosition(Rect newPos);
        protected internal void SetCollapsedElements(IEnumerable<GraphElement> collapsedElements);
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
        public void StartEditTitle();
        public static bool ComputeElementBounds(ref Rect pos, List<GraphElement> elements, MinSizePolicy ensureMinSize = MinSizePolicy.EnsureMinSize);
        public enum MinSizePolicy
        {

            EnsureMinSize = 0,
            DoNotEnsureMinSize = 1
        }
    }
}
