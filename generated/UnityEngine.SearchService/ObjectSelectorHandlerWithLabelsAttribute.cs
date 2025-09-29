#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.SearchService
{
    [AttributeUsage(AttributeTargets.Field)]
    [Obsolete("ObjectSelectorHandlerWithLabelsAttribute has been deprecated. Use SearchContextAttribute instead.")]
    public class ObjectSelectorHandlerWithLabelsAttribute : Attribute
    {
        public ObjectSelectorHandlerWithLabelsAttribute(params string[] labels);
        public ObjectSelectorHandlerWithLabelsAttribute(bool matchAll, params string[] labels);

        public string[] labels { get; }
        public bool matchAll { get; }
    }
}
