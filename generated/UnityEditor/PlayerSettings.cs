#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.iOS;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeClass(null)]
    [NativeHeader("Runtime/Misc/PlayerSettingsSplashScreen.h")]
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    [NativeHeader("Runtime/Misc/BuildSettings.h")]
    [NativeHeader("Editor/Mono/PlayerSettings.bindings.h")]
    [StaticAccessor("GetPlayerSettings()")]
    public sealed class PlayerSettings : UnityEngine.Object
    {
        public static string companyName { get; set; }
        public static string productName { get; set; }
        [Obsolete("Use PlayerSettings.SplashScreen.show instead")]
        [StaticAccessor("GetPlayerSettings().GetSplashScreenSettings()")]
        public static bool showUnitySplashScreen { get; set; }
        [NativeProperty("SplashScreenLogoStyle")]
        [Obsolete("Use PlayerSettings.SplashScreen.unityLogoStyle instead")]
        [StaticAccessor("GetPlayerSettings().GetSplashScreenSettings()")]
        public static SplashScreenStyle splashScreenStyle { get; set; }
        [Obsolete("cloudProjectId is deprecated, use CloudProjectSettings.projectId instead")]
        public static string cloudProjectId { get; }
        public static Guid productGUID { get; }
        public static ColorSpace colorSpace { get; set; }
        public static int defaultScreenWidth { get; set; }
        public static int defaultScreenHeight { get; set; }
        public static int defaultWebScreenWidth { get; set; }
        public static int defaultWebScreenHeight { get; set; }
        [Obsolete("displayResolutionDialog has been removed.", False)]
        public static ResolutionDialogSetting displayResolutionDialog { get; set; }
        [Obsolete("(defaultIsFullScreen is deprecated, use fullScreenMode instead")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool defaultIsFullScreen { get; set; }
        public static bool defaultIsNativeResolution { get; set; }
        public static bool macRetinaSupport { get; set; }
        public static bool runInBackground { get; set; }
        public static bool captureSingleScreen { get; set; }
        public static bool usePlayerLog { get; set; }
        public static bool resizableWindow { get; set; }
        public static bool resetResolutionOnWindowResize { get; set; }
        public static bool bakeCollisionMeshes { get; set; }
        public static bool useMacAppStoreValidation { get; set; }
        [Obsolete("macFullscreenMode is deprecated, use fullScreenMode instead")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static MacFullscreenMode macFullscreenMode { get; set; }
        [Obsolete("d3d9FullscreenMode is deprecated, use fullScreenMode instead")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static D3D9FullscreenMode d3d9FullscreenMode { get; set; }
        [Obsolete("d3d11FullscreenMode is deprecated, use fullScreenMode instead")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static D3D11FullscreenMode d3d11FullscreenMode { get; set; }
        [NativeProperty("FullscreenMode")]
        public static FullScreenMode fullScreenMode { get; set; }
        [Obsolete("This API is obsolete, and should no longer be used. Please use XRManagerSettings in the XR Management package instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool virtualRealitySupported { get; set; }
        public static bool enable360StereoCapture { get; set; }
        [Obsolete("singlePassStereoRendering will be deprecated. Use stereoRenderingPath instead.")]
        public static bool singlePassStereoRendering { get; set; }
        public static StereoRenderingPath stereoRenderingPath { get; set; }
        [Obsolete("protectGraphicsMemory is deprecated. This field has no effect.", False)]
        public static bool protectGraphicsMemory { get; set; }
        public static bool enableFrameTimingStats { get; set; }
        public static bool enableOpenGLProfilerGPURecorders { get; set; }
        public static bool useHDRDisplay { get; set; }
        public static D3DHDRDisplayBitDepth D3DHDRBitDepth { get; set; }
        public static bool visibleInBackground { get; set; }
        public static bool allowFullscreenSwitch { get; set; }
        public static bool forceSingleInstance { get; set; }
        public static bool useFlipModelSwapchain { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        public static bool openGLRequireES31 { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        public static bool openGLRequireES31AEP { get; set; }
        [NativeProperty(TargetType = TargetType.Field)]
        public static bool openGLRequireES32 { get; set; }
        [Obsolete("resolutionDialogBanner has been removed.", False)]
        public static Texture2D resolutionDialogBanner { get; set; }
        [StaticAccessor("GetPlayerSettings().GetSplashScreenSettings()")]
        public static Texture2D virtualRealitySplashScreen { get; set; }
        [Obsolete("iPhoneBundleIdentifier is deprecated. Use PlayerSettings.SetApplicationIdentifier(NamedBuildTarget.iOS) instead.")]
        public static string iPhoneBundleIdentifier { get; set; }
        public static bool assemblyVersionValidation { get; set; }
        [Obsolete("ScriptingRuntimeVersion has been deprecated in 2019.3 due to the removal of legacy mono")]
        public static ScriptingRuntimeVersion scriptingRuntimeVersion { get; set; }
        public static bool suppressCommonWarnings { get; set; }
        public static bool allowUnsafeCode { get; set; }
        [Obsolete("Use of reference assemblies is always enabled")]
        public static bool useReferenceAssemblies { get; set; }
        public static bool gcIncremental { get; set; }
        public static string keystorePass { get; set; }
        public static string keyaliasPass { get; set; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static string xboxTitleId { get; set; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static string xboxImageXexFilePath { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static string xboxSpaFilePath { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxGenerateSpa { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxEnableGuest { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxDeployKinectResources { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxDeployKinectHeadOrientation { get; set; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxDeployKinectHeadPosition { get; set; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static Texture2D xboxSplashScreen { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static int xboxAdditionalTitleMemorySize { get; set; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxEnableKinect { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxEnableKinectAutoTracking { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static bool xboxEnableSpeech { get; }
        [Obsolete("Xbox 360 has been removed in >=5.5")]
        public static uint xboxSpeechDB { get; }
        [NativeProperty("GPUSkinning")]
        public static bool gpuSkinning { get; set; }
        public static bool graphicsJobs { get; set; }
        public static GraphicsJobMode graphicsJobMode { get; set; }
        public static bool xboxPIXTextureCapture { get; }
        public static bool xboxEnableAvatar { get; }
        public static int xboxOneResolution { get; }
        public static bool enableInternalProfiler { get; set; }
        public static ActionOnDotNetUnhandledException actionOnDotNetUnhandledException { get; set; }
        public static bool logObjCUncaughtExceptions { get; set; }
        public static bool enableCrashReportAPI { get; set; }
        public static string applicationIdentifier { get; set; }
        [NativeProperty("ApplicationVersion")]
        public static string bundleVersion { get; set; }
        [NativeProperty("UIStatusBarHidden")]
        public static bool statusBarHidden { get; set; }
        [Obsolete("strippingLevel is deprecated, Use PlayerSettings.GetManagedStrippingLevel()/PlayerSettings.SetManagedStrippingLevel() instead. StripByteCode and UseMicroMSCorlib are no longer supported.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static StrippingLevel strippingLevel { get; set; }
        public static bool stripEngineCode { get; set; }
        [NativeProperty("DefaultScreenOrientation")]
        public static UIOrientation defaultInterfaceOrientation { get; set; }
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool allowedAutorotateToPortrait { get; set; }
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool allowedAutorotateToPortraitUpsideDown { get; set; }
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool allowedAutorotateToLandscapeRight { get; set; }
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool allowedAutorotateToLandscapeLeft { get; set; }
        [NativeProperty("UseAnimatedAutoRotation")]
        public static bool useAnimatedAutorotation { get; set; }
        public static bool use32BitDisplayBuffer { get; set; }
        public static bool preserveFramebufferAlpha { get; set; }
        [Obsolete("apiCompatibilityLevel is deprecated. Use PlayerSettings.GetApiCompatibilityLevel()/PlayerSettings.SetApiCompatibilityLevel() instead.")]
        public static ApiCompatibilityLevel apiCompatibilityLevel { get; set; }
        public static bool stripUnusedMeshComponents { get; set; }
        public static bool mipStripping { get; set; }
        [NativeProperty("hasAdvancedVersion", TargetType.Field)]
        [StaticAccessor("GetBuildSettings()")]
        public static bool advancedLicense { get; }
        public static string aotOptions { get; set; }
        public static Texture2D defaultCursor { get; set; }
        public static Vector2 cursorHotspot { get; set; }
        public static int accelerometerFrequency { get; set; }
        public static bool MTRendering { get; set; }
        [Obsolete("Use UnityEditor.PlayerSettings.SetGraphicsAPIs/GetGraphicsAPIs instead")]
        public static bool useDirect3D11 { get; set; }
        [Obsolete("Use VREditor.GetStereoDeviceEnabled instead")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool stereoscopic3D { get; set; }
        public static bool muteOtherAudioSources { get; set; }
        public static bool legacyClampBlendShapeWeights { get; set; }
        [Obsolete("uploadClearedTextureDataAfterCreationFromScript was not working as intended and will be superseded with a per-texture flag.", True)]
        public static bool uploadClearedTextureDataAfterCreationFromScript { get; set; }
        [NativeProperty("MetalAPIValidation")]
        public static bool enableMetalAPIValidation { get; set; }
        public static WindowsGamepadBackendHint windowsGamepadBackendHint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The option alwaysDisplayWatermark is deprecated and is always false", True)]
        public static bool alwaysDisplayWatermark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use AssetBundles instead for streaming data", True)]
        public static int firstStreamedLevelWithResources { get; set; }
        [Obsolete("targetGlesGraphics is ignored, use SetGraphicsAPIs/GetGraphicsAPIs APIs", False)]
        public static TargetGlesGraphics targetGlesGraphics { get; set; }
        [Obsolete("targetIOSGraphics is ignored, use SetGraphicsAPIs/GetGraphicsAPIs APIs", False)]
        public static TargetIOSGraphics targetIOSGraphics { get; set; }
        [Obsolete("Use PlayerSettings.iOS.locationUsageDescription instead (UnityUpgradable) -> UnityEditor.PlayerSettings/iOS.locationUsageDescription", False)]
        public static string locationUsageDescription { get; set; }
        [Obsolete("renderingPath is ignored, use UnityEditor.Rendering.TierSettings with UnityEditor.Rendering.SetTierSettings/GetTierSettings instead", False)]
        public static RenderingPath renderingPath { get; set; }
        [Obsolete("mobileRenderingPath is ignored, use UnityEditor.Rendering.TierSettings with UnityEditor.Rendering.SetTierSettings/GetTierSettings instead", False)]
        public static RenderingPath mobileRenderingPath { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use PlayerSettings.applicationIdentifier instead (UnityUpgradable) -> UnityEditor.PlayerSettings.applicationIdentifier", True)]
        public static string bundleIdentifier { get; set; }
        public static bool vulkanEnableSetSRGBWrite { get; set; }
        public static uint vulkanNumSwapchainBuffers { get; set; }
        public static bool vulkanEnableLateAcquireNextImage { get; set; }
        [Obsolete("Vulkan SW command buffers are deprecated, vulkanUseSWCommandBuffers will be ignored.")]
        public static bool vulkanUseSWCommandBuffers { get; set; }
        public static bool vulkanEnablePreTransform { get; set; }

        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetPropertyInt(string name, int value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyInt(string name, int value);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyInt(string name, int value, BuildTarget target);
        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static int GetPropertyInt(string name, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static int GetPropertyInt(string name);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalInt(string name, ref int value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalInt(string name, ref int value);
        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetPropertyBool(string name, bool value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyBool(string name, bool value);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyBool(string name, bool value, BuildTarget target);
        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool GetPropertyBool(string name, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyBool(string name);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalBool(string name, ref bool value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalBool(string name, ref bool value);
        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetPropertyString(string name, string value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyString(string name, string value);
        [Obsolete("Use explicit API instead.")]
        public static void SetPropertyString(string name, string value, BuildTarget target);
        [Obsolete("Use explicit API instead.")]
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static string GetPropertyString(string name, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static string GetPropertyString(string name);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalString(string name, ref string value, BuildTargetGroup target);
        [Obsolete("Use explicit API instead.")]
        public static bool GetPropertyOptionalString(string name, ref string value);
        [NativeMethod("AspectRatioEnabled")]
        public static bool HasAspectRatio(AspectRatio aspectRatio);
        public static void SetAspectRatio(AspectRatio aspectRatio, bool enable);
        public static UnityEngine.Object[] GetPreloadedAssets();
        public static void SetPreloadedAssets(UnityEngine.Object[] assets);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static int GetShaderChunkSizeInMBForPlatform(BuildTarget buildTarget);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetShaderChunkSizeInMBForPlatform(BuildTarget buildTarget, int sizeInMegabytes);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static int GetShaderChunkCountForPlatform(BuildTarget buildTarget);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetShaderChunkCountForPlatform(BuildTarget buildTarget, int chunkCount);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static int GetDefaultShaderChunkSizeInMB();
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetDefaultShaderChunkSizeInMB(int sizeInMegabytes);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static int GetDefaultShaderChunkCount();
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetDefaultShaderChunkCount(int chunkCount);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static bool GetOverrideShaderChunkSettingsForPlatform(BuildTarget buildTarget);
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetOverrideShaderChunkSettingsForPlatform(BuildTarget buildTarget, bool value);
        [NativeMethod("GetPlatformGraphicsAPIs")]
        public static GraphicsDeviceType[] GetGraphicsAPIs(BuildTarget platform);
        public static void SetGraphicsAPIs(BuildTarget platform, GraphicsDeviceType[] apis);
        [NativeMethod("GetPlatformAutomaticGraphicsAPIs")]
        public static bool GetUseDefaultGraphicsAPIs(BuildTarget platform);
        public static void SetUseDefaultGraphicsAPIs(BuildTarget platform, bool automatic);
        public static void SetTemplateCustomValue(string name, string value);
        public static string GetTemplateCustomValue(string name);
        public static string GetScriptingDefineSymbolsForGroup(BuildTargetGroup targetGroup);
        public static void GetScriptingDefineSymbolsForGroup(BuildTargetGroup targetGroup, out string[] defines);
        public static void SetScriptingDefineSymbolsForGroup(BuildTargetGroup targetGroup, string defines);
        public static void SetScriptingDefineSymbolsForGroup(BuildTargetGroup targetGroup, string[] defines);
        public static string[] GetAdditionalCompilerArgumentsForGroup(BuildTargetGroup targetGroup);
        public static void SetAdditionalCompilerArgumentsForGroup(BuildTargetGroup targetGroup, string[] additionalCompilerArguments);
        public static int GetArchitecture(BuildTargetGroup targetGroup);
        public static void SetArchitecture(BuildTargetGroup targetGroup, int architecture);
        public static ScriptingImplementation GetScriptingBackend(BuildTargetGroup targetGroup);
        public static void SetScriptingBackend(BuildTargetGroup targetGroup, ScriptingImplementation backend);
        public static ScriptingImplementation GetDefaultScriptingBackend(BuildTargetGroup targetGroup);
        public static string GetApplicationIdentifier(BuildTargetGroup targetGroup);
        public static void SetApplicationIdentifier(BuildTargetGroup targetGroup, string identifier);
        public static Il2CppCompilerConfiguration GetIl2CppCompilerConfiguration(BuildTargetGroup targetGroup);
        public static void SetIl2CppCompilerConfiguration(BuildTargetGroup targetGroup, Il2CppCompilerConfiguration configuration);
        public static bool GetIncrementalIl2CppBuild(BuildTargetGroup targetGroup);
        public static void SetIncrementalIl2CppBuild(BuildTargetGroup targetGroup, bool enabled);
        public static void SetManagedStrippingLevel(BuildTargetGroup targetGroup, ManagedStrippingLevel level);
        public static ManagedStrippingLevel GetManagedStrippingLevel(BuildTargetGroup targetGroup);
        public static ApiCompatibilityLevel GetApiCompatibilityLevel(BuildTargetGroup buildTargetGroup);
        public static void SetApiCompatibilityLevel(BuildTargetGroup buildTargetGroup, ApiCompatibilityLevel value);
        public static bool GetMobileMTRendering(BuildTargetGroup targetGroup);
        public static void SetMobileMTRendering(BuildTargetGroup targetGroup, bool enable);
        public static NormalMapEncoding GetNormalMapEncoding(BuildTargetGroup platform);
        public static void SetNormalMapEncoding(BuildTargetGroup platform, NormalMapEncoding encoding);
        public static string GetScriptingDefineSymbols(NamedBuildTarget buildTarget);
        public static void GetScriptingDefineSymbols(NamedBuildTarget buildTarget, out string[] defines);
        public static void SetScriptingDefineSymbols(NamedBuildTarget buildTarget, string defines);
        public static void SetScriptingDefineSymbols(NamedBuildTarget buildTarget, string[] defines);
        public static string[] GetAdditionalCompilerArguments(NamedBuildTarget buildTarget);
        public static void SetAdditionalCompilerArguments(NamedBuildTarget buildTarget, string[] additionalCompilerArguments);
        public static int GetArchitecture(NamedBuildTarget buildTarget);
        public static void SetArchitecture(NamedBuildTarget buildTarget, int architecture);
        public static ScriptingImplementation GetScriptingBackend(NamedBuildTarget buildTarget);
        public static void SetScriptingBackend(NamedBuildTarget buildTarget, ScriptingImplementation backend);
        public static ScriptingImplementation GetDefaultScriptingBackend(NamedBuildTarget buildTarget);
        public static void SetApplicationIdentifier(NamedBuildTarget buildTarget, string identifier);
        public static string GetApplicationIdentifier(NamedBuildTarget buildTarget);
        public static Il2CppCompilerConfiguration GetIl2CppCompilerConfiguration(NamedBuildTarget buildTarget);
        public static void SetIl2CppCompilerConfiguration(NamedBuildTarget buildTarget, Il2CppCompilerConfiguration configuration);
        public static bool GetIncrementalIl2CppBuild(NamedBuildTarget buildTarget);
        public static void SetIncrementalIl2CppBuild(NamedBuildTarget buildTarget, bool enabled);
        public static void SetManagedStrippingLevel(NamedBuildTarget buildTarget, ManagedStrippingLevel level);
        public static ManagedStrippingLevel GetManagedStrippingLevel(NamedBuildTarget buildTarget);
        public static ApiCompatibilityLevel GetApiCompatibilityLevel(NamedBuildTarget buildTarget);
        public static void SetApiCompatibilityLevel(NamedBuildTarget buildTarget, ApiCompatibilityLevel value);
        public static void SetMobileMTRendering(NamedBuildTarget buildTarget, bool enable);
        public static bool GetMobileMTRendering(NamedBuildTarget buildTarget);
        public static NormalMapEncoding GetNormalMapEncoding(NamedBuildTarget buildTarget);
        public static void SetNormalMapEncoding(NamedBuildTarget buildTarget, NormalMapEncoding encoding);
        [NativeMethod("c_str")]
        [StaticAccessor("GetPlayerSettings().GetEditorOnly().additionalIl2CppArgs")]
        public static string GetAdditionalIl2CppArgs();
        [StaticAccessor("PlayerSettingsBindings", StaticAccessorType.DoubleColon)]
        public static void SetAdditionalIl2CppArgs(string additionalArgs);
        [StaticAccessor("GetPlayerSettings()")]
        public static bool GetWsaHolographicRemotingEnabled();
        [StaticAccessor("GetPlayerSettings()")]
        public static void SetWsaHolographicRemotingEnabled(bool enabled);
        [NativeMethod("GetStackTraceType")]
        public static StackTraceLogType GetStackTraceLogType(LogType logType);
        [NativeMethod("SetStackTraceType")]
        public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
        [NativeMethod("GetVirtualTexturingSupportEnabled")]
        [StaticAccessor("GetPlayerSettings()")]
        public static bool GetVirtualTexturingSupportEnabled();
        [NativeMethod("SetVirtualTexturingSupportEnabled")]
        [StaticAccessor("GetPlayerSettings()")]
        public static void SetVirtualTexturingSupportEnabled(bool enabled);
        [StaticAccessor("GetPlayerSettings().GetEditorOnly()")]
        public static ShaderPrecisionModel GetShaderPrecisionModel();
        [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()")]
        public static void SetShaderPrecisionModel(ShaderPrecisionModel model);
        public static PlatformIcon[] GetPlatformIcons(BuildTargetGroup platform, PlatformIconKind kind);
        public static PlatformIcon[] GetPlatformIcons(NamedBuildTarget buildTarget, PlatformIconKind kind);
        public static void SetPlatformIcons(BuildTargetGroup platform, PlatformIconKind kind, PlatformIcon[] icons);
        public static void SetPlatformIcons(NamedBuildTarget buildTarget, PlatformIconKind kind, PlatformIcon[] icons);
        public static PlatformIconKind[] GetSupportedIconKindsForPlatform(BuildTargetGroup platform);
        public static PlatformIconKind[] GetSupportedIconKinds(NamedBuildTarget buildTarget);
        public static void SetIconsForTargetGroup(BuildTargetGroup platform, Texture2D[] icons, IconKind kind);
        public static void SetIcons(NamedBuildTarget buildTarget, Texture2D[] icons, IconKind kind);
        public static void SetIconsForTargetGroup(BuildTargetGroup platform, Texture2D[] icons);
        public static Texture2D[] GetIconsForTargetGroup(BuildTargetGroup platform, IconKind kind);
        public static Texture2D[] GetIcons(NamedBuildTarget buildTarget, IconKind kind);
        public static Texture2D[] GetIconsForTargetGroup(BuildTargetGroup platform);
        public static int[] GetIconSizesForTargetGroup(BuildTargetGroup platform, IconKind kind);
        public static int[] GetIconSizes(NamedBuildTarget buildTarget, IconKind kind);
        public static int[] GetIconSizesForTargetGroup(BuildTargetGroup platform);
        [Obsolete("This API is deprecated and will be removed prior to shipping 2020.2", False)]
        public static bool GetVirtualRealitySupported(BuildTargetGroup targetGroup);
        [Obsolete("This API is deprecated and will be removed prior to shipping 2020.2", False)]
        public static void SetVirtualRealitySupported(BuildTargetGroup targetGroup, bool value);

        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public class Android
        {
            public Android();

            [Obsolete("Use targetArchitectures instead. (UnityUpgradable) -> targetArchitectures", False)]
            public static AndroidTargetDevice targetDevice { get; set; }
            public static bool disableDepthAndStencilBuffers { get; set; }
            [Obsolete("use24BitDepthBuffer is deprecated, use disableDepthAndStencilBuffers instead.")]
            public static bool use24BitDepthBuffer { get; set; }
            public static int defaultWindowWidth { get; set; }
            public static int defaultWindowHeight { get; set; }
            public static int minimumWindowWidth { get; set; }
            public static int minimumWindowHeight { get; set; }
            public static bool resizableWindow { get; set; }
            public static FullScreenMode fullscreenMode { get; set; }
            public static AndroidAutoRotationBehavior autoRotationBehavior { get; set; }
            public static int bundleVersionCode { get; set; }
            public static AndroidSdkVersions minSdkVersion { get; set; }
            public static AndroidSdkVersions targetSdkVersion { get; set; }
            public static AndroidPreferredInstallLocation preferredInstallLocation { get; set; }
            public static bool forceInternetPermission { get; set; }
            public static bool forceSDCardPermission { get; set; }
            public static bool androidTVCompatibility { get; set; }
            public static bool androidIsGame { get; set; }
            public static bool ARCoreEnabled { get; set; }
            public static bool chromeosInputEmulation { get; set; }
            public static AndroidArchitecture targetArchitectures { get; set; }
            public static bool buildApkPerCpuArchitecture { get; set; }
            public static AndroidTargetDevices androidTargetDevices { get; set; }
            public static AndroidSplashScreenScale splashScreenScale { get; set; }
            [NativeProperty("androidUseCustomKeystore", TargetType.Function)]
            public static bool useCustomKeystore { get; set; }
            public static string keystoreName { get; set; }
            public static string keystorePass { get; set; }
            public static string keyaliasName { get; set; }
            public static string keyaliasPass { get; set; }
            public static bool licenseVerification { get; }
            public static bool useAPKExpansionFiles { get; set; }
            public static AndroidShowActivityIndicatorOnLoading showActivityIndicatorOnLoading { get; set; }
            public static AndroidBlitType blitType { get; set; }
            public static float maxAspectRatio { get; set; }
            public static bool startInFullscreen { get; set; }
            public static bool renderOutsideSafeArea { get; set; }
            [NativeProperty("AndroidMinifyWithR8", TargetType.Function)]
            public static bool minifyWithR8 { get; set; }
            [NativeProperty("AndroidMinifyRelease", TargetType.Function)]
            public static bool minifyRelease { get; set; }
            [NativeProperty("AndroidMinifyDebug", TargetType.Function)]
            public static bool minifyDebug { get; set; }
            public static bool optimizedFramePacing { get; set; }
        }
        [NativeHeader("Editor/Src/EditorUserBuildSettings.h")]
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public class iOS
        {
            public iOS();

            [Obsolete("exitOnSuspend is deprecated, use appInBackgroundBehavior", False)]
            public static bool exitOnSuspend { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use Screen.SetResolution at runtime", True)]
            public static iOSTargetResolution targetResolution { get; set; }
            [Obsolete("Use PlayerSettings.muteOtherAudioSources instead (UnityUpgradable) -> UnityEditor.PlayerSettings.muteOtherAudioSources", False)]
            public static bool overrideIPodMusic { get; set; }
            [NativeProperty("ProductName")]
            public static string applicationDisplayName { get; set; }
            public static string buildNumber { get; set; }
            public static bool disableDepthAndStencilBuffers { get; set; }
            public static ScriptCallOptimizationLevel scriptCallOptimization { get; set; }
            public static iOSSdkVersion sdkVersion { get; set; }
            [Obsolete("OBSOLETE warning targetOSVersion is obsolete, use targetOSVersionString")]
            public static iOSTargetOSVersion targetOSVersion { get; set; }
            [NativeProperty("iOSTargetOSVersion")]
            public static string targetOSVersionString { get; set; }
            public static iOSTargetDevice targetDevice { get; set; }
            [NativeProperty("UIPrerenderedIcon")]
            public static bool prerenderedIcon { get; set; }
            [NativeProperty("UIRequiresPersistentWiFi")]
            public static bool requiresPersistentWiFi { get; set; }
            [NativeProperty("UIRequiresFullScreen")]
            public static bool requiresFullScreen { get; set; }
            [NativeProperty("UIStatusBarStyle")]
            public static iOSStatusBarStyle statusBarStyle { get; set; }
            public static SystemGestureDeferMode deferSystemGesturesMode { get; set; }
            [NativeProperty("HideHomeButton")]
            public static bool hideHomeButton { get; set; }
            public static iOSAppInBackgroundBehavior appInBackgroundBehavior { get; set; }
            [NativeProperty("IOSAppInBackgroundBehavior")]
            public static iOSBackgroundMode backgroundModes { get; set; }
            [NativeProperty("IOSMetalForceHardShadows")]
            public static bool forceHardShadowsOnMetal { get; set; }
            [NativeProperty("IOSAllowHTTPDownload")]
            public static bool allowHTTPDownload { get; set; }
            public static string appleDeveloperTeamID { get; set; }
            public static string iOSManualProvisioningProfileID { get; set; }
            public static string tvOSManualProvisioningProfileID { get; set; }
            [NativeProperty("tvOSManualProvisioningProfileType")]
            public static ProvisioningProfileType tvOSManualProvisioningProfileType { get; set; }
            [NativeProperty("iOSManualProvisioningProfileType")]
            public static ProvisioningProfileType iOSManualProvisioningProfileType { get; set; }
            public static bool appleEnableAutomaticSigning { get; set; }
            [NativeProperty("CameraUsageDescription")]
            public static string cameraUsageDescription { get; set; }
            [NativeProperty("LocationUsageDescription")]
            public static string locationUsageDescription { get; set; }
            [NativeProperty("MicrophoneUsageDescription")]
            public static string microphoneUsageDescription { get; set; }
            [NativeProperty("IOSAppInBackgroundBehavior")]
            public static iOSShowActivityIndicatorOnLoading showActivityIndicatorOnLoading { get; set; }
            [NativeProperty("UseOnDemandResources")]
            public static bool useOnDemandResources { get; set; }
            [NativeProperty("iOSURLSchemes", False, TargetType.Field)]
            public static string[] iOSUrlSchemes { get; set; }

            public static void SetLaunchScreenImage(Texture2D image, iOSLaunchScreenImageType type);
            public static void SetiPhoneLaunchScreenType(iOSLaunchScreenType type);
            public static void SetiPadLaunchScreenType(iOSLaunchScreenType type);
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public sealed class EmbeddedLinux
        {
            public EmbeddedLinux();

            [NativeProperty("PlayerDataPath")]
            public static string playerDataPath { get; set; }
            [NativeProperty("ForceSRGBBlit")]
            public static bool forceSRGBBlit { get; set; }
        }
        [Obsolete("Facebook support was removed in 2019.3", True)]
        public class Facebook
        {
            public Facebook();

            public static string sdkVersion { get; set; }
            public static string appId { get; set; }
            public static bool useCookies { get; set; }
            public static bool useStatus { get; set; }
            public static bool useFrictionlessRequests { get; set; }
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        public sealed class Lumin
        {
            public Lumin();

            [NativeProperty("LuminIconModelFolderPath")]
            public static string iconModelFolderPath { get; set; }
            [NativeProperty("LuminIconPortalFolderPath")]
            public static string iconPortalFolderPath { get; set; }
            [NativeProperty("LuminCertificatePath")]
            public static string certificatePath { get; set; }
            [NativeProperty("LuminSignPackage")]
            public static bool signPackage { get; set; }
            [NativeProperty("LuminIsChannelApp")]
            public static bool isChannelApp { get; set; }
            [NativeProperty("LuminVersionCode")]
            public static int versionCode { get; set; }
            [NativeProperty("LuminVersionName")]
            public static string versionName { get; set; }
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
        public class macOS
        {
            public macOS();

            public static string buildNumber { get; set; }
            [NativeProperty("MacAppStoreCategory")]
            public static string applicationCategoryType { get; set; }
            [NativeProperty("CameraUsageDescription")]
            public static string cameraUsageDescription { get; set; }
            [NativeProperty("MicrophoneUsageDescription")]
            public static string microphoneUsageDescription { get; set; }
            [NativeProperty("BluetoothUsageDescription")]
            public static string bluetoothUsageDescription { get; set; }
            [NativeProperty("macOSURLSchemes", False, TargetType.Field)]
            public static string[] urlSchemes { get; set; }
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
        public sealed class PS4
        {
            public PS4();

            [NativeProperty("ps4NPTrophyPackPath")]
            public static string npTrophyPackPath { get; set; }
            [NativeProperty("ps4NPAgeRating", False, TargetType.Field)]
            public static int npAgeRating { get; set; }
            [NativeProperty("ps4NPTitleSecret", False, TargetType.Function)]
            public static string npTitleSecret { get; set; }
            [NativeProperty("ps4ParentalLevel", False, TargetType.Field)]
            public static int parentalLevel { get; set; }
            [NativeProperty("ps4ApplicationParam1", False, TargetType.Field)]
            public static int applicationParameter1 { get; set; }
            [NativeProperty("ps4ApplicationParam2", False, TargetType.Field)]
            public static int applicationParameter2 { get; set; }
            [NativeProperty("ps4ApplicationParam3", False, TargetType.Field)]
            public static int applicationParameter3 { get; set; }
            [NativeProperty("ps4ApplicationParam4", False, TargetType.Field)]
            public static int applicationParameter4 { get; set; }
            [NativeProperty("ps4Passcode", False, TargetType.Function)]
            public static string passcode { get; set; }
            [NativeProperty("monoEnv", False, TargetType.Function)]
            public static string monoEnv { get; set; }
            [NativeProperty(TargetType = TargetType.Field)]
            public static bool playerPrefsSupport { get; set; }
            [NativeProperty(TargetType = TargetType.Field)]
            public static bool restrictedAudioUsageRights { get; set; }
            [NativeProperty("ps4UseResolutionFallback", False, TargetType.Field)]
            public static bool useResolutionFallback { get; set; }
            [NativeProperty("ps4ContentID", False, TargetType.Function)]
            public static string contentID { get; set; }
            [NativeProperty("ps4Category", False, TargetType.Field)]
            public static PS4AppCategory category { get; set; }
            [NativeProperty("ps4AppType", False, TargetType.Field)]
            public static int appType { get; set; }
            [NativeProperty("ps4MasterVersion", False, TargetType.Function)]
            public static string masterVersion { get; set; }
            [NativeProperty("ps4AppVersion", False, TargetType.Function)]
            public static string appVersion { get; set; }
            [NativeProperty("ps4RemotePlayKeyAssignment", False, TargetType.Field)]
            public static PS4RemotePlayKeyAssignment remotePlayKeyAssignment { get; set; }
            [NativeProperty("ps4RemotePlayKeyMappingDir", False, TargetType.Function)]
            public static string remotePlayKeyMappingDir { get; set; }
            [NativeProperty("ps4PlayTogetherPlayerCount", False, TargetType.Field)]
            public static int playTogetherPlayerCount { get; set; }
            [NativeProperty("ps4EnterButtonAssignment", False, TargetType.Field)]
            public static PS4EnterButtonAssignment enterButtonAssignment { get; set; }
            [NativeProperty("ps4ParamSfxPath", False, TargetType.Function)]
            public static string paramSfxPath { get; set; }
            [NativeProperty("ps4VideoOutPixelFormat", False, TargetType.Field)]
            public static int videoOutPixelFormat { get; set; }
            [NativeProperty("ps4VideoOutInitialWidth", False, TargetType.Field)]
            public static int videoOutInitialWidth { get; set; }
            [Obsolete("videoOutResolution is deprecated. Use PlayerSettings.PS4.videoOutInitialWidth and PlayerSettings.PS4.videoOutReprojectionRate to control initial display resolution and reprojection rate.")]
            public static int videoOutResolution { get; set; }
            public static string SdkOverride { get; set; }
            [NativeProperty("ps4VideoOutBaseModeInitialWidth", False, TargetType.Field)]
            public static int videoOutBaseModeInitialWidth { get; set; }
            [NativeProperty("ps4VideoOutReprojectionRate", False, TargetType.Field)]
            public static int videoOutReprojectionRate { get; set; }
            [NativeProperty("ps4PronunciationXMLPath", False, TargetType.Function)]
            public static string PronunciationXMLPath { get; set; }
            [NativeProperty("ps4PronunciationSIGPath", False, TargetType.Function)]
            public static string PronunciationSIGPath { get; set; }
            [NativeProperty("ps4BackgroundImagePath", False, TargetType.Function)]
            public static string BackgroundImagePath { get; set; }
            [NativeProperty("ps4StartupImagePath", False, TargetType.Function)]
            public static string StartupImagePath { get; set; }
            [NativeProperty("ps4StartupImagesFolder", False, TargetType.Function)]
            public static string startupImagesFolder { get; set; }
            [NativeProperty("ps4IconImagesFolder", False, TargetType.Function)]
            public static string iconImagesFolder { get; set; }
            [NativeProperty("ps4SaveDataImagePath", False, TargetType.Function)]
            public static string SaveDataImagePath { get; set; }
            [NativeProperty("ps4BGMPath", False, TargetType.Function)]
            public static string BGMPath { get; set; }
            [NativeProperty("ps4ShareFilePath", False, TargetType.Function)]
            public static string ShareFilePath { get; set; }
            [NativeProperty("ps4ShareOverlayImagePath", False, TargetType.Function)]
            public static string ShareOverlayImagePath { get; set; }
            [NativeProperty("ps4PrivacyGuardImagePath", False, TargetType.Function)]
            public static string PrivacyGuardImagePath { get; set; }
            [NativeProperty("ps4ExtraSceSysFile", False, TargetType.Function)]
            public static string ExtraSceSysFile { get; set; }
            [NativeProperty("ps4PatchDayOne", False, TargetType.Field)]
            public static bool patchDayOne { get; set; }
            [NativeProperty("ps4PatchPkgPath", False, TargetType.Function)]
            public static string PatchPkgPath { get; set; }
            [NativeProperty("ps4PatchLatestPkgPath", False, TargetType.Function)]
            public static string PatchLatestPkgPath { get; set; }
            [NativeProperty("ps4PatchChangeinfoPath", False, TargetType.Function)]
            public static string PatchChangeinfoPath { get; set; }
            [NativeProperty("ps4NPtitleDatPath", False, TargetType.Function)]
            public static string NPtitleDatPath { get; set; }
            [NativeProperty("ps4pnSessions", False, TargetType.Field)]
            public static bool pnSessions { get; set; }
            [NativeProperty("ps4pnPresence", False, TargetType.Field)]
            public static bool pnPresence { get; set; }
            [NativeProperty("ps4pnFriends", False, TargetType.Field)]
            public static bool pnFriends { get; set; }
            [NativeProperty("ps4pnGameCustomData", False, TargetType.Field)]
            public static bool pnGameCustomData { get; set; }
            [NativeProperty("ps4DownloadDataSize", False, TargetType.Field)]
            public static int downloadDataSize { get; set; }
            [NativeProperty("ps4GarlicHeapSize", False, TargetType.Field)]
            public static int garlicHeapSize { get; set; }
            [NativeProperty("ps4ProGarlicHeapSize", False, TargetType.Field)]
            public static int proGarlicHeapSize { get; set; }
            [NativeProperty("ps4ReprojectionSupport", False, TargetType.Field)]
            public static bool reprojectionSupport { get; set; }
            [NativeProperty("ps4UseAudio3dBackend", False, TargetType.Field)]
            public static bool useAudio3dBackend { get; set; }
            [NativeProperty("ps4Audio3dVirtualSpeakerCount", False, TargetType.Field)]
            public static int audio3dVirtualSpeakerCount { get; set; }
            [NativeProperty("ps4ScriptOptimizationLevel", False, TargetType.Field)]
            public static int scriptOptimizationLevel { get; set; }
            [NativeProperty("ps4UseLowGarlicFragmentationMode", True, TargetType.Field)]
            public static bool useLowGarlicFragmentationMode { get; set; }
            [NativeProperty("ps4SocialScreenEnabled", False, TargetType.Field)]
            public static int socialScreenEnabled { get; set; }
            [NativeProperty("ps4attribUserManagement", False, TargetType.Field)]
            public static bool attribUserManagement { get; set; }
            [NativeProperty("ps4attribMoveSupport", False, TargetType.Field)]
            public static bool attribMoveSupport { get; set; }
            [NativeProperty("ps4attrib3DSupport", False, TargetType.Field)]
            public static bool attrib3DSupport { get; set; }
            [NativeProperty("ps4attribShareSupport", False, TargetType.Field)]
            public static bool attribShareSupport { get; set; }
            [NativeProperty("ps4attribExclusiveVR", False, TargetType.Field)]
            public static bool attribExclusiveVR { get; set; }
            [NativeProperty("ps4disableAutoHideSplash", False, TargetType.Field)]
            public static bool disableAutoHideSplash { get; set; }
            [NativeProperty("ps4attribCpuUsage", False, TargetType.Field)]
            public static int attribCpuUsage { get; set; }
            [NativeProperty("ps4videoRecordingFeaturesUsed", False, TargetType.Field)]
            public static bool videoRecordingFeaturesUsed { get; set; }
            [NativeProperty("ps4contentSearchFeaturesUsed", False, TargetType.Field)]
            public static bool contentSearchFeaturesUsed { get; set; }
            [NativeProperty("ps4attribEyeToEyeDistanceSettingVR", False, TargetType.Field)]
            public static PlayStationVREyeToEyeDistanceSettings attribEyeToEyeDistanceSettingVR { get; set; }
            [NativeProperty("ps4IncludedModules", False, TargetType.Field)]
            public static string[] includedModules { get; set; }
            [NativeProperty(TargetType = TargetType.Field)]
            public static bool enableApplicationExit { get; set; }
            [NativeProperty(TargetType = TargetType.Field)]
            public static bool resetTempFolder { get; set; }
            [NativeProperty(TargetType = TargetType.Field)]
            public static int playerPrefsMaxSize { get; set; }
            [NativeProperty("ps4attribVROutputEnabled", False, TargetType.Field)]
            public static bool attribVROutputEnabled { get; set; }
            [NativeProperty("ps4CompatibilityPS5", False, TargetType.Field)]
            public static bool compatibilityPS5 { get; set; }
            [NativeProperty("ps4AllowPS5Detection", False, TargetType.Field)]
            public static bool allowPS5Detection { get; set; }
            [NativeProperty("ps4GPU800MHz", False, TargetType.Field)]
            public static bool gpu800MHz { get; set; }

            public enum PS4AppCategory
            {
                Application = 0,
                Patch = 1,
                Remaster = 2
            }
            public enum PS4RemotePlayKeyAssignment
            {
                None = -1,
                PatternA = 0,
                PatternB = 1,
                PatternC = 2,
                PatternD = 3,
                PatternE = 4,
                PatternF = 5,
                PatternG = 6,
                PatternH = 7
            }
            public enum PS4EnterButtonAssignment
            {
                CircleButton = 0,
                CrossButton = 1,
                SystemDefined = 2
            }
            public enum PlayStationVREyeToEyeDistanceSettings
            {
                PerUser = 0,
                ForceDefault = 1,
                DynamicModeAtRuntime = 2
            }
        }
        [NativeHeader("Runtime/Misc/PlayerSettingsSplashScreen.h")]
        public struct SplashScreenLogo
        {
            public Sprite logo { get; set; }
            public static Sprite unityLogo { get; }
            public float duration { get; set; }

            [ExcludeFromDocs]
            public static SplashScreenLogo Create(float duration);
            [ExcludeFromDocs]
            public static SplashScreenLogo Create();
            public static SplashScreenLogo Create([DefaultValue("k_MinLogoTime")] float duration, [DefaultValue("null")] Sprite logo);
            [ExcludeFromDocs]
            public static SplashScreenLogo CreateWithUnityLogo();
            public static SplashScreenLogo CreateWithUnityLogo([DefaultValue("k_MinLogoTime")] float duration);
        }
        [NativeHeader("Editor/Mono/PlayerSettingsSplashScreen.bindings.h")]
        [StaticAccessor("GetPlayerSettings().GetSplashScreenSettings()", StaticAccessorType.Dot)]
        public class SplashScreen
        {
            public SplashScreen();

            [NativeName("SplashScreenAnimation")]
            public static AnimationMode animationMode { get; set; }
            [NativeName("SplashScreenBackgroundZoom")]
            public static float animationBackgroundZoom { get; set; }
            [NativeName("SplashScreenLogoZoom")]
            public static float animationLogoZoom { get; set; }
            public static Sprite background { get; set; }
            public static Sprite backgroundPortrait { get; set; }
            public static bool blurBackgroundImage { get; set; }
            [NativeName("SplashScreenBackgroundColor")]
            public static Color backgroundColor { get; set; }
            [NativeName("SplashScreenDrawMode")]
            public static DrawMode drawMode { get; set; }
            [NativeName("SplashScreenLogos")]
            public static SplashScreenLogo[] logos { get; set; }
            [NativeName("SplashScreenOverlayOpacity")]
            public static float overlayOpacity { get; set; }
            [NativeName("ShowUnitySplashScreen")]
            public static bool show { get; set; }
            [NativeName("ShowUnitySplashLogo")]
            public static bool showUnityLogo { get; set; }
            [NativeName("SplashScreenLogoStyle")]
            public static UnityLogoStyle unityLogoStyle { get; set; }

            public enum AnimationMode
            {
                Static = 0,
                Dolly = 1,
                Custom = 2
            }
            public enum DrawMode
            {
                UnityLogoBelow = 0,
                AllSequential = 1
            }
            public enum UnityLogoStyle
            {
                DarkOnLight = 0,
                LightOnDark = 1
            }
        }
        [NativeHeader("Editor/Mono/PlayerSettingsSwitch.bindings.h")]
        [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
        public sealed class Switch
        {
            public Switch();

            [NativeProperty("switchSocketMemoryPoolSize", TargetType.Field)]
            public static int socketMemoryPoolSize { get; set; }
            [NativeProperty("switchSocketAllocatorPoolSize", TargetType.Field)]
            public static int socketAllocatorPoolSize { get; set; }
            [NativeProperty("switchSocketConcurrencyLimit", TargetType.Field)]
            public static int socketConcurrencyLimit { get; set; }
            [NativeProperty("switchUseCPUProfiler", TargetType.Field)]
            public static bool useSwitchCPUProfiler { get; set; }
            [NativeProperty("switchEnableFileSystemTrace", TargetType.Field)]
            public static bool enableFileSystemTrace { get; set; }
            [NativeProperty("switchLTOSetting", TargetType.Field)]
            public static int switchLTOSetting { get; set; }
            [NativeProperty("switchSystemResourceMemory", TargetType.Field)]
            public static int systemResourceMemory { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int queueCommandMemory { get; set; }
            [StaticAccessor("PlayerSettings", StaticAccessorType.DoubleColon)]
            public static int defaultSwitchQueueCommandMemory { get; }
            [StaticAccessor("PlayerSettings", StaticAccessorType.DoubleColon)]
            public static int minimumSwitchQueueCommandMemory { get; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int queueControlMemory { get; set; }
            [StaticAccessor("PlayerSettings", StaticAccessorType.DoubleColon)]
            public static int defaultSwitchQueueControlMemory { get; }
            [StaticAccessor("PlayerSettings", StaticAccessorType.DoubleColon)]
            public static int minimumSwitchQueueControlMemory { get; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int queueComputeMemory { get; set; }
            [StaticAccessor("PlayerSettings", StaticAccessorType.DoubleColon)]
            public static int defaultSwitchQueueComputeMemory { get; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int NVNShaderPoolsGranularity { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int NVNDefaultPoolsGranularity { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int NVNOtherPoolsGranularity { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int NVNMaxPublicTextureIDCount { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int NVNMaxPublicSamplerIDCount { get; set; }
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int switchMaxWorkerMultiple { get; set; }
            [NativeProperty("switchScreenResolutionBehavior", TargetType.Field)]
            public static ScreenResolutionBehavior screenResolutionBehavior { get; set; }
            public static string NMETAOverride { get; set; }
            public static string NMETAOverrideFullPath { get; }
            [NativeProperty("switchApplicationID", TargetType.Function)]
            public static string applicationID { get; set; }
            [NativeProperty("switchNSODependencies", TargetType.Function)]
            public static string nsoDependencies { get; set; }
            public static string[] titleNames { get; set; }
            public static string[] publisherNames { get; set; }
            public static Texture2D[] icons { get; set; }
            public static Texture2D[] smallIcons { get; set; }
            public static string manualHTMLPath { get; set; }
            public static string accessibleURLPath { get; set; }
            public static string legalInformationPath { get; set; }
            [NativeProperty("switchMainThreadStackSize", TargetType.Field)]
            public static int mainThreadStackSize { get; set; }
            [NativeProperty("switchPresenceGroupId", TargetType.Function)]
            public static string presenceGroupId { get; set; }
            [NativeProperty("switchLogoHandling", TargetType.Field)]
            public static LogoHandling logoHandling { get; set; }
            public static string releaseVersion { get; set; }
            [NativeProperty("switchDisplayVersion", TargetType.Function)]
            public static string displayVersion { get; set; }
            [NativeProperty("switchStartupUserAccount", TargetType.Field)]
            public static StartupUserAccount startupUserAccount { get; set; }
            [NativeProperty("switchSupportedLanguagesMask", TargetType.Field)]
            public static int supportedLanguages { get; set; }
            [NativeProperty("switchLogoType", TargetType.Field)]
            public static LogoType logoType { get; set; }
            [NativeProperty("switchApplicationErrorCodeCategory", TargetType.Function)]
            public static string applicationErrorCodeCategory { get; set; }
            [NativeProperty("switchUserAccountSaveDataSize", TargetType.Field)]
            public static int userAccountSaveDataSize { get; set; }
            [NativeProperty("switchUserAccountSaveDataJournalSize", TargetType.Field)]
            public static int userAccountSaveDataJournalSize { get; set; }
            [NativeProperty("switchApplicationAttribute", TargetType.Field)]
            public static ApplicationAttribute applicationAttribute { get; set; }
            public static int cardSpecSize { get; set; }
            public static int cardSpecClock { get; set; }
            [NativeProperty("switchRatingsMask", TargetType.Field)]
            public static int ratingsMask { get; set; }
            public static string[] localCommunicationIds { get; set; }
            [NativeProperty("switchParentalControl", TargetType.Field)]
            public static bool isUnderParentalControl { get; set; }
            [NativeProperty("switchAllowsScreenshot", TargetType.Field)]
            public static bool isScreenshotEnabled { get; set; }
            [NativeProperty("switchAllowsScreenshot", TargetType.Field)]
            [Obsolete("isAllowsScreenshot was renamed to isScreenshotEnabled")]
            public static bool isAllowsScreenshot { get; set; }
            [NativeProperty("switchAllowsVideoCapturing", TargetType.Field)]
            public static bool isVideoCapturingEnabled { get; set; }
            [NativeProperty("switchAllowsRuntimeAddOnContentInstall", TargetType.Field)]
            public static bool isRuntimeAddOnContentInstallEnabled { get; set; }
            [NativeProperty("switchDataLossConfirmation", TargetType.Field)]
            public static bool isDataLossConfirmationEnabled { get; set; }
            [NativeProperty("switchUserAccountLockEnabled", TargetType.Field)]
            public static bool isUserAccountLockEnabled { get; set; }
            [NativeProperty("switchDataLossConfirmation", TargetType.Field)]
            [Obsolete("isDataLossConfirmation was renamed to isDataLossConfirmationEnabled")]
            public static bool isDataLossConfirmation { get; set; }
            [NativeProperty("switchSupportedNpadStyles", TargetType.Field)]
            public static SupportedNpadStyle supportedNpadStyles { get; set; }
            public static int[] ratingAgeArray { get; set; }
            [NativeProperty("switchNativeFsCacheSize", TargetType.Field)]
            public static int nativeFsCacheSize { get; set; }
            [NativeProperty("switchIsHoldTypeHorizontal", TargetType.Field)]
            public static bool isHoldTypeHorizontal { get; set; }
            [NativeProperty("switchSupportedNpadCount", TargetType.Field)]
            public static int supportedNpadCount { get; set; }
            [NativeProperty("switchEnableTouchScreen", TargetType.Field)]
            public static bool enableTouchScreen { get; set; }
            [NativeProperty("switchSocketConfigEnabled", TargetType.Field)]
            public static bool socketConfigEnabled { get; set; }
            [NativeProperty("switchTcpInitialSendBufferSize", TargetType.Field)]
            public static int tcpInitialSendBufferSize { get; set; }
            [NativeProperty("switchTcpInitialReceiveBufferSize", TargetType.Field)]
            public static int tcpInitialReceiveBufferSize { get; set; }
            [NativeProperty("switchTcpAutoSendBufferSizeMax", TargetType.Field)]
            public static int tcpAutoSendBufferSizeMax { get; set; }
            [NativeProperty("switchTcpAutoReceiveBufferSizeMax", TargetType.Field)]
            public static int tcpAutoReceiveBufferSizeMax { get; set; }
            [NativeProperty("switchUdpSendBufferSize", TargetType.Field)]
            public static int udpSendBufferSize { get; set; }
            [NativeProperty("switchUdpReceiveBufferSize", TargetType.Field)]
            public static int udpReceiveBufferSize { get; set; }
            [NativeProperty("switchSocketBufferEfficiency", TargetType.Field)]
            public static int socketBufferEfficiency { get; set; }
            [NativeProperty("switchSocketInitializeEnabled", TargetType.Field)]
            public static bool socketInitializeEnabled { get; set; }
            [NativeProperty("switchNetworkInterfaceManagerInitializeEnabled", TargetType.Field)]
            public static bool networkInterfaceManagerInitializeEnabled { get; set; }
            [NativeProperty("switchUseNewStyleFilepaths", TargetType.Field)]
            public static bool useNewStyleFilepaths { get; set; }
            [NativeProperty("switchUseLegacyFmodPriorities", TargetType.Field)]
            public static bool switchUseLegacyFmodPriorities { get; set; }
            [NativeProperty("switchUseMicroSleepForYield", TargetType.Field)]
            public static bool switchUseMicroSleepForYield { get; set; }
            [NativeProperty("switchMicroSleepForYieldTime", TargetType.Field)]
            public static int switchMicroSleepForYieldTime { get; set; }
            [NativeProperty("switchEnableRamDiskSupport", TargetType.Field)]
            public static bool switchEnableRamDiskSupport { get; set; }
            [NativeProperty("switchRamDiskSpaceSize", TargetType.Field)]
            public static int switchRamDiskSpaceSize { get; set; }

            public static int GetRatingAge(RatingCategories category);

            public enum ScreenResolutionBehavior
            {
                Manual = 0,
                OperationMode = 1,
                PerformanceMode = 2,
                Both = 3
            }
            public enum Languages
            {
                AmericanEnglish = 0,
                BritishEnglish = 1,
                Japanese = 2,
                French = 3,
                German = 4,
                LatinAmericanSpanish = 5,
                Spanish = 6,
                Italian = 7,
                Dutch = 8,
                CanadianFrench = 9,
                Portuguese = 10,
                Russian = 11,
                SimplifiedChinese = 12,
                TraditionalChinese = 13,
                Korean = 14,
                BrazilianPortuguese = 15
            }
            public enum StartupUserAccount
            {
                None = 0,
                Required = 1,
                RequiredWithNetworkServiceAccountAvailable = 2
            }
            public enum LogoHandling
            {
                Auto = 0,
                Manual = 1
            }
            public enum LogoType
            {
                LicensedByNintendo = 0,
                [Obsolete("This attribute is no longer available as of NintendoSDK 4.3.", True)]
                DistributedByNintendo = 1,
                Nintendo = 2
            }
            public enum ApplicationAttribute
            {
                None = 0,
                Demo = 1
            }
            public enum RatingCategories
            {
                CERO = 0,
                GRACGCRB = 1,
                GSRMR = 2,
                ESRB = 3,
                ClassInd = 4,
                USK = 5,
                PEGI = 6,
                PEGIPortugal = 7,
                PEGIBBFC = 8,
                Russian = 9,
                ACB = 10,
                OFLC = 11,
                IARCGeneric = 12
            }
            [Flags]
            public enum SupportedNpadStyle
            {
                FullKey = 2,
                Handheld = 4,
                JoyDual = 16,
                JoyLeft = 256,
                JoyRight = 65536
            }
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [NativeHeader("Editor/Src/EditorUserBuildSettings.h")]
        [StaticAccessor("GetPlayerSettings()")]
        public class tvOS
        {
            public tvOS();

            public static tvOSSdkVersion sdkVersion { get; set; }
            public static string buildNumber { get; set; }
            [Obsolete("targetOSVersion is obsolete. Use targetOSVersionString instead.", False)]
            public static tvOSTargetOSVersion targetOSVersion { get; set; }
            public static string targetOSVersionString { get; set; }
            public static bool requireExtendedGameController { get; set; }
        }
        [NativeHeader("Editor/Mono/PlayerSettingsWebGL.bindings.h")]
        public sealed class WebGL
        {
            public WebGL();

            [NativeProperty("webGLMemorySize", TargetType.Field)]
            public static int memorySize { get; set; }
            [NativeProperty("webGLExceptionSupport", TargetType.Field)]
            public static WebGLExceptionSupport exceptionSupport { get; set; }
            [NativeProperty("webGLDataCaching", TargetType.Field)]
            public static bool dataCaching { get; set; }
            [NativeProperty("WebGLEmscriptenArgs")]
            public static string emscriptenArgs { get; set; }
            [NativeProperty("WebGLModulesDirectory")]
            public static string modulesDirectory { get; set; }
            [NativeProperty("WebGLTemplate")]
            public static string template { get; set; }
            [NativeProperty("webGLAnalyzeBuildSize", TargetType.Field)]
            public static bool analyzeBuildSize { get; set; }
            [NativeProperty("webGLUseEmbeddedResources", TargetType.Field)]
            public static bool useEmbeddedResources { get; set; }
            [Obsolete("useWasm Property deprecated. Use linkerTarget instead")]
            public static bool useWasm { get; set; }
            [NativeProperty("webGLThreadsSupport", TargetType.Field)]
            public static bool threadsSupport { get; set; }
            [NativeProperty("webGLLinkerTarget", TargetType.Field)]
            public static WebGLLinkerTarget linkerTarget { get; set; }
            [NativeProperty("webGLCompressionFormat", TargetType.Field)]
            public static WebGLCompressionFormat compressionFormat { get; set; }
            [NativeProperty("webGLNameFilesAsHashes", TargetType.Field)]
            public static bool nameFilesAsHashes { get; set; }
            [NativeProperty("webGLDebugSymbols", TargetType.Field)]
            public static WebGLDebugSymbolMode debugSymbolMode { get; set; }
            [Obsolete("debugSymbols Property deprecated. Property has been replaced by debugSymbolMode property.", False)]
            public static bool debugSymbols { get; set; }
            [NativeProperty("webGLWasmStreaming", TargetType.Field)]
            [Obsolete("wasmStreaming Property deprecated. WebAssembly streaming will be automatically used when decompressionFallback is disabled and vice versa.", True)]
            public static bool wasmStreaming { get; set; }
            [NativeProperty("webGLDecompressionFallback", TargetType.Field)]
            public static bool decompressionFallback { get; set; }
            [NativeProperty("webGLWasmArithmeticExceptions", TargetType.Field)]
            public static WebGLWasmArithmeticExceptions wasmArithmeticExceptions { get; set; }
            [NativeProperty("webGLPowerPreference", TargetType.Field)]
            public static WebGLPowerPreference powerPreference { get; set; }
        }
        public enum WSAApplicationShowName
        {
            NotSet = 0,
            AllLogos = 1,
            NoLogos = 2,
            StandardLogoOnly = 3,
            WideLogoOnly = 4
        }
        public enum WSADefaultTileSize
        {
            NotSet = 0,
            Medium = 1,
            Wide = 2
        }
        public enum WSAApplicationForegroundText
        {
            Light = 1,
            Dark = 2
        }
        public enum WSACapability
        {
            EnterpriseAuthentication = 0,
            InternetClient = 1,
            InternetClientServer = 2,
            MusicLibrary = 3,
            PicturesLibrary = 4,
            PrivateNetworkClientServer = 5,
            RemovableStorage = 6,
            SharedUserCertificates = 7,
            VideosLibrary = 8,
            WebCam = 9,
            Proximity = 10,
            Microphone = 11,
            Location = 12,
            HumanInterfaceDevice = 13,
            AllJoyn = 14,
            BlockedChatMessages = 15,
            Chat = 16,
            CodeGeneration = 17,
            Objects3D = 18,
            PhoneCall = 19,
            UserAccountInformation = 20,
            VoipCall = 21,
            Bluetooth = 22,
            SpatialPerception = 23,
            InputInjectionBrokered = 24,
            Appointments = 25,
            BackgroundMediaPlayback = 26,
            Contacts = 27,
            LowLevelDevices = 28,
            OfflineMapsManagement = 29,
            PhoneCallHistoryPublic = 30,
            PointOfService = 31,
            RecordedCallsFolder = 32,
            RemoteSystem = 33,
            SystemManagement = 34,
            UserDataTasks = 35,
            UserNotificationListener = 36,
            GazeInput = 37
        }
        public enum WSATargetFamily
        {
            Desktop = 0,
            Mobile = 1,
            Xbox = 2,
            Holographic = 3,
            Team = 4,
            IoT = 5,
            IoTHeadless = 6
        }
        public enum WSAImageScale
        {
            _100 = 100,
            _125 = 125,
            _150 = 150,
            _200 = 200,
            _400 = 400,
            Target16 = 16,
            Target24 = 24,
            Target32 = 32,
            Target48 = 48,
            Target256 = 256,
            [Obsolete("Image scale 80 is not used in Universal Windows Platform", False)]
            _80 = 80,
            [Obsolete("Image scale 140 is not used in Universal Windows Platform", False)]
            _140 = 140,
            [Obsolete("Image scale 180 is not used in Universal Windows Platform", False)]
            _180 = 180,
            [Obsolete("Image scale 240 is not used in Universal Windows Platform", False)]
            _240 = 240
        }
        public enum WSAImageType
        {
            PackageLogo = 1,
            SplashScreenImage = 2,
            UWPSquare44x44Logo = 31,
            UWPSquare71x71Logo = 32,
            UWPSquare150x150Logo = 33,
            UWPSquare310x310Logo = 34,
            UWPWide310x150Logo = 35
        }
        public enum WSAInputSource
        {
            CoreWindow = 0,
            IndependentInputSource = 1,
            SwapChainPanel = 2
        }
        [RequiredByNativeCode]
        public struct WSASupportedFileType
        {
            public string contentType;
            public string fileType;
        }
        public struct WSAFileTypeAssociations
        {
            public string name;
            public WSASupportedFileType[] supportedFileTypes;
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [NativeHeader("Editor/Mono/PlayerSettingsWSA.bindings.h")]
        [StaticAccessor("PlayerSettingsBindings::WSA", StaticAccessorType.DoubleColon)]
        public sealed class WSA
        {
            public WSA();

            [NativeProperty("wsaTransparentSwapchain", TargetType.Field)]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static bool transparentSwapchain { get; set; }
            public static string packageName { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string packageLogo { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("PlayerSettings.WSA.commandLineArgsFile is deprecated", True)]
            public static string commandLineArgsFile { get; set; }
            [NativeProperty("metroCertificatePath", TargetType.Field)]
            [StaticAccessor("GetPlayerSettings().GetEditorOnly()", StaticAccessorType.Dot)]
            public static string certificatePath { get; }
            public static string certificateSubject { get; }
            public static string certificateIssuer { get; }
            public static string applicationDescription { get; set; }
            public static string tileShortName { get; set; }
            [NativeProperty("metroTileShowName", TargetType.Field)]
            public static WSAApplicationShowName tileShowName { get; set; }
            [NativeProperty("metroMediumTileShowName", TargetType.Field)]
            public static bool mediumTileShowName { get; set; }
            [NativeProperty("metroLargeTileShowName", TargetType.Field)]
            public static bool largeTileShowName { get; set; }
            [NativeProperty("metroWideTileShowName", TargetType.Field)]
            public static bool wideTileShowName { get; set; }
            [NativeProperty("metroDefaultTileSize", TargetType.Field)]
            public static WSADefaultTileSize defaultTileSize { get; set; }
            [NativeProperty("metroTileForegroundText", TargetType.Field)]
            public static WSAApplicationForegroundText tileForegroundText { get; set; }
            [NativeProperty("metroTileBackgroundColor", TargetType.Field)]
            public static Color tileBackgroundColor { get; set; }
            [Obsolete("PlayerSettings.WSA.enableIndependentInputSource is deprecated. Use PlayerSettings.WSA.inputSource.", False)]
            public static bool enableIndependentInputSource { get; set; }
            [NativeProperty("metroInputSource", TargetType.Field)]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static WSAInputSource inputSource { get; set; }
            [NativeProperty("metroSupportStreamingInstall", TargetType.Field)]
            public static bool supportStreamingInstall { get; set; }
            [NativeProperty("metroLastRequiredScene", TargetType.Field)]
            public static int lastRequiredScene { get; set; }
            public static string vcxProjDefaultLanguage { get; set; }
            public static Version packageVersion { get; set; }
            public static DateTime? certificateNotAfter { get; }
            public static Color? splashScreenBackgroundColor { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileLogo80 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileLogo { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileLogo140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileLogo180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileWideLogo80 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileWideLogo { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileWideLogo140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileWideLogo180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileSmallLogo80 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileSmallLogo { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileSmallLogo140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeTileSmallLogo180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSmallTile80 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSmallTile { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSmallTile140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSmallTile180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeLargeTile80 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeLargeTile { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeLargeTile140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeLargeTile180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSplashScreenImage { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSplashScreenImageScale140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string storeSplashScreenImageScale180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneAppIcon { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneAppIcon140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneAppIcon240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSmallTile { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSmallTile140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSmallTile240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneMediumTile { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneMediumTile140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneMediumTile240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneWideTile { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneWideTile140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneWideTile240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSplashScreenImage { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSplashScreenImageScale140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string phoneSplashScreenImageScale240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string packageLogo140 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string packageLogo180 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("Use GetVisualAssetsImage()/SetVisualAssetsImage()", True)]
            public static string packageLogo240 { get; set; }
            [EditorBrowsable(EditorBrowsableState.Never)]
            [Obsolete("PlayerSettings.enableLowLatencyPresentationAPI is deprecated. It is now always enabled.", True)]
            public static bool enableLowLatencyPresentationAPI { get; set; }

            [NativeThrows]
            public static bool SetCertificate(string path, string password);
            public static string GetVisualAssetsImage(WSAImageType type, WSAImageScale scale);
            public static void SetVisualAssetsImage(string image, WSAImageType type, WSAImageScale scale);
            public static void SetCapability(WSACapability capability, bool value);
            public static bool GetCapability(WSACapability capability);
            public static void SetTargetDeviceFamily(WSATargetFamily family, bool value);
            public static bool GetTargetDeviceFamily(WSATargetFamily family);

            public static class Declarations
            {
                public static string protocolName { get; set; }
                public static WSAFileTypeAssociations fileTypeAssociations { get; set; }
            }
        }
        [NativeHeader("Runtime/Misc/PlayerSettings.h")]
        [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
        public sealed class XboxOne
        {
            public XboxOne();

            [NativeProperty("XboxOneXTitleMemory", TargetType.Field)]
            public static int XTitleMemory { get; set; }
            [NativeProperty("XboxOneLoggingLevel")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static XboxOneLoggingLevel defaultLoggingLevel { get; set; }
            [NativeProperty("XboxOneProductId", False, TargetType.Function)]
            public static string ProductId { get; set; }
            [NativeProperty("XboxOneUpdateKey", False, TargetType.Function)]
            public static string UpdateKey { get; set; }
            [NativeProperty("XboxOneSandboxId", False, TargetType.Function)]
            [Obsolete("SandboxId is obsolete please remove")]
            public static string SandboxId { get; set; }
            [NativeProperty("XboxOneContentId", False, TargetType.Function)]
            public static string ContentId { get; set; }
            [NativeProperty("XboxOneTitleId", False, TargetType.Function)]
            public static string TitleId { get; set; }
            [NativeProperty("XboxOneSCId", False, TargetType.Function)]
            public static string SCID { get; set; }
            [NativeProperty("XboxOneEnableGPUVariability", TargetType.Field)]
            public static bool EnableVariableGPU { get; set; }
            [NativeProperty("XboxOnePresentImmediateThreshold")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static uint PresentImmediateThreshold { get; set; }
            [NativeProperty("XboxOneEnable7thCore")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static bool Enable7thCore { get; set; }
            [NativeProperty("XboxOneDisableKinectGpuReservation")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static bool DisableKinectGpuReservation { get; set; }
            [NativeProperty("XboxEnablePIXSampling")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static bool EnablePIXSampling { get; set; }
            [NativeProperty("XboxOneGameOsOverridePath", False, TargetType.Function)]
            public static string GameOsOverridePath { get; set; }
            [NativeProperty("XboxOnePackagingOverridePath", False, TargetType.Function)]
            public static string PackagingOverridePath { get; set; }
            [NativeProperty("XboxOnePackageEncryption", TargetType.Field)]
            public static XboxOneEncryptionLevel PackagingEncryption { get; set; }
            [NativeProperty("XboxOnePackageUpdateGranularity", TargetType.Field)]
            public static XboxOnePackageUpdateGranularity PackageUpdateGranularity { get; set; }
            [NativeProperty("XboxOneOverrideIdentityName", False, TargetType.Function)]
            public static string OverrideIdentityName { get; set; }
            [NativeProperty("XboxOneOverrideIdentityPublisher", False, TargetType.Function)]
            public static string OverrideIdentityPublisher { get; set; }
            [NativeProperty("XboxOneAppManifestOverridePath", False, TargetType.Function)]
            public static string AppManifestOverridePath { get; set; }
            [NativeProperty("XboxOneIsContentPackage", TargetType.Field)]
            public static bool IsContentPackage { get; set; }
            [NativeProperty("XboxOneEnhancedXboxCompatibilityMode", TargetType.Field)]
            public static bool EnhancedXboxCompatibilityMode { get; set; }
            [NativeProperty("XboxOneVersion", False, TargetType.Function)]
            public static string Version { get; set; }
            [NativeProperty("XboxOneDescription", False, TargetType.Function)]
            public static string Description { get; set; }
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static string[] SocketNames { get; }
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static string[] AllowedProductIds { get; }
            public static uint PersistentLocalStorageSize { get; set; }
            [NativeProperty("XboxOneEnableTypeOptimization")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static bool EnableTypeOptimization { get; set; }
            [NativeProperty("XboxOneMonoLoggingLevel")]
            [StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
            public static int monoLoggingLevel { get; set; }
            [Obsolete("Mono script compiler is no longer supported.")]
            public static ScriptCompiler scriptCompiler { get; set; }

            [NativeMethod("SetXboxOneCapability")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void SetCapability(string capability, bool value);
            [NativeMethod("GetXboxOneCapability")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnly()", StaticAccessorType.Dot)]
            public static bool GetCapability(string capability);
            [NativeMethod("SetXboxOneLanguage")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void SetSupportedLanguage(string language, bool enabled);
            [NativeMethod("GetXboxOneLanguage")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnly()", StaticAccessorType.Dot)]
            public static bool GetSupportedLanguage(string language);
            [NativeMethod("RemoveXboxOneSocketDefinition")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void RemoveSocketDefinition(string name);
            [NativeMethod("SetXboxOneSocketDefinition")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void SetSocketDefinition(string name, string port, int protocol, int[] usages, string templateName, int sessionRequirment, int[] deviceUsages);
            public static void GetSocketDefinition(string name, out string port, out int protocol, out int[] usages, out string templateName, out int sessionRequirment, out int[] deviceUsages);
            [NativeMethod("RemoveXboxOneAllowedProductId")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void RemoveAllowedProductId(string id);
            [NativeMethod("AddXboxOneAllowedProductId")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static bool AddAllowedProductId(string id);
            [NativeMethod("UpdateXboxOneAllowedProductId")]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void UpdateAllowedProductId(int idx, string id);
            [NativeMethod("SetXboxOneGameRating")]
            [Obsolete("Starting May 11th 2020 any new base game submission releasing digital only, digital and disc, or disc only, should not include a ratings element in the AppxManifest. This ratings policy update applies to all Xbox supported ratings. New base submissions that come in on or after this date will be rejected by your Microsoft Representative if a ratings element is present.", False)]
            [StaticAccessor("GetPlayerSettings().GetEditorOnlyForUpdate()", StaticAccessorType.Dot)]
            public static void SetGameRating(string name, int value);
            [NativeMethod("GetXboxOneGameRating")]
            [Obsolete("Starting May 11th 2020 any new base game submission releasing digital only, digital and disc, or disc only, should not include a ratings element in the AppxManifest. This ratings policy update applies to all Xbox supported ratings. New base submissions that come in on or after this date will be rejected by your Microsoft Representative if a ratings element is present.", False)]
            [StaticAccessor("GetPlayerSettings().GetEditorOnly()", StaticAccessorType.Dot)]
            public static int GetGameRating(string name);
        }
        [Obsolete("This API is deprecated and will be removed in 2020.2.", False)]
        public static class VRWindowsMixedReality
        {
            [Obsolete("This API is deprecated and will be removed in 2020.2.", False)]
            public static DepthBufferFormat depthBufferFormat { get; set; }
            [Obsolete("This API is deprecated and will be removed in 2020.2.", False)]
            public static bool depthBufferSharingEnabled { get; set; }

            [Obsolete("This API is deprecated and will be removed in 2020.2.", False)]
            public enum DepthBufferFormat
            {
                DepthBufferFormat16Bit = 0,
                DepthBufferFormat24Bit = 1
            }
        }
    }
}
