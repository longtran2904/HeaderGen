#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor.XR
{
    [ExcludeFromDocs]
    [NativeType(Header = "Modules/XREditor/Boot/XRBoot.h")]
    public class BootOptions
    {
        public BootOptions();

        [ExcludeFromDocs]
        public static void SetXRSDKPreInitLibrary(string bootConfigPath, string libraryName);
    }
}
