#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEditor
{
    public class ProjectWindowUtil
    {
        public ProjectWindowUtil();

        [MenuItem("Assets/Create/GUI Skin", False, 601)]
        public static void CreateNewGUISkin();
        public static void CreateAsset(UnityEngine.Object asset, string pathName);
        public static void CreateFolder();
        public static void CreateScene();
        public static void CreateAssetWithContent(string filename, string content, Texture2D icon = null);
        [RequiredByNativeCode]
        public static void CreateScriptAssetFromTemplateFile(string templatePath, string defaultNewFileName);
        public static void ShowCreatedAsset(UnityEngine.Object o);
        public static void StartNameEditingIfProjectWindowExists(int instanceID, EndNameEditAction endAction, string pathName, Texture2D icon, string resourceFile);
        public static int[] GetAncestors(int instanceID);
        public static bool IsFolder(int instanceID);
        public static string GetContainingFolder(string path);
        public static string[] GetBaseFolders(string[] folders);
    }
}
