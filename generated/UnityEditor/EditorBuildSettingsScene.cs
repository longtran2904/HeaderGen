#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeAsStruct]
    [NativeHeader("Editor/Src/EditorBuildSettings.h")]
    [UsedByNativeCode]
    public class EditorBuildSettingsScene : IComparable
    {

        public EditorBuildSettingsScene();
        public EditorBuildSettingsScene(string path, bool enabled);
        public EditorBuildSettingsScene(GUID guid, bool enabled);

        public bool enabled { get; set; }
        public string path { get; set; }
        public GUID guid { get; set; }

        public static string[] GetActiveSceneList(EditorBuildSettingsScene[] scenes);
        public int CompareTo(object obj);
    }
}
