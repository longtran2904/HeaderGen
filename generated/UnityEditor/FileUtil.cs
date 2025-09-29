#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Platform/Interface/EditorUtility.h")]
    [NativeHeader("Runtime/Utilities/File.h")]
    [NativeHeader("Runtime/Utilities/FileUtilities.h")]
    public class FileUtil
    {
        public FileUtil();

        public static bool DeleteFileOrDirectory(string path);
        public static void CopyFileOrDirectory(string source, string dest);
        public static void CopyFileOrDirectoryFollowSymlinks(string source, string dest);
        public static void MoveFileOrDirectory(string source, string dest);
        [FreeFunction]
        public static string GetUniqueTempPathInProject();
        [FreeFunction]
        public static string GetProjectRelativePath(string path);
        [FreeFunction]
        public static string GetLogicalPath(string path);
        [FreeFunction]
        public static string GetPhysicalPath(string path);
        public static void ReplaceFile(string src, string dst);
        public static void ReplaceDirectory(string src, string dst);
    }
}
