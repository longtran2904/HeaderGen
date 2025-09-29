#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Callbacks
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    public class RunAfterClassAttribute : Attribute
    {

        public RunAfterClassAttribute(Type type);
        public RunAfterClassAttribute(string assemblyQualifiedName);

        public Type classType { get; }
    }
}
