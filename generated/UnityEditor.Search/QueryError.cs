#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public class QueryError
    {
        public QueryError();
        public QueryError(int index, string reason);
        public QueryError(int index, int length, string reason);

        public int index { get; set; }
        public int length { get; set; }
        public string reason { get; set; }
    }
}
