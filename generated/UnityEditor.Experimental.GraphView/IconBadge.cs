#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class IconBadge : VisualElement
    {
        public IconBadge();
        public IconBadge(VisualTreeAsset template);

        protected SpriteAlignment alignment { get; set; }
        protected VisualElement target { get; set; }
        public string badgeText { get; set; }
        public string visualStyle { get; set; }
        public int distance { get; set; }

        public static IconBadge CreateError(string message);
        public static IconBadge CreateComment(string message);
        public void AttachTo(VisualElement target, SpriteAlignment align);
        public void Detach();
        protected override void ExecuteDefaultAction(EventBase evt);
    }
}
