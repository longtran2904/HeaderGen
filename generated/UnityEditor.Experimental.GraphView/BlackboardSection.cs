#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class BlackboardSection : GraphElement
    {

        public BlackboardSection();

        public CanAcceptDropDelegate canAcceptDrop { get; set; }
        public override VisualElement contentContainer { get; }
        public override string title { get; set; }
        public bool headerVisible { get; set; }

        public bool CanAcceptDrop(List<ISelectable> selection);
        public delegate bool CanAcceptDropDelegate(ISelectable selected);
    }
}
