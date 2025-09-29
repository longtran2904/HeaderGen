#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{
    public class SearchTreeEntry : IComparable<SearchTreeEntry>
    {

        public int level;
        public GUIContent content;
        public object userData;

        public SearchTreeEntry(GUIContent content);

        public string name { get; }

        public int CompareTo(SearchTreeEntry o);
    }
}
