#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.WSA
{
    [NativeConditional("PLATFORM_METRO")]
    [NativeHeader("Runtime/Export/WSA/WSALauncher.bindings.h")]
    [NativeHeader("PlatformDependent/MetroPlayer/MetroLauncher.h")]
    [StaticAccessor("metro::Launcher", StaticAccessorType.DoubleColon)]
    public sealed class Launcher
    {

        public Launcher();

        public static void LaunchFile(Folder folder, string relativeFilePath, bool showWarning);
        public static void LaunchFileWithPicker(string fileExtension);
        public static void LaunchUri(string uri, bool showWarning);
    }
}
