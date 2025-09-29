#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.SearchService
{
    public interface ISearchContext
    {

        Guid guid { get; }
        SearchEngineScope engineScope { get; }
        IEnumerable<Type> requiredTypes { get; }
        IEnumerable<string> requiredTypeNames { get; }
    }
}
