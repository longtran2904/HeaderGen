#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/EditorUserBuildSettings.h")]
    [StaticAccessor("GetEditorUserBuildSettings()", StaticAccessorType.Dot)]
    public class EditorUserBuildSettings : UnityEngine.Object
    {
        [Obsolete("UnityEditor.activeBuildTargetChanged has been deprecated.Use UnityEditor.Build.IActiveBuildTargetChanged instead.")]
        public static Action activeBuildTargetChanged;

        public static BuildTargetGroup selectedBuildTargetGroup { get; set; }
        public static EmbeddedLinuxArchitecture selectedEmbeddedLinuxArchitecture { get; set; }
        public static bool remoteDeviceInfo { get; set; }
        public static string remoteDeviceAddress { get; set; }
        public static string remoteDeviceUsername { get; set; }
        public static string remoteDeviceExports { get; set; }
        public static string pathOnRemoteDevice { get; set; }
        public static BuildTarget selectedStandaloneTarget { get; set; }
        public static StandaloneBuildSubtarget standaloneBuildSubtarget { get; set; }
        public static PS4BuildSubtarget ps4BuildSubtarget { get; set; }
        public static PS4HardwareTarget ps4HardwareTarget { get; set; }
        public static bool explicitNullChecks { get; set; }
        public static bool explicitDivideByZeroChecks { get; set; }
        public static bool explicitArrayBoundsChecks { get; set; }
        public static bool needSubmissionMaterials { get; set; }
        [Obsolete("EditorUserBuildSettings.compressWithPsArc is obsolete and has no effect. It will be removed in a subsequent Unity release.")]
        public static bool compressWithPsArc { get; set; }
        public static bool forceInstallation { get; set; }
        public static bool movePackageToDiscOuterEdge { get; set; }
        public static bool compressFilesInPackage { get; set; }
        [Obsolete("Use EditorUserBuildSettings.standaloneBuildSubtarget instead.")]
        public static bool enableHeadlessMode { get; set; }
        public static bool buildScriptsOnly { get; set; }
        public static XboxBuildSubtarget xboxBuildSubtarget { get; set; }
        public static int streamingInstallLaunchRange { get; set; }
        public static XboxOneDeployMethod xboxOneDeployMethod { get; set; }
        public static XboxOneDeployDrive xboxOneDeployDrive { get; set; }
        [Obsolete("xboxOneUsername is deprecated, it is unnecessary and non-functional.")]
        public static string xboxOneUsername { get; set; }
        [Obsolete("xboxOneNetworkSharePath is deprecated, it is unnecessary and non-functional.")]
        public static string xboxOneNetworkSharePath { get; set; }
        public static string xboxOneAdditionalDebugPorts { get; set; }
        public static bool xboxOneRebootIfDeployFailsAndRetry { get; set; }
        public static MobileTextureSubtarget androidBuildSubtarget { get; set; }
        public static WebGLTextureSubtarget webGLBuildSubtarget { get; set; }
        public static AndroidETC2Fallback androidETC2Fallback { get; set; }
        public static AndroidBuildSystem androidBuildSystem { get; set; }
        public static AndroidBuildType androidBuildType { get; set; }
        [Obsolete("androidUseLegacySdkTools has been deprecated. It does not have any effect.")]
        public static bool androidUseLegacySdkTools { get; set; }
        [Obsolete("androidCreateSymbolsZip has been deprecated. Use androidCreateSymbols property")]
        public static bool androidCreateSymbolsZip { get; set; }
        public static AndroidCreateSymbols androidCreateSymbols { get; set; }
        [Obsolete("EditorUserBuildSettings.wsaSubtarget is obsolete and has no effect. It will be removed in a subsequent Unity release.")]
        public static WSASubtarget wsaSubtarget { get; set; }
        [Obsolete("EditorUserBuildSettings.wsaSDK is obsolete and has no effect.It will be removed in a subsequent Unity release.")]
        public static WSASDK wsaSDK { get; set; }
        public static WSAUWPBuildType wsaUWPBuildType { get; set; }
        public static string wsaUWPSDK { get; set; }
        public static string wsaMinUWPSDK { get; set; }
        public static string wsaArchitecture { get; set; }
        public static string wsaUWPVisualStudioVersion { get; set; }
        public static string windowsDevicePortalAddress { get; set; }
        public static string windowsDevicePortalUsername { get; set; }
        public static string windowsDevicePortalPassword { get; set; }
        public static WSABuildAndRunDeployTarget wsaBuildAndRunDeployTarget { get; set; }
        public static int overrideMaxTextureSize { get; set; }
        public static OverrideTextureCompression overrideTextureCompression { get; set; }
        public static BuildTarget activeBuildTarget { get; }
        public static string[] activeScriptCompilationDefines { get; }
        public static bool development { get; set; }
        public static Il2CppCodeGeneration il2CppCodeGeneration { get; set; }
        [Obsolete("Building with pre-built Engine option is no longer supported.", True)]
        public static bool webGLUsePreBuiltUnityEngine { get; set; }
        public static bool connectProfiler { get; set; }
        public static bool buildWithDeepProfilingSupport { get; set; }
        public static bool allowDebugging { get; set; }
        public static bool waitForPlayerConnection { get; set; }
        public static bool exportAsGoogleAndroidProject { get; set; }
        public static bool buildAppBundle { get; set; }
        [Obsolete("EditorUserBuildSettings.symlinkLibraries is obsolete. Use EditorUserBuildSettings.symlinkSources instead (UnityUpgradable) -> [UnityEditor] EditorUserBuildSettings.symlinkSources", False)]
        public static bool symlinkLibraries { get; set; }
        public static bool symlinkSources { get; set; }
        public static XcodeBuildConfig iOSXcodeBuildConfig { get; set; }
        public static XcodeBuildConfig macOSXcodeBuildConfig { get; set; }
        [Obsolete("iOSBuildConfigType is obsolete. Use iOSXcodeBuildConfig instead (UnityUpgradable) -> iOSXcodeBuildConfig", True)]
        public static iOSBuildType iOSBuildConfigType { get; set; }
        public static bool switchCreateRomFile { get; set; }
        public static bool switchEnableRomCompression { get; set; }
        public static bool switchSaveADF { get; set; }
        public static SwitchRomCompressionType switchRomCompressionType { get; set; }
        public static int switchRomCompressionLevel { get; set; }
        public static string switchRomCompressionConfig { get; set; }
        public static bool switchNVNGraphicsDebugger { get; set; }
        public static bool generateNintendoSwitchShaderInfo { get; set; }
        public static bool switchNVNShaderDebugging { get; set; }
        [Obsolete("switchNVNDrawValidation is deprecated, use switchNVNDrawValidation_Heavy instead.")]
        public static bool switchNVNDrawValidation { get; set; }
        public static bool switchNVNDrawValidation_Light { get; set; }
        public static bool switchNVNDrawValidation_Heavy { get; set; }
        public static bool switchEnableMemoryTracker { get; set; }
        public static bool switchWaitForMemoryTrackerOnStartup { get; set; }
        public static bool switchEnableDebugPad { get; set; }
        public static bool switchRedirectWritesToHostMount { get; set; }
        public static bool switchHTCSScriptDebugging { get; set; }
        public static bool switchUseLegacyNvnPoolAllocator { get; set; }
        public static bool installInBuildFolder { get; set; }
        public static bool waitForManagedDebugger { get; set; }
        public static int managedDebuggerFixedPort { get; set; }
        [Obsolete("forceOptimizeScriptCompilation is obsolete - will always return false. Control script optimization using the 'IL2CPP optimization level' configuration in Player Settings / Other.")]
        public static bool forceOptimizeScriptCompilation { get; }
        [Obsolete("androidDebugMinification is obsolete. Use PlayerSettings.Android.minifyDebug and PlayerSettings.Android.minifyWithR8.")]
        public static AndroidMinification androidDebugMinification { get; set; }
        [Obsolete("androidReleaseMinification is obsolete. Use PlayerSettings.Android.minifyRelease and PlayerSettings.Android.minifyWithR8.")]
        public static AndroidMinification androidReleaseMinification { get; set; }

        public static bool SwitchActiveBuildTarget(BuildTargetGroup targetGroup, BuildTarget target);
        public static bool SwitchActiveBuildTargetAsync(BuildTargetGroup targetGroup, BuildTarget target);
        public static bool SwitchActiveBuildTarget(NamedBuildTarget namedBuildTarget, BuildTarget target);
        public static string GetBuildLocation(BuildTarget target);
        public static void SetBuildLocation(BuildTarget target, string location);
        public static void SetPlatformSettings(string platformName, string name, string value);
        public static void SetPlatformSettings(string buildTargetGroup, string buildTarget, string name, string value);
        public static string GetPlatformSettings(string platformName, string name);
        public static string GetPlatformSettings(string buildTargetGroup, string platformName, string name);
        [Obsolete("Please use SwitchActiveBuildTarget(BuildTargetGroup targetGroup, BuildTarget target)")]
        public static bool SwitchActiveBuildTarget(BuildTarget target);
    }
}
