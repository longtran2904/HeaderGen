#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
    public static class Crypto
    {

        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsCryptoBindings.h")]
        public static byte[] ComputeMD5Hash([Unmarshalled] byte[] buffer);
        [NativeHeader("PlatformDependent/MetroPlayer/Bindings/WindowsCryptoBindings.h")]
        public static byte[] ComputeSHA1Hash([Unmarshalled] byte[] buffer);
    }
}
