#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Compilation;

namespace Microsoft.Unity.VisualStudio.Editor
{
    public class ProjectGeneration : IGenerator
    {

        public static readonly string MSBuildNamespaceUri;

        public ProjectGeneration();
        public ProjectGeneration(string tempDirectory);
        public ProjectGeneration(string tempDirectory, IAssemblyNameProvider assemblyNameProvider, IFileIO fileIoProvider, IGUIDGenerator guidGenerator);

        public IAssemblyNameProvider AssemblyNameProvider { get; }
        public string ProjectDirectory { get; }

        public bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles);
        public void Sync();
        public bool HasSolutionBeenGenerated();
        public bool IsSupportedFile(string path);
        public void GenerateAndWriteSolutionAndProjects();
        public string ProjectFile(Assembly assembly);
        public string SolutionFile();
    }
}
