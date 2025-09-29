#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace UnityEditorInternal
{
    public class ScriptEditorUtility
    {

        public ScriptEditorUtility();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use UnityEditor.ScriptEditor.Register()", True)]
        public static void RegisterIde(Func<Installation[]> pathCallBack);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This functionality is going to be removed. See IExternalCodeEditor for more information", True)]
        public static ScriptEditor GetScriptEditorFromPath(string path);
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static string GetExternalScriptEditor();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This method has been moved to CodeEditor.SetExternalScriptEditor", True)]
        public static void SetExternalScriptEditor(string path);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use UnityEditor.ScriptEditor.GetCurrentEditor()", True)]
        public static ScriptEditor GetScriptEditorFromPreferences();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This method is being internalized, please use UnityEditorInternal.CodeEditorUtility.GetFoundScriptEditorPaths", True)]
        public static Dictionary<string, string> GetFoundScriptEditorPaths(RuntimePlatform platform);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This will be removed", False)]
        public enum ScriptEditor
        {

            SystemDefault = 0,
            MonoDevelop = 1,
            VisualStudio = 2,
            VisualStudioExpress = 3,
            Other = 32
        }
        public struct Installation
        {

            public string Name;
            public string Path;
        }
    }
}
