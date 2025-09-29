#region UnityEngine.NVIDIAModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.NVIDIAModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.NVIDIA
{
    [NativeHeader("Modules/NVIDIA/NVPlugins.h")]
    public static class NVUnityPlugin
    {

        public static bool Load();
        public static bool IsLoaded();
    }
}
