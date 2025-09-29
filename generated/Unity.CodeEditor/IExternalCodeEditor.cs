#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace Unity.CodeEditor
{
    public interface IExternalCodeEditor
    {
        CodeEditor.Installation[] Installations { get; }

        bool TryGetInstallationForPath(string editorPath, out CodeEditor.Installation installation);
        void OnGUI();
        void SyncIfNeeded(string[] addedFiles, string[] deletedFiles, string[] movedFiles, string[] movedFromFiles, string[] importedFiles);
        void SyncAll();
        void Initialize(string editorInstallationPath);
        bool OpenProject(string filePath = "", int line = -1, int column = -1);
    }
}
