#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = True, Inherited = False)]
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    [RequiredByNativeCode]
    public class CollectImportedDependenciesAttribute : Attribute
    {

        public CollectImportedDependenciesAttribute(Type importerType, uint version);

        public Type importerType { get; }
        public uint version { get; }
    }
}
