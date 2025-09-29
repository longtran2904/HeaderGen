#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Lumin
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = True)]
    public sealed class UsesLuminPrivilegeAttribute : Attribute
    {
        public UsesLuminPrivilegeAttribute(string privilege);

        public string privilege { get; }
    }
}
