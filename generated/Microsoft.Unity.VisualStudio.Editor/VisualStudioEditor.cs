#region Unity.VisualStudio.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.VisualStudio.Editor.dll
#endregion

using Unity.CodeEditor;
using UnityEditor;

namespace Microsoft.Unity.VisualStudio.Editor
{
    [InitializeOnLoad]
    public class VisualStudioEditor : IExternalCodeEditor
    {

        public VisualStudioEditor();

        public void CreateIfDoesntExist();
        public void Initialize(string editorInstallationPath);
        public virtual bool TryGetInstallationForPath(string editorPath, out CodeEditor.Installation installation);
        public void OnGUI();
        public void SyncIfNeeded(string[] addedFiles, string[] deletedFiles, string[] movedFiles, string[] movedFromFiles, string[] importedFiles);
        public void SyncAll();
        public bool OpenProject(string path, int line, int column);
    }
}
