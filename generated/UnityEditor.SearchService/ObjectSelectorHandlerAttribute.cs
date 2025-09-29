#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.SearchService
{
    [AttributeUsage(AttributeTargets.Method)]
    [Obsolete("ObjectSelectorHandlerAttribute has been deprecated. Use SearchContextAttribute instead.")]
    public class ObjectSelectorHandlerAttribute : Attribute
    {
        public ObjectSelectorHandlerAttribute(Type attributeType);

        public Type attributeType { get; }
    }
}
