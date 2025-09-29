#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = False)]
    public class UnityAPICompatibilityVersionAttribute : Attribute
    {

        [Obsolete("This overload of the attribute has been deprecated. Use the constructor that takes the version and a boolean", True)]
        public UnityAPICompatibilityVersionAttribute(string version);
        public UnityAPICompatibilityVersionAttribute(string version, bool checkOnlyUnityVersion);
        public UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes);

        public string version { get; }
    }
}
