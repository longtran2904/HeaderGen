#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/EditorUserSettings.h")]
    [NativeHeader("Editor/Src/VersionControlSettings.h")]
    [NativeHeader("Editor/Src/EditorSettings.h")]
    public sealed class EditorSettings : UnityEngine.Object
    {

        public static string unityRemoteDevice { get; set; }
        public static string unityRemoteCompression { get; set; }
        public static string unityRemoteResolution { get; set; }
        public static string unityRemoteJoystickSource { get; set; }
        [Obsolete("Use VersionControlSettings.mode instead.")]
        [StaticAccessor("GetVersionControlSettings()", StaticAccessorType.Dot)]
        public static string externalVersionControl { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static SerializationMode serializationMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static LineEndingsMode lineEndingsForNewScripts { get; set; }
        [Obsolete("EditorSettings.webSecurityEmulationEnabled is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
        public static bool webSecurityEmulationEnabled { get; set; }
        [Obsolete("EditorSettings.webSecurityEmulationHostUrl is no longer supported, since the Unity Web Player is no longer supported by Unity.")]
        public static string webSecurityEmulationHostUrl { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static EditorBehaviorMode defaultBehaviorMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static SceneAsset prefabRegularEnvironment { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static SceneAsset prefabUIEnvironment { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool prefabModeAllowAutoSave { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static SpritePackerMode spritePackerMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int spritePackerPaddingPower { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int etcTextureCompressorBehavior { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int etcTextureFastCompressor { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int etcTextureNormalCompressor { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int etcTextureBestCompressor { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool enableTextureStreamingInEditMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool enableTextureStreamingInPlayMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool asyncShaderCompilation { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool cachingShaderPreprocessor { get; set; }
        public static string[] projectGenerationUserExtensions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static string[] projectGenerationBuiltinExtensions { get; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static string projectGenerationRootNamespace { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool useLegacyProbeSampleCount { get; set; }
        [Obsolete("EditorSettings.disableCookiesInLightmapper is obsolete, please use EditorSettings.enableCookiesInLightmapper instead.", False)]
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool disableCookiesInLightmapper { get; set; }
        public static bool enableCookiesInLightmapper { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool enterPlayModeOptionsEnabled { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static EnterPlayModeOptions enterPlayModeOptions { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool serializeInlineMappingsOnOneLine { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static AssetPipelineMode assetPipelineMode { get; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static CacheServerMode cacheServerMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static AssetDatabase.RefreshImportMode refreshImportMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static string cacheServerEndpoint { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static string cacheServerNamespacePrefix { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool cacheServerEnableDownload { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool cacheServerEnableUpload { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool cacheServerEnableAuth { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool cacheServerEnableTls { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static CacheServerValidationMode cacheServerValidationMode { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int cacheServerDownloadBatchSize { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static int gameObjectNamingDigits { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static NamingScheme gameObjectNamingScheme { get; set; }
        [StaticAccessor("GetEditorSettings()", StaticAccessorType.Dot)]
        public static bool assetNamingUsesSpace { get; set; }
        public enum NamingScheme
        {

            SpaceParenthesis = 0,
            Dot = 1,
            Underscore = 2
        }
    }
}
