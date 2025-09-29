#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    [Flags]
    public enum BuildOptions
    {
        None = 0,
        Development = 1,
        AutoRunPlayer = 4,
        ShowBuiltPlayer = 8,
        BuildAdditionalStreamedScenes = 16,
        AcceptExternalModificationsToPlayer = 32,
        InstallInBuildFolder = 64,
        CleanBuildCache = 128,
        ConnectWithProfiler = 256,
        AllowDebugging = 512,
        [Obsolete("BuildOptions.SymlinkLibraries is obsolete. Use BuildOptions.SymlinkSources instead (UnityUpgradable) -> [UnityEditor] BuildOptions.SymlinkSources", False)]
        SymlinkLibraries = 1024,
        SymlinkSources = 1024,
        UncompressedAssetBundle = 2048,
        [Obsolete("Use BuildOptions.Development instead")]
        StripDebugSymbols = 0,
        [Obsolete("Texture Compression is now always enabled")]
        CompressTextures = 0,
        ConnectToHost = 4096,
        CustomConnectionID = 8192,
        [Obsolete("Use StandaloneBuildSubtarget.Server instead")]
        EnableHeadlessMode = 16384,
        BuildScriptsOnly = 32768,
        PatchPackage = 65536,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("BuildOptions.IL2CPP is deprecated and has no effect. Use PlayerSettings.SetScriptingBackend() instead.", True)]
        Il2CPP = 0,
        ForceEnableAssertions = 131072,
        CompressWithLz4 = 262144,
        CompressWithLz4HC = 524288,
        [Obsolete("Specify IL2CPP optimization level in Player Settings.")]
        ForceOptimizeScriptCompilation = 0,
        ComputeCRC = 1048576,
        StrictMode = 2097152,
        IncludeTestAssemblies = 4194304,
        NoUniqueIdentifier = 8388608,
        WaitForPlayerConnection = 33554432,
        EnableCodeCoverage = 67108864,
        EnableDeepProfilingSupport = 268435456,
        DetailedBuildReport = 536870912,
        ShaderLivelinkSupport = 1073741824
    }
}
