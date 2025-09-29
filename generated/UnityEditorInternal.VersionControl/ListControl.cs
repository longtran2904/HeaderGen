#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{
    public class ListControl
    {
        public ListControl();

        ~ListControl();

        public ListState listState { get; }
        public ExpandDelegate ExpandEvent { get; set; }
        public DragDelegate DragEvent { get; set; }
        public ActionDelegate ActionEvent { get; set; }
        public ListItem Root { get; }
        public AssetList SelectedAssets { get; }
        public ChangeSets SelectedChangeSets { get; }
        public ChangeSets EmptyChangeSets { get; }
        public bool ReadOnly { get; set; }
        public string MenuFolder { get; set; }
        public string MenuDefault { get; set; }
        public bool DragAcceptOnly { get; set; }
        public int Size { get; }

        public static ListControl FromID(int id);
        public ListItem FindItemWithIdentifier(int identifier);
        public ListItem Add(ListItem parent, string name, Asset asset);
        public ListItem Add(ListItem parent, string name, ChangeSet change);
        public void Clear();
        public void Refresh();
        public void Refresh(bool updateExpanded);
        public void Sync();
        public bool OnGUI(Rect area, bool focus);
        public void SelectedSet(ListItem item);
        public void SelectedAll();
        public void SelectedAdd(ListItem item);

        public enum SelectDirection
        {
            Up = 0,
            Down = 1,
            Current = 2
        }
        public class ListState
        {
            [SerializeField]
            public float Scroll;
            [SerializeField]
            public List<string> Expanded;

            public ListState();
        }
        public delegate void ExpandDelegate(ChangeSet expand, ListItem item);
        public delegate void DragDelegate(ChangeSet target);
        public delegate void ActionDelegate(ListItem item, int actionIdx);
    }
}
