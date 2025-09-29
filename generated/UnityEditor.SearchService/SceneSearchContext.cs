#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.SearchService
{
    public class SceneSearchContext : ISearchContext
    {

        public SceneSearchContext();

        public Guid guid { get; }
        public SearchEngineScope engineScope { get; protected set; }
        public IEnumerable<Type> requiredTypes { get; set; }
        public IEnumerable<string> requiredTypeNames { get; set; }
        public HierarchyProperty rootProperty { get; set; }
    }
}
