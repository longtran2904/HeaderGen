#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
    public static class File
    {

        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsFileBindings.h")]
        public static byte[] ReadAllBytes(string path);
        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsFileBindings.h")]
        public static void WriteAllBytes(string path, [Unmarshalled] byte[] bytes);
        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsFileBindings.h")]
        public static bool Exists(string path);
        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsFileBindings.h")]
        public static void Delete(string path);
    }
}
