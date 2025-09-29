#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/AssetPipelineEditor/Public/PluginImporter.h")]
    public sealed class PluginImporter : AssetImporter
    {
        public PluginImporter();

        [NativeProperty("DefineConstraints")]
        public string[] DefineConstraints { get; set; }
        public bool isPreloaded { get; set; }
        public bool isNativePlugin { get; }

        public static PluginImporter[] GetImporters(string platformName);
        public static PluginImporter[] GetImporters(BuildTarget platform);
        public static PluginImporter[] GetImporters(string buildTargetGroup, string buildTarget);
        public static PluginImporter[] GetImporters(BuildTargetGroup buildTargetGroup, BuildTarget buildTarget);
        [NativeMethod("ClearPlatformData")]
        public void ClearSettings();
        public void SetCompatibleWithAnyPlatform(bool enable);
        public bool GetCompatibleWithAnyPlatform();
        public void SetExcludeFromAnyPlatform(string platformName, bool excludedFromAny);
        public bool GetExcludeFromAnyPlatform(string platformName);
        public void SetIncludeInBuildDelegate(IncludeInBuildDelegate includeInBuildDelegate);
        public void SetExcludeFromAnyPlatform(BuildTarget platform, bool excludedFromAny);
        public bool GetExcludeFromAnyPlatform(BuildTarget platform);
        public void SetExcludeEditorFromAnyPlatform(bool excludedFromAny);
        public bool GetExcludeEditorFromAnyPlatform();
        public void SetCompatibleWithEditor(bool enable);
        public bool GetCompatibleWithEditor();
        public bool GetCompatibleWithEditor(string buildTargetGroup, string buildTarget);
        public bool GetIsOverridable();
        public bool ShouldIncludeInBuild();
        public void SetCompatibleWithPlatform(BuildTarget platform, bool enable);
        public bool GetCompatibleWithPlatform(BuildTarget platform);
        public void SetCompatibleWithPlatform(string platformName, bool enable);
        public bool GetCompatibleWithPlatform(string platformName);
        public void SetPlatformData(BuildTarget platform, string key, string value);
        public string GetPlatformData(BuildTarget platform, string key);
        public void SetPlatformData(string platformName, string key, string value);
        public string GetPlatformData(string platformName, string key);
        public void SetEditorData(string key, string value);
        public string GetEditorData(string key);
        public static PluginImporter[] GetAllImporters();
        public void SetIcon([NotNull("ArgumentNullException")] string className, Texture2D icon);
        public Texture2D GetIcon([NotNull("ArgumentNullException")] string className);

        public delegate bool IncludeInBuildDelegate(string path);
    }
}
