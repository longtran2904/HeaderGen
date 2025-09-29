#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeType(Header = "Modules/BuildReportingEditor/Public/CommonRoles.h")]
    public static class CommonRoles
    {
        [NativeProperty("BuildReporting::CommonRoles::scene", True, TargetType.Field)]
        public static string scene { get; }
        [NativeProperty("BuildReporting::CommonRoles::sharedAssets", True, TargetType.Field)]
        public static string sharedAssets { get; }
        [NativeProperty("BuildReporting::CommonRoles::resourcesFile", True, TargetType.Field)]
        public static string resourcesFile { get; }
        [NativeProperty("BuildReporting::CommonRoles::assetBundle", True, TargetType.Field)]
        public static string assetBundle { get; }
        [NativeProperty("BuildReporting::CommonRoles::manifestAssetBundle", True, TargetType.Field)]
        public static string manifestAssetBundle { get; }
        [NativeProperty("BuildReporting::CommonRoles::assetBundleTextManifest", True, TargetType.Field)]
        public static string assetBundleTextManifest { get; }
        [NativeProperty("BuildReporting::CommonRoles::managedLibrary", True, TargetType.Field)]
        public static string managedLibrary { get; }
        [NativeProperty("BuildReporting::CommonRoles::dependentManagedLibrary", True, TargetType.Field)]
        public static string dependentManagedLibrary { get; }
        [NativeProperty("BuildReporting::CommonRoles::executable", True, TargetType.Field)]
        public static string executable { get; }
        [NativeProperty("BuildReporting::CommonRoles::streamingResourceFile", True, TargetType.Field)]
        public static string streamingResourceFile { get; }
        [NativeProperty("BuildReporting::CommonRoles::streamingAsset", True, TargetType.Field)]
        public static string streamingAsset { get; }
        [NativeProperty("BuildReporting::CommonRoles::bootConfig", True, TargetType.Field)]
        public static string bootConfig { get; }
        [NativeProperty("BuildReporting::CommonRoles::builtInResources", True, TargetType.Field)]
        public static string builtInResources { get; }
        [NativeProperty("BuildReporting::CommonRoles::builtInShaders", True, TargetType.Field)]
        public static string builtInShaders { get; }
        [NativeProperty("BuildReporting::CommonRoles::appInfo", True, TargetType.Field)]
        public static string appInfo { get; }
        [NativeProperty("BuildReporting::CommonRoles::managedEngineAPI", True, TargetType.Field)]
        public static string managedEngineApi { get; }
        [NativeProperty("BuildReporting::CommonRoles::monoRuntime", True, TargetType.Field)]
        public static string monoRuntime { get; }
        [NativeProperty("BuildReporting::CommonRoles::monoConfig", True, TargetType.Field)]
        public static string monoConfig { get; }
        [NativeProperty("BuildReporting::CommonRoles::debugInfo", True, TargetType.Field)]
        public static string debugInfo { get; }
        [NativeProperty("BuildReporting::CommonRoles::globalGameManagers", True, TargetType.Field)]
        public static string globalGameManagers { get; }
        [NativeProperty("BuildReporting::CommonRoles::crashHandler", True, TargetType.Field)]
        public static string crashHandler { get; }
        [NativeProperty("BuildReporting::CommonRoles::engineLibrary", True, TargetType.Field)]
        public static string engineLibrary { get; }
    }
}
