#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class AdvancedDropdownItem : IComparable
    {
        public AdvancedDropdownItem(string name);

        public string name { get; set; }
        public Texture2D icon { get; set; }
        public int id { get; set; }
        public bool enabled { get; set; }
        public IEnumerable<AdvancedDropdownItem> children { get; }

        public void AddChild(AdvancedDropdownItem child);
        public virtual int CompareTo(object o);
        public void AddSeparator();
        public override string ToString();
    }
}
