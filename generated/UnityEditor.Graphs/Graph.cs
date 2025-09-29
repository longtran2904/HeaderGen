#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace UnityEditor.Graphs
{
    [DefaultMember("Item")]
    public class Graph : ScriptableObject
    {

        [SerializeField]
        public List<Node> nodes;
        [SerializeField]
        public List<Edge> edges;

        public Graph();

        public Node this[string name] { get; }
        protected bool isAwake { get; }

        public virtual bool CanConnect(Slot fromSlot, Slot toSlot);
        public virtual bool Connected(Slot fromSlot, Slot toSlot);
        public virtual Edge Connect(Slot fromSlot, Slot toSlot);
        public virtual void RemoveEdge(Edge e);
        public virtual void AddNode(Node node);
        public virtual void AddNodes(params Node[] nodes);
        public virtual void Clear(bool destroyNodes = False);
        public virtual void RemoveNodes(List<Node> nodesToRemove, bool destroyNodes = False);
        public virtual void RemoveNode(Node node, bool destroyNode = False);
        public virtual void DestroyNode(Node node);
        public Node GetNodeByName(string name);
        public virtual void OnEnable();
        public void WakeUp();
        public virtual void WakeUp(bool force);
        public void WakeUpEdges(bool clearSlotEdges);
        public void RevalidateInputDataEdges(Slot s);
        public void RevalidateOutputDataEdges(Slot s);
        protected virtual void WakeUpNodes();
        public override string ToString();
        public static Graph FlattenedCopy(Graph source);
        public void RedirectSlotEdges(Node node, string oldSlotName, string newSlotName);
        public virtual void Dirty();
        public void RemoveInvalidEdgesForSlot(Slot slot);
    }
}
