#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomObjectIndexerAttribute : Attribute
    {

        public CustomObjectIndexerAttribute(Type type);

        public Type type { get; }
        public int version { get; set; }
    }
}
