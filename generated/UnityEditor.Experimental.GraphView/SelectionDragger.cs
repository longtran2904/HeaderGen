#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class SelectionDragger : Dragger
    {
        public SelectionDragger();

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
        protected void OnMouseDown(MouseDownEvent e);
        protected void OnMouseMove(MouseMoveEvent e);
        protected void OnMouseUp(MouseUpEvent evt);
    }
}
