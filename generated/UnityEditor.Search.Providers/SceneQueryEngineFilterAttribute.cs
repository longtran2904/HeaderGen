#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search.Providers
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SceneQueryEngineFilterAttribute : QueryEngineFilterAttribute
    {
        public SceneQueryEngineFilterAttribute(string token, string[] supportedOperators = null);
        public SceneQueryEngineFilterAttribute(string token, StringComparison options, string[] supportedOperators = null);
        public SceneQueryEngineFilterAttribute(string token, string paramTransformerFunction, string[] supportedOperators = null);
        public SceneQueryEngineFilterAttribute(string token, string paramTransformerFunction, StringComparison options, string[] supportedOperators = null);
    }
}
