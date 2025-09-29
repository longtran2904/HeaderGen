#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class TreeViewItem : IComparable<TreeViewItem>
    {

        public TreeViewItem();
        public TreeViewItem(int id);
        public TreeViewItem(int id, int depth);
        public TreeViewItem(int id, int depth, string displayName);

        public virtual int id { get; set; }
        public virtual string displayName { get; set; }
        public virtual int depth { get; set; }
        public virtual bool hasChildren { get; }
        public virtual List<TreeViewItem> children { get; set; }
        public virtual TreeViewItem parent { get; set; }
        public virtual Texture2D icon { get; set; }

        public void AddChild(TreeViewItem child);
        public virtual int CompareTo(TreeViewItem other);
        public override string ToString();
    }
}
