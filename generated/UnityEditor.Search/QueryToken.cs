#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public readonly struct QueryToken
    {

        public QueryToken(string text, int position);
        public QueryToken(string text, int position, int length);

        public string text { get; }
        public int position { get; }
        public int length { get; }
    }
}
