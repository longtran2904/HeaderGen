#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{
    public class ObjectSelectorSearchContext : ISearchContext
    {
        public ObjectSelectorSearchContext();

        [Obsolete("selectorConstraint has been deprecated.")]
        public Func<ObjectSelectorTargetInfo, UnityEngine.Object[], ObjectSelectorSearchContext, bool> selectorConstraint { get; set; }
        public Guid guid { get; }
        public SearchEngineScope engineScope { get; protected set; }
        public UnityEngine.Object currentObject { get; set; }
        public UnityEngine.Object[] editedObjects { get; set; }
        public IEnumerable<Type> requiredTypes { get; set; }
        public IEnumerable<string> requiredTypeNames { get; set; }
        public VisibleObjects visibleObjects { get; set; }
        public IEnumerable<int> allowedInstanceIds { get; set; }
    }
}
