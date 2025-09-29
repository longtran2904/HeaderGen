#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class RectangleSelector : MouseManipulator
    {
        public RectangleSelector();

        public Rect ComputeAxisAlignedBound(Rect position, Matrix4x4 transform);
        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
    }
}
