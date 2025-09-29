#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.PackageManager;

namespace Microsoft.Unity.VisualStudio.Editor
{
    public interface IAssemblyNameProvider
    {
        string[] ProjectSupportedExtensions { get; }
        string ProjectGenerationRootNamespace { get; }
        ProjectGenerationFlag ProjectGenerationFlag { get; }

        string GetAssemblyNameFromScriptPath(string path);
        string GetAssemblyName(string assemblyOutputPath, string assemblyName);
        bool IsInternalizedPackagePath(string path);
        IEnumerable<Assembly> GetAssemblies(Func<string, bool> shouldFileBePartOfSolution);
        IEnumerable<string> GetAllAssetPaths();
        PackageInfo FindForAssetPath(string assetPath);
        ResponseFileData ParseResponseFile(string responseFilePath, string projectDirectory, string[] systemReferenceDirectories);
        void ToggleProjectGeneration(ProjectGenerationFlag preference);
    }
}
