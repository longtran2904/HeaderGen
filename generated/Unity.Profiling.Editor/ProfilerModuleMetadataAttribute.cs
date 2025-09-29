#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace Unity.Profiling.Editor
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    public class ProfilerModuleMetadataAttribute : Attribute
    {

        public ProfilerModuleMetadataAttribute(string displayName);

        public string DisplayName { get; }
        public string IconPath { get; set; }
    }
}
