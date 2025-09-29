#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine;

namespace UnityEditor.Search
{
    [DefaultMember("Item")]
    public class SearchItem : IComparable, IComparable<SearchItem>, IEquatable<SearchItem>
    {
        public readonly string id;
        public int score;
        public string label;
        public string description;
        public SearchItemOptions options;
        public Texture2D thumbnail;
        public Texture2D preview;
        public object data;
        public SearchProvider provider;
        public SearchContext context;
        [Obsolete("Use SearchItem.clear instead.", False)]
        public static readonly SearchItem none;

        public SearchItem(string _id);

        public static SearchItem clear { get; }

        public string GetLabel(SearchContext context, bool stripHTML = False);
        public string GetDescription(SearchContext context, bool stripHTML = False);
        public Texture2D GetThumbnail(SearchContext context, bool cacheThumbnail = False);
        public Texture2D GetPreview(SearchContext context, Vector2 size, FetchPreviewOptions options = FetchPreviewOptions.Normal, bool cacheThumbnail = False);
        public int CompareTo(SearchItem other);
        public int CompareTo(object other);
        public override bool Equals(object other);
        public override int GetHashCode();
        public bool Equals(SearchItem other);
        public override string ToString();
        public UnityEngine.Object ToObject();
        public UnityEngine.Object ToObject(Type type);
        public T ToObject<T>() where T : UnityEngine.Object;
        [Obsolete("This API will be removed", True)]
        public string ToGlobalId();
    }
}
