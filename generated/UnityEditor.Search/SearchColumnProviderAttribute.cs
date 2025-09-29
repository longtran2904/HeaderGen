#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    public class SearchColumnProviderAttribute : Attribute
    {
        public SearchColumnProviderAttribute(string provider);

        public string provider { get; }
    }
}
