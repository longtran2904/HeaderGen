#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.SearchService
{
    public interface ISearchEngineBase
    {
        string name { get; }

        void BeginSession(ISearchContext context);
        void EndSession(ISearchContext context);
        void BeginSearch(ISearchContext context, string query);
        void EndSearch(ISearchContext context);
    }
}
