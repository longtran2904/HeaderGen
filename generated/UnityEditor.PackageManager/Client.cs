#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.PackageManager.Requests;
using UnityEngine.Bindings;

namespace UnityEditor.PackageManager
{
    [NativeHeader("Modules/PackageManager/Editor/Public/PackageManager.h")]
    public static class Client
    {

        [NativeHeader("Modules/PackageManager/Editor/PackageManagerLogger.h")]
        [StaticAccessor("PackageManager", StaticAccessorType.DoubleColon)]
        public static LogLevel LogLevel { get; set; }

        public static ListRequest List(bool offlineMode, bool includeIndirectDependencies);
        public static ListRequest List(bool offlineMode);
        public static ListRequest List();
        public static AddRequest Add(string identifier);
        public static AddAndRemoveRequest AddAndRemove(string[] packagesToAdd = null, string[] packagesToRemove = null);
        public static EmbedRequest Embed(string packageName);
        public static RemoveRequest Remove(string packageName);
        public static SearchRequest Search(string packageIdOrName, bool offlineMode);
        public static SearchRequest Search(string packageIdOrName);
        public static SearchRequest SearchAll(bool offlineMode);
        public static SearchRequest SearchAll();
        public static ResetToEditorDefaultsRequest ResetToEditorDefaults();
        public static PackRequest Pack(string packageFolder, string targetFolder);
        public static void Resolve();
    }
}
