#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True)]
    [MovedFrom("Unity.MPE")]
    [RequiredByNativeCode]
    public sealed class RoleProviderAttribute : Attribute
    {
        public string name;
        public ProcessEvent eventType;
        public ProcessLevel level;

        public RoleProviderAttribute(string name, ProcessEvent eventType);
        public RoleProviderAttribute(ProcessLevel level, ProcessEvent eventType);
    }
}
