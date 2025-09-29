#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class EdgeManipulator : MouseManipulator
    {

        public EdgeManipulator();

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
        protected void OnMouseDown(MouseDownEvent evt);
        protected void OnMouseMove(MouseMoveEvent evt);
        protected void OnMouseUp(MouseUpEvent evt);
        protected void OnKeyDown(KeyDownEvent evt);
    }
}
