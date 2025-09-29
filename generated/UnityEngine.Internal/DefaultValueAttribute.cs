#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Internal
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
    public class DefaultValueAttribute : Attribute
    {
        public DefaultValueAttribute(string value);

        public object Value { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
