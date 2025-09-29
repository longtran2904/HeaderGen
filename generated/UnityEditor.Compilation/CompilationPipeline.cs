#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor.Compilation
{
    [NativeHeader("Editor/Src/ScriptCompilation/ScriptCompilationPipeline.h")]
    public static class CompilationPipeline
    {
        public static CodeOptimization codeOptimization { get; set; }

        public static event Action<object> compilationStarted;
        public static event Action<object> compilationFinished;
        [Obsolete("Use compilationStarted, compilationFinished or assemblyCompilationFinished instead. Note that using any of these functions to do time measurements is a bad idea as they run async to actual compilation.")]
        public static event Action<string> assemblyCompilationStarted;
        public static event Action<string, CompilerMessage[]> assemblyCompilationFinished;
        public static event Action<CodeOptimization> codeOptimizationChanged;

        public static string[] GetSystemAssemblyDirectories(ApiCompatibilityLevel apiCompatibilityLevel);
        public static ResponseFileData ParseResponseFile(string relativePath, string projectDirectory, string[] systemReferenceDirectories);
        public static Assembly[] GetAssemblies();
        public static Assembly[] GetAssemblies(AssembliesType assembliesType);
        public static string GetAssemblyNameFromScriptPath(string sourceFilePath);
        public static string GetAssemblyDefinitionFilePathFromScriptPath(string sourceFilePath);
        public static string GetAssemblyDefinitionFilePathFromAssemblyName(string assemblyName);
        public static string GetAssemblyDefinitionFilePathFromAssemblyReference(string reference);
        public static AssemblyDefinitionReferenceType GetAssemblyDefinitionReferenceType(string reference);
        public static string GUIDToAssemblyDefinitionReferenceGUID(string guid);
        public static string AssemblyDefinitionReferenceGUIDToGUID(string reference);
        public static string GetAssemblyRootNamespaceFromScriptPath(string sourceFilePath);
        public static AssemblyDefinitionPlatform[] GetAssemblyDefinitionPlatforms();
        public static string[] GetDefinesFromAssemblyName(string assemblyName);
        public static string[] GetResponseFileDefinesFromAssemblyName(string assemblyName);
        public static string[] GetPrecompiledAssemblyNames();
        public static bool IsDefineConstraintsCompatible(string[] defines, string[] defineConstraints);
        public static string[] GetPrecompiledAssemblyPaths(PrecompiledAssemblySources precompiledAssemblySources);
        public static string GetPrecompiledAssemblyPathFromAssemblyName(string assemblyName);
        public static void RequestScriptCompilation();
        public static void RequestScriptCompilation(RequestScriptCompilationOptions options);

        [Flags]
        public enum PrecompiledAssemblySources
        {
            UserAssembly = 1,
            UnityEngine = 2,
            UnityEditor = 4,
            SystemAssembly = 8,
            UnityAssembly = 16,
            All = -1
        }
    }
}
