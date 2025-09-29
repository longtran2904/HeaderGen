#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class Port : GraphElement
    {
        protected EdgeConnector m_EdgeConnector;
        protected VisualElement m_ConnectorBox;
        protected Label m_ConnectorText;
        protected VisualElement m_ConnectorBoxCap;
        protected GraphView m_GraphView;

        protected Port(Orientation portOrientation, Direction portDirection, Capacity portCapacity, Type type);

        public override bool showInMiniMap { get; }
        public bool allowMultiDrag { get; set; }
        public string portName { get; set; }
        public bool portCapLit { get; set; }
        public Direction direction { get; }
        public Orientation orientation { get; }
        public Capacity capacity { get; }
        public string visualClass { get; set; }
        public Type portType { get; set; }
        public EdgeConnector edgeConnector { get; }
        public object source { get; set; }
        public bool highlight { get; set; }
        public virtual IEnumerable<Edge> connections { get; }
        public virtual bool connected { get; }
        public virtual bool collapsed { get; }
        public Color portColor { get; set; }
        public Color disabledPortColor { get; }
        public Node node { get; }

        public virtual void OnStartEdgeDragging();
        public virtual void OnStopEdgeDragging();
        public Edge ConnectTo(Port other);
        public T ConnectTo<T>(Port other) where T : Edge, new();
        public virtual void Connect(Edge edge);
        public virtual void Disconnect(Edge edge);
        public virtual void DisconnectAll();
        public static Port Create<TEdge>(Orientation orientation, Direction direction, Capacity capacity, Type type) where TEdge : Edge, new();
        public override Vector3 GetGlobalCenter();
        public override bool ContainsPoint(Vector2 localPoint);
        protected override void ExecuteDefaultAction(EventBase evt);
        protected override void OnCustomStyleResolved(ICustomStyle styles);

        public enum Capacity
        {
            Single = 0,
            Multi = 1
        }
    }
}
