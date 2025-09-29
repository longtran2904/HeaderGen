#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.PackageManager
{
    [NativeAsStruct]
    [NativeHeader("Modules/PackageManager/Editor/Public/PackageManager.h")]
    [NativeType(IntermediateScriptingStructName = "PackageManager_PackageInfo")]
    [RequiredByNativeCode]
    [StaticAccessor("PackageManager", StaticAccessorType.DoubleColon)]
    public sealed class PackageInfo
    {
        public string packageId { get; }
        public bool isDirectDependency { get; }
        public string version { get; }
        public PackageSource source { get; }
        public string resolvedPath { get; }
        public string assetPath { get; }
        public string name { get; }
        public string displayName { get; }
        public string category { get; }
        public string type { get; }
        public string description { get; }
        [Obsolete("PackageInfo.status is deprecated and will be removed in a later version.", False)]
        public PackageStatus status { get; }
        public Error[] errors { get; }
        public VersionsInfo versions { get; }
        public DependencyInfo[] dependencies { get; }
        public DependencyInfo[] resolvedDependencies { get; }
        public string[] keywords { get; }
        public AuthorInfo author { get; }
        public string documentationUrl { get; }
        public string changelogUrl { get; }
        public string licensesUrl { get; }
        public RegistryInfo registry { get; }
        public DateTime? datePublished { get; }
        public GitInfo git { get; }
        public RepositoryInfo repository { get; }

        public static PackageInfo FindForAssetPath(string assetPath);
        public static PackageInfo FindForAssembly(Assembly assembly);
        [NativeName("GetAllPackages")]
        public static PackageInfo[] GetAllRegisteredPackages();
    }
}
