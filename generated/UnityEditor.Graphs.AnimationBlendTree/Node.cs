#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace UnityEditor.Graphs.AnimationBlendTree
{
    public class Node : UnityEditor.Graphs.Node
    {

        public List<Node> children;
        public Motion motion;
        public float weight;

        public Node();

        public bool controllerDirty { get; }
        public BlendTree blendTree { get; }
        public Animator animator { get; }
        public Node parent { get; set; }
        public int childIndex { get; }
        public bool isLeaf { get; }
        public Color weightColor { get; }
        public Color weightEdgeColor { get; }

        public void CreateParameters();
        protected virtual void ControllerDirty();
        public void UpdateAnimator();
    }
}
