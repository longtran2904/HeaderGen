#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Attacher
    {

        public Attacher(VisualElement anchored, VisualElement target, SpriteAlignment alignment);

        public VisualElement target { get; }
        public VisualElement element { get; }
        public SpriteAlignment alignment { get; set; }
        public Vector2 offset { get; set; }
        public float distance { get; set; }

        public void Detach();
        public void Reattach();
    }
}
