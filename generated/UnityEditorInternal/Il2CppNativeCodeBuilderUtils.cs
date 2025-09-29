#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEditor;

namespace UnityEditorInternal
{
    public static class Il2CppNativeCodeBuilderUtils
    {

        public static string GetConfigurationName(Il2CppCompilerConfiguration compilerConfiguration);
        public static IEnumerable<string> AddBuilderArguments(Il2CppNativeCodeBuilder builder, string outputRelativePath, IEnumerable<string> includeRelativePaths, IEnumerable<string> additionalLibs, Il2CppCompilerConfiguration compilerConfiguration);
        public static void ClearAndPrepareCacheDirectory(Il2CppNativeCodeBuilder builder);
        public static void ClearCacheIfEditorVersionDiffers(Il2CppNativeCodeBuilder builder, string currentEditorVersion);
        public static void PrepareCacheDirectory(Il2CppNativeCodeBuilder builder, string currentEditorVersion);
        public static string ObjectFilePathInCacheDirectoryFor(string builderCacheDirectory);
    }
}
