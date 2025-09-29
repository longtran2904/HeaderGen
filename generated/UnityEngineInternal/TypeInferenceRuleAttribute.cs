#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngineInternal
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TypeInferenceRuleAttribute : Attribute
    {

        public TypeInferenceRuleAttribute(TypeInferenceRules rule);
        public TypeInferenceRuleAttribute(string rule);

        public override string ToString();
    }
}
