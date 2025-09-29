#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using System.Collections.Generic;

namespace Microsoft.Unity.VisualStudio.Editor
{
    public interface IGenerator
    {

        string ProjectDirectory { get; }
        IAssemblyNameProvider AssemblyNameProvider { get; }

        bool SyncIfNeeded(IEnumerable<string> affectedFiles, IEnumerable<string> reimportedFiles);
        void Sync();
        bool HasSolutionBeenGenerated();
        bool IsSupportedFile(string path);
        string SolutionFile();
    }
}
