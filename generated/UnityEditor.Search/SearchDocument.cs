#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    public readonly struct SearchDocument : IComparable<SearchDocument>, IEquatable<SearchDocument>
    {
        public readonly string id;
        public readonly int score;

        public SearchDocument(string id, string name = null, string source = null, int score = 2147483647);
        public SearchDocument(SearchDocument doc, int score);
        public SearchDocument(SearchDocument doc, string path);
        [Obsolete("Search document index is no longer used and will be removed.", True)]
        public SearchDocument(int index, string id, string path = null, int score = 2147483647);

        [Obsolete("Search document index is no longer used and will be removed.", True)]
        public int index { get; }
        [Obsolete("Use name to get the document name and source to get the document source path.", True)]
        public string path { get; }
        public string name { get; }
        public string source { get; }
        public bool valid { get; }

        public override string ToString();
        public bool Equals(SearchDocument other);
        public override int GetHashCode();
        public override bool Equals(object other);
        public int CompareTo(SearchDocument other);
    }
}
