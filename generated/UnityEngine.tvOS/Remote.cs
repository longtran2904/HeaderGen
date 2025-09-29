#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.tvOS
{
    [NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
    public sealed class Remote
    {
        public Remote();

        public static bool allowExitToHome { get; set; }
        public static bool allowRemoteRotation { get; set; }
        public static bool reportAbsoluteDpadValues { get; set; }
        public static bool touchesEnabled { get; set; }
    }
}
