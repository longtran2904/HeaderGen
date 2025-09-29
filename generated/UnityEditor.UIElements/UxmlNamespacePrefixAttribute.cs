#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;

namespace UnityEditor.UIElements
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = True)]
    public sealed class UxmlNamespacePrefixAttribute : Attribute
    {

        public UxmlNamespacePrefixAttribute(string ns, string prefix);

        public string ns { get; }
        public string prefix { get; }
    }
}
