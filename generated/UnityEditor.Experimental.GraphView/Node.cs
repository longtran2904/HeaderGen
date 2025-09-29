#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Node : GraphElement, ICollectibleElement
    {

        protected readonly VisualElement m_CollapseButton;
        protected readonly VisualElement m_ButtonContainer;

        public Node();
        public Node(string uiFile);

        public VisualElement mainContainer { get; }
        public VisualElement titleContainer { get; }
        public VisualElement inputContainer { get; }
        public VisualElement outputContainer { get; }
        public VisualElement titleButtonContainer { get; }
        public VisualElement topContainer { get; }
        public VisualElement extensionContainer { get; }
        public virtual bool expanded { get; set; }
        public override string title { get; set; }

        public void RefreshExpandedState();
        public override Rect GetPosition();
        public override void SetPosition(Rect newPos);
        protected virtual void OnPortRemoved(Port port);
        public virtual Port InstantiatePort(Orientation orientation, Direction direction, Port.Capacity capacity, Type type);
        public bool RefreshPorts();
        protected virtual void ToggleCollapse();
        protected void UseDefaultStyling();
        public virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
        public virtual void CollectElements(HashSet<GraphElement> collectedElementSet, Func<GraphElement, bool> conditionFunc);
    }
}
