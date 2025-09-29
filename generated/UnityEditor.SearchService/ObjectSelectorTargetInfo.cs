#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.SearchService
{
    [Obsolete("ObjectSelectorTargetInfo has been deprecated.")]
    public struct ObjectSelectorTargetInfo
    {
        public ObjectSelectorTargetInfo(GlobalObjectId globalObjectId, UnityEngine.Object targetObject = null, Type type = null);

        public GlobalObjectId globalObjectId { get; }
        public UnityEngine.Object targetObject { get; }
        public Type type { get; }

        public UnityEngine.Object LoadObject();
    }
}
