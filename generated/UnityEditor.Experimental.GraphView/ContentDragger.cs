#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class ContentDragger : MouseManipulator
    {

        public ContentDragger();

        public Vector2 panSpeed { get; set; }
        public bool clampToParentEdges { get; set; }

        protected Rect CalculatePosition(float x, float y, float width, float height);
        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
        protected void OnMouseDown(MouseDownEvent e);
        protected void OnMouseMove(MouseMoveEvent e);
        protected void OnMouseUp(MouseUpEvent e);
    }
}
