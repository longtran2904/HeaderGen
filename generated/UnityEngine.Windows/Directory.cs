#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
    public static class Directory
    {
        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static string temporaryFolder { get; }
        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static string localFolder { get; }
        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static string roamingFolder { get; }

        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static void CreateDirectory(string path);
        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static bool Exists(string path);
        [NativeHeader("Runtime/Export/Windows/WindowsDirectoryBindings.h")]
        public static void Delete(string path);
    }
}
