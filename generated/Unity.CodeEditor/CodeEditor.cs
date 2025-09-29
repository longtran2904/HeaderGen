#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;

namespace Unity.CodeEditor
{
    public class CodeEditor
    {
        public CodeEditor();

        public IExternalCodeEditor CurrentCodeEditor { get; }
        public Installation CurrentInstallation { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IExternalCodeEditor CurrentEditor { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static string CurrentEditorInstallation { get; }
        public static string CurrentEditorPath { get; }
        public static CodeEditor Editor { get; }

        public Installation GetInstallationForPath(string editorPath);
        public IExternalCodeEditor GetCodeEditorForPath(string editorPath);
        public Dictionary<string, string> GetFoundScriptEditorPaths();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void SetExternalScriptEditor(string path);
        public void SetCodeEditor(string editorPath);
        public static void Register(IExternalCodeEditor externalCodeEditor);
        public static void Unregister(IExternalCodeEditor externalCodeEditor);
        public static bool OSOpenFile(string appPath, string arguments);
        public static string ParseArgument(string arguments, string path, int line, int column);
        public static string QuoteForProcessStart(string argument);

        public struct Installation
        {
            public string Name;
            public string Path;
        }
    }
}
