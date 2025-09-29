#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Internal;

namespace UnityEditor.Search
{
    public class SearchColumn : IEquatable<SearchColumn>, ISerializationCallbackReceiver
    {
        public string path;
        public string provider;
        public string selector;
        public float width;
        public SearchColumnFlags options;
        public GUIContent content;

        public GetterEntry getter { get; set; }
        public SetterEntry setter { get; set; }
        public DrawEntry drawer { get; set; }
        public CompareEntry comparer { get; set; }
        public string name { get; }

        public override string ToString();
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(SearchColumn other);
        [ExcludeFromDocs]
        public void OnBeforeSerialize();
        [ExcludeFromDocs]
        public void OnAfterDeserialize();

        public delegate object GetterEntry(SearchColumnEventArgs args);
        public delegate void SetterEntry(SearchColumnEventArgs args);
        public delegate object DrawEntry(SearchColumnEventArgs args);
        public delegate int CompareEntry(SearchColumnCompareArgs args);
    }
}
