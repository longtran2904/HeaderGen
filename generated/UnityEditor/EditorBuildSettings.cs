#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/EditorBuildSettings.h")]
    public class EditorBuildSettings : UnityEngine.Object
    {

        public static EditorBuildSettingsScene[] scenes { get; set; }

        public static event Action sceneListChanged;

        public static bool RemoveConfigObject(string name);
        public static string[] GetConfigObjectNames();
        public static void AddConfigObject(string name, UnityEngine.Object obj, bool overwrite);
        public static bool TryGetConfigObject<T>(string name, out T result) where T : UnityEngine.Object;
    }
}
