#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.SearchService
{
    [AttributeUsage(AttributeTargets.Field)]
    [Obsolete("ObjectSelectorHandlerWithTagsAttribute has been deprecated. Use SearchContextAttribute instead.")]
    public class ObjectSelectorHandlerWithTagsAttribute : Attribute
    {

        public ObjectSelectorHandlerWithTagsAttribute(params string[] tags);

        public string[] tags { get; }
    }
}
