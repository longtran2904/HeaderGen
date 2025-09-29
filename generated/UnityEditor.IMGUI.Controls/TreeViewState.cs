#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class TreeViewState
    {

        public Vector2 scrollPos;

        public TreeViewState();

        public List<int> selectedIDs { get; set; }
        public int lastClickedID { get; set; }
        public List<int> expandedIDs { get; set; }
        public string searchString { get; set; }
    }
}
