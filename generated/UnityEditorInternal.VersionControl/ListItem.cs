#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.VersionControl;
using UnityEngine;

namespace UnityEditorInternal.VersionControl
{
    public class ListItem
    {
        public ListItem();

        ~ListItem();

        public Texture Icon { get; set; }
        public int Identifier { get; }
        public string Name { get; set; }
        public int Indent { get; set; }
        public object Item { get; set; }
        public Asset Asset { get; set; }
        public ChangeSet Change { get; set; }
        public bool Expanded { get; set; }
        public bool Exclusive { get; set; }
        public bool Dummy { get; set; }
        public bool Hidden { get; set; }
        public bool HasChildren { get; }
        public bool HasActions { get; }
        public string[] Actions { get; set; }
        public bool CanExpand { get; }
        public bool CanAccept { get; set; }
        public int OpenCount { get; }
        public int ChildCount { get; }
        public ListItem Parent { get; }
        public ListItem FirstChild { get; }
        public ListItem LastChild { get; }
        public ListItem Prev { get; }
        public ListItem Next { get; }
        public ListItem PrevOpen { get; }
        public ListItem NextOpen { get; }
        public ListItem PrevOpenSkip { get; }
        public ListItem NextOpenSkip { get; }
        public ListItem PrevOpenVisible { get; }
        public ListItem NextOpenVisible { get; }

        public bool HasPath();
        public bool IsChildOf(ListItem listItem);
        public void Clear();
        public void Add(ListItem listItem);
        public bool Remove(ListItem listItem);
        public void RemoveAll();
        public ListItem FindWithIdentifierRecurse(int inIdentifier);
    }
}
