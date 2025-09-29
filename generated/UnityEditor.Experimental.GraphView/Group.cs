#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Experimental.GraphView
{
    public class Group : Scope, ICollectibleElement
    {

        public Group();

        public override string title { get; set; }

        public override bool AcceptsElement(GraphElement element, ref string reasonWhyNotAccepted);
        protected override void OnElementsAdded(IEnumerable<GraphElement> elements);
        protected override void OnElementsRemoved(IEnumerable<GraphElement> elements);
        public void FocusTitleTextField();
        protected virtual void OnGroupRenamed(string oldName, string newName);
        public void CollectElements(HashSet<GraphElement> collectedElementSet, Func<GraphElement, bool> conditionFunc);
    }
}
