#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public struct SearchWindowContext
    {
        public SearchWindowContext(Vector2 screenMousePosition, float requestedWidth = 0, float requestedHeight = 0);

        public Vector2 screenMousePosition { get; }
        public float requestedWidth { get; }
        public float requestedHeight { get; }
    }
}
