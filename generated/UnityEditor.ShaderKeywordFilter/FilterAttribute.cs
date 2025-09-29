#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.ShaderKeywordFilter
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = True)]
    public class FilterAttribute : Attribute
    {

        public FilterAttribute(FilterAction action, Precedence precedence, EvaluationMode evaluationMode, object condition, string fileName, int lineNumber, params string[] keywordNames);
        public enum Precedence
        {

            Normal = 0,
            Override = 1
        }
        public enum EvaluationMode
        {

            Normal = 0,
            Negated = 1
        }
    }
}
