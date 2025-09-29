#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class MiniMap : GraphElement
    {

        protected readonly Color m_SelectedChildrenColor;
        public Action<string> zoomFactorTextChanged;

        public MiniMap();

        public float maxHeight { get; set; }
        public float maxWidth { get; set; }
        public bool anchored { get; set; }
        public bool windowed { get; set; }
        public GraphView graphView { get; set; }

        public virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
        public void OnResized();
    }
}
