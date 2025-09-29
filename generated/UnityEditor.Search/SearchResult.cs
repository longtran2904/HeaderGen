#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    public readonly struct SearchResult : IComparable<SearchResult>, IEquatable<SearchResult>
    {

        public readonly string id;
        public readonly int index;
        public readonly int score;
        public static readonly SearchResult nil;

        public SearchResult(string id, int index, int score);
        public SearchResult(int index);
        public SearchResult(int index, int score);

        public bool valid { get; }

        public bool Equals(SearchResult other);
        public override int GetHashCode();
        public override bool Equals(object other);
        public int CompareTo(SearchResult other);
        public override string ToString();
    }
}
