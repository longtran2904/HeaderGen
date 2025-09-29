#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public abstract class EdgeDragHelper
    {
        protected EdgeDragHelper();

        public abstract Edge edgeCandidate { get; set; }
        public abstract Port draggedPort { get; set; }

        public abstract bool HandleMouseDown(MouseDownEvent evt);
        public abstract void HandleMouseMove(MouseMoveEvent evt);
        public abstract void HandleMouseUp(MouseUpEvent evt);
        public abstract void Reset(bool didConnect = False);
    }
}
