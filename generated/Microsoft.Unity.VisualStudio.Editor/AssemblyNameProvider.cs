#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.PackageManager;

namespace Microsoft.Unity.VisualStudio.Editor
{
    public class AssemblyNameProvider : IAssemblyNameProvider
    {
        public AssemblyNameProvider();

        public string[] ProjectSupportedExtensions { get; }
        public string ProjectGenerationRootNamespace { get; }
        public ProjectGenerationFlag ProjectGenerationFlag { get; }

        public string GetAssemblyNameFromScriptPath(string path);
        public IEnumerable<Assembly> GetAssemblies(Func<string, bool> shouldFileBePartOfSolution);
        public string GetCompileOutputPath(string assemblyName);
        public IEnumerable<string> GetAllAssetPaths();
        public PackageInfo FindForAssetPath(string assetPath);
        public bool IsInternalizedPackagePath(string path);
        public ResponseFileData ParseResponseFile(string responseFilePath, string projectDirectory, string[] systemReferenceDirectories);
        public void ToggleProjectGeneration(ProjectGenerationFlag preference);
        public void ResetProjectGenerationFlag();
        public string GetAssemblyName(string assemblyOutputPath, string assemblyName);
    }
}
