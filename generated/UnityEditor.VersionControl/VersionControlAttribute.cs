#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.VersionControl
{
    [AttributeUsage(AttributeTargets.Class)]
    public class VersionControlAttribute : Attribute
    {
        public VersionControlAttribute(string name, string displayName = null);

        public string name { get; }
        public virtual string displayName { get; }
    }
}
