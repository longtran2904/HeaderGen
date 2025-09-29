#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    public class SearchSelectorAttribute : Attribute
    {
        public SearchSelectorAttribute(string pattern, int priority = 100, string provider = null, bool printable = True);
    }
}
