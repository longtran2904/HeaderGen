#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Scope : GraphElement
    {

        public Scope();

        public bool autoUpdateGeometry { get; set; }
        public VisualElement headerContainer { get; }
        public IEnumerable<GraphElement> containedElements { get; }
        public Rect containedElementsRect { get; }

        public override bool HitTest(Vector2 localPoint);
        public override bool Overlaps(Rect rectangle);
        public bool ContainsElement(GraphElement element);
        public virtual bool AcceptsElement(GraphElement element, ref string reasonWhyNotAccepted);
        public void AddElements(IEnumerable<GraphElement> elements);
        public void AddElement(GraphElement element);
        protected virtual void OnElementsAdded(IEnumerable<GraphElement> elements);
        public void RemoveElementsWithoutNotification(IEnumerable<GraphElement> elements);
        public void RemoveElements(IEnumerable<GraphElement> elements);
        public void RemoveElement(GraphElement element);
        protected virtual void OnElementsRemoved(IEnumerable<GraphElement> elements);
        protected void ScheduleUpdateGeometryFromContent();
        public void UpdateGeometryFromContent();
        public override Rect GetPosition();
        public override void SetPosition(Rect newPos);
        protected virtual void SetScopePositionOnly(Rect newPos);
        public override void UpdatePresenterPosition();
    }
}
